using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ViewImage {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form {
        private String imageName = "C:\\Users\\evans\\Pictures\\Assorted\\BirthOfVenus.jpg";
        enum MODE { NORMAL, CENTER, STRETCH, ZOOM };
        private MODE mode = MODE.STRETCH;

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenu;
        private System.Windows.Forms.MenuItem fileMenuOpen;
        private System.Windows.Forms.MenuItem fileMenuExit;
        private System.Windows.Forms.MenuItem helpMenu;
        private System.Windows.Forms.MenuItem helpMenuAbout;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private IContainer components;
        private System.Windows.Forms.MenuItem optionsMenu;
        private System.Windows.Forms.MenuItem optionsSizeModeCenterImage;
        private System.Windows.Forms.MenuItem optionsSizeModeNormal;
        private System.Windows.Forms.MenuItem optionsSizeMode;
        private System.Windows.Forms.MenuItem optionsFitToImage;
        private MenuItem optionsSizeModeZoomImage;
        private MenuItem helpMenuInformation;
        private System.Windows.Forms.MenuItem optionsSizeModeStretchImage;

        public MainForm() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.helpMenuAbout = new System.Windows.Forms.MenuItem();
            this.helpMenuInformation = new System.Windows.Forms.MenuItem();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
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
            this.optionsSizeModeZoomImage});
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
            this.optionsSizeModeZoomImage.Text = "Zoom Image";
            this.optionsSizeModeZoomImage.Click += new System.EventHandler(this.MainMenuHandler);
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
            this.imagePictureBox.BackColor = System.Drawing.Color.YellowGreen;
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
            this.BackColor = System.Drawing.Color.Maroon;
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

                openFileDialog.InitialDirectory = "c:\\GIF";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
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
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Image image = imagePictureBox.Image;
            int offW = (ClientSize.Width - image.Width) / 2;
            int offH = (ClientSize.Height - image.Height) / 2;
            imagePictureBox.Location = new Point(offW, offH);
            imagePictureBox.ClientSize = new Size(image.Width, image.Height);
            AutoScroll = true;
            HorizontalScroll.Maximum = image.Width;
            VerticalScroll.Maximum = image.Height;
            optionsSizeModeCenterImage.Checked = true;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = false;
            Invalidate();
        }

        private void doNormal() {
            mode = MODE.NORMAL;
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Image image = imagePictureBox.Image;
            imagePictureBox.Location = new Point(0, 0);
            imagePictureBox.ClientSize = new Size(image.Width, image.Height);
            AutoScroll = true;
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = true;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = false;
            Invalidate();
        }

        private void doStretch() {
            mode = MODE.STRETCH;
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePictureBox.Location = new Point(0, 0);
            imagePictureBox.ClientSize = ClientSize;
            AutoScroll = false;
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = true;
            optionsSizeModeZoomImage.Checked = false;
            Invalidate();
        }

        private void doZoom() {
            mode = MODE.ZOOM;
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imagePictureBox.Location = new Point(0, 0);
            imagePictureBox.ClientSize = ClientSize;
            AutoScroll = false;
            optionsSizeModeCenterImage.Checked = false;
            optionsSizeModeNormal.Checked = false;
            optionsSizeModeStretchImage.Checked = false;
            optionsSizeModeZoomImage.Checked = true;
            Invalidate();
        }

        private void doFit() {
            imagePictureBox.ClientSize = imagePictureBox.Image.Size;
            imagePictureBox.Location = new Point(0, 0);
            ClientSize = imagePictureBox.Size;
            Invalidate();
        }

        private void doInfo() {
            MessageBox.Show("mode=" + mode
                + "\nClientSize=" + ClientSize
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
               ,
                "Debug Information");
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
            }
            Invalidate();
        }

        private void OnFormResize(object sender, System.EventArgs e) {
            refresh();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            imagePictureBox.Image = new Bitmap(imageName);
            doStretch();
        }
    }
}
