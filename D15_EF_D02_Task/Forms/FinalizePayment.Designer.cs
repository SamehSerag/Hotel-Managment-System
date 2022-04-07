namespace D15_EF_D02_Task.Forms
{
    partial class FinalizePayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentBill = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoodBill = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lablCardType = new System.Windows.Forms.Label();
            this.combPayment = new System.Windows.Forms.ComboBox();
            this.txtPaymentNumber = new System.Windows.Forms.TextBox();
            this.combMM = new System.Windows.Forms.ComboBox();
            this.CombYY = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFinalizeNext = new System.Windows.Forms.Button();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Bill";
            // 
            // txtCurrentBill
            // 
            this.txtCurrentBill.AutoSize = true;
            this.txtCurrentBill.Location = new System.Drawing.Point(476, 51);
            this.txtCurrentBill.Name = "txtCurrentBill";
            this.txtCurrentBill.Size = new System.Drawing.Size(17, 20);
            this.txtCurrentBill.TabIndex = 3;
            this.txtCurrentBill.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Food Bill";
            // 
            // txtFoodBill
            // 
            this.txtFoodBill.AutoSize = true;
            this.txtFoodBill.Location = new System.Drawing.Point(466, 88);
            this.txtFoodBill.Name = "txtFoodBill";
            this.txtFoodBill.Size = new System.Drawing.Size(17, 20);
            this.txtFoodBill.TabIndex = 5;
            this.txtFoodBill.Text = "$";
            // 
            // txtTax
            // 
            this.txtTax.AutoSize = true;
            this.txtTax.Location = new System.Drawing.Point(447, 126);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(17, 20);
            this.txtTax.TabIndex = 6;
            this.txtTax.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(348, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(432, 157);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(17, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Payment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Card Type:";
            // 
            // lablCardType
            // 
            this.lablCardType.AutoSize = true;
            this.lablCardType.Location = new System.Drawing.Point(439, 275);
            this.lablCardType.Name = "lablCardType";
            this.lablCardType.Size = new System.Drawing.Size(70, 20);
            this.lablCardType.TabIndex = 12;
            this.lablCardType.Text = "Unknown";
            // 
            // combPayment
            // 
            this.combPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPayment.FormattingEnabled = true;
            this.combPayment.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.combPayment.Location = new System.Drawing.Point(12, 219);
            this.combPayment.Name = "combPayment";
            this.combPayment.Size = new System.Drawing.Size(151, 28);
            this.combPayment.TabIndex = 13;
            // 
            // txtPaymentNumber
            // 
            this.txtPaymentNumber.Location = new System.Drawing.Point(211, 219);
            this.txtPaymentNumber.Name = "txtPaymentNumber";
            this.txtPaymentNumber.Size = new System.Drawing.Size(344, 27);
            this.txtPaymentNumber.TabIndex = 14;
            this.txtPaymentNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // combMM
            // 
            this.combMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMM.FormattingEnabled = true;
            this.combMM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.combMM.Location = new System.Drawing.Point(12, 271);
            this.combMM.Name = "combMM";
            this.combMM.Size = new System.Drawing.Size(83, 28);
            this.combMM.TabIndex = 15;
            this.combMM.SelectedIndexChanged += new System.EventHandler(this.combMM_SelectedIndexChanged);
            // 
            // CombYY
            // 
            this.CombYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombYY.FormattingEnabled = true;
            this.CombYY.Items.AddRange(new object[] {
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.CombYY.Location = new System.Drawing.Point(135, 271);
            this.CombYY.Name = "CombYY";
            this.CombYY.Size = new System.Drawing.Size(83, 28);
            this.CombYY.TabIndex = 16;
            this.CombYY.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(101, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 38);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            // 
            // btnFinalizeNext
            // 
            this.btnFinalizeNext.Location = new System.Drawing.Point(476, 313);
            this.btnFinalizeNext.Name = "btnFinalizeNext";
            this.btnFinalizeNext.Size = new System.Drawing.Size(94, 29);
            this.btnFinalizeNext.TabIndex = 19;
            this.btnFinalizeNext.Text = "Next";
            this.btnFinalizeNext.UseVisualStyleBackColor = true;
            this.btnFinalizeNext.Click += new System.EventHandler(this.btnFinalizeNext_Click);
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(238, 271);
            this.txtCVC.Multiline = true;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(85, 28);
            this.txtCVC.TabIndex = 20;
            // 
            // FinalizePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(588, 354);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.btnFinalizeNext);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CombYY);
            this.Controls.Add(this.combMM);
            this.Controls.Add(this.txtPaymentNumber);
            this.Controls.Add(this.combPayment);
            this.Controls.Add(this.lablCardType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtFoodBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurrentBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinalizePayment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FinalizePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label txtCurrentBill;
        public Label label5;
        public Label txtFoodBill;
        public Label txtTax;
        public Label label8;
        public Label label9;
        public Label txtTotal;
        public Label label11;
        public Label label12;
        public Label lablCardType;
        public ComboBox combPayment;
        public TextBox txtPaymentNumber;
        public ComboBox combMM;
        public ComboBox CombYY;
        public Label label14;
        public Button btnFinalizeNext;
        public TextBox txtCVC;
    }
}