using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memorization
{
    public partial class Editor : Form
    {
        #region Field

        //ファイル名
        private string file;

        //前回の保存から変更されたか
        private bool flag;

        //問題
        private List<string> question;

        //解答
        private List<string> answer;

        //問題番号(ページ) [0<=page<=question.Count]
        private int page;

        #endregion

        #region Constructor

        public Editor()
        {
            InitializeComponent();
            question = new List<string>(50);
            answer = new List<string>(50);
            flag = false;
            page = 0;
            setText(0);
            setTitle();
        }

        #endregion

        #region Method

        #region Motion

        /// <summary>
        /// 引数で指定された番号の問題を表示
        /// </summary>
        /// <param name="page">表示するページ番号</param>
        private void setText(int page)
        {
            this.label1.Text = string.Format("第{0,3}問目/全{1,3}問", this.page + 1, this.question.Count);
            if (page < this.question.Count)
            {
                this.richTextBox1.Text = question[page];
                this.textBox1.Text = answer[page];
            }
            else
            {
                this.richTextBox1.Text = "";
                this.textBox1.Text = "";
            }
        }

        private void setTitle()
        {
            this.Text = FileName().Replace(".txt", "") + (flag ? " *" : "") + " - Memorization Editor";
        }

        //ファイル名の取得
        private string FileName()
        {
            return file != null ? System.IO.Path.GetFileName(file) : "無題";
        }

        /// <summary>
        /// ページ移動
        /// </summary>
        /// <param name="forward">trueなら次へ、falseなら前のページへ移動</param>
        private void movePage(bool forward)
        {
            if (forward) { movePage(page + 1); } else { movePage(page - 1); }
        }

        /// <summary>
        /// ページ移動
        /// </summary>
        /// <param name="page">対象のページ番号</param>
        private void movePage(int page)
        {
            //ページ移動できるか
            bool able = true;

            //既存ページの範囲
            if (this.page < question.Count)
            {
                //それぞれ、変更されていれば登録
                if (this.question[this.page] != this.richTextBox1.Text)
                {
                    question.RemoveAt(this.page);
                    question.Insert(this.page, this.richTextBox1.Text);
                }
                if (this.answer[this.page] != this.textBox1.Text)
                {
                    answer.RemoveAt(this.page);
                    answer.Insert(this.page, this.textBox1.Text);
                }
            }
            //新しいページ
            else if (this.page == question.Count)
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text) && !string.IsNullOrEmpty(this.textBox1.Text))
                {
                    //追加
                    question.Add(this.richTextBox1.Text);
                    answer.Add(this.textBox1.Text);
                }
                else if (!(string.IsNullOrEmpty(this.richTextBox1.Text) && string.IsNullOrEmpty(this.textBox1.Text)))
                {
                    string message;
                    if (string.IsNullOrEmpty(this.richTextBox1.Text))
                    {
                        message = "入力した解答が消えてしまいますがよろしいですか？";
                    }
                    else
                    {
                        message = "入力した問題が消えてしまいますがよろしいですか？";
                    }
                    if (MessageBox.Show(message, "Memorization", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        able = false;
                    }
                }
            }
            //エラー
            else
            {
                MessageBox.Show("そのページへは飛べません","Memorization");
                able = false;
            }

            if (able)
            {
                //ページの切り替え
                this.page = page;
                setText(this.page);
            }
        }

        #endregion

        #region File

        /// <summary>
        /// 引数で指定されたファイルを現在の問題の末尾に追加します
        /// </summary>
        /// <param name="file">追加するファイル</param>
        public void Open(string file)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(file, Encoding.GetEncoding("Shift_JIS")))
                {
                    //追加できるかどうか確かめるため
                    List<string> tmpq = new List<string>(30);
                    List<string> tmpa = new List<string>(30);

                    //読み込み
                    string line;

                    //奇数回はtrue 偶数回はfalse
                    bool sw = true;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (sw)
                        {
                            tmpq.Add(outQuestionFormat(line));
                        }
                        else
                        {
                            tmpa.Add(line);
                        }
                        sw = !sw;
                    }

                    //終了時奇数回(大きさが同じ)だったらtrue
                    if (sw)
                    {
                        question.AddRange(tmpq);
                        answer.AddRange(tmpa);

                        flag = true;

                        //再描画
                        setText(this.page);
                        setTitle();
                    }
                    else
                    {
                        MessageBox.Show("の読み込みに失敗しました。以下の可能性を確認してください。\n\n・ファイルの行数が0である\n・ファイルが偶数行でない\n・空白行がある\n・区切り文字(,や/など)のみの行がある","Memorization");
                    }
                }
            }
            catch { MessageBox.Show(FileName() + "の読み込みに失敗しました","Memorization"); }
        }
        
        //ファイル書き込み
        public void Write()
        {
            /* 現在のページについて */
            //既存ページの範囲
            if (this.page < question.Count)
            {
                //それぞれ、変更されていれば登録
                if (this.question[this.page] != this.richTextBox1.Text)
                {
                    question.RemoveAt(this.page);
                    question.Insert(this.page, this.richTextBox1.Text);
                }
                if (this.answer[this.page] != this.textBox1.Text)
                {
                    answer.RemoveAt(this.page);
                    answer.Insert(this.page, this.textBox1.Text);
                }
            }
            //新しいページ
            else if (this.page == question.Count)
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text) && !string.IsNullOrEmpty(this.textBox1.Text))
                {
                    //追加
                    question.Add(this.richTextBox1.Text);
                    answer.Add(this.textBox1.Text);
                }                
            }
            setText(this.page);

            if (question.Count == 0)
            {
                return;
            }

            //Directoryが決まっているか
            if (string.IsNullOrEmpty(this.file))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.file = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(this.file, false, Encoding.GetEncoding("Shift_JIS")))
            {
                //交互に一行ずつ書いていく
                //両方に何も書いてなければ書き込まない
                for (int i = 0; i < question.Count; i++)
                {
                    if (!string.IsNullOrEmpty(question[i]) || !string.IsNullOrEmpty(answer[i]))
                    {
                        sw.WriteLine(questionFormat(question[i]));
                        sw.WriteLine(answerFormat(answer[i]));
                    }
                }
                sw.Close();
            }
            //MessageBox.Show("ファイルは\n" + file + "\nに保存されました","Memorization");

            //変更ナシ
            this.flag = false;
            setTitle();
        }

        //問題解答を一掃 取扱注意 確認必須
        public void Clear()
        {
            file = null;
            flag=false;
            page = 0;
            question = new List<string>();
            answer = new List<string>();

            setText(0);
            setTitle();
        }

        //書き込み時の問題のフォーマット
        public string questionFormat(string obj)
        {
            obj = obj.Replace('\n', '\\');            
            return obj;
        }

        //書き込み時の答えのフォーマット
        public string answerFormat(string obj)
        {
            //区切り文字
            obj = obj.Replace('　', ',');
            obj = obj.Replace(' ', ',');
            obj = obj.Replace('，', ',');
            obj = obj.Replace(',', '、');

            //または
            obj = obj.Replace('/', '|');
            obj = obj.Replace('｜', '|');
            
            return obj;
        }

        private string outQuestionFormat(string obj)
        {
            obj = obj.Replace('￥', '\n');
            obj = obj.Replace('\\', '\n');
            return obj;
        }

        #endregion

        #region Event

        #region Menu

        //Open
        private void openOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] files;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog1.FileNames;
                foreach (string value in files)
                {
                    Open(value);
                }                
                //最後のページへ
                movePage(question.Count);
            }
        }

        //Save
        private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Write();
        }

        //SaveAs
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.file = saveFileDialog1.FileName;
                Write();
            }
        }

        //New File
        private void newFileNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (MessageBox.Show("新しいエディタを開きますか？", "Memorization", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    /* 前の案はClearと同じなので消した */
                    new Editor().Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show(FileName() + "は変更されています。\n保存しますか？", "Memoriation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        //Directoryが決まっているか
                        if (string.IsNullOrEmpty(this.file))
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                this.file = saveFileDialog1.FileName;
                            }
                            else
                            {
                                return;
                            }
                        }
                        Write();
                        Clear();
                    }
                }
            }
            else
            {
                Clear();
            }
        }

        //Clear
        private void clearCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //前回の保存から変更があった場合
            if (flag)
            {
                DialogResult result = MessageBox.Show(FileName() + "は変更されています。\n保存しますか？", "Memoriation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    //Directoryが決まっているか
                    if (string.IsNullOrEmpty(this.file))
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            this.file = saveFileDialog1.FileName;
                        }
                        else
                        {
                            return;
                        }
                    }
                    Write();
                }
                if (result != DialogResult.Cancel)
                {
                    Clear();
                }
            }
            else
            {
                Clear();
            }
        }

        //Exit
        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button5.PerformClick();
        }

        //Delete
        private void deleteDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button1.PerformClick();
        }

        //Insert
        private void insertIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button8.PerformClick();
        }

        //Clean
        private void cleanLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button6.PerformClick();
        }

        //Put Behind
        private void putBehindBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button7.PerformClick();
        }

        //Next
        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button3.PerformClick();
            this.richTextBox1.Focus();
        }

        //Back
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button2.PerformClick();
            this.richTextBox1.Focus();
        }

        #endregion

        #region Other

        //テキストの変更
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == this.textBox1)
                {
                    this.button3.PerformClick();
                    this.richTextBox1.Focus();
                    e.Handled = true;
                    return;
                }
                else if (sender == this.richTextBox1)
                {
                    if (e.Control)
                    {
                        this.textBox1.Focus();
                        e.Handled = true;
                        return;
                    }
                }
            }
            if (!e.Alt && !e.Control && isAllowedKey(e))
            {
                //フラグをたてる
                flag = true;
                setTitle();
            }
        }

        //入力キーか否か
        private bool isAllowedKey(KeyEventArgs e)
        {
            Keys[] banKeys={Keys.ShiftKey,Keys.Tab,Keys.Up,Keys.Down,Keys.Left,Keys.Right};
            for (int i = 0; i < banKeys.Length; i++)
            {
                if (e.KeyCode == banKeys[i])
                {
                    return false;
                }
            }
            return true;
        }

        //×ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.page != this.question.Count)
            {
                if (this.page != 0)
                {
                    //1ページ戻る
                    movePage(false);

                    //1ページ先を消す
                    this.question.RemoveAt(this.page + 1);
                    this.answer.RemoveAt(this.page + 1);

                    //flagをたてる
                    flag = true;
                    setTitle();
                }
                else if (this.question.Count > 0)
                {
                    if (this.page == this.question.Count - 1)
                    {
                        this.richTextBox1.Text = "";
                        this.textBox1.Text = "";
                    }
                    this.question.RemoveAt(this.page);
                    this.answer.RemoveAt(this.page);
                    movePage(this.page);
                }
            }
            else
            {
                this.richTextBox1.Text = "";
                this.textBox1.Text = "";
            }
        }

        //前の問題へ
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.page > 0) { movePage(false); }
        }

        //次の問題へ
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.richTextBox1.Text) && !string.IsNullOrEmpty(this.textBox1.Text)) { movePage(true); }
            else if (this.page < question.Count) { movePage(true); }
        }

        //保存&決定
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("保存しますか？", "Memorization",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                /*
                if (!string.IsNullOrEmpty(file) && MessageBox.Show(FileName() + "に保存しますか？", "Memorization", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
                    {
                        this.file = saveFileDialog1.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                */
                Write();
            }
        }

        //タイトルへ
        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (MessageBox.Show(FileName() + "は変更されています\n保存しますか？", "Memorization", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Write();
                }
            }
            if (MessageBox.Show("タイトルに戻りますか？", "Memorization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //o 空にする
        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) || !string.IsNullOrEmpty(textBox1.Text))
            {
                this.richTextBox1.Text = "";
                this.textBox1.Text = "";
                flag = true;
                setTitle();
            }
        }

        //+ 後に追加
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.page < question.Count)
            {
                movePage(true);
                question.Insert(this.page, "");
                answer.Insert(this.page, "");
                setText(this.page);
                flag = true;
                setTitle();
            }
        }

        //± その場に追加
        private void button8_Click(object sender, EventArgs e)
        {
            if (this.page < question.Count)
            {
                movePage(true);
                movePage(false);
                question.Insert(this.page, "");
                answer.Insert(this.page, "");
                setText(this.page);
                flag = true;
                setTitle();
            }
        }

        #endregion

        #endregion

        #endregion        
    }
}
