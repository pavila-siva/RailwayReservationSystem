﻿namespace RailwayReservationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            Welcome = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            UnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            PassTb = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.LightSeaGreen;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-123, -3);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(251, 506);
            guna2CircleButton1.TabIndex = 0;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.DimGray;
            Welcome.Location = new Point(221, 20);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(123, 27);
            Welcome.TabIndex = 1;
            Welcome.Text = "Welcome";
            Welcome.Click += Welcome_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.White;
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DodgerBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.RoyalBlue;
            guna2Button1.HoverState.ForeColor = Color.LightGray;
            guna2Button1.Location = new Point(261, 187);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.MediumBlue;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button1.ShadowDecoration.Depth = 10;
            guna2Button1.ShadowDecoration.Enabled = true;
            guna2Button1.Size = new Size(156, 39);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "login";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(134, 87);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(134, 136);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 4;
            label2.Text = "Phone";
            // 
            // UnameTb
            // 
            UnameTb.BackColor = SystemColors.Window;
            UnameTb.BorderColor = Color.FromArgb(204, 204, 204);
            UnameTb.BorderRadius = 10;
            UnameTb.CustomizableEdges = customizableEdges4;
            UnameTb.DefaultText = "";
            UnameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UnameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UnameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UnameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UnameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UnameTb.Font = new Font("Segoe UI", 9F);
            UnameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UnameTb.Location = new Point(261, 85);
            UnameTb.Margin = new Padding(3, 4, 3, 4);
            UnameTb.Name = "UnameTb";
            UnameTb.PasswordChar = '\0';
            UnameTb.PlaceholderText = "Enter Username";
            UnameTb.SelectedText = "";
            UnameTb.ShadowDecoration.CustomizableEdges = customizableEdges5;
            UnameTb.Size = new Size(196, 27);
            UnameTb.TabIndex = 5;
            // 
            // PassTb
            // 
            PassTb.BackColor = SystemColors.Window;
            PassTb.BorderColor = Color.FromArgb(204, 204, 204);
            PassTb.BorderRadius = 10;
            PassTb.CustomizableEdges = customizableEdges6;
            PassTb.DefaultText = "";
            PassTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PassTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PassTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PassTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PassTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PassTb.Font = new Font("Segoe UI", 9F);
            PassTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PassTb.Location = new Point(261, 134);
            PassTb.Margin = new Padding(3, 4, 3, 4);
            PassTb.Name = "PassTb";
            PassTb.PasswordChar = '\0';
            PassTb.PlaceholderText = "Enter Phone Number";
            PassTb.SelectedText = "";
            PassTb.ShadowDecoration.CustomizableEdges = customizableEdges7;
            PassTb.Size = new Size(196, 27);
            PassTb.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(431, 12);
            label3.Name = "label3";
            label3.Size = new Size(26, 27);
            label3.TabIndex = 9;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(470, 254);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(PassTb);
            Controls.Add(UnameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(Welcome);
            Controls.Add(guna2CircleButton1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label Welcome;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox UnameTb;
        private Guna.UI2.WinForms.Guna2TextBox PassTb;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
