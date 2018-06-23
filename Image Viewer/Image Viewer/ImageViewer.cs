#undef DOTEST

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer {
    public partial class ImageViewer : Form {
        //private const String imageName = @"C:\Users\evans\Pictures\AAA\Grid-1200x800.png";
        private static String INITIAL_IMAGE = @"C:\Users\evans\Pictures\Assorted\DAZ.Dogfight.15017.jpg";
        private static double ZOOM_FACTOR = 1.1;
        private double zoom = 1;
        private Bitmap originalImage;

        public ImageViewer() {
            InitializeComponent();
            if (this.TopMost) {
                toolStripMenuItemTopMost.CheckState = CheckState.Checked;
            } else {
                toolStripMenuItemTopMost.CheckState = CheckState.Unchecked;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Size = panel1.ClientSize;
        }

        private void doInfo() {

            string msg = DateTime.Now.ToString("f")
                //+ "\nmode=" + mode
                + "\nClientSize=" + ClientSize
                + "\nLocation=" + Location
                + "\npictureBox1.Image.Size" + pictureBox1.Image.Size
                + "\npictureBox1.Size=" + pictureBox1.Size
                + "\npictureBox1.ClientSize=" + pictureBox1.ClientSize
                + "\npictureBox1.Location=" + pictureBox1.Location
                + "\npictureBox1.SizeMode=" + pictureBox1.SizeMode
                + "\nHorizontalScroll.Maximum=" + this.HorizontalScroll.Maximum
                + "\nHorizontalScroll.Minimum=" + this.HorizontalScroll.Minimum
                + "\nHorizontalScroll.Value=" + this.HorizontalScroll.Value
                + "\nHorizontalScroll.Visible=" + this.HorizontalScroll.Visible
                + "\nHorizontalScroll.SmallChange=" + this.HorizontalScroll.SmallChange
                + "\nHorizontalScroll.LargeChange=" + this.HorizontalScroll.LargeChange
                + "\nVerticalScroll.Maximum=" + this.VerticalScroll.Maximum
                + "\nVerticalScroll.Minimum=" + this.VerticalScroll.Minimum
                + "\nVerticalScroll.Value=" + this.VerticalScroll.Value
                + "\nVerticalScroll.Visible=" + this.VerticalScroll.Visible
                + "\nVerticalScroll.SmallChange=" + this.VerticalScroll.SmallChange
                + "\nVerticalScroll.LargeChange=" + this.VerticalScroll.LargeChange
               ;
#if false
            MessageBox.Show(msg, "Debug Information");
#else
            // Allow it to stay up
            Thread t = new Thread(() => MessageBox.Show(msg, "Debug Information"));
            t.Start();
#endif
        }

         private void doHelp() {
            MessageBox.Show("Help is not implemented yet", "Help");
        }

        private void refresh() {
             Invalidate();
        }

        private void zoomIn() {
            if (originalImage == null) return;
            zoom *= ZOOM_FACTOR;
            int width = (int)Math.Round(originalImage.Size.Width * zoom);
            int height = (int)Math.Round(originalImage.Size.Height * zoom);
            Size newSize = new Size(width, height);
            Bitmap bmp = new Bitmap(originalImage, newSize);
            pictureBox1.Image = bmp;
        }

        private void zoomOut() {
            if (originalImage == null) return;
            zoom /= ZOOM_FACTOR;
            int width = (int)Math.Round(originalImage.Size.Width * zoom);
            int height = (int)Math.Round(originalImage.Size.Height * zoom);
            Size newSize = new Size(width, height);
            Bitmap bmp = new Bitmap(originalImage, newSize);
            pictureBox1.Image = bmp;
        }

        private void zoomFill() {
            if(originalImage == null) return;
            Size curSize = panel1.Size;
            double widthFactor = (double)curSize.Width / (double)originalImage.Width;
            double heightFactor = (double)curSize.Height / (double)originalImage.Height;
            if(widthFactor < heightFactor) {
                zoom = widthFactor;
            } else {
                zoom = heightFactor;
            }
            int width = (int)Math.Round(originalImage.Size.Width * zoom);
            int height = (int)Math.Round(originalImage.Size.Height * zoom);
            Size newSize = new Size(width, height);
            Bitmap bmp = new Bitmap(originalImage, newSize);
            pictureBox1.Image = bmp;
        }

        private void zoom100() {
            if (originalImage == null) return;
            zoom = 1;
            Size newSize = originalImage.Size;
            pictureBox1.Image = originalImage;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (originalImage == null) return true; ;
            if (keyData == (Keys.Control | Keys.Oemplus) ||
                keyData == (Keys.Control | Keys.Add)) {
                zoomIn();
            } else if (keyData == (Keys.Control | Keys.OemMinus) ||
               keyData == (Keys.Control | Keys.Subtract)) {
                zoomOut();
            } else if (keyData == (Keys.Control | Keys.D1) ||
                keyData == (Keys.Control | Keys.NumPad1)) {
                zoom100();
            } else if (keyData == (Keys.Control | Keys.D0) ||
                 keyData == (Keys.Control | Keys.NumPad0)) {
                zoomFill();
            }
            return true;
            //return base.ProcessCmdKey(ref msg, keyData);
        }

        private void OnFormLoad(object sender, EventArgs e) {
#if true
            // Load an initial image
            if (File.Exists(INITIAL_IMAGE)) {
                try {
                    originalImage = new Bitmap(INITIAL_IMAGE);
                    pictureBox1.Image = originalImage;
                } catch {
                    MessageBox.Show("Not a valid image file:\n" + INITIAL_IMAGE,
                        "Error");
                    return;
                }
            }
#endif
            //refresh();
        }

        private void OnExitClick(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OnTopMostClick(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(this.TopMost) {
                this.TopMost = false;
                toolStripMenuItemTopMost.CheckState = CheckState.Unchecked;
            } else {
                this.TopMost = true;
                toolStripMenuItemTopMost.CheckState = CheckState.Checked;
            }
        }

        private void OnZoomIn(object sender, EventArgs e) {
            zoomIn();
        }

        private void OnZoomOut(object sender, EventArgs e) {
            zoomOut();
        }

        private void OnZoom100(object sender, EventArgs e) {
            zoom100();
        }

        //private void OnRezize(object sender, EventArgs e) {
        //    pictureBox1.Size = panel1.ClientSize;
        //    refresh();
        //}

        private void OnZoomFill(object sender, EventArgs e) {
            zoomFill();
        }
    }
}
