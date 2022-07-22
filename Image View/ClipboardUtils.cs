using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Utils {
    internal class ClipboardUtils {
        /// <summary>
        /// Returns an image from the clipboard and capture exception
        /// </summary>
        /// <returns>Bitmap captured or null</returns>
        public static Bitmap GetImage() {
            try {
                var dataObject = Clipboard.GetDataObject();

                var formats = dataObject.GetFormats(true);
                if (formats == null || formats.Length == 0)
                    return null;
                foreach (var f in formats)
                    Debug.WriteLine(" - " + f.ToString());

                var first = formats[0];

                if (formats.Contains("PNG")) {
                    Debug.WriteLine("PNG");

                    using (MemoryStream ms = (MemoryStream)dataObject.GetData("PNG")) {
                        ms.Position = 0;
                        return (Bitmap)new Bitmap(ms);
                    }
                }
                // Guess at Chromium and Moz Web Browsers which can just use WPF's formatting
                else if (first == DataFormats.Bitmap || formats.Contains("text/_moz_htmlinfo")) {
                    Debug.WriteLine("First == Bitmap");

                    var src = Clipboard.GetImage();
                    //return WindowUtilities.BitmapSourceToBitmap(src);
                } else if (formats.Contains("System.Drawing.Bitmap")) // (first == DataFormats.Dib)
                  {
                    Debug.WriteLine("System.Drawing.Bitmap");
                    var bitmap = (Bitmap)dataObject.GetData("System.Drawing.Bitmap");
                    return bitmap;
                }

                return System.Windows.Forms.Clipboard.GetImage() as Bitmap;
            } catch {
                return null;
            }
        }
    }
}
