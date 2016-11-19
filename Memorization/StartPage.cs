using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Memorization
{
    public partial class StartPage : UserControl
    {
        #region Field

        //出題開始用のデリゲート
        public delegate bool Start(string filename);
        Start start;

        //終了用のデリゲート
        public delegate void Exit();
        Exit exit;

        #endregion

        #region Constructor

        public StartPage(Start st,Exit ex)
        {
            start = st;
            exit = ex;
            InitializeComponent();
        }

        #endregion

        #region Event

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                start(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Editor().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exit();
        }

        #endregion
    }
}
