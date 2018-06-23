namespace Image_Viewer {
    partial class ImageViewer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoomFill = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 662);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTopMost,
            this.toolStripMenuItemZoom});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 96);
            // 
            // toolStripMenuItemTopMost
            // 
            this.toolStripMenuItemTopMost.Checked = true;
            this.toolStripMenuItemTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemTopMost.Name = "toolStripMenuItemTopMost";
            this.toolStripMenuItemTopMost.Size = new System.Drawing.Size(213, 46);
            this.toolStripMenuItemTopMost.Text = "TopMost";
            this.toolStripMenuItemTopMost.Click += new System.EventHandler(this.OnTopMostClick);
            // 
            // toolStripMenuItemZoom
            // 
            this.toolStripMenuItemZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemZoomIn,
            this.toolStripMenuItemZoomOut,
            this.toolStripMenuItemZoomFill,
            this.toolStripMenuItemZoom100});
            this.toolStripMenuItemZoom.Name = "toolStripMenuItemZoom";
            this.toolStripMenuItemZoom.Size = new System.Drawing.Size(213, 46);
            this.toolStripMenuItemZoom.Text = "Zoom";
            // 
            // toolStripMenuItemZoomIn
            // 
            this.toolStripMenuItemZoomIn.Name = "toolStripMenuItemZoomIn";
            this.toolStripMenuItemZoomIn.Size = new System.Drawing.Size(396, 46);
            this.toolStripMenuItemZoomIn.Text = "In";
            this.toolStripMenuItemZoomIn.Click += new System.EventHandler(this.OnZoomIn);
            // 
            // toolStripMenuItemZoomOut
            // 
            this.toolStripMenuItemZoomOut.Name = "toolStripMenuItemZoomOut";
            this.toolStripMenuItemZoomOut.Size = new System.Drawing.Size(396, 46);
            this.toolStripMenuItemZoomOut.Text = "Out";
            this.toolStripMenuItemZoomOut.Click += new System.EventHandler(this.OnZoomOut);
            // 
            // toolStripMenuItemZoom100
            // 
            this.toolStripMenuItemZoom100.Name = "toolStripMenuItemZoom100";
            this.toolStripMenuItemZoom100.Size = new System.Drawing.Size(396, 46);
            this.toolStripMenuItemZoom100.Text = "100%";
            this.toolStripMenuItemZoom100.Click += new System.EventHandler(this.OnZoom100);
            // 
            // toolStripMenuItemZoomFill
            // 
            this.toolStripMenuItemZoomFill.Name = "toolStripMenuItemZoomFill";
            this.toolStripMenuItemZoomFill.Size = new System.Drawing.Size(396, 46);
            this.toolStripMenuItemZoomFill.Text = "Fill";
            this.toolStripMenuItemZoomFill.Click += new System.EventHandler(this.OnZoomFill);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 662);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Name = "ImageViewer";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTopMost;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoomIn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoomOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoomFill;
    }
}

