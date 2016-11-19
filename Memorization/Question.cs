using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Memorization
{
    public partial class Question : UserControl
    {
        #region Field

        /// <summary>
        /// 問題
        /// </summary>
        private List<string> question;

        /// <summary>
        /// 出題に使う問題
        /// </summary>
        private string[] quest;

        /// <summary>
        /// 間違えた問題
        /// </summary>
        private List<string> wr_que;

        /// <summary>
        /// 答え
        /// </summary>
        private List<string> answer;

        /// <summary>
        /// 出題に使う問題
        /// </summary>
        private string[] answr;

        /// <summary>
        /// 間違えた問題の解答
        /// </summary>
        private List<string> wr_ans;

        /// <summary>
        /// 間違えた問題の要素番号
        /// </summary>
        private List<int> wr_num;

        /// <summary>
        /// 間違えた問題の問題番号
        /// </summary>
        private List<int> wr_number;

        /// <summary>
        /// 問題の出題順
        /// </summary>
        private int[] order;

        private static Random ran = new Random();

        //タイトルに戻るためのデリゲート
        public delegate void BackTitle();
        public BackTitle toTitle;

        //進めるかどうか
        private bool cleared;

        //問題番号
        private int number;

        //解答の改行用
        private bool flag;

        /// <summary>
        /// 間違えた分を保存するファイルのディレクトリ
        /// </summary>
        private string wr_file;

        //１つ前の単語。初期値は"n"
        private string backword = "n";

        //現在の単語。初期値は"y"
        private string prevword = "y";

        #endregion

        #region Constructor

        public Question(List<string> q, List<string> a, string name)
        {
            InitializeComponent();
            flag = false;
            question = q;
            answer = a;
            if (name.LastIndexOf('\\') != -1)
            {
                if (name.LastIndexOf("\\wr_") == name.LastIndexOf('\\'))
                {
                    wr_file = name;
                }
                else
                {
                    wr_file = name.Insert(name.LastIndexOf('\\') + 1, "wr_");
                }
            }
            Startup(q, a);
        }

        #endregion

        #region Methods

        #region Startup

        /// <summary>
        /// 出題前
        /// </summary>
        /// <param name="q">問題</param>
        /// <param name="a">解答</param>
        public void Startup(List<string> q, List<string> a)
        {
            //問題番号を-1に
            number = -1;

            //初期値に
            backword = "n";
            prevword = "y";
            
            //問題と答えを初期化
            quest = q.ToArray();
            answr = a.ToArray();
            
            //間違えた問題に関するものを全て初期化
            wr_ans = new List<string>();
            wr_que = new List<string>();
            wr_num = new List<int>();
            wr_number = new List<int>();
            
            //進まないように
            cleared = false;
            
            //画面関係
            SetNumber(0);
            Ask(number);
            
            //決定ボタンを有効に。
            this.button1.Enabled = true;
            
            //スキップは無効のまま(有効にするのは問題が始まってから)
            this.button4.Enabled = false;
            
            //間違え直しは見えなくする
            this.button5.Visible = false;
        }

        /// <summary>
        /// 出題順を設定
        /// </summary>
        /// <param name="b"></param>
        public void Shuffle(bool b)
        {
            //order内に配列の要素番号の数字を入れる
            order = new int[quest.Length];           
            for (int i = 0; i < order.Length; i++)
            {
                order[i] = i;
            }
            //bがtrueならorderをシャッフル
            if (b)
            {
                for (int i = 0; i < order.Length; i++)
                {
                    int index = ran.Next(order.Length);
                    int tmp = order[i];
                    order[i] = order[index];
                    order[index] = tmp;
                }
            }
        }

        #endregion

        #region Asking

        /// <summary>
        /// 何問目か表示する。
        /// </summary>
        public void SetNumber(int i)
        {
            int right = i <= 0 ? 0 : i - 1 - wr_num.Count; //正解数
            this.label1.Text = String.Format("第{0,3}問   {0,3}問/ {1,3}問                          {2,3}問正解、{3,3}問不正解", i, quest.Length, right, wr_num.Count);
        }

        public void SetNumber()
        {
            int right = number < 0 ? 0 : number + 1 - wr_num.Count; //正解数
            this.label1.Text = String.Format("第{0,3}問   {0,3}問/ {1,3}問                          {2,3}問正解、{3,3}問不正解", number + 1, quest.Length, right, wr_num.Count);
        }
        /// <summary>
        /// 出題
        /// </summary>
        /// <param name="i"></param>
        public void Ask(int i)
        {
            cleared = false;
            //初回
            if (i == -1)
            {
                this.richTextBox1.Text = "問題をランダムに出力しますか？(Y/N)";
                this.textBox1.Text = "y";
            }
            //その他
            else
            {
                this.richTextBox1.Text = questionFormat(quest[i]);
            }
        }

        //出題終わり
        private void Finish()
        {
            //間違った番号をソートして、順番通り保存
            wr_num.Sort();
            foreach (int value in wr_num)
            {
                this.wr_que.Add(quest[value]);
                this.wr_ans.Add(answr[value]);
            }
            //間違えた問題を出題順に出力
            this.richTextBox1.Text = "";
            this.label1.Text = string.Format("問題終わり:結果 正答率{0,6:F}%       {1,3}問中、{2,3}問正解 {3,3}問不正解", ((this.question.Count - this.wr_que.Count) * 100.0 / this.question.Count), quest.Length, (quest.Length - wr_num.Count), wr_num.Count);
            foreach (int value in wr_number)
            {
                this.richTextBox1.Text += "第" + (value + 1).ToString() + "問\n";
                this.richTextBox1.Text += questionFormat(quest[order[value]]) + "\n";
                this.richTextBox1.Text += "答え:" + answerFormat(answr[order[value]]) + "\n\n";
            }
            //バグを防ぐため決定ボタンスキップボタン凍結
            this.button1.Enabled = false;
            this.button4.Enabled = false;
            //ミスがある場合のみ見えるようにする
            if (this.wr_que.Count > 0)
            {
                this.button5.Visible = true;
            }
            else
            {
                this.richTextBox1.Text += "パーフェクト！！";
            }
        }

        /// <summary>
        /// 答えが合っているか
        /// </summary>
        /// <param name="ans">答え</param>
        /// <param name="index">判定する文章の番号</param>
        public bool Equal(String ans, int index)
        {
            List<string> div_ans = null;
            List<string> div_answer = null;
            int mode = 0;

            ans = Format(ans);
            string answer = Format(this.answr[index]);

            /* 答えを分割 */
            //0:Normal 1:Multiple Choice 2:Select All
            if (answer.IndexOf('、') != -1 || answer.IndexOf('|') != -1)
            {
                div_ans = new List<string>();
                div_answer = new List<string>();
                //どの区切り文字があるかで判定モードを切り替え
                if (answer.IndexOf('、') != -1)
                {
                    mode = 2;
                }
                else
                {
                    mode = 1;
                }

                /* 入力された答えの分割 */
                string s1 = "";
                for (int i = 0; i < ans.Length; i++)
                {
                    //区切り文字でsが空白じゃなければ追加
                    if (ans[i] == '、' || ans[i] == '|')
                    {
                        if (!string.IsNullOrEmpty(s1))
                        {
                            div_ans.Add(s1);
                        }
                        s1 = "";
                    }
                    //区切り文字じゃなければsに文字を追加
                    else
                    {
                        s1 += ans[i];
                    }
                }
                //末尾までいったら追加
                if (!string.IsNullOrEmpty(s1))
                {
                    div_ans.Add(s1);
                }
                                
                //解答の分割
                string s2 = "";
                for (int i = 0; i < answer.Length; i++)
                {
                    //区切り文字であれば追加
                    if (answer[i] == '、' || answer[i] == '|')
                    {
                        if (!string.IsNullOrEmpty(s2))
                        {
                            div_answer.Add(s2);
                        }
                        s2 = "";
                    }
                    //そうでなければsに文字を追加
                    else
                    {
                        s2 += answer[i];
                    }
                }
                //末尾まできたら追加
                if (!string.IsNullOrEmpty(s2))
                {
                    div_answer.Add(s2);
                }
            }

            //Normal
            if (mode == 0)
            {
                //文章が同じなら正解
                return ans == answer;
            }
            //Multiple Choice
            else if (mode == 1)
            {
                //答えが一つでも含まれていれば正解
                foreach (string value in div_ans)
                {
                    if (div_answer.Contains(value))
                    {
                        return true;
                    }
                }
                return false;
            }
            //Select All
            else
            {
                if (div_ans.Count == div_answer.Count)
                {
                    //答えが一つでも含まれてなければfalse
                    foreach (string value in div_ans)
                    {
                        if (!div_answer.Contains(value))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
        }

        #endregion

        #region Format

        // Equalで判定するときに使う
        // 、と,と，の互換、・と＝と=の互換、（数字の大文字小文字の互換）、漢数字と数字の互換
        public string Format(string obj)
        {
            obj = obj.Replace('=', '・');
            obj = obj.Replace('＝', '・');

            obj = obj.Replace('１', '1');
            obj = obj.Replace('２', '2');
            obj = obj.Replace('３', '3');
            obj = obj.Replace('４', '4');
            obj = obj.Replace('５', '5');
            obj = obj.Replace('６', '6');
            obj = obj.Replace('７', '7');
            obj = obj.Replace('８', '8');
            obj = obj.Replace('９', '9');
            obj = obj.Replace('０', '0');

            obj = obj.Replace('一', '1');
            obj = obj.Replace('二', '2');
            obj = obj.Replace('三', '3');
            obj = obj.Replace('四', '4');
            obj = obj.Replace('五', '5');
            obj = obj.Replace('六', '6');
            obj = obj.Replace('七', '7');
            obj = obj.Replace('八', '8');
            obj = obj.Replace('九', '9');
            obj = obj.Replace('零', '0');
            obj = obj.Replace('〇', '0');

            //区切り文字
            obj = obj.Replace('　', ',');
            obj = obj.Replace(' ', ',');
            obj = obj.Replace('，', ',');
            obj = obj.Replace(',', '、');

            //または
            obj = obj.Replace('/', '|');
            obj = obj.Replace('｜', '|');

            obj = obj.Replace("\\", "\n");
            obj = obj.Replace("￥", "\n");

            obj = obj.ToLowerInvariant();

            for (int i = 0; i < obj.Length; i++)
            {
                if ('ａ' <= obj[i] && obj[i] <= 'ｚ')
                {
                    obj = obj.Replace(obj[i], (char)(obj[i] - 'ａ' + 'a'));
                }
                /*else if ('ァ' <= obj[i] && obj[i] <= 'ン')
                {
                    obj = obj.Replace(obj[i], (char)(obj[i] - 'ァ' + 'ぁ'));
                }*/
            }

            return obj;
        }

        //出題するときのフォーマット
        private string questionFormat(string obj)
        {
            obj = obj.Replace('\\', '\n');
            obj = obj.Replace('￥', '\n');
            return obj;
        }

        //答えを出力するときのフォーマット
        private string answerFormat(string obj)
        {
            obj = obj.Replace('/', '|');
            obj = obj.Replace('｜', '|');
            obj = obj.Replace("|", " or ");
            obj = obj.Replace("、", ",");
            obj = obj.Replace("，", ",");
            obj = obj.Trim(new char[] { ' ', '　' });
            return obj;
        }
        #endregion

        #endregion

        #region Event

        /// <summary>
        /// 決定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (number == -1)
            {
                //初回
                string yn = Format(this.textBox1.Text);
                if (yn == "y" || yn == "yes")
                {
                    Shuffle(true);
                    cleared = true;
                }
                else if (yn == "n" || yn == "no")
                {
                    Shuffle(false);
                    cleared = true;
                }
                //シャッフルするか決まれば次の問題へ
                if (cleared)
                {
                    this.button4.Enabled = true;
                    number++;
                    Ask(order[number]);
                    SetNumber(number + 1);
                }
            }
            else
            {
                //前の問題の答えを消す
                if (!String.IsNullOrEmpty(this.label7.Text))
                {
                    this.label7.Text = "";
                    this.textBox2.Text = "";
                }
                cleared = Equal(this.textBox1.Text, order[number]);
                //正解
                if (cleared)
                {
                    if (number + 1 == quest.Length)
                    {
                        Finish();
                    }
                    else
                    {
                        number++;
                        Ask(order[number]);
                        SetNumber(number + 1);
                    }
                }
                //間違っていた場合
                else
                {
                    if (!wr_num.Contains(order[number]))
                    {
                        wr_number.Add(number);
                        wr_num.Add(order[number]);
                        SetNumber();
                    }
                }
            }
            //答えを保存してから入力欄を空に
            this.backword = this.textBox1.Text;
            this.textBox1.Text = "";

            //Focusをテキストボックスへ
            textBox1.Focus();
        }

        /// <summary>
        /// 最初から
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //前の問題の答えを消す
            if (!String.IsNullOrEmpty(this.label7.Text))
            {
                this.label7.Text = "";
                this.textBox2.Text = "";
            }
                
            Startup(question, answer);

            //Focusをテキストボックスへ
            textBox1.Focus();
        }

        /// <summary>
        /// タイトルへ戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //間違えた問題があった場合は
            if (wr_que.Count > 0)
            {
                //間違えた問題を保存するか聞く。ファイルは読み込んだファイルと同じ場所
                if (MessageBox.Show("現在間違えている問題を保存しますか?", "Memorization", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(wr_file, false, Encoding.GetEncoding("Shift_JIS")))
                    {
                        for (int i = 0; i < wr_que.Count; i++)
                        {
                            sw.WriteLine(wr_que[i]);
                            sw.WriteLine(wr_ans[i]);
                        }
                        sw.Close();
                    }
                    MessageBox.Show("ファイルは\n" + wr_file + "\nに保存されました", "Memorization");
                }
            }
            //戻る
            if (MessageBox.Show("タイトルに戻ります", "Memorization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                toTitle();
            }
            else
            {
                //Focusを戻す
                this.textBox1.Focus();
            }
        }

        /// <summary>
        /// スキップ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //間違えたときの処理とほぼ同じ
            if (!wr_num.Contains(order[number]))
            {
                wr_num.Add(order[number]);
                wr_number.Add(number);
            }
            //答えを表示
            this.label7.Text = "答えは " + answerFormat(answr[order[number]]);
            this.textBox2.Text = "答えは " + answerFormat(answr[order[number]]);

            //次の問題があれば進む
            if (number + 1 == quest.Length)
            {
                Finish();
            }
            else
            {
                number++;
                Ask(order[number]);
                SetNumber(number + 1);
            }

            //答えの入力欄を空に
            this.textBox1.Text = "";

            //Focusをテキストボックスへ
            textBox1.Focus();
        }

        /// <summary>
        /// 間違え直し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //前の問題の答えを消す
            if (!String.IsNullOrEmpty(this.label7.Text))
            {
                this.label7.Text = "";
                this.textBox2.Text = "";
            }
            
            //最初からと違い、間違えた問題を渡す
            Startup(wr_que, wr_ans);

            //Focusをテキストボックスへ
            textBox1.Focus();
        }

        /// <summary>
        /// Enterキー実装
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handledをtrueにするためにこっちに
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.button1.PerformClick();
                e.Handled = true;
            }            
        }

        //スキップをショートカットキーで出来るようにする
        //答えを１つ前に戻せるようにする        
        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //スキップ
            if (e.Control || e.Alt)
            {
                if ((e.KeyCode & Keys.S) == Keys.S)
                {
                    this.button4.PerformClick();
                    return;
                }
            }
            //１つ前の答えを出す
            else if (e.KeyCode == Keys.Up)
            {
                if (this.textBox1.Text != this.backword)
                {
                    this.prevword = this.textBox1.Text;
                    this.textBox1.Text = this.backword;
                    this.textBox1.SelectionStart = this.textBox1.Text.Length;
                }
            }
            //入力欄を戻す
            else if (e.KeyCode == Keys.Down)
            {
                this.textBox1.Text = this.prevword;
                this.textBox1.SelectionStart = this.textBox1.Text.Length;
            }
        }

        /// <summary>
        /// 問題を選ばせなくする。飛ばされたフォーカスはテキストボックスへ行く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (this.button1.Enabled)
            {
                this.textBox1.Focus();
            }
        }

        /// <summary>
        /// フォーカスを回答入力欄に飛ばす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //2行以上
            if (this.label7.Width >= this.textBox2.Width * 2)
            {
                this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            }
            //2行
            else if (this.label7.Width > this.textBox2.Width)
            {
                this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            }
            //1行以内
            else
            {
                //一回目だけ改行
                if (!flag)
                {
                    flag = true;
                    this.textBox2.Text = "\r\n" + this.textBox2.Text;

                }
                else
                {
                    flag = false;
                }
                this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            }
        }

        #endregion


    }
}
