using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittlePaint
{
    public partial class MainForm : Form
    {
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AskForSaveChanges())
                return;
            Image image = new Bitmap((int)pictArea.Width - 2, (int)pictArea.Height - 2);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            g.Dispose();

            if (pictArea.Image != null)
                pictArea.Image.Dispose();

            pictArea.Image = (Image)image.Clone();
            image.Dispose();
            oldImage = (Bitmap)pictArea.Image;
            this.Text = "Little Paint";
            pictWasChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AskForSaveChanges())
                return;
            using (OpenFileDialog openPictureDialog = new OpenFileDialog())
            {
                //фильтры
                openPictureDialog.Filter = "Image files (*.jpeg,*.png,*.bmp) | *.jpeg;*.png;*.bmp;";
                // выход, если была нажата кнопка Отмена и прочие (кроме ОК)
                if (openPictureDialog.ShowDialog() != DialogResult.OK)
                    return;
                // имя файла теперь хранится в openPictureDialog.FileName
                curImgName = openPictureDialog.FileName;
                try
                {
                    if (pictArea.Image != null)
                        pictArea.Image.Dispose();
                    Image image = new Bitmap(curImgName);
                    pictArea.Image = image;
                    oldImage = new Bitmap(image);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error. Try open another file.", "Error opening", MessageBoxButtons.OK);
                }
                Text = "Little Paint : " + curImgName;
                pictWasChanged = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savePictureDialog = new SaveFileDialog())
            {
                //фильтры
                savePictureDialog.Filter = "JPEG Image (*.jpeg)|*.jpeg|PNG Image (*.png)|*.png|GIF Image (*.bmp)|*.bmp";

                if (curImgName == null || curImgName == "")
                    savePictureDialog.FileName = "NotNamed";

                else
                    savePictureDialog.FileName = curImgName;
                //end
                try
                {
                    if (savePictureDialog.ShowDialog() == DialogResult.OK)
                    {
                        switch (savePictureDialog.FilterIndex)
                        {
                            case 1:
                                pictArea.Image.Save(savePictureDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 2:
                                pictArea.Image.Save(savePictureDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case 3:
                                pictArea.Image.Save(savePictureDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                        }
                        Text = "Little Paint : " + savePictureDialog.FileName;
                        pictWasChanged = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error. Try to save file with another name.", "Error saving", MessageBoxButtons.OK);
                    saveToolStripMenuItem_Click(saveToolStripMenuItem, null);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AskForSaveChanges())
                return;
        }


        bool AskForSaveChanges()
        {
            if (pictWasChanged)
            {
                DialogResult dResult = MessageBox.Show("Picture was changed. Do you want save the picture changes?", "Save changes?", MessageBoxButtons.YesNoCancel);

                if (dResult == DialogResult.Cancel) { return true; }

                if (dResult == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(saveToolStripMenuItem, null);

                    return false;
                }
            }
            return false;
        }
    }
}
