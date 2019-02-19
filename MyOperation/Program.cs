﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyOperation.Forms;


namespace MyOperation
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //创建Init对象
            Init init = new Init();
            Application.Run(init);
        }
    }
}
