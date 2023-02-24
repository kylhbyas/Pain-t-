using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/// Kyle Byassee
/// 2023-02-23
/// 
/// This file contains the new main, which is the new entry point for the program.
/// 
namespace Pain_t_
{
    internal class Class1
    {
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {
            string msg = "Hello from Main!";
            MessageBox.Show(msg);

            Pain_t_.App app = new Pain_t_.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
