using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_CKawakawam_300821245_A6
{
    public partial class SplashHomeScreen : Form
    {
        //Alias 
        public Form1 FirstForm = Program.FirstForm;

        public SplashHomeScreen()
        {
            InitializeComponent();
        }

        private void SplashHomeScreentimer_Tick(object sender, EventArgs e)
        {
            SplashHomeScreentimer.Enabled = false;
            FirstForm.Show();
            this.Hide();
        }

    }
}
