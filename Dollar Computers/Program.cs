using Dollar_Computers.Models;
using Dollar_Computers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Assignment 5, Dollar Computers
 * MUHAMMAD SHIBLEE
 * 301064587
 * Version 5.0 (Completed)
 * Last modified on 16 Aug, 2019
 */

namespace Dollar_Computers
{
    public static class Program
    {
        //static members
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;
        public static ProductDetails productDetails;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instantiate all forms here
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();
            productDetails = new ProductDetails();
            product = new Product();


            Application.Run(splashForm);
        }
    }
}
