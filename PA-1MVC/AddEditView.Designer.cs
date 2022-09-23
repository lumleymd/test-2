using System;

namespace PA_1MVC
{
    partial class AddEditView
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.on_checkbox = new System.Windows.Forms.CheckBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.snooze_amount = new System.Windows.Forms.NumericUpDown();
            this.combo_Box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.snooze_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(38, 104);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(316, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // on_checkbox
            // 
            this.on_checkbox.AutoSize = true;
            this.on_checkbox.Location = new System.Drawing.Point(377, 104);
            this.on_checkbox.Name = "on_checkbox";
            this.on_checkbox.Size = new System.Drawing.Size(46, 20);
            this.on_checkbox.TabIndex = 1;
            this.on_checkbox.Text = "On";
            this.on_checkbox.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(49, 162);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(129, 47);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(259, 162);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(140, 47);
            this.set_button.TabIndex = 3;
            this.set_button.Text = "Set";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // snooze_amount
            // 
            this.snooze_amount.Location = new System.Drawing.Point(66, 35);
            this.snooze_amount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.snooze_amount.Name = "snooze_amount";
            this.snooze_amount.Size = new System.Drawing.Size(47, 22);
            this.snooze_amount.TabIndex = 4;
            this.snooze_amount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // combo_Box
            // 
            this.combo_Box.DataSource = new PA_1MVC.Sounds[] {
        PA_1MVC.Sounds.Radar,
        PA_1MVC.Sounds.Beacon,
        PA_1MVC.Sounds.Chimes,
        PA_1MVC.Sounds.Circuit,
        PA_1MVC.Sounds.Reflection};
            this.combo_Box.FormattingEnabled = true;
          
            this.combo_Box.Location = new System.Drawing.Point(217, 35);
            this.combo_Box.Name = "combo_Box";
            this.combo_Box.Size = new System.Drawing.Size(166, 24);
            this.combo_Box.TabIndex = 5;
            // 
            // AddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 245);
            this.Controls.Add(this.combo_Box);
            this.Controls.Add(this.snooze_amount);
            this.Controls.Add(this.set_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.on_checkbox);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AddEditView";
            this.Text = "AddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.snooze_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox on_checkbox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.NumericUpDown snooze_amount;
        private System.Windows.Forms.ComboBox combo_Box;
    }
}