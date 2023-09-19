using System.Configuration;

namespace TulisanBerjalan
{
    public partial class frmTulisanBerjalan : Form
    {
        public frmTulisanBerjalan()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iblAnimasi.Left -= 10;
            if (iblAnimasi.Left < -iblAnimasi.Width) iblAnimasi.Left = this.Width;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}