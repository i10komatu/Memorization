namespace Memorization
{
    partial class StartPage
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "暗記補助ソフト Memorization";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(37, 222);
            this.button1.MaximumSize = new System.Drawing.Size(200, 70);
            this.button1.MinimumSize = new System.Drawing.Size(97, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Start";
            this.toolTip1.SetToolTip(this.button1, "出題を開始します\r\n押すと、ファイルを開くダイアログが開きます");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(153, 222);
            this.button2.MaximumSize = new System.Drawing.Size(200, 70);
            this.button2.MinimumSize = new System.Drawing.Size(97, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Make";
            this.toolTip1.SetToolTip(this.button2, "問題の書いてあるテキストファイルを作ります");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(271, 222);
            this.button3.MaximumSize = new System.Drawing.Size(200, 70);
            this.button3.MinimumSize = new System.Drawing.Size(97, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Exit";
            this.toolTip1.SetToolTip(this.button3, "プログラムを終了します");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copyright © 2010-2013 H.Komatsu";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "StartPage";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}
