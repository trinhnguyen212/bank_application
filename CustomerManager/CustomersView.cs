using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CustomerManager
{
    public partial class CustomersView : Form
    {
        public CustomersView()
        {
            InitializeComponent();
        }

       CustomersController _controller;

        #region Events raised  back to controller

        private void btnAdd_Click(object sender, EventArgs e)
        {
          this._controller.AddNewCustomer(); 

            //this._controller.clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            this._controller.RemoveCustomer();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
         
                this._controller.Save();
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._controller.Update();

        }

        #endregion

        #region ICatalogView implementation

        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }

        public void ClearGrid()
        {
            // Define columns in grid
            this.grdCustomers.Columns.Clear();

            this.grdCustomers.Columns.Add("Id",          150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("First Name",  150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("Lastst Name", 150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("Department",  150,  HorizontalAlignment.Left);
            this.grdCustomers.Columns.Add("Sex",         50,   HorizontalAlignment.Left);

            // Add rows to grid
            this.grdCustomers.Items.Clear();
        }
        public void ClearTxt()
        {
            FirstName= string.Empty;
            LastName= string.Empty;
            Nationality= string.Empty;
            ID= string.Empty;
            Sex = Customer.SexOfPerson.Male;
        }

      

        public void AddCustomerToGrid(Customer usr)
        {
            ListViewItem parent;
            parent = this.grdCustomers.Items.Add(usr.ID);
            parent.SubItems.Add(usr.FirstName);
            parent.SubItems.Add(usr.LastName);
            parent.SubItems.Add(usr.Nationality);
            parent.SubItems.Add(Enum.GetName(typeof(Customer.SexOfPerson), usr.Sex));
        }

        public void UpdateGridWithChangedCustomer(Customer usr)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdCustomers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = usr.ID;
                rowToUpdate.SubItems[1].Text = usr.FirstName;
                rowToUpdate.SubItems[2].Text = usr.LastName;
                rowToUpdate.SubItems[3].Text = usr.Nationality;
                rowToUpdate.SubItems[4].Text = Enum.GetName(typeof(Customer.SexOfPerson), usr.Sex);
            }
        }

        public void RemoveCustomerFromGrid(Customer usr)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdCustomers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdCustomers.Items.Remove(rowToRemove);
                this.grdCustomers.Focus();
            }
        }
        public bool CheckTxt()
        {
            if (FirstName!= "" & LastName != "" & Nationality != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("!! Input ERROR !!");
                return false; 
            }
        }
        public string GetIdOfSelectedCustomerInGrid()
        {
            if (this.grdCustomers.SelectedItems.Count > 0)
                return this.grdCustomers.SelectedItems[0].Text;
            else
            {

                return "";
            }

        }

        public void SetSelectedCustomerInGrid(Customer usr)
        {
            foreach (ListViewItem row in this.grdCustomers.Items)
            {
                if (row.Text == usr.ID)
                {
                    row.Selected = true;
                }
            }
        }

        public string FirstName 
        {
            get { return this.txtFirstName.Text; }
            set { this.txtFirstName.Text = value; }
        }

        public string LastName 
        {
            get { return this.txtLastName.Text; }
            set { this.txtLastName.Text = value; }
        }

        public string ID
        {
            get { return this.txtID.Text; }
            set { this.txtID.Text = value; }
        }


        public string Nationality 
        {
            get { return this.txtNationality.Text; }
            set { this.txtNationality.Text = value; }
        }

        public Customer.SexOfPerson Sex
        {
            get
            {
                if (this.rdMale.Checked)
                    return Customer.SexOfPerson.Male;
                else
                    return Customer.SexOfPerson.Female;
            }
            set
            {
                if (value == Customer.SexOfPerson.Male)
                    this.rdMale.Checked = true;
                else
                    this.rdFamele.Checked = true;
            }
        }

        public bool CanModifyID
        {
            set { this.txtID.Enabled = value; }
        }

        #endregion

      

        private void grdCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdCustomers.SelectedItems.Count > 0)
                this._controller.SelectedCustomerChanged(this.grdCustomers.SelectedItems[0].Text);
        }

        private void CustomersView_Load(object sender, EventArgs e)
        {

        }
    }
}
