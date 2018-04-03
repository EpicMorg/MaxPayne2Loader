using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace max_payne2_loader
{
    public partial class frm_howtouse : Form
    {
        public frm_howtouse()
        {
            InitializeComponent();
        }

        private void frm_howtouse_Load(object sender, EventArgs e)
        {

        }

        private void frm_howtouse_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }
    }
}
