namespace ProgramRequestResponseKlient
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxNotifications = new System.Windows.Forms.GroupBox();
            this.pickDate = new System.Windows.Forms.CheckBox();
            this.pickTime = new System.Windows.Forms.CheckBox();
            this.pick5second = new System.Windows.Forms.CheckBox();
            this.pick10second = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pickEvery = new System.Windows.Forms.CheckBox();
            this.textSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receiveButton = new System.Windows.Forms.Button();
            this.windowLogs = new System.Windows.Forms.ListBox();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxNotifications.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.BackColor = System.Drawing.Color.Silver;
            this.groupBoxSettings.Controls.Add(this.receiveButton);
            this.groupBoxSettings.Controls.Add(this.groupBox3);
            this.groupBoxSettings.Controls.Add(this.pick10second);
            this.groupBoxSettings.Controls.Add(this.pick5second);
            this.groupBoxSettings.Controls.Add(this.pickTime);
            this.groupBoxSettings.Controls.Add(this.pickDate);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(554, 137);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Ustawienia";
            // 
            // groupBoxNotifications
            // 
            this.groupBoxNotifications.BackColor = System.Drawing.Color.Tan;
            this.groupBoxNotifications.Controls.Add(this.windowLogs);
            this.groupBoxNotifications.Location = new System.Drawing.Point(12, 155);
            this.groupBoxNotifications.Name = "groupBoxNotifications";
            this.groupBoxNotifications.Size = new System.Drawing.Size(554, 251);
            this.groupBoxNotifications.TabIndex = 1;
            this.groupBoxNotifications.TabStop = false;
            this.groupBoxNotifications.Text = "Powiadomienia";
            // 
            // pickDate
            // 
            this.pickDate.AutoSize = true;
            this.pickDate.Location = new System.Drawing.Point(6, 29);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(85, 17);
            this.pickDate.TabIndex = 0;
            this.pickDate.Text = "Pobierz datę";
            this.pickDate.UseVisualStyleBackColor = true;
            // 
            // pickTime
            // 
            this.pickTime.AutoSize = true;
            this.pickTime.Location = new System.Drawing.Point(6, 61);
            this.pickTime.Name = "pickTime";
            this.pickTime.Size = new System.Drawing.Size(86, 17);
            this.pickTime.TabIndex = 1;
            this.pickTime.Text = "Pobierz czas";
            this.pickTime.UseVisualStyleBackColor = true;
            // 
            // pick5second
            // 
            this.pick5second.AutoSize = true;
            this.pick5second.Location = new System.Drawing.Point(183, 29);
            this.pick5second.Name = "pick5second";
            this.pick5second.Size = new System.Drawing.Size(126, 17);
            this.pick5second.TabIndex = 2;
            this.pick5second.Text = "Pobieraj co 5 sekund";
            this.pick5second.UseVisualStyleBackColor = true;
            this.pick5second.CheckedChanged += new System.EventHandler(this.pick5second_CheckedChanged);
            // 
            // pick10second
            // 
            this.pick10second.AutoSize = true;
            this.pick10second.Location = new System.Drawing.Point(183, 61);
            this.pick10second.Name = "pick10second";
            this.pick10second.Size = new System.Drawing.Size(132, 17);
            this.pick10second.TabIndex = 3;
            this.pick10second.Text = "Pobieraj co 10 sekund";
            this.pick10second.UseVisualStyleBackColor = true;
            this.pick10second.CheckedChanged += new System.EventHandler(this.pick10second_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textSecond);
            this.groupBox3.Controls.Add(this.pickEvery);
            this.groupBox3.Location = new System.Drawing.Point(341, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ustawienie niestandardowe";
            // 
            // pickEvery
            // 
            this.pickEvery.AutoSize = true;
            this.pickEvery.Location = new System.Drawing.Point(7, 32);
            this.pickEvery.Name = "pickEvery";
            this.pickEvery.Size = new System.Drawing.Size(79, 17);
            this.pickEvery.TabIndex = 0;
            this.pickEvery.Text = "Pobieraj co";
            this.pickEvery.UseVisualStyleBackColor = true;
            this.pickEvery.CheckedChanged += new System.EventHandler(this.pickEvery_CheckedChanged);
            // 
            // textSecond
            // 
            this.textSecond.Location = new System.Drawing.Point(83, 30);
            this.textSecond.Name = "textSecond";
            this.textSecond.Size = new System.Drawing.Size(39, 20);
            this.textSecond.TabIndex = 1;
            this.textSecond.TextChanged += new System.EventHandler(this.textSecond_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "sekund";
            // 
            // receiveButton
            // 
            this.receiveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.receiveButton.Location = new System.Drawing.Point(6, 94);
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(116, 23);
            this.receiveButton.TabIndex = 5;
            this.receiveButton.Text = "Pobierz jednorazowo";
            this.receiveButton.UseVisualStyleBackColor = false;
            this.receiveButton.Click += new System.EventHandler(this.receiveButton_Click);
            // 
            // windowLogs
            // 
            this.windowLogs.BackColor = System.Drawing.Color.Tan;
            this.windowLogs.FormattingEnabled = true;
            this.windowLogs.Location = new System.Drawing.Point(6, 19);
            this.windowLogs.Name = "windowLogs";
            this.windowLogs.Size = new System.Drawing.Size(542, 225);
            this.windowLogs.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 418);
            this.Controls.Add(this.groupBoxNotifications);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxNotifications.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxNotifications;
        private System.Windows.Forms.Button receiveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSecond;
        private System.Windows.Forms.CheckBox pickEvery;
        private System.Windows.Forms.CheckBox pick10second;
        private System.Windows.Forms.CheckBox pick5second;
        private System.Windows.Forms.CheckBox pickTime;
        private System.Windows.Forms.CheckBox pickDate;
        private System.Windows.Forms.ListBox windowLogs;
    }
}

