namespace YelpDatabaseProject
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
            this.state_dropDown = new System.Windows.Forms.ComboBox();
            this.city_listbox = new System.Windows.Forms.ListBox();
            this.zipcode_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.population_listbox = new System.Windows.Forms.ListBox();
            this.avg_income_listbox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.median_age_listbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // state_dropDown
            // 
            this.state_dropDown.FormattingEnabled = true;
            this.state_dropDown.Location = new System.Drawing.Point(196, 168);
            this.state_dropDown.Name = "state_dropDown";
            this.state_dropDown.Size = new System.Drawing.Size(432, 39);
            this.state_dropDown.TabIndex = 0;
            this.state_dropDown.DropDown += new System.EventHandler(this.state_dropDown_DropDown);
            this.state_dropDown.SelectedIndexChanged += new System.EventHandler(this.state_dropDown_SelectedIndexChanged);
            // 
            // city_listbox
            // 
            this.city_listbox.FormattingEnabled = true;
            this.city_listbox.ItemHeight = 31;
            this.city_listbox.Location = new System.Drawing.Point(196, 236);
            this.city_listbox.Name = "city_listbox";
            this.city_listbox.Size = new System.Drawing.Size(432, 345);
            this.city_listbox.TabIndex = 1;
            this.city_listbox.SelectedIndexChanged += new System.EventHandler(this.city_listbox_SelectedIndexChanged);
            // 
            // zipcode_listbox
            // 
            this.zipcode_listbox.FormattingEnabled = true;
            this.zipcode_listbox.ItemHeight = 31;
            this.zipcode_listbox.Location = new System.Drawing.Point(196, 610);
            this.zipcode_listbox.Name = "zipcode_listbox";
            this.zipcode_listbox.Size = new System.Drawing.Size(432, 252);
            this.zipcode_listbox.TabIndex = 2;
            this.zipcode_listbox.SelectedIndexChanged += new System.EventHandler(this.zipcode_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(69, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(69, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(46, 704);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zipcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(272, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Location";
            // 
            // population_listbox
            // 
            this.population_listbox.FormattingEnabled = true;
            this.population_listbox.ItemHeight = 31;
            this.population_listbox.Location = new System.Drawing.Point(1029, 175);
            this.population_listbox.Name = "population_listbox";
            this.population_listbox.Size = new System.Drawing.Size(376, 66);
            this.population_listbox.TabIndex = 7;
            // 
            // avg_income_listbox
            // 
            this.avg_income_listbox.FormattingEnabled = true;
            this.avg_income_listbox.ItemHeight = 31;
            this.avg_income_listbox.Location = new System.Drawing.Point(1029, 300);
            this.avg_income_listbox.Name = "avg_income_listbox";
            this.avg_income_listbox.Size = new System.Drawing.Size(375, 66);
            this.avg_income_listbox.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1024, 450);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 226);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // median_age_listbox
            // 
            this.median_age_listbox.FormattingEnabled = true;
            this.median_age_listbox.ItemHeight = 31;
            this.median_age_listbox.Location = new System.Drawing.Point(1024, 793);
            this.median_age_listbox.Name = "median_age_listbox";
            this.median_age_listbox.Size = new System.Drawing.Size(378, 66);
            this.median_age_listbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(851, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Population";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1295);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.median_age_listbox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.avg_income_listbox);
            this.Controls.Add(this.population_listbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipcode_listbox);
            this.Controls.Add(this.city_listbox);
            this.Controls.Add(this.state_dropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox state_dropDown;
        private System.Windows.Forms.ListBox city_listbox;
        private System.Windows.Forms.ListBox zipcode_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox population_listbox;
        private System.Windows.Forms.ListBox avg_income_listbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox median_age_listbox;
        private System.Windows.Forms.Label label5;
    }
}

