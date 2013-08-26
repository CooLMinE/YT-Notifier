using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace YTNotifier
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
