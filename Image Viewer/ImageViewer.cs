﻿#undef DOTEST
#define doInitialImage

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
        private string fileName = INITIAL_IMAGE;

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
            string msg;
            if(originalImage == null) {
                msg = "No image";
            } else {
                double bytes = new FileInfo(fileName).Length;
                double kbytes = bytes / 1024.0;
                double mbytes = kbytes / 1024.0;
                double gbytes = mbytes / 1024.0;
                msg = fileName;
                msg += "\nImage Size: " + originalImage.Size.Width + "x" + originalImage.Size.Height;
                msg += "\nFile Size: "
                    + String.Format("{0:0.00} GB, {1:0.00} MB, {2:0.00} KB, {3:0} bytes",
                    gbytes, mbytes, kbytes, bytes);
                msg += "\nCreated: " + File.GetCreationTime(fileName);
                msg += "\nModified: " + File.GetLastWriteTime(fileName);
                msg += "\nAccessed: " + File.GetLastAccessTime(fileName);
            }

#if false
            string msg = DateTime.Now.ToString("f")
                + "\nmode=" + mode
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
#endif
#if false
            MessageBox.Show(msg, " File Information");
#else
            // Allow it to stay up
            Thread t = new Thread(() => MessageBox.Show(msg, "File Information"));
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
#if doInitialImage
            // Load an initial image
            if (File.Exists(INITIAL_IMAGE)) {
                try {
                    originalImage = new Bitmap(INITIAL_IMAGE);
                    pictureBox1.Image = originalImage;
                    zoomFill();
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

        private void OnZoomInClick(object sender, EventArgs e) {
            zoomIn();
        }

        private void OnZoomOutClick(object sender, EventArgs e) {
            zoomOut();
        }

        private void OnZoom100Click(object sender, EventArgs e) {
            zoom100();
        }

        //private void OnRezize(object sender, EventArgs e) {
        //    pictureBox1.Size = panel1.ClientSize;
        //    refresh();
        //}

        private void OnZoomFill(object sender, EventArgs e) {
            zoomFill();
        }

        private void OnOpenClick(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.gif"
                + "|JPEG|*.jpg;*.jpeg;*.jpe"
                + "|PNG|*.png"
                + "|All files|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string imageName="Unknown";
                try {
                    imageName = openFileDialog.FileName;
                    Bitmap newImage = new Bitmap(imageName);
                    pictureBox1.Image = newImage;
                    originalImage = newImage;
                    fileName = imageName;
                    zoom = 1;
                    zoomFill();
                } catch {
                    MessageBox.Show("Not a valid image file:\n" + imageName,
                        "Error");
                    return;
                }
                refresh();
            }
        }

        private void OnInfoClick(object sender, EventArgs e) {
            doInfo();
        }
    }
}
