using System.Drawing;
using System.Windows.Forms;

namespace OurChat {
    public class RedrawTask {
        private Bitmap bitmap = new Bitmap(48, 48);
        private Image image = null;
        private ToolStripButton bind = null;

        public RedrawTask(ToolStripButton bind, string iconPath) {
            this.bind = bind; image = Image.FromFile(iconPath);
        }
        public void Draw(int unread) {
            using (var g = Graphics.FromImage(bitmap)) {
                g.DrawImage(image, 0, 0, 48, 48);
                if (unread > 0) {
                    string msg = unread >= 100 ? "..." : unread.ToString("D02");
                    g.FillEllipse(Brushes.Red, 24, 0, 24, 16);
                    g.DrawString(msg, SystemFonts.CaptionFont, Brushes.White, 28, 0);
                }
                bind.Image = bitmap;
            }
        }
    }
}
