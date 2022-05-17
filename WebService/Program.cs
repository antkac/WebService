using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime;


namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1()); 
        } 
    }
}

