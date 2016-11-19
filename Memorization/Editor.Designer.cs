namespace Memorization
{
    partial class Editor
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putBehindBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "第000問目/全000問";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.pagePToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileNToolStripMenuItem,
            this.openOToolStripMenuItem,
            this.saveSToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.clearCToolStripMenuItem,
            this.exitEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // newFileNToolStripMenuItem
            // 
            this.newFileNToolStripMenuItem.Name = "newFileNToolStripMenuItem";
            this.newFileNToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.newFileNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.newFileNToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.newFileNToolStripMenuItem.Text = "New &File";
            this.newFileNToolStripMenuItem.Click += new System.EventHandler(this.newFileNToolStripMenuItem_Click);
            // 
            // openOToolStripMenuItem
            // 
            this.openOToolStripMenuItem.Name = "openOToolStripMenuItem";
            this.openOToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openOToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openOToolStripMenuItem.Text = "&Open";
            this.openOToolStripMenuItem.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // saveSToolStripMenuItem
            // 
            this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
            this.saveSToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveSToolStripMenuItem.Text = "&Save";
            this.saveSToolStripMenuItem.Click += new System.EventHandler(this.saveSToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // clearCToolStripMenuItem
            // 
            this.clearCToolStripMenuItem.Name = "clearCToolStripMenuItem";
            this.clearCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clearCToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.clearCToolStripMenuItem.Text = "&Clear";
            this.clearCToolStripMenuItem.Click += new System.EventHandler(this.clearCToolStripMenuItem_Click);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exitEToolStripMenuItem.Text = "&Exit";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertIToolStripMenuItem,
            this.putBehindBToolStripMenuItem,
            this.deleteDToolStripMenuItem,
            this.cleanLToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.editEToolStripMenuItem.Text = "Edit(&E)";
            // 
            // insertIToolStripMenuItem
            // 
            this.insertIToolStripMenuItem.Name = "insertIToolStripMenuItem";
            this.insertIToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+I";
            this.insertIToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.insertIToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.insertIToolStripMenuItem.Text = "&Insert";
            this.insertIToolStripMenuItem.Click += new System.EventHandler(this.insertIToolStripMenuItem_Click);
            // 
            // putBehindBToolStripMenuItem
            // 
            this.putBehindBToolStripMenuItem.Name = "putBehindBToolStripMenuItem";
            this.putBehindBToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.putBehindBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.putBehindBToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.putBehindBToolStripMenuItem.Text = "&Put Behind";
            this.putBehindBToolStripMenuItem.Click += new System.EventHandler(this.putBehindBToolStripMenuItem_Click);
            // 
            // deleteDToolStripMenuItem
            // 
            this.deleteDToolStripMenuItem.Name = "deleteDToolStripMenuItem";
            this.deleteDToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.deleteDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.deleteDToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteDToolStripMenuItem.Text = "&Delete";
            this.deleteDToolStripMenuItem.Click += new System.EventHandler(this.deleteDToolStripMenuItem_Click);
            // 
            // cleanLToolStripMenuItem
            // 
            this.cleanLToolStripMenuItem.Name = "cleanLToolStripMenuItem";
            this.cleanLToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cleanLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.cleanLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cleanLToolStripMenuItem.Text = "C&Lean";
            this.cleanLToolStripMenuItem.Click += new System.EventHandler(this.cleanLToolStripMenuItem_Click);
            // 
            // pagePToolStripMenuItem
            // 
            this.pagePToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forwardToolStripMenuItem,
            this.backToolStripMenuItem});
            this.pagePToolStripMenuItem.Name = "pagePToolStripMenuItem";
            this.pagePToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.pagePToolStripMenuItem.Text = "Page(&P)";
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forwardToolStripMenuItem.Text = "&Next";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(363, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 4;
            this.button1.Text = "×";
            this.toolTip1.SetToolTip(this.button1, "この問題を削除します");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 160);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.toolTip1.SetToolTip(this.richTextBox1, "問題を入力してください");
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "解答              区切り文字は\'、\'(AND)、\'/\'(OR)のどちらかに統一してください";
            this.toolTip1.SetToolTip(this.label2, "区切り文字に使える文字一覧 (AND･OR併用不可)\r\nAND: \'　\'　\' \'　\',\'　\'，\'　\'、\' (全半ｽﾍﾟｰｽ、全半ｶﾝﾏ、読点)\r\nOR: \'｜\'　" +
        "\'|\'　\'/\'(全半縦線、半角ｽﾗｯｼｭ)\r\n穴埋めに使うなら\'・\'(全角中点)を使ってください");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 19);
            this.textBox1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox1, "解答を入力してください。上記以外の区切り文字も使えます\r\n OR : 、([全]読点) , ([半]コンマ) ，([全]コンマ)\r\nAND: / ([半]斜線) " +
        "| ([半]縦線) ｜([全]縦線)");
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Location = new System.Drawing.Point(61, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "前の問題へ";
            this.toolTip1.SetToolTip(this.button2, "前の番号の問題を編集します");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Location = new System.Drawing.Point(142, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "次の問題へ";
            this.toolTip1.SetToolTip(this.button3, "次の番号の問題を編集します");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Location = new System.Drawing.Point(223, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "決定&&保存";
            this.toolTip1.SetToolTip(this.button4, "ファイルに保存します");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.Location = new System.Drawing.Point(304, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "タイトルへ";
            this.toolTip1.SetToolTip(this.button5, "タイトルに戻ります");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PowderBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(341, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(16, 16);
            this.button6.TabIndex = 3;
            this.button6.Text = "○";
            this.toolTip1.SetToolTip(this.button6, "入力欄を空にします");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PowderBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(319, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(16, 16);
            this.button7.TabIndex = 2;
            this.button7.Text = "＋";
            this.toolTip1.SetToolTip(this.button7, "この問題の次に新しい問題を追加します");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PowderBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.Location = new System.Drawing.Point(297, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(16, 16);
            this.button8.TabIndex = 1;
            this.button8.Text = "±";
            this.toolTip1.SetToolTip(this.button8, "この番号に新しい問題を追加します");
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(398, 299);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.Text = "Memorization Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem clearCToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanLToolStripMenuItem;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem putBehindBToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem pagePToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}