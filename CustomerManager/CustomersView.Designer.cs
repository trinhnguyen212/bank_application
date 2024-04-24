namespace CustomerManager
{
    partial class CustomersView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdFamele = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grdCustomers = new System.Windows.Forms.ListView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.grbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(778, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(410, 31);
            this.txtID.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 104);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(434, 31);
            this.txtLastName.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(634, 60);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(160, 44);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(36, 110);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(126, 44);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(1282, 104);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(199, 44);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "&Remove Customer";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grbSex);
            this.grpDetails.Controls.Add(this.txtNationality);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtID);
            this.grpDetails.Controls.Add(this.lblID);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(24, 23);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(6);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(6);
            this.grpDetails.Size = new System.Drawing.Size(1228, 277);
            this.grpDetails.TabIndex = 34;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Register new customer :";
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdFamele);
            this.grbSex.Controls.Add(this.rdMale);
            this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbSex.Location = new System.Drawing.Point(42, 152);
            this.grbSex.Margin = new System.Windows.Forms.Padding(6);
            this.grbSex.Name = "grbSex";
            this.grbSex.Padding = new System.Windows.Forms.Padding(6);
            this.grbSex.Size = new System.Drawing.Size(552, 104);
            this.grbSex.TabIndex = 29;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Sex";
            // 
            // rdFamele
            // 
            this.rdFamele.Location = new System.Drawing.Point(276, 37);
            this.rdFamele.Margin = new System.Windows.Forms.Padding(6);
            this.rdFamele.Name = "rdFamele";
            this.rdFamele.Size = new System.Drawing.Size(134, 46);
            this.rdFamele.TabIndex = 5;
            this.rdFamele.Text = "Famele";
            // 
            // rdMale
            // 
            this.rdMale.Location = new System.Drawing.Point(114, 37);
            this.rdMale.Margin = new System.Windows.Forms.Padding(6);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(106, 46);
            this.rdMale.TabIndex = 4;
            this.rdMale.Text = "Male";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(778, 104);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(6);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(410, 31);
            this.txtNationality.TabIndex = 27;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(634, 110);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(160, 44);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Nationality:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 54);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(434, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(36, 60);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(126, 44);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(1282, 48);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 44);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "&Add New Customer";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Location = new System.Drawing.Point(1282, 235);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 44);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "&Register Customer";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCustomers.FullRowSelect = true;
            this.grdCustomers.GridLines = true;
            this.grdCustomers.HideSelection = false;
            this.grdCustomers.Location = new System.Drawing.Point(0, 316);
            this.grdCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(1500, 567);
            this.grdCustomers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdCustomers.TabIndex = 35;
            this.grdCustomers.UseCompatibleStateImageBehavior = false;
            this.grdCustomers.View = System.Windows.Forms.View.Details;
            this.grdCustomers.SelectedIndexChanged += new System.EventHandler(this.grdCustomers_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(1282, 166);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 44);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "&Update Customer";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 883);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "CustomersView";
            this.Text = "Customer List - Active Customers";
            this.Load += new System.EventHandler(this.CustomersView_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbSex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.GroupBox grpDetails;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.ListView grdCustomers;
        internal System.Windows.Forms.TextBox txtNationality;
        internal System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.GroupBox grbSex;
        internal System.Windows.Forms.RadioButton rdFamele;
        internal System.Windows.Forms.RadioButton rdMale;
        internal System.Windows.Forms.Button btnUpdate;
    }
}

