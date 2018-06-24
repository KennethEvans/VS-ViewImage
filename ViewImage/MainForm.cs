using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.IO;

namespace ViewImage {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form {
        private static String imageName = @"C:\Users\evans\Pictures\AAA\Grid-1200x800.png";
        //private static String imageName = @"C:\Users\evans\Pictures\Assorted\DAZ.Dogfight.15017.jpg";
        enum MODE { NORMAL, CENTER, STRETCH, ZOOM, AUTOSIZE };
        private MODE mode = MODE.AUTOSIZE;  // (Will be reset in OnFormLoad)

        private MenuItem fileMenu;
        private MainMenu mainMenu;
        private MenuItem fileMenuOpen;
        private MenuItem fileMenuExit;
        private MenuItem optionsMenu;
        private MenuItem optionsSizeMode;
        private MenuItem optionsSizeModeCenterImage;
        private MenuItem optionsSizeModeStretchImage;
        private MenuItem optionsSizeModeNormal;
        private MenuItem optionsSizeModeZoomImage;
        private MenuItem optionsSizeModeAutoSize;
        private MenuItem optionsFitToImage;
        private MenuItem helpMenu;
        private MenuItem helpMenuInformation;
        private MenuItem helpMenuAbout;
        private IContainer components;
        private PictureBox imagePictureBox;

        public MainForm() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

#if true
            // Set background colors for debugging
            this.BackColor = System.Drawing.Color.Maroon;
            this.imagePictureBox.BackColor = System.Drawing.Color.YellowGreen;
#endif
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenu = new System.Windows.Forms.MenuItem();
            this.fileMenuOpen = new System.Windows.Forms.MenuItem();
            this.fileMenuExit = new System.Windows.Forms.MenuItem();
            this.optionsMenu = new System.Windows.Forms.MenuItem();
            this.optionsSizeMode = new System.Windows.Forms.MenuItem();
            this.optionsSizeModeCenterImage = new System.Windows.Forms.MenuItem();
            this.optionsSizeModeNormal = new System.Windows.Forms.MenuItem();
            this.optionsSizeModeStretchImage = new System.Windows.Forms.MenuItem();
            this.optionsSizeModeZoomImage = new System.Windows.Forms.MenuItem();
            this.optionsFitToImage = new System.Windows.Forms.MenuItem();
            this.helpMenu = new System.Windows.Forms.MenuItem();
            this.helpMenuInformation = new System.Windows.Forms.MenuItem();
            this.helpMenuAbout = new System.Windows.Forms.MenuItem();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.optionsSizeModeAutoSize = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenu,
            this.optionsMenu,
            this.helpMenu});
            // 
            // fileMenu
            // 
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuOpen,
            this.fileMenuExit});
            this.fileMenu.Text = "File";
            // 
            // fileMenuOpen
            // 
            this.fileMenuOpen.Index = 0;
            this.fileMenuOpen.Text = "Open...";
            this.fileMenuOpen.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // fileMenuExit
            // 
            this.fileMenuExit.Index = 1;
            this.fileMenuExit.Text = "Exit";
            this.fileMenuExit.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // optionsMenu
            // 
            this.optionsMenu.Index = 1;
            this.optionsMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.optionsSizeMode,
            this.optionsFitToImage});
            this.optionsMenu.Text = "Options";
            // 
            // optionsSizeMode
            // 
            this.optionsSizeMode.Index = 0;
            this.optionsSizeMode.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.optionsSizeModeCenterImage,
            this.optionsSizeModeNormal,
            this.optionsSizeModeStretchImage,
            this.optionsSizeModeZoomImage,
            this.optionsSizeModeAutoSize});
            this.optionsSizeMode.Text = "Size Mode";
            // 
            // optionsSizeModeCenterImage
            // 
            this.optionsSizeModeCenterImage.Index = 0;
            this.optionsSizeModeCenterImage.RadioCheck = true;
            this.optionsSizeModeCenterImage.Text = "Center Image";
            this.optionsSizeModeCenterImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // optionsSizeModeNormal
            // 
            this.optionsSizeModeNormal.Index = 1;
            this.optionsSizeModeNormal.RadioCheck = true;
            this.optionsSizeModeNormal.Text = "Normal";
            this.optionsSizeModeNormal.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // optionsSizeModeStretchImage
            // 
            this.optionsSizeModeStretchImage.Index = 2;
            this.optionsSizeModeStretchImage.RadioCheck = true;
            this.optionsSizeModeStretchImage.Text = "Stretch Image";
            this.optionsSizeModeStretchImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // optionsSizeModeZoomImage
            // 
            this.optionsSizeModeZoomImage.Index = 3;
            this.optionsSizeModeZoomImage.RadioCheck = true;
            this.optionsSizeModeZoomImage.Text = "Zoom Image";
            this.optionsSizeModeZoomImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // menuItemAutoSize
            // 
            this.optionsSizeModeAutoSize.Index = 4;
            this.optionsSizeModeAutoSize.RadioCheck = true;
            this.optionsSizeModeAutoSize.Text = "AutoSize";
            this.optionsSizeModeAutoSize.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // optionsFitToImage
            // 
            this.optionsFitToImage.Index = 1;
            this.optionsFitToImage.Text = "Fit To Image";
            this.optionsFitToImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // helpMenu
            // 
            this.helpMenu.Index = 2;
            this.helpMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.helpMenuInformation,
            this.helpMenuAbout});
            this.helpMenu.Text = "Help";
            // 
            // helpMenuInformation
            // 
            this.helpMenuInformation.Index = 0;
            this.helpMenuInformation.Text = "Debug Information...";
            this.helpMenuInformation.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // helpMenuAbout
            // 
            this.helpMenuAbout.Index = 1;
            this.helpMenuAbout.Text = "About...";
            this.helpMenuAbout.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(968, 1062);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(13, 31);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(968, 1062);
            this.Controls.Add(this.imagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "View Image";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Resize += new System.EventHandler(this.OnFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new MainForm());
        }

        private void MainMenuHandler(object sender, System.EventArgs e) {
#if false
            MessageBox.Show(item.Text + "\n     Index=" + item.Index + "\n     Handle=" +
                item.Handle,"Information");
#endif
            if (sender == fileMenuExit) {
                Application.Exit();
            } else if (sender == fileMenuOpen) {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                //openFileDialog.InitialDirectory = "c:\\GIF";
                openFileDialog.Filter = "Image Files|*.png;*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.gif"
                    + "|JPEG|*.jpg;*.jpeg;*.jpe"
                    + "|PNG|*.png"
                    + "|All files|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        imageName = openFileDialog.FileName;
                        imagePictureBox.Image = new Bitmap(imageName);
                    } catch {
                        MessageBox.Show("Not a valid image file:\n" + imageName,
                            "Error");
                        return;
                    }
                    refresh();
                }
            } else if (sender == optionsSizeModeCenterImage) {
                doCenter();
            } else if (sender == optionsSizeModeNormal) {
                doNormal();
            } else if (sender == optionsSizeModeStretchImage) {
                doStretch();
            } else if (sender == optionsSizeModeZoomImage) {
                doZoom();
            } else if (sender == optionsSizeModeAutoSize) {
                doAutoSize();
            } else if (sender == optionsFitToImage) {
                doFit();
            } else if (sender == helpMenuInformation) {
                doInfo();
            } else if (sender == helpMenuAbout) {
                doHelp();
            }
        }

        private void doCenter() {
            mode = MODE.CENTER;
            AutoScroll = true;
            imagePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            if (imagePictureBox.Image != null) {
                Image image = imagePictureBox.Image;
                int offW = (ClientSize.Width - image.Width) / 2;
                int offH = (ClientSize.Height - image.Height) / 2;
                imagePictureBox.Location = new Point(offW, offH);
                imagePictureBox.ClientSize = new Size(image.Width, image.Height);
            } else {
                imagePictureBox.Location = new Point(0, 0);
            }
            //HorizontalScroll.Maximum = image.Width;
            //VerticalScroll.Maximum = image.Height;
            optionsSizeModeCenterImage.Checked = true;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = false;
            optionsSizeModeAutoSize.Checked = false;
            Invalidate();
        }

        private void doNormal() {
            mode = MODE.NORMAL;
            AutoScroll = true;
            imagePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            imagePictureBox.Location = new Point(0, 0);
            if (imagePictureBox.Image != null) {
                Image image = imagePictureBox.Image;
                imagePictureBox.ClientSize = new Size(image.Width, image.Height);
            }
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = true;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = false;
            optionsSizeModeAutoSize.Checked = false;
            Invalidate();
        }

        private void doStretch() {
            mode = MODE.STRETCH;
            AutoScroll = false;
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePictureBox.Location = new Point(0, 0);
            imagePictureBox.ClientSize = ClientSize;
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = true;
            optionsSizeModeZoomImage.Checked = false;
            optionsSizeModeAutoSize.Checked = false;
            Invalidate();
        }

        private void doZoom() {
            mode = MODE.ZOOM;
            AutoScroll = false;
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imagePictureBox.Location = new Point(0, 0);
            imagePictureBox.ClientSize = ClientSize;
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = true;
            optionsSizeModeAutoSize.Checked = false;
            Invalidate();
        }

        private void doAutoSize() {
            mode = MODE.AUTOSIZE;
            AutoScroll = true;
            imagePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            imagePictureBox.Location = new Point(0, 0);
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = false;
            optionsSizeModeAutoSize.Checked = true;
            Invalidate();
        }

        private void doFit() {
            imagePictureBox.ClientSize = imagePictureBox.Image.Size;
            imagePictureBox.Location = new Point(0, 0);
            ClientSize = imagePictureBox.Size;
            Invalidate();
        }

        private void doInfo() {

            string msg = DateTime.Now.ToString("f")
                + "\nmode=" + mode
                + "\nClientSize=" + ClientSize
                + "\nLocation=" + Location
                + "\nimagePictureBox.Image.Size" + imagePictureBox.Image.Size
                + "\nimagePictureBox.Size=" + imagePictureBox.Size
                + "\nimagePictureBox.ClientSize=" + imagePictureBox.ClientSize
                + "\nimagePictureBox.Location=" + imagePictureBox.Location
                + "\nimagePictureBox.SizeMode=" + imagePictureBox.SizeMode
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
            switch (mode) {
                case MODE.NORMAL:
                    doNormal();
                    break;
                case MODE.CENTER:
                    doCenter();
                    break;
                case MODE.STRETCH:
                    doStretch();
                    break;
                case MODE.ZOOM:
                    doZoom();
                    break;
                case MODE.AUTOSIZE:
                    doAutoSize();
                    break;
            }
            Invalidate();
        }

        private void OnFormResize(object sender, System.EventArgs e) {
            Point pictureBoxLocation = imagePictureBox.Location;
            if (imagePictureBox.Image == null) {
                return;
            }
            refresh();
            if (pictureBoxLocation != null && mode == MODE.AUTOSIZE) {
                imagePictureBox.Location = pictureBoxLocation;
            }
        }

        private void OnFormLoad(object sender, EventArgs e) {
#if true
            // Load an initial image
            if (File.Exists(imageName)) {
                try {
                    imagePictureBox.Image = new Bitmap(imageName);
                } catch {
                    MessageBox.Show("Not a valid image file:\n" + imageName,
                        "Error");
                    return;
                }
            }
#endif
            refresh();
        }
    }
}
