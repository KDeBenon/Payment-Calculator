namespace Assignment3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculatePayment = new System.Windows.Forms.Button();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtFixedInterestRate = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtNumberOfPayments = new System.Windows.Forms.TextBox();
            this.txtPaymentTotal = new System.Windows.Forms.TextBox();
            this.txtInterestPaid = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fixed Interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Years:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Payment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number Of Payments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interest Paid:";
            // 
            // btnCalculatePayment
            // 
            this.btnCalculatePayment.Location = new System.Drawing.Point(214, 164);
            this.btnCalculatePayment.Name = "btnCalculatePayment";
            this.btnCalculatePayment.Size = new System.Drawing.Size(228, 51);
            this.btnCalculatePayment.TabIndex = 3;
            this.btnCalculatePayment.Text = "Calculate Payment";
            this.btnCalculatePayment.UseVisualStyleBackColor = true;
            this.btnCalculatePayment.Click += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cmbYears.Location = new System.Drawing.Point(319, 120);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(121, 24);
            this.cmbYears.TabIndex = 2;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(319, 28);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(121, 22);
            this.txtLoanAmount.TabIndex = 0;
            this.txtLoanAmount.Text = "1000.00";
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoanAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanAmount_Validating);
            // 
            // txtFixedInterestRate
            // 
            this.txtFixedInterestRate.Location = new System.Drawing.Point(319, 69);
            this.txtFixedInterestRate.Name = "txtFixedInterestRate";
            this.txtFixedInterestRate.Size = new System.Drawing.Size(121, 22);
            this.txtFixedInterestRate.TabIndex = 1;
            this.txtFixedInterestRate.Text = "5.00";
            this.txtFixedInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFixedInterestRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtFixedInterestRate_Validating);
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(319, 237);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(121, 22);
            this.txtMonthlyPayment.TabIndex = 11;
            this.txtMonthlyPayment.TabStop = false;
            this.txtMonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberOfPayments
            // 
            this.txtNumberOfPayments.Location = new System.Drawing.Point(319, 283);
            this.txtNumberOfPayments.Name = "txtNumberOfPayments";
            this.txtNumberOfPayments.ReadOnly = true;
            this.txtNumberOfPayments.Size = new System.Drawing.Size(121, 22);
            this.txtNumberOfPayments.TabIndex = 12;
            this.txtNumberOfPayments.TabStop = false;
            this.txtNumberOfPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.Location = new System.Drawing.Point(319, 332);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.ReadOnly = true;
            this.txtPaymentTotal.Size = new System.Drawing.Size(121, 22);
            this.txtPaymentTotal.TabIndex = 13;
            this.txtPaymentTotal.TabStop = false;
            this.txtPaymentTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterestPaid
            // 
            this.txtInterestPaid.Location = new System.Drawing.Point(319, 376);
            this.txtInterestPaid.Name = "txtInterestPaid";
            this.txtInterestPaid.ReadOnly = true;
            this.txtInterestPaid.Size = new System.Drawing.Size(121, 22);
            this.txtInterestPaid.TabIndex = 14;
            this.txtInterestPaid.TabStop = false;
            this.txtInterestPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInterestPaid);
            this.Controls.Add(this.txtPaymentTotal);
            this.Controls.Add(this.txtNumberOfPayments);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtFixedInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.btnCalculatePayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculatePayment;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtFixedInterestRate;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox txtNumberOfPayments;
        private System.Windows.Forms.TextBox txtPaymentTotal;
        private System.Windows.Forms.TextBox txtInterestPaid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

