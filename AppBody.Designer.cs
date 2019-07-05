namespace dbms_mini_pro
{
    partial class AppBody
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
            this.log_in_timer = new System.Windows.Forms.Timer(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_Button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_in_timer
            // 
            this.log_in_timer.Interval = 50;
            this.log_in_timer.Tick += new System.EventHandler(this.log_in_timer_Tick);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.TitleBar.Controls.Add(this.button2);
            this.TitleBar.Controls.Add(this.button1);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(884, 35);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_Paint);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(786, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(740, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(832, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(388, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin_Button
            // 
            this.Admin_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Admin_Button.Location = new System.Drawing.Point(3, 3);
            this.Admin_Button.Name = "Admin_Button";
            this.Admin_Button.Size = new System.Drawing.Size(197, 71);
            this.Admin_Button.TabIndex = 2;
            this.Admin_Button.Text = "ADMIN ";
            this.Admin_Button.UseVisualStyleBackColor = true;
            this.Admin_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(3, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "TENANT ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(3, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = " OWNER";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(203, 87);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(681, 458);
            this.ContentPanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.Admin_Button);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 512);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 547);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TitleBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer log_in_timer;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Admin_Button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}