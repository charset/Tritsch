using System;
using System.Drawing;
using System.Windows.Forms;

namespace OurChat {
    public partial class Bubble : UserControl {
        private readonly bool portraitLeft;
        public bool PortraitLeft { get { return portraitLeft; } }

        private readonly DateTime timestamp;
        public DateTime Timestamp { get { return timestamp; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="portrait"></param>
        /// <param name="rtxContent"></param>
        /// <param name="portraitLeft"></param>
        public Bubble(Guid portrait, string rtxContent, bool portraitLeft = true) {
            this.portraitLeft = portraitLeft;
            this.timestamp = DateTime.Now;
            InitializeComponent();

            #region 根据入参编排UI
            SuspendLayout();
            TableLayoutColumnStyleCollection tableLayout = Layout.ColumnStyles;
            if (portraitLeft) { //0: Portrait PictureBox 1: RichTextBox 2: Blank Space
                tableLayout[0].SizeType = SizeType.Absolute;
                tableLayout[0].Width = 48;
                tableLayout[1].SizeType = SizeType.Percent;
                tableLayout[1].Width = 75F;
                tableLayout[2].SizeType = SizeType.Percent;
                tableLayout[2].Width = 25F;
                Layout.SetColumn(Portrait, 0);
                Layout.SetColumn(rtx, 1);
                rtx.BackColor = Color.RoyalBlue;
                Portrait.Dock = DockStyle.Left;
                Portrait.Margin = new Padding(4, 4, 0, 0);
            } else { //0: Blank Space 1: RichTextBox 2: Portrait PictureBox
                tableLayout[0].SizeType = SizeType.Percent;
                tableLayout[0].Width = 25F;
                tableLayout[1].SizeType = SizeType.Percent;
                tableLayout[1].Width = 75F;
                tableLayout[2].SizeType = SizeType.Absolute;
                tableLayout[2].Width = 48;
                Layout.SetColumn(rtx, 1);
                Layout.SetColumn(Portrait, 2);
                rtx.BackColor = Color.LimeGreen;
                Portrait.Dock = DockStyle.Right;
                Portrait.Margin = new Padding(0, 4, 4, 0);
            }
            Layout.SetRow(rtx, 0); Layout.SetRow(Portrait, 0);
            Portrait.Dock = rtx.Dock = Layout.Dock =  DockStyle.Fill;
            Height = 32;
            Icon icon = Utilities.IconCache.Find(portrait.ToString());
            if (icon == null) icon = Icon.ExtractAssociatedIcon(@"D:\Desktop\S.BAT");
            Portrait.Image = icon.ToBitmap();
            icon.Dispose(); icon = null;
            rtx.Text = rtxContent;
            var size = rtx.GetPreferredSize(new Size(Width, 0));
            rtx.Height = size.Height;
            Portrait.Visible = rtx.Visible = true;
            ResumeLayout();
            #endregion
        }
    }
}
