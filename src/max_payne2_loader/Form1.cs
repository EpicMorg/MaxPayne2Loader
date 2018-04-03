using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;


namespace max_payne2_loader
{
    public partial class frm_Main : Form

    {
        SoundPlayer backsound = new SoundPlayer(Properties.Resources.backsound);
        Process Payne2 = new Process();
        String key = "";

  

        public frm_Main()
        {
            InitializeComponent();
        }


        private void btn_info_Click(object sender, EventArgs e)
        {
            frm_info form_i = new frm_info();
            form_i.ShowDialog();
        }

        private void btn_howtouse_Click(object sender, EventArgs e)
        {
            frm_howtouse form_htu = new frm_howtouse();
            form_htu.ShowDialog();
        }

        private void btn_rungame_Click(object sender, EventArgs e)
        {
          backsound.Stop();
            key = "";
            if (chbx_developerkeys.Checked)
            {
                key += " -developerkeys ";
            }
            if (chbx_developer.Checked)
            {
                key += " -developer ";
            }
            if (chbx_screenshots.Checked)
            {
                key += " -screenshots ";
            }
            Payne2.StartInfo.Arguments = key;
            //MessageBox.Show(key);
            Payne2.StartInfo.FileName = "MaxPayne2.exe";
            try
            {
                Payne2.Start();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(" The Max Payne™ Loader could not find the file 'MaxPayne.exe'! Please specify the path to yourself.", "File not found...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult res = ofdpain2.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        Payne2.StartInfo.FileName = ofdpain2.FileName;
                        Payne2.Start();
                    }
                    catch (System.Exception exs)
                    {
                        MessageBox.Show(exs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Max Payne 2™ is not installed on your PC! At first, You must install the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
           backsound.PlayLooping();
        }

        private void pic_logo_main_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(" http://www.rockstargames.com/maxpayne2/");
        }

        private void frm_Main_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }

        
    }
}
