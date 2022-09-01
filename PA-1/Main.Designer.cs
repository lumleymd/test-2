
namespace PA_1
{
    partial class Main
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
            this.status_label = new System.Windows.Forms.Label();
            this.snooze_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.alarm_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // edit_button
            // 
            this.edit_button.Enabled = false;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.edit_button.Location = new System.Drawing.Point(40, 32);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(125, 63);
            this.edit_button.TabIndex = 0;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.add_button.Location = new System.Drawing.Point(189, 32);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(125, 63);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.status_label.Location = new System.Drawing.Point(60, 461);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 31);
            this.status_label.TabIndex = 3;
            // 
            // snooze_button
            // 
            this.snooze_button.Enabled = false;
            this.snooze_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.snooze_button.Location = new System.Drawing.Point(40, 496);
            this.snooze_button.Name = "snooze_button";
            this.snooze_button.Size = new System.Drawing.Size(125, 63);
            this.snooze_button.TabIndex = 4;
            this.snooze_button.Text = "Snooze";
            this.snooze_button.UseVisualStyleBackColor = true;
            this.snooze_button.Click += new System.EventHandler(this.snooze_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stop_button.Location = new System.Drawing.Point(189, 496);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(125, 63);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // alarm_list
            // 
            this.alarm_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.alarm_list.FormattingEnabled = true;
            this.alarm_list.ItemHeight = 29;
            this.alarm_list.Location = new System.Drawing.Point(40, 118);
            this.alarm_list.Name = "alarm_list";
            this.alarm_list.Size = new System.Drawing.Size(274, 323);
            this.alarm_list.TabIndex = 6;
            this.alarm_list.SelectedIndexChanged += new System.EventHandler(this.alarm_list_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 584);
            this.Controls.Add(this.alarm_list);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.snooze_button);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.edit_button);
            this.Name = "Main";
            this.Text = "Alarm501";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button snooze_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.ListBox alarm_list;
    }
}

