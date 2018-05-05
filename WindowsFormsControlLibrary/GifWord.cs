﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class GifWord : Label
    {
        public string Word { get; set; }

        public GifWord()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            if (string.IsNullOrEmpty(Word)) return;
            var font = new Font("黑体", 20);
            Brush[] brush = { Brushes.Black, Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Brown, Brushes.Gold };
            var str = g.MeasureString(Word, font);
            var strW = str.Width / Word.Length;
            //格式文本
            var sf = new StringFormat
            {
                Alignment = StringAlignment.Near,   //alignment属性垂直
                LineAlignment = StringAlignment.Center  //水平
            };
            for (int i = 0, j = 0; i < Word.Length; i++, j++)
            {
                if (j > brush.Length - 1) j = 0;
                g.DrawString(Word[i].ToString(), font, brush[j], i * strW, ClientSize.Height / 2, sf);
            }
        }
    }
}
