using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittlePaint
{
    public partial class MainForm : Form
    {

        private void bnInverse_Click(object sender, EventArgs e)
        {
            bworkImage = (Image)pictArea.Image.Clone();
            if (!bWork.IsBusy)
            {
                // Start the asynchronous operation.
                bWork.RunWorkerAsync();
                lbProgress.Text = "Working";
                bnInverse.Enabled = false;
                bnCancel.Enabled = true;
            }
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            if (bWork.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                bWork.CancelAsync();
                bnInverse.Enabled = true;
                bnCancel.Enabled = false;

            }
        }

        private void bWork_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            MakeGray((Bitmap)bworkImage, worker, e);


        }
        private void bWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbInvertation.Value = e.ProgressPercentage;
            lbProgress.Text = (e.ProgressPercentage.ToString() + "%");

        }

        private void bWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbProgress.Text = "Canceled!";
                pbInvertation.Value = 0;

            }
            else
                if (e.Error != null)
                {
                    lbProgress.Text = "Error: " + e.Error.Message;
                    pbInvertation.Value = 0;
                }
                else
                {
                    pbInvertation.Value = pbInvertation.Maximum;
                    lbProgress.Text = "Ready to work";
                    if (pictWasChanged)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Save the current changes before loading inverted image?", "Save changes?", MessageBoxButtons.YesNo))
                            saveToolStripMenuItem_Click(null, null);
                    }
                    pictArea.Image = new Bitmap(bworkImage);
                    oldImage = (Bitmap)bworkImage.Clone();
                    pictWasChanged = true;
                }

            bnInverse.Enabled = true;
            bnCancel.Enabled = false;
        }
    }
}

