namespace Course_work
{
    partial class loginForm
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
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.hideButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.wrongDataLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.guna2TileButton2);
            this.topPanel.Controls.Add(this.hideButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShadowDecoration.BorderRadius = 10;
            this.topPanel.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.topPanel.ShadowDecoration.Depth = 50;
            this.topPanel.ShadowDecoration.Parent = this.topPanel;
            this.topPanel.Size = new System.Drawing.Size(510, 36);
            this.topPanel.TabIndex = 4;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(169, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.AllowDrop = true;
            this.guna2TileButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton2.Animated = true;
            this.guna2TileButton2.AutoRoundedCorners = true;
            this.guna2TileButton2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2TileButton2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.guna2TileButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.guna2TileButton2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Location = new System.Drawing.Point(432, 3);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(0, 30);
            this.guna2TileButton2.TabIndex = 1;
            this.guna2TileButton2.Text = "Cтуденты";
            // 
            // hideButton
            // 
            this.hideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.CheckedState.Parent = this.hideButton;
            this.hideButton.HoverState.Image = global::Course_work.Properties.Resources.minus_active;
            this.hideButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.HoverState.Parent = this.hideButton;
            this.hideButton.Image = global::Course_work.Properties.Resources.minus__1_;
            this.hideButton.ImageRotate = 0F;
            this.hideButton.Location = new System.Drawing.Point(438, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.PressedState.Parent = this.hideButton;
            this.hideButton.Size = new System.Drawing.Size(16, 16);
            this.hideButton.TabIndex = 2;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.HoverState.Image = global::Course_work.Properties.Resources.cancel_active;
            this.closeButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Image = global::Course_work.Properties.Resources.cancel;
            this.closeButton.ImageRotate = 0F;
            this.closeButton.Location = new System.Drawing.Point(482, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.PressedState.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.TabIndex = 3;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Animated = true;
            this.loginTextBox.AutoRoundedCorners = true;
            this.loginTextBox.BorderRadius = 21;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.Parent = this.loginTextBox;
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.FocusedState.Parent = this.loginTextBox;
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.HoverState.Parent = this.loginTextBox;
            this.loginTextBox.Location = new System.Drawing.Point(79, 181);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "Логин";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.ShadowDecoration.Parent = this.loginTextBox;
            this.loginTextBox.Size = new System.Drawing.Size(330, 44);
            this.loginTextBox.TabIndex = 5;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginImage
            // 
            this.loginImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginImage.Image = global::Course_work.Properties.Resources.Gender_Neutral_User_icon_icons1;
            this.loginImage.Location = new System.Drawing.Point(188, 102);
            this.loginImage.Name = "loginImage";
            this.loginImage.ShadowDecoration.Parent = this.loginImage;
            this.loginImage.Size = new System.Drawing.Size(104, 74);
            this.loginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginImage.TabIndex = 6;
            this.loginImage.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.AutoRoundedCorners = true;
            this.passwordTextBox.BorderRadius = 21;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(79, 248);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(330, 44);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.Animated = true;
            this.loginButton.BorderRadius = 15;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(79, 324);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(330, 48);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // wrongDataLabel
            // 
            this.wrongDataLabel.AutoSize = false;
            this.wrongDataLabel.AutoSizeHeightOnly = true;
            this.wrongDataLabel.AvoidGeometryAntialias = true;
            this.wrongDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongDataLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongDataLabel.Location = new System.Drawing.Point(152, 300);
            this.wrongDataLabel.Name = "wrongDataLabel";
            this.wrongDataLabel.Size = new System.Drawing.Size(208, 17);
            this.wrongDataLabel.TabIndex = 10;
            this.wrongDataLabel.Text = "Неверный логин или пароль";
            this.wrongDataLabel.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(510, 522);
            this.Controls.Add(this.wrongDataLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton hideButton;
        private Guna.UI2.WinForms.Guna2ImageButton closeButton;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox loginImage;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel wrongDataLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}