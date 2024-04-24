using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Collections;

namespace CustomerManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //View
            CustomersView view = new CustomersView();
            view.Visible = false;

            //Model
            // Add some dummy data
            IList customers = new ArrayList();
            customers.Add(new Customer("Tracy",   "Nguyen","Vietnamese",          Customer.SexOfPerson.Female));
            customers.Add(new Customer("Tim",     "Kapoor",    "USA",             Customer.SexOfPerson.Male));
            customers.Add(new Customer("Steven",    "Song",    "Canadian",          Customer.SexOfPerson.Male));
      
            //Controller
            CustomersController controller = new CustomersController(view, customers);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}
