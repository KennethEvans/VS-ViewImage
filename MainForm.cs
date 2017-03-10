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
        private PictureBoxSizeMode sizeMode = PictureBoxSizeMode.StretchImage;
        private String imageName = "C:\\Users\\evans\\Pictures\\Assorted\\BirthOfVenus.jpg";

        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem FileMenu;
        private System.Windows.Forms.MenuItem FileMenuOpen;
        private System.Windows.Forms.MenuItem FileMenuExit;
        private System.Windows.Forms.MenuItem HelpMenu;
        private System.Windows.Forms.MenuItem HelpMenuAbout;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private IContainer components;
        private System.Windows.Forms.MenuItem OptionsMenu;
        private System.Windows.Forms.MenuItem OptionsSizeModeAutoSize;
        private System.Windows.Forms.MenuItem OptionsSizeModeCenterImage;
        private System.Windows.Forms.MenuItem OptionsSizeModeNormal;
        private System.Windows.Forms.MenuItem OptionsSizeMode;
        private System.Windows.Forms.MenuItem OptionsFitToImage;
        private System.Windows.Forms.MenuItem OptionsSizeModeStretchImage;

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
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.FileMenuOpen = new System.Windows.Forms.MenuItem();
            this.FileMenuExit = new System.Windows.Forms.MenuItem();
            this.OptionsMenu = new System.Windows.Forms.MenuItem();
            this.OptionsSizeMode = new System.Windows.Forms.MenuItem();
            this.OptionsSizeModeAutoSize = new System.Windows.Forms.MenuItem();
            this.OptionsSizeModeCenterImage = new System.Windows.Forms.MenuItem();
            this.OptionsSizeModeNormal = new System.Windows.Forms.MenuItem();
            this.OptionsSizeModeStretchImage = new System.Windows.Forms.MenuItem();
            this.OptionsFitToImage = new System.Windows.Forms.MenuItem();
            this.HelpMenu = new System.Windows.Forms.MenuItem();
            this.HelpMenuAbout = new System.Windows.Forms.MenuItem();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenu,
            this.OptionsMenu,
            this.HelpMenu});
            // 
            // FileMenu
            // 
            this.FileMenu.Index = 0;
            this.FileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenuOpen,
            this.FileMenuExit});
            this.FileMenu.Text = "File";
            // 
            // FileMenuOpen
            // 
            this.FileMenuOpen.Index = 0;
            this.FileMenuOpen.Text = "Open...";
            this.FileMenuOpen.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // FileMenuExit
            // 
            this.FileMenuExit.Index = 1;
            this.FileMenuExit.Text = "Exit";
            this.FileMenuExit.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.Index = 1;
            this.OptionsMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OptionsSizeMode,
            this.OptionsFitToImage});
            this.OptionsMenu.Text = "Options";
            // 
            // OptionsSizeMode
            // 
            this.OptionsSizeMode.Index = 0;
            this.OptionsSizeMode.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OptionsSizeModeAutoSize,
            this.OptionsSizeModeCenterImage,
            this.OptionsSizeModeNormal,
            this.OptionsSizeModeStretchImage});
            this.OptionsSizeMode.Text = "Size Mode";
            // 
            // OptionsSizeModeAutoSize
            // 
            this.OptionsSizeModeAutoSize.Index = 0;
            this.OptionsSizeModeAutoSize.RadioCheck = true;
            this.OptionsSizeModeAutoSize.Text = "Auto Size";
            this.OptionsSizeModeAutoSize.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // OptionsSizeModeCenterImage
            // 
            this.OptionsSizeModeCenterImage.Index = 1;
            this.OptionsSizeModeCenterImage.RadioCheck = true;
            this.OptionsSizeModeCenterImage.Text = "Center Image";
            this.OptionsSizeModeCenterImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // OptionsSizeModeNormal
            // 
            this.OptionsSizeModeNormal.Index = 2;
            this.OptionsSizeModeNormal.RadioCheck = true;
            this.OptionsSizeModeNormal.Text = "Normal";
            this.OptionsSizeModeNormal.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // OptionsSizeModeStretchImage
            // 
            this.OptionsSizeModeStretchImage.Index = 3;
            this.OptionsSizeModeStretchImage.RadioCheck = true;
            this.OptionsSizeModeStretchImage.Text = "Stretch Image";
            this.OptionsSizeModeStretchImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // OptionsFitToImage
            // 
            this.OptionsFitToImage.Index = 1;
            this.OptionsFitToImage.Text = "Fit To Image";
            this.OptionsFitToImage.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Index = 2;
            this.HelpMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.HelpMenuAbout});
            this.HelpMenu.Text = "Help";
            // 
            // HelpMenuAbout
            // 
            this.HelpMenuAbout.Index = 0;
            this.HelpMenuAbout.Text = "About...";
            this.HelpMenuAbout.Click += new System.EventHandler(this.MainMenuHandler);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(968, 1062);
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(13, 31);
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 1062);
            this.Controls.Add(this.ImagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "View Image";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Resize += new System.EventHandler(this.OnFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
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
            if (sender == FileMenuExit) {
                // FileMenuExit
                Application.Exit();
            } else if (sender == FileMenuOpen) {
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
                        ImagePictureBox.Image = new Bitmap(imageName);
                    } catch {
                        MessageBox.Show("Not a valid image file:\n" + imageName,
                            "Error");
                        return;
                    }
                    if (sizeMode != PictureBoxSizeMode.AutoSize) {
                        ImagePictureBox.ClientSize = ClientSize;
                    }
                    Invalidate();
                }
            } else if (sender == OptionsSizeModeAutoSize) {
                // OptionsSizeModeAutoSize
                doAutoSize();
            } else if (sender == OptionsSizeModeCenterImage) {
                // OptionsSizeModeCenterImage
                doCenter();
            } else if (sender == OptionsSizeModeNormal) {
                // OptionsSizeModeNormal
                doNormal();
            } else if (sender == OptionsSizeModeStretchImage) {
                // OptionsSizeModeStretchImage
                doStretch();
            } else if (sender == OptionsFitToImage) {
                // OptionsFitToImage
                doFit();
            } else if (sender == HelpMenuAbout) {
                // HelpMenuAbout
            }
        }

        private void doAutoSize() {
            sizeMode = PictureBoxSizeMode.AutoSize;
            this.AutoScroll = true;
            ImagePictureBox.SizeMode = sizeMode;
            OptionsSizeModeAutoSize.Checked = true;
            OptionsSizeModeCenterImage.Checked = false;
            OptionsSizeModeNormal.Checked = false;
            OptionsSizeModeStretchImage.Checked = false;
            Invalidate();
        }

        private void doCenter() {
            sizeMode = PictureBoxSizeMode.CenterImage;
            ImagePictureBox.SizeMode = sizeMode;
            this.AutoScroll = false;
            ImagePictureBox.ClientSize = ClientSize;
            OptionsSizeModeAutoSize.Checked = false;
            OptionsSizeModeCenterImage.Checked = true;
            OptionsSizeModeNormal.Checked = false;
            OptionsSizeModeStretchImage.Checked = false;
            Invalidate();
        }

        private void doNormal() {
            sizeMode = PictureBoxSizeMode.Normal;
            ImagePictureBox.SizeMode = sizeMode;
            this.AutoScroll = false;
            ImagePictureBox.ClientSize = ClientSize;
            OptionsSizeModeAutoSize.Checked = false;
            OptionsSizeModeCenterImage.Checked = false;
            OptionsSizeModeNormal.Checked = true;
            OptionsSizeModeStretchImage.Checked = false;
            Invalidate();
        }

        private void doStretch() {
            sizeMode = PictureBoxSizeMode.StretchImage;
            ImagePictureBox.SizeMode = sizeMode;
            this.AutoScroll = false;
            ImagePictureBox.ClientSize = ClientSize;
            OptionsSizeModeAutoSize.Checked = false;
            OptionsSizeModeCenterImage.Checked = false;
            OptionsSizeModeNormal.Checked = false;
            OptionsSizeModeStretchImage.Checked = true;
            Invalidate();
        }

        private void doFit() {
            if (sizeMode == PictureBoxSizeMode.AutoSize) {
                this.AutoScroll = false;
                ClientSize = ImagePictureBox.Size;
                Invalidate();
            }
        }

        private void OnFormResize(object sender, System.EventArgs e) {
#if false
            MessageBox.Show("OnFormResize"
                + "\nClientSize.Width=" + ClientSize.Width
                + "\nClientSize.Height=" + ClientSize.Height
               + "\nImagePictureBox.ClientSize.Width=" + ImagePictureBox.ClientSize.Width
                + "\nImagePictureBox.ClientSize.Height=" + ImagePictureBox.ClientSize.Height,
                "Information");
#endif
            switch (sizeMode) {
                case PictureBoxSizeMode.AutoSize:
                    break;
                case PictureBoxSizeMode.Normal:
                case PictureBoxSizeMode.CenterImage:
                case PictureBoxSizeMode.StretchImage:
                    ImagePictureBox.ClientSize = ClientSize;
                    break;
            }
            Invalidate();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            ImagePictureBox.Image = new Bitmap(imageName);
#if false
            doAutoSize();
#else
            doStretch();
#endif
        }
    }
}
