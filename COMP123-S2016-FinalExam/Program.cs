/*
 * Student Name: Christopher Ritchil 
 * Student ID: 300702644
 * Date Created: August 19th 2016
 * Date Updated: August 19th 2016
 * Description: This application demonstrate the requirement for the Programming II final test
 * file name: Program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AbilityGeneratorForm());
        }
    }
}
