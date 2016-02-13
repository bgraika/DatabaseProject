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
            this.SuspendLayout();
            // 
            // state_dropDown
            // 
            this.state_dropDown.FormattingEnabled = true;
            this.state_dropDown.Location = new System.Drawing.Point(196, 99);
            this.state_dropDown.Name = "state_dropDown";
            this.state_dropDown.Size = new System.Drawing.Size(341, 39);
            this.state_dropDown.TabIndex = 0;
            this.state_dropDown.DropDown += new System.EventHandler(this.state_dropDown_DropDown);
            this.state_dropDown.SelectedIndexChanged += new System.EventHandler(this.state_dropDown_SelectedIndexChanged);
            // 
            // city_listbox
            // 
            this.city_listbox.FormattingEnabled = true;
            this.city_listbox.ItemHeight = 31;
            this.city_listbox.Location = new System.Drawing.Point(196, 167);
            this.city_listbox.Name = "city_listbox";
            this.city_listbox.Size = new System.Drawing.Size(341, 314);
            this.city_listbox.TabIndex = 1;
            this.city_listbox.SelectedIndexChanged += new System.EventHandler(this.city_listbox_SelectedIndexChanged);
            // 
            // zipcode_listbox
            // 
            this.zipcode_listbox.FormattingEnabled = true;
            this.zipcode_listbox.ItemHeight = 31;
            this.zipcode_listbox.Location = new System.Drawing.Point(196, 514);
            this.zipcode_listbox.Name = "zipcode_listbox";
            this.zipcode_listbox.Size = new System.Drawing.Size(330, 221);
            this.zipcode_listbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 1042);
            this.Controls.Add(this.zipcode_listbox);
            this.Controls.Add(this.city_listbox);
            this.Controls.Add(this.state_dropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox state_dropDown;
        private System.Windows.Forms.ListBox city_listbox;
        private System.Windows.Forms.ListBox zipcode_listbox;
    }
}

