namespace Hotel_System
{
    partial class MainForm
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
            this.panel_cover = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_guest = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_dashboard);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_room);
            this.panel1.Controls.Add(this.button_reception);
            this.panel1.Controls.Add(this.button_guest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.label_exit);
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_cover.Location = new System.Drawing.Point(253, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(940, 700);
            this.panel_cover.TabIndex = 1;
            this.panel_cover.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_logout
            // 
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_logout.Image = global::Hotel_System.Properties.Resources.logout_rounded_left_50px;
            this.button_logout.Location = new System.Drawing.Point(3, 548);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(213, 125);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_room
            // 
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_room.Image = global::Hotel_System.Properties.Resources.room1;
            this.button_room.Location = new System.Drawing.Point(3, 417);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(213, 125);
            this.button_room.TabIndex = 4;
            this.button_room.Text = "Room";
            this.button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_room.UseVisualStyleBackColor = true;
            this.button_room.Click += new System.EventHandler(this.button_room_Click);
            // 
            // button_reception
            // 
            this.button_reception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reception.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_reception.Image = global::Hotel_System.Properties.Resources.reception;
            this.button_reception.Location = new System.Drawing.Point(3, 289);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(213, 122);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Reception";
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            this.button_reception.Click += new System.EventHandler(this.button_reception_Click);
            // 
            // button_guest
            // 
            this.button_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_guest.Image = global::Hotel_System.Properties.Resources.guest2;
            this.button_guest.Location = new System.Drawing.Point(3, 157);
            this.button_guest.Name = "button_guest";
            this.button_guest.Size = new System.Drawing.Size(213, 126);
            this.button_guest.TabIndex = 2;
            this.button_guest.Text = "Guest";
            this.button_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_guest.UseVisualStyleBackColor = true;
            this.button_guest.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dashboard.Image = global::Hotel_System.Properties.Resources.home;
            this.button_dashboard.Location = new System.Drawing.Point(3, 32);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(213, 119);
            this.button_dashboard.TabIndex = 1;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_slide.Location = new System.Drawing.Point(222, 41);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(8, 100);
            this.panel_slide.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hotel Management System";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(879, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(42, 38);
            this.label_exit.TabIndex = 6;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1193, 700);
            this.panel_main.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1193, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_slide);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_guest;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
    }
}