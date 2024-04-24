﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class InvestmentForm2 : Form
    {
        InvestmentAccounts investmentAccounts;
        Customer customer;
        public InvestmentForm2(Customer customer, InvestmentAccounts investmentAccounts)
        {
            InitializeComponent();
            this.investmentAccounts = investmentAccounts;
            this.customer = customer;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                double Amount = double.Parse(txtAmount.Text);
                investmentAccounts.Deposit(Amount);
                listBox1.Items.Add($"Deposit: {Amount}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            txtAmount.Clear();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double Amount = double.Parse(txtWithdrawAmount.Text);
                investmentAccounts.Withdraw(Amount);
                listBox1.Items.Add($"Withdraw: {Amount}");
                txtWithdrawAmount.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            txtWithdrawAmount.Clear();
            double x = investmentAccounts.CaculateTransFee(customer);
            if (x != 0)
            {
                listBox1.Items.Add($"transaction fee: {x}");
                listBox1.Items.Add($"Update balance: {investmentAccounts.Balance} - {x} = {investmentAccounts.Balance -= x}");
                investmentAccounts.failedTransFee = 0;
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Current Balance: {investmentAccounts.Balance}");
        }


        private void btnCaculateInterest_Click(object sender, EventArgs e)
        {
            double x = investmentAccounts.CaCulatedInterest();
            listBox1.Items.Add($"Caculated Interest: {x}");
        }

        private void btnApplyInterest_Click(object sender, EventArgs e)
        {
            try
            {
                investmentAccounts.ApplyInterest();
                listBox1.Items.Add($"Added Interest Balance: {investmentAccounts.Balance}");
                investmentAccounts.Caculatedinterest = 0;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


    }
}

