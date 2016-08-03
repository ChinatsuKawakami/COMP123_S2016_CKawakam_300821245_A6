using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_CKawakawam_300821245_A6
{
    public static class Program
    {
        public static SplashHomeScreen SplashHome;
        public static BMICalculator FirstForm;
        public static ResultOfBMICalculator SecondForm;
     
        [STAThread]
       public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            SecondForm = new ResultOfBMICalculator();
            FirstForm = new BMICalculator();
            SplashHome = new SplashHomeScreen();
            Application.Run(SplashHome);
        }
    }
}
