namespace PA_1MVC
{
    partial class MainView
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
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.snooze_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.alert_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edit_button
            // 
            this.edit_button.Enabled = false;
            this.edit_button.Location = new System.Drawing.Point(56, 57);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(137, 62);
            this.edit_button.TabIndex = 0;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Enabled = false;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_button.Location = new System.Drawing.Point(236, 57);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(134, 62);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(56, 146);
            this.listbox.Name = "listbox";
            this.listbox.ScrollAlwaysVisible = true;
            this.listbox.Size = new System.Drawing.Size(314, 244);
            this.listbox.TabIndex = 2;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // snooze_button
            // 
            this.snooze_button.Enabled = false;
            this.snooze_button.Location = new System.Drawing.Point(56, 464);
            this.snooze_button.Name = "snooze_button";
            this.snooze_button.Size = new System.Drawing.Size(112, 59);
            this.snooze_button.TabIndex = 3;
            this.snooze_button.Text = "Snooze";
            this.snooze_button.UseVisualStyleBackColor = true;
            this.snooze_button.Click += new System.EventHandler(this.snooze_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(236, 464);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(123, 59);
            this.stop_button.TabIndex = 4;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // alert_label
            // 
            this.alert_label.AutoSize = true;
            this.alert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert_label.Location = new System.Drawing.Point(155, 409);
            this.alert_label.Name = "alert_label";
            this.alert_label.Size = new System.Drawing.Size(0, 25);
            this.alert_label.TabIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 562);
            this.Controls.Add(this.alert_label);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.snooze_button);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.edit_button);
            this.Name = "MainView";
            this.Text = "MainView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button snooze_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label alert_label;
    }
}

