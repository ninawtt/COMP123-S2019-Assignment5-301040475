using COMP123_S2019_Assignment5_301040475.Models;
using COMP123_S2019_Assignment5_301040475.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project Name : COMP123-S2019-Assignment5-301040475
// Program Name : Program.cs
// Author : Tzu-Ting Wu (Nina)
// Author's Student Number : 301040475
// Created On : 8/1/2019 16:00:00 PM
// Last Modified On : 8/1/2019 20:47:00 PM
// Description : Create a Computer purchase application
// Revision History  :
// *
// * Date             Author Ref         Revision(Date in YYYYMMDD format)
// * 20190801         Tzu-Ting Wu        1  Created the initial UI      
// * 20190815         Tzu-Ting Wu        2  Finish startForm, selectForm and productInfoForm functionalities
// * 20190816         Tzu-Ting Wu        3  Finish orderForm and fix startForm's functionalities
// * 
// * 
// * 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace COMP123_S2019_Assignment5_301040475
{
   public static class Program
    {
        // static members
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate all forms here
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            product = new Product();

            Application.Run(splashForm);
        }
    }
}
