using CodeD.Data;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocalLengthStatics
{
    public partial class FormHeatmap : MetroForm
    {
        public FormHeatmap()
        {
            InitializeComponent();
        }

        internal void CreateXLabel(int begin, int end)
        {
            labelLeftEdge.Text = begin.ToString();
            labelRightEdge.Text = end.ToString();

            var y = labelLeftEdge.Location.Y;
            var left_x = labelLeftEdge.Location.X;
            var right_x = labelRightEdge.Location.X;

            var unit = 6;
            var diff = (right_x - left_x) / unit;
            var label_diff = end / unit;
            for (var i = 1; i < unit; i++)
            {
                var new_x = left_x + (diff * i);
                var label = new Label();
                label.Text = (label_diff * i).ToString();
                label.Location = new System.Drawing.Point(new_x, y);
                label.ForeColor = Color.Black;
                label.Font = new Font("メイリオ", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
                label.Size = new Size(29, 12);
                this.Controls.Add(label);
            }
        }

        internal void CreateYLable(DateTime dateBegin, DateTime dateEnd)
        {
            labelDateBegin.Text = dateBegin.ToString("yyyy-MM");
            labelEndDate.Text = dateEnd.ToString("yyyy-MM"); 

            var x = labelDateBegin.Location.X;
            var up_y = labelDateBegin.Location.Y;
            var down_y = labelEndDate.Location.Y;

            var unit = 6;
            var diff = (down_y - up_y) / unit;
            var diff_days = (dateEnd - dateBegin).Days / unit;
            for (var i = 1; i < unit; i++)
            {
                var new_y = up_y + (diff * i);
                var label = new Label();
                label.Text = dateBegin.AddDays(diff_days * i).ToString("yyyy-MM");
                label.Font = new Font("メイリオ", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
                label.Location = new Point(x, new_y);
                this.Controls.Add(label);
            }
        }

        internal void CreateColorBar()
        {
            var forColorBar = new double[765, 1];
            for (int i = 0; i < 765; i++)
            {
                forColorBar[i, 0] = i;
            }
            var colorBar = new ZMappingData(forColorBar);

            int w = pictureBoxColorBar.Size.Width;
            int h = pictureBoxColorBar.Size.Height;

            var image = new Bitmap(w, h);
            var g = Graphics.FromImage(image);
            g.InterpolationMode = InterpolationMode.High;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(colorBar.ToBitmap(null, null, ZMappingData.ColorMode.Rainbow),
                0, 0, w, h);

            pictureBoxColorBar.Image = image;
        }

        internal void SetImage(Bitmap image)
        {
            var w = pictureBox1.Width;
            var h = pictureBox1.Height;

            var canvas = new Bitmap(w, image.Height);
            var g = Graphics.FromImage(canvas);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(image, 0, 0, w, image.Height);
            g.Dispose();

            if (image.Height < h)
            {
                canvas = InflateVertical(canvas, h);
            }

            pictureBox1.Image = canvas;
        }

        /// <summary>
        /// 縦方向に膨らませる
        /// </summary>
        /// <param name="oldCanvas"></param>
        /// <param name="requiredHeight">必要高さ;pictureboxのサイズ</param>
        /// <returns></returns>
        private Bitmap InflateVertical(Bitmap oldCanvas, int requiredHeight)
        {
            //縦方向の決定 requiredHeightを越えるように
            var multiple = (requiredHeight / oldCanvas.Height) + 1;
            var newHeight = oldCanvas.Height * multiple;
            var newCanvas = new Bitmap(oldCanvas.Width, newHeight);

            var newCanvasPlus = new BitmapPlus.BitmapPlus(newCanvas);
            var oldCanvasPlus = new BitmapPlus.BitmapPlus(oldCanvas);
            newCanvasPlus.BeginAccess();
            oldCanvasPlus.BeginAccess();
            // 拡大処理
            var w = oldCanvas.Width;

            Enumerable.Range(0, oldCanvas.Height)
                      .ToList()
                      .ForEach(i =>
                     {
                         for (var j = 0; j < w; j++)
                         {
                             var c = oldCanvasPlus.GetPixel(j, i);
                             for (var k = 0; k < multiple; k++)
                             {
                                 newCanvasPlus.SetPixel(j, i * multiple + k, c);
                             }
                         }
                     });

            //**********
            newCanvasPlus.EndAccess();
            oldCanvasPlus.EndAccess();
            return newCanvas;
        }

        internal Rectangle Rect(Bitmap canvas)
        {
            return new Rectangle(0, 0, canvas.Width, canvas.Height);
        }


        internal void SetTitle(string title)
        {
            metroLabelTitle.Text = title;
        }
    }
}
