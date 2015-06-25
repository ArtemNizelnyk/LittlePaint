using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittlePaint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        bool pictWasChanged, drawing;

        Point startPt, endPt;

        string curImgName;

        Bitmap oldImage, tmpImage, newImage;
        Image bworkImage;

        Item curItem;

        Pen pen, eraser;

        Brush brush;

        enum Item
        {
            Pen,
            Line,
            Rectangle,
            Elipse,
            Eraser
        }

        private void bnPencil_Click(object sender, EventArgs e)
        {
            curItem = Item.Pen;
        }

        private void bnLine_Click(object sender, EventArgs e)
        {
            curItem = Item.Line;
        }

        private void bnRectangle_Click(object sender, EventArgs e)
        {
            curItem = Item.Rectangle;
        }

        private void bnElipse_Click(object sender, EventArgs e)
        {
            curItem = Item.Elipse;
        }

        private void bnEraser_Click(object sender, EventArgs e)
        {
            curItem = Item.Eraser;
        }

        private void lbPaintColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    lbPaintColor.BackColor = colorDialog.Color;
            }
        }

        private void lbFontColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    lbFontColor.BackColor = colorDialog.Color;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(this, null);
        }

        private void bnRotate_Click(object sender, EventArgs e)
        {
            Bitmap bmap = (Bitmap)pictArea.Image;
            bmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictArea.Image = bmap;
            oldImage = (Bitmap)pictArea.Image.Clone();
        }

        private void bnRotate180_Click(object sender, EventArgs e)
        {
            Bitmap bmap = (Bitmap)pictArea.Image;
            bmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictArea.Image = bmap;
            oldImage = (Bitmap)pictArea.Image.Clone();
        }























    }
}
