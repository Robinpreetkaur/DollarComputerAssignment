/*
   Author's name: Robinpreet Kaur
   Author’s student number: 301100296
   Date last Modified: Augusts 23 2020
   Program description: 
       Assignment-5 of Programming-2
   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputerAssignment
{
    static class Program
    {
       
        public static SplashForm splashForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

                 //starts/call  the program with splash form
            splashForm = new SplashForm();
            Application.Run(splashForm); 
        }
    }
}
