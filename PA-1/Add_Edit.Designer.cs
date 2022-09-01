
namespace PA_1
{
    partial class Add_Edit
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.status_check = new System.Windows.Forms.CheckBox();
            this.time_input = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(44, 120);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 56);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(269, 119);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(100, 56);
            this.set_button.TabIndex = 1;
            this.set_button.Text = "Set";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // status_check
            // 
            this.status_check.AutoSize = true;
            this.status_check.Location = new System.Drawing.Point(354, 55);
            this.status_check.Name = "status_check";
            this.status_check.Size = new System.Drawing.Size(49, 21);
            this.status_check.TabIndex = 3;
            this.status_check.Text = "On";
            this.status_check.UseVisualStyleBackColor = true;
            // 
            // time_input
            // 
            this.time_input.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_input.Location = new System.Drawing.Point(44, 55);
            this.time_input.Name = "time_input";
            this.time_input.Size = new System.Drawing.Size(283, 22);
            this.time_input.TabIndex = 4;
            this.time_input.Value = new System.DateTime(2022, 8, 28, 18, 41, 0);
            
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 187);
            this.Controls.Add(this.time_input);
            this.Controls.Add(this.status_check);
            this.Controls.Add(this.set_button);
            this.Controls.Add(this.cancel_button);
            this.Name = "Add_Edit";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.CheckBox status_check;
        private System.Windows.Forms.DateTimePicker time_input;
    }
}