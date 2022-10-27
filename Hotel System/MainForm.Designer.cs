﻿namespace Hotel_System
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
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_quest = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_room);
            this.panel1.Controls.Add(this.button_reception);
            this.panel1.Controls.Add(this.button_quest);
            this.panel1.Controls.Add(this.button_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 631);
            this.panel1.TabIndex = 0;
            // 
            // button_room
            // 
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_room.Image = global::Hotel_System.Properties.Resources.room1;
            this.button_room.Location = new System.Drawing.Point(3, 417);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(279, 125);
            this.button_room.TabIndex = 4;
            this.button_room.Text = "Room";
            this.button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_room.UseVisualStyleBackColor = true;
            // 
            // button_reception
            // 
            this.button_reception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reception.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_reception.Image = global::Hotel_System.Properties.Resources.reception;
            this.button_reception.Location = new System.Drawing.Point(3, 289);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(279, 122);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Reception";
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            // 
            // button_quest
            // 
            this.button_quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_quest.Image = global::Hotel_System.Properties.Resources.guest2;
            this.button_quest.Location = new System.Drawing.Point(3, 157);
            this.button_quest.Name = "button_quest";
            this.button_quest.Size = new System.Drawing.Size(279, 126);
            this.button_quest.TabIndex = 2;
            this.button_quest.Text = "Guest";
            this.button_quest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_quest.UseVisualStyleBackColor = true;
            this.button_quest.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dashboard.Image = global::Hotel_System.Properties.Resources.home;
            this.button_dashboard.Location = new System.Drawing.Point(3, 32);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(279, 119);
            this.button_dashboard.TabIndex = 1;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_dashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(324, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel System";
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_slide.Location = new System.Drawing.Point(292, 32);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(26, 119);
            this.panel_slide.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(592, 631);
            this.Controls.Add(this.panel_slide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_quest;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_slide;
    }
}