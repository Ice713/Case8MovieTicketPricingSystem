namespace Case8MovieTicketPricingSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Movie";
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.Location = new System.Drawing.Point(38, 67);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(132, 95);
            this.listBoxMovies.TabIndex = 1;
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiscount.Location = new System.Drawing.Point(38, 199);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(111, 17);
            this.checkBoxDiscount.TabIndex = 2;
            this.checkBoxDiscount.Text = "Apply Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(38, 222);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(132, 30);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate Ticket Price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discount:";
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.DecimalPlaces = 2;
            this.numericUpDownDiscount.Location = new System.Drawing.Point(97, 168);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownDiscount.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Case8MovieTicketPricingSystem.Properties.Resources.Ticket;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.labelFinalPrice);
            this.panel1.Controls.Add(this.labelDiscount);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelMovie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(466, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 387);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Movie Ticket";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.labelMovie.Location = new System.Drawing.Point(21, 86);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(42, 13);
            this.labelMovie.TabIndex = 7;
            this.labelMovie.Text = "Movie: ";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.labelPrice.Location = new System.Drawing.Point(20, 112);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(72, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Original Price:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.labelDiscount.Location = new System.Drawing.Point(21, 137);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(52, 13);
            this.labelDiscount.TabIndex = 9;
            this.labelDiscount.Text = "Discount:";
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.labelFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPrice.Location = new System.Drawing.Point(21, 172);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(71, 13);
            this.labelFinalPrice.TabIndex = 10;
            this.labelFinalPrice.Text = "Final Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.checkBoxDiscount);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Movie Ticket Pricing System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label label3;
    }
}

