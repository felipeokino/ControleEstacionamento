﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstacionamento;
using System.Windows.Forms;

namespace ControleEstacionamento
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin login = new FormLogin();
            Application.Run(login);
            if(login.DialogResult == DialogResult.OK){
                 Application.Run(new FormPrincipal());
            }
        }
    }
}
