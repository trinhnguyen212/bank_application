using System;
using System.Collections;

namespace CustomerManager
{
    public class CustomersController
    {
        CustomersView _view;
        IList      _customers;
        Customer       _selectedCustomer;

        public CustomersController(CustomersView view, IList customers)
        {
            _view = view;
            _customers = customers;
            view.SetController(this);
        }

        public CustomersView CustomersView
        {
            get => default;
            set
            {
            }
        }

        public Customer Customer
        {
            get => default;
            set
            {
            }
        }

        //public IList Customers
        //{
        //   get { return ArrayList.ReadOnly(_customers); }
        //}

        private void updateViewDetailValues(Customer csr)
        {
           _view.FirstName   =  csr.FirstName;
           _view.LastName    =  csr.LastName;
           _view.ID          =  csr.ID;
           _view.Nationality  =  csr.Nationality;
           _view.Sex         =  csr.Sex;
        }

        private void updateCustomerWithViewValues(Customer csr)
        {
            if (this._view.CheckTxt())
            {
                csr.FirstName = _view.FirstName;
                csr.LastName = _view.LastName;
                csr.ID = _view.ID;
                csr.Nationality = _view.Nationality;
                csr.Sex = _view.Sex;
            }
        }


        public void LoadView()
        {
            _view.ClearGrid();
            foreach (Customer csr in _customers)
                _view.AddCustomerToGrid(csr);

          // _view.SetSelectedUserInGrid((User)_customers[0]);

        }

        public void SelectedCustomerChanged(string selectedCustomerId)
        {
            foreach (Customer csr in this._customers)
            {
                if (csr.ID == selectedCustomerId)
                {
                    _selectedCustomer = csr;
                    updateViewDetailValues(csr);
                    _view.SetSelectedCustomerInGrid(csr);
                    this._view.CanModifyID = false;
                    break;
                }
            }
        }
   

        public void AddNewCustomer()
        {
                _selectedCustomer = new Customer(""/*firstname*/,
                                         "" /*lastname*/,
                                         //   ""  /*id*/, 
                                         "" /*department*/,
                                         Customer.SexOfPerson.Male /*sex*/);

                this.updateViewDetailValues(_selectedCustomer);
                this._view.CanModifyID = false;
            
            
        }
      
        public void RemoveCustomer()
        {
              //if (this._customers.Count == 1)
              // { this._view.ClearTxt(); }
            if (this._customers.Count >0)
            {
                string id = this._view.GetIdOfSelectedCustomerInGrid();
                Customer customerToRemove = null;

                if (id != "")
                {
                    foreach (Customer csr in this._customers)
                    {
                        if (csr.ID == id)
                        {
                            customerToRemove = csr;
                            break;
                        }
                      
                    }

                    if (customerToRemove != null)
                    {
                        int newSelectedIndex = this._customers.IndexOf(customerToRemove);
                        this._customers.Remove(customerToRemove);
                        this._view.RemoveCustomerFromGrid(customerToRemove);

                        if (newSelectedIndex > -1 && newSelectedIndex < _customers.Count)
                        {
                            this._view.SetSelectedCustomerInGrid((Customer)_customers[newSelectedIndex]);
                        }
                        else { this._view.ClearTxt(); }


                    }

                }


            }

        }

        public void Save()
        {
            if (this._view.CheckTxt())
            {
                updateCustomerWithViewValues(_selectedCustomer);
                if (!this._customers.Contains(_selectedCustomer))
                {
                    // Add new customer
                    this._customers.Add(_selectedCustomer);
                    this._view.AddCustomerToGrid(_selectedCustomer);
                }
                //else
                //{
                //    // Update existing
                //    this._view.UpdateGridWithChangedUser(_selectedCustomer);
                //}
              //  _view.SetSelectedCustomerInGrid(_selectedCustomer);
                this._view.CanModifyID = false;
            }

        }

        public void Update()
        {
            updateCustomerWithViewValues(_selectedCustomer);
            if (this._customers.Contains(_selectedCustomer))
            {
            //    // Add new user
            //    this._customers.Add(_selectedCustomer);
            //    this._view.AddUserToGrid(_selectedCustomer);
            //}
            //else
            //{
                // Update existing
                this._view.UpdateGridWithChangedCustomer(_selectedCustomer);
            }
      //  _view.SetSelectedCustomerInGrid(_selectedCustomer);
            this._view.CanModifyID = false;
        }

    }
}
