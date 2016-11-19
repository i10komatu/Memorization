using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memorization
{
    public partial class Form1 : Form
    {
        #region Field

        //ファイルから読み込んだ問題と答え
        List<string> question, answer;

        //最初のページ
        StartPage start;

        //問題のページ
        Question quest;

        //ファイル名
        string file;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            question = new List<string>();
            answer = new List<string>();
            Startup();
        }

        #endregion

        #region Methods

        //スタート画面初期化&表示
        public void Startup()
        {
            this.start = new StartPage(LoadFile, Exit);
            this.SuspendLayout();
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "startPage1";
            this.start.Size = new System.Drawing.Size(400, 300);
            this.start.TabIndex = 0;
            this.Controls.Add(this.start);
            this.ResumeLayout(false);
        }

        //問題画面初期化&表示
        public void QuestStart()
        {
            this.quest = new Question(question, answer, file);
            this.SuspendLayout();
            this.quest.Location = new System.Drawing.Point(0, 0);
            this.quest.Size = new System.Drawing.Size(400, 300);
            this.quest.toTitle = BackTitle;
            this.start.TabIndex = 0;
            this.Controls.Remove(start);
            this.Controls.Add(this.quest);
            this.ResumeLayout(false);
        }

        //スタート画面表示
        public void BackTitle()
        {
            this.Controls.Remove(this.quest);
            this.Controls.Add(this.start);
        }

        //問題読み込み
        public bool LoadFile(string filename)
        {
            try
            {
                //問題と解答をクリア
                question.Clear();
                answer.Clear();

                //ファイル名を保存
                file = filename;

                //ファイル読み込み
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filename, Encoding.GetEncoding("Shift_JIS")))
                {
                    bool flag = true;

                    //一行ずつ読んでいく
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //空白行などがあったら上手く動かないかも。一応聞く
                        if (string.IsNullOrEmpty(line.Trim()) && MessageBox.Show("空白行がありました。このまま続行すると、意図しない動作をする可能性があります。\n続行しますか？", "Memorization", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return false;
                        }
                        if (flag)
                        {
                            question.Add(line);
                        }
                        else
                        {
                            answer.Add(line);
                        }
                        flag = !flag;
                    }
                }
            }
            catch { return false; }

            //問題数と解答数が一致
            if (question.Count > 0 && question.Count == answer.Count)
            {
                QuestStart();
                return true;
            }
            //読み込み失敗
            else
            {
                MessageBox.Show("ファイルの読み込みに失敗しました。以下の可能性を確認してください。\n\n・ファイルの行数が0である\n・ファイルが偶数行でない\n・空白行がある\n・区切り文字(,や/など)のみの行がある", "読み込み失敗");
                return false;
            }
        }

        //終了ボタン
        public void Exit()
        {
            if (MessageBox.Show("終了しますか?", "Memorization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion
    }
}
