namespace D15_EF_D02_Task.Forms
{
    partial class FoodMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.txtBreakFast = new System.Windows.Forms.TextBox();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkBreakFast = new System.Windows.Forms.CheckBox();
            this.chkLunch = new System.Windows.Forms.CheckBox();
            this.chkDinner = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chekSweetest = new System.Windows.Forms.CheckBox();
            this.chekCleaning = new System.Windows.Forms.CheckBox();
            this.chekTowels = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFoodMenuFrmNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDinner);
            this.panel1.Controls.Add(this.txtBreakFast);
            this.panel1.Controls.Add(this.txtLunch);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chkBreakFast);
            this.panel1.Controls.Add(this.chkLunch);
            this.panel1.Controls.Add(this.chkDinner);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDinner
            // 
            this.txtDinner.Location = new System.Drawing.Point(14, 394);
            this.txtDinner.Multiline = true;
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(175, 33);
            this.txtDinner.TabIndex = 12;
            // 
            // txtBreakFast
            // 
            this.txtBreakFast.Location = new System.Drawing.Point(14, 203);
            this.txtBreakFast.Multiline = true;
            this.txtBreakFast.Name = "txtBreakFast";
            this.txtBreakFast.Size = new System.Drawing.Size(175, 33);
            this.txtBreakFast.TabIndex = 11;
            // 
            // txtLunch
            // 
            this.txtLunch.Location = new System.Drawing.Point(221, 203);
            this.txtLunch.Multiline = true;
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(175, 33);
            this.txtLunch.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel_Management_System.Properties.Resources.lunch_new_png;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(221, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_Management_System.Properties.Resources.Dinner_new_png;
            this.pictureBox2.Location = new System.Drawing.Point(14, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management_System.Properties.Resources.breakfast;
            this.pictureBox1.Location = new System.Drawing.Point(14, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // chkBreakFast
            // 
            this.chkBreakFast.AutoSize = true;
            this.chkBreakFast.Location = new System.Drawing.Point(14, 182);
            this.chkBreakFast.Name = "chkBreakFast";
            this.chkBreakFast.Size = new System.Drawing.Size(127, 24);
            this.chkBreakFast.TabIndex = 2;
            this.chkBreakFast.Text = "Break Fast ($7)";
            this.chkBreakFast.UseVisualStyleBackColor = true;
            this.chkBreakFast.CheckedChanged += new System.EventHandler(this.chkBreakFast_CheckedChanged);
            // 
            // chkLunch
            // 
            this.chkLunch.AutoSize = true;
            this.chkLunch.Location = new System.Drawing.Point(221, 182);
            this.chkLunch.Name = "chkLunch";
            this.chkLunch.Size = new System.Drawing.Size(107, 24);
            this.chkLunch.TabIndex = 3;
            this.chkLunch.Text = "Lunch ($15)";
            this.chkLunch.UseVisualStyleBackColor = true;
            this.chkLunch.CheckedChanged += new System.EventHandler(this.chkLunch_CheckedChanged);
            // 
            // chekDinner
            // 
            this.chkDinner.AutoSize = true;
            this.chkDinner.Location = new System.Drawing.Point(14, 364);
            this.chkDinner.Name = "chekDinner";
            this.chkDinner.Size = new System.Drawing.Size(113, 24);
            this.chkDinner.TabIndex = 4;
            this.chkDinner.Text = "Dinner ($15)";
            this.chkDinner.UseVisualStyleBackColor = true;
            this.chkDinner.CheckedChanged += new System.EventHandler(this.chekDinner_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Selection";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chekSweetest);
            this.panel2.Controls.Add(this.chekCleaning);
            this.panel2.Controls.Add(this.chekTowels);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(452, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 362);
            this.panel2.TabIndex = 1;
            // 
            // chekSweetest
            // 
            this.chekSweetest.AutoSize = true;
            this.chekSweetest.Location = new System.Drawing.Point(32, 152);
            this.chekSweetest.Name = "chekSweetest";
            this.chekSweetest.Size = new System.Drawing.Size(147, 24);
            this.chekSweetest.TabIndex = 4;
            this.chekSweetest.Text = "Sweetest Surprise";
            this.chekSweetest.UseVisualStyleBackColor = true;
            // 
            // chekCleaning
            // 
            this.chekCleaning.AutoSize = true;
            this.chekCleaning.Location = new System.Drawing.Point(32, 59);
            this.chekCleaning.Name = "chekCleaning";
            this.chekCleaning.Size = new System.Drawing.Size(89, 24);
            this.chekCleaning.TabIndex = 2;
            this.chekCleaning.Text = "Cleaning";
            this.chekCleaning.UseVisualStyleBackColor = true;
            // 
            // chekTowels
            // 
            this.chekTowels.AutoSize = true;
            this.chekTowels.Location = new System.Drawing.Point(32, 107);
            this.chekTowels.Name = "chekTowels";
            this.chekTowels.Size = new System.Drawing.Size(76, 24);
            this.chekTowels.TabIndex = 3;
            this.chekTowels.Text = "Towels";
            this.chekTowels.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specail Needs";
            // 
            // btnFoodMenuFrmNext
            // 
            this.btnFoodMenuFrmNext.Location = new System.Drawing.Point(452, 411);
            this.btnFoodMenuFrmNext.Name = "btnFoodMenuFrmNext";
            this.btnFoodMenuFrmNext.Size = new System.Drawing.Size(210, 39);
            this.btnFoodMenuFrmNext.TabIndex = 5;
            this.btnFoodMenuFrmNext.Text = "Next";
            this.btnFoodMenuFrmNext.UseVisualStyleBackColor = true;
            this.btnFoodMenuFrmNext.Click += new System.EventHandler(this.btnFoodMenuFrmNext_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 462);
            this.Controls.Add(this.btnFoodMenuFrmNext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FoodMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodMenu";
            this.Load += new System.EventHandler(this.FoodMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public CheckBox chkBreakFast;
        public CheckBox chkLunch;
        public CheckBox chkDinner;
        private Label label1;
        private Panel panel2;
        private Label label2;
        public TextBox txtDinner;
        public TextBox txtBreakFast;
        public TextBox txtLunch;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        public CheckBox chekSweetest;
        public CheckBox chekCleaning;
        public CheckBox chekTowels;
        public Button btnFoodMenuFrmNext;
    }
}