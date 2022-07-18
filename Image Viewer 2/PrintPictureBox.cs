using KEUtils.Utils;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Image_Viewer_2 {
    public class PrintPictureBox {
        Image Image { get; set; }
        PrintDocument PrintDocument { get; set; }
        PrinterSettings PrinterSettings { get; set; }
        PageSettings PageSettings { get; set; }
        PaperSize PaperSize { get; set; }

        public PrintPictureBox(Image image) {
            Image = image;
            PrintDocument = new PrintDocument();
            PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(print);
            PrinterSettings = new PrinterSettings();
            PageSettings = new PageSettings();
            //    PaperSize = new PaperSize("Custome", 100, 200);
            //    pd.Document = pdoc;
            //    pd.Document.DefaultPageSettings.PaperSize = psize;
            //    pdoc.DefaultPageSettings.PaperSize.Height = 320;
            //    pdoc.DefaultPageSettings.PaperSize.Width = 200;
        }

        public void showPrintDialog() {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = PrintDocument;
            if (printDialog.ShowDialog() == DialogResult.OK) {
                PrintDocument.Print();
            }
        }

        public DialogResult showPrintPreview() {
            PrintPreviewDialog ppDialog = new PrintPreviewDialog();
            Control.ControlCollection controls = ppDialog.Controls;
            ToolStrip toolStrip = (ToolStrip)controls[1];
            ToolStripItemCollection items = toolStrip.Items;
            PointF toolBarDpi = getDpi(toolStrip);
            PointF dpiScale = new PointF(toolBarDpi.X / 96f, toolBarDpi.Y / 96f);
            int toolBarWidth = 0;
            int toolBarHeight = 0;
            foreach (ToolStripItem item in items) {
                item.AutoSize = false;
                Image image = item.Image;

                // Resize the image of the button to the new size
                item.Width = (int)Math.Round(dpiScale.X * item.Width);
                item.Height = (int)Math.Round(dpiScale.Y * item.Height);
                // Separators do not have an image
                if (image != null) {
                    int sourceWidth = image.Width;
                    int sourceHeight = image.Height;
                    int width = (int)(Math.Round(dpiScale.X * image.Width));
                    int height = (int)(Math.Round(dpiScale.Y * image.Height));
                    if (width > toolBarWidth) toolBarWidth = width;
                    if (height > toolBarHeight) toolBarHeight = height;
                    Bitmap bm = new Bitmap(width, height);
                    using (Graphics g = Graphics.FromImage((Image)bm)) {
                        // Should be the best
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(image, 0, 0, width, height);
                    }
                    // Put the resized image back to the button 
                    image = (Image)bm;
                }
            }
            toolStrip.AutoSize = false;
            toolStrip.ImageScalingSize = new Size(toolBarWidth, toolBarHeight);
            ppDialog.Document = PrintDocument;
            DialogResult res = ppDialog.ShowDialog();
            return res;
        }

        public PointF getDpi(Control control) {
            float dx, dy;
            Graphics g = control.CreateGraphics();
            try {
                dx = g.DpiX;
                dy = g.DpiY;
            } finally {
                g.Dispose();
            }
            return new PointF(dx, dy);
        }

        public PageSettings getDefaultPageSettings() {
            return PrintDocument.DefaultPageSettings;
        }

        public void showPageSetupDialog() {
            PageSetupDialog psDialog = new PageSetupDialog();
            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            psDialog.PageSettings = PageSettings;
            psDialog.PrinterSettings = PrinterSettings;

            // Do not show the network in the printer dialog.
            psDialog.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = psDialog.ShowDialog();
            if (result == DialogResult.OK) {
                PageSettings = psDialog.PageSettings;
            }
        }

        private void print(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            Rectangle drawingArea = e.MarginBounds;
            if(Image == null) {
                Utils.errMsg("Printing: No image");
                return;
            }
            float aspect = (float)Image.Height / Image.Width;
            if(aspect == 0) {
                Utils.errMsg("Printing: Invalid image");
                return;
            }
            float printAspect = (float)drawingArea.Height / drawingArea.Width;
            // Adjust to fit drawing area
            if (aspect < printAspect) {
                drawingArea.Height = (int)Math.Round(drawingArea.Width * aspect);
            } else {
                drawingArea.Width = (int)Math.Round(drawingArea.Width / aspect);
            }
            e.Graphics.DrawImage(Image, drawingArea);
        }
    }
}
