using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMET
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new StartForm());
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Program error!\n" + ex.ToString());
            }
        }
    }
}
