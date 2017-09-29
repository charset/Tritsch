using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OurChat {
    public partial class RichTextBoxEx : RichTextBox {
        [DllImport("user32")]
        internal extern static int HideCaret(IntPtr hWnd);

        public RichTextBoxEx() {
            InitializeComponent();
            TabStop = false;
            SetStyle(ControlStyles.Selectable, false);

            MouseDown += (sender, @event) => {
                HideCaret(Handle);
            };

            MouseEnter += (sender, @event) => {
                HideCaret(Handle);
            };

            SelectionChanged += (sender, @event) => {
                HideCaret(Handle);
            };
        }
    }
}
