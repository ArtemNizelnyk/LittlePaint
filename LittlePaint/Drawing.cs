using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LittlePaint
{
    public partial class MainForm : Form
    {
        private void pictArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                startPt=endPt = e.Location;
                if (tmpImage != null)
                    tmpImage.Dispose();
                tmpImage = new Bitmap(oldImage);
            }
        }

        private void pictArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = false;
                oldImage = new Bitmap(pictArea.Image);
            }
        }

        private void pictArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (drawing)
                {
                    pictWasChanged = true;

                    using (pen = new Pen((Color)lbPaintColor.BackColor, Convert.ToInt32(tbBrushSize.Value)))
                    {
                        using (brush = new SolidBrush((Color)lbFontColor.BackColor))
                        {
                            switch (curItem)
                            {
                                case Item.Pen:
                                    pictArea.Image = oldImage;
                                    Graphics g = Graphics.FromImage(pictArea.Image);
                                    g.SmoothingMode = SmoothingMode.HighQuality;
                                    pen.StartCap = pen.EndCap = LineCap.Round;
                                    pen.Alignment = PenAlignment.Center;
                                    g.DrawLine(pen, startPt, e.Location);
                                    startPt = e.Location;
                                    g.Dispose();
                                    pictArea.Invalidate();
                                    break;
                                case Item.Line:
                                    newImage = new Bitmap(oldImage);
                                    g = Graphics.FromImage(tmpImage);
                                    g.SmoothingMode = SmoothingMode.HighQuality;
                                    g.Clear(pictArea.BackColor);
                                    g.DrawImage(newImage, 0, 0, pictArea.Width-4, pictArea.Height-4);
                                    endPt = e.Location;
                                    g.DrawLine(pen, startPt, endPt);
                                    pictArea.Image =tmpImage;
                                    pictArea.Refresh();
                                    g.Dispose();
                                    newImage.Dispose();
                                    break;
                                case Item.Rectangle:
                                    newImage = new Bitmap(oldImage);
                                    g = Graphics.FromImage(tmpImage);
                                    g.SmoothingMode = SmoothingMode.HighQuality;
                                    g.Clear(pictArea.BackColor);
                                    g.DrawImage(newImage, 0, 0, pictArea.Width-4, pictArea.Height-4);
                                    endPt = e.Location;
                                    Rectangle rect = DrawRectangle(startPt, endPt);
                                    g.DrawRectangle(pen, DrawRectangle(startPt, endPt));
                                    g.FillRectangle(brush, DrawRectangle(startPt, endPt));
                                    pictArea.Image = tmpImage;
                                    pictArea.Refresh();
                                    g.Dispose();
                                    newImage.Dispose();
                                    break;
                                case Item.Elipse:
                                    newImage = new Bitmap(oldImage);
                                    g = Graphics.FromImage(tmpImage);
                                    g.SmoothingMode = SmoothingMode.HighQuality;
                                    g.Clear(pictArea.BackColor);
                                    g.DrawImage(newImage, 0, 0, pictArea.Width-4, pictArea.Height-4);
                                    endPt = e.Location;
                                    rect = DrawRectangle(startPt, endPt);
                                    g.DrawEllipse(pen, DrawRectangle(startPt, endPt));
                                    g.FillEllipse(brush, DrawRectangle(startPt, endPt));
                                    pictArea.Image = tmpImage;
                                    pictArea.Refresh();
                                    g.Dispose();
                                    newImage.Dispose();
                                    break;
                                case Item.Eraser:
                                    using (eraser = new Pen(Color.White, Convert.ToInt32(tbBrushSize.Value)))
                                    {
                                        pictArea.Image = oldImage;
                                        g = Graphics.FromImage(pictArea.Image);
                                        g.SmoothingMode = SmoothingMode.HighQuality;
                                        eraser.StartCap = eraser.EndCap = LineCap.Round;
                                        eraser.Alignment = PenAlignment.Center;
                                        g.DrawLine(eraser, startPt, e.Location);
                                        g.Dispose();
                                    }
                                    startPt = e.Location;
                                    pictArea.Invalidate();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private Rectangle DrawRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int w = Math.Abs(p2.X - p1.X);
            int h = Math.Abs(p2.Y - p1.Y);

            return new Rectangle(x, y, w, h);
        }

        private void MakeGray(Bitmap bmp, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // Задаём формат Пикселя.
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            // Получаем данные картинки.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            //Блокируем набор данных изображения в памяти
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            // Получаем адрес первой линии.
            IntPtr ptr = bmpData.Scan0;
            // Задаём массив из Byte и помещаем в него надор данных.
            // int numBytes = bmp.Width * bmp.Height * 3; 
            //На 3 умножаем - поскольку RGB цвет кодируется 3-мя байтами
            //Либо используем вместо Width - Stride
            int numBytes = bmpData.Stride * bmp.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];
            // Копируем значения в массив.
            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            for (int i = 0; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(30);
                    worker.ReportProgress(i);
                }
            }
           
            // Перебираем пикселы по 3 байта на каждый и меняем значения
            for (int counter = 0; counter < rgbValues.Length - 2; counter += 3)
            {
                //worker.ReportProgress(counter * 100 / (rgbValues.Length - 2));

                int value = rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2];
                byte color_b = 0;

                color_b = Convert.ToByte(value / 3);

                rgbValues[counter] = color_b;
                rgbValues[counter + 1] = color_b;
                rgbValues[counter + 2] = color_b;
            }
            
            // Копируем набор данных обратно в изображение
            Marshal.Copy(rgbValues, 0, ptr, numBytes);
            // Разблокируем набор данных изображения в памяти.
            bmp.UnlockBits(bmpData);
        }
    }
}
