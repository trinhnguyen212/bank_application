﻿namespace BankApplication
{
    partial class OmniForm3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnCaculateInterest = new System.Windows.Forms.Button();
            this.btnApplyInterest = new System.Windows.Forms.Button();
            this.btnCheckOverDraft = new System.Windows.Forms.Button();
            this.txtWithdrawOmni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Enter Deposit Amount: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "TRANSACTION HISTORY";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(825, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 308);
            this.listBox1.TabIndex = 34;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(23, 174);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(125, 47);
            this.btnCheckBalance.TabIndex = 33;
            this.btnCheckBalance.Text = "&Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(936, 492);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 47);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(568, 28);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(167, 22);
            this.txtAmount.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Enter Withdrawal Amount: ";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(23, 91);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(125, 47);
            this.btnWithdraw.TabIndex = 27;
            this.btnWithdraw.Text = "&Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(23, 15);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(125, 47);
            this.btnDeposit.TabIndex = 26;
            this.btnDeposit.Text = "&Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnCaculateInterest
            // 
            this.btnCaculateInterest.Location = new System.Drawing.Point(23, 244);
            this.btnCaculateInterest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaculateInterest.Name = "btnCaculateInterest";
            this.btnCaculateInterest.Size = new System.Drawing.Size(125, 47);
            this.btnCaculateInterest.TabIndex = 39;
            this.btnCaculateInterest.Text = "&Caculate Interest";
            this.btnCaculateInterest.UseVisualStyleBackColor = true;
            this.btnCaculateInterest.Click += new System.EventHandler(this.btnCaculateInterest_Click);
            // 
            // btnApplyInterest
            // 
            this.btnApplyInterest.Location = new System.Drawing.Point(23, 310);
            this.btnApplyInterest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplyInterest.Name = "btnApplyInterest";
            this.btnApplyInterest.Size = new System.Drawing.Size(125, 47);
            this.btnApplyInterest.TabIndex = 42;
            this.btnApplyInterest.Text = "&Apply Interest";
            this.btnApplyInterest.UseVisualStyleBackColor = true;
            this.btnApplyInterest.Click += new System.EventHandler(this.btnApplyInterest_Click);
            // 
            // btnCheckOverDraft
            // 
            this.btnCheckOverDraft.Location = new System.Drawing.Point(23, 369);
            this.btnCheckOverDraft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOverDraft.Name = "btnCheckOverDraft";
            this.btnCheckOverDraft.Size = new System.Drawing.Size(125, 47);
            this.btnCheckOverDraft.TabIndex = 45;
            this.btnCheckOverDraft.Text = "&Check Overdraft Limit";
            this.btnCheckOverDraft.UseVisualStyleBackColor = true;
            this.btnCheckOverDraft.Click += new System.EventHandler(this.btnCheckOverDraft_Click);
            // 
            // txtWithdrawOmni
            // 
            this.txtWithdrawOmni.Location = new System.Drawing.Point(568, 98);
            this.txtWithdrawOmni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWithdrawOmni.Name = "txtWithdrawOmni";
            this.txtWithdrawOmni.Size = new System.Drawing.Size(167, 22);
            this.txtWithdrawOmni.TabIndex = 47;
            // 
            // OmniForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtWithdrawOmni);
            this.Controls.Add(this.btnCheckOverDraft);
            this.Controls.Add(this.btnApplyInterest);
            this.Controls.Add(this.btnCaculateInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OmniForm3";
            this.Text = "OmniForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnCaculateInterest;
        private System.Windows.Forms.Button btnApplyInterest;
        private System.Windows.Forms.Button btnCheckOverDraft;
        private System.Windows.Forms.TextBox txtWithdrawOmni;
    }
}