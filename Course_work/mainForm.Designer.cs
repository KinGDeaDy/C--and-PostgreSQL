using Npgsql;
namespace Course_work
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPannel = new Guna.UI2.WinForms.Guna2Panel();
            this.hideButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.queriesButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.marksButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.d_pButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.subjectsButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.LectorsButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.groupsButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.studentsButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tablePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.marksPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.studentField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lectorField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.subjectField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.marksField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.absentCountField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.subjectsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.subjectHoursField = new Guna.UI2.WinForms.Guna2TextBox();
            this.subjectNameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cypherField = new Guna.UI2.WinForms.Guna2TextBox();
            this.lectorsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tMiddleNameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.tSurnameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.tNameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.editingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.groupField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ticketNumberField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.STmiddleNameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.STsurnameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.STnameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.d_pPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.d_pLectorField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.d_PSubjectField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.queryPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.checkGrantsButton = new Guna.UI2.WinForms.Guna2Button();
            this.sortOrderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sortOrderLabel = new System.Windows.Forms.Label();
            this.sortOrderBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.vectorButton = new Guna.UI2.WinForms.Guna2Button();
            this.secondTaskLabel = new System.Windows.Forms.Label();
            this.secondTaskField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.transactionButton = new Guna.UI2.WinForms.Guna2Button();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.addGrantButton = new Guna.UI2.WinForms.Guna2Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TopPannel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.marksPanel.SuspendLayout();
            this.subjectsPanel.SuspendLayout();
            this.groupsPanel.SuspendLayout();
            this.lectorsPanel.SuspendLayout();
            this.editingPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.d_pPanel.SuspendLayout();
            this.queryPanel.SuspendLayout();
            this.sortOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPannel
            // 
            this.TopPannel.Controls.Add(this.hideButton);
            this.TopPannel.Controls.Add(this.closeButton);
            this.guna2Transition1.SetDecoration(this.TopPannel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.ShadowDecoration.Parent = this.TopPannel;
            this.TopPannel.Size = new System.Drawing.Size(1379, 50);
            this.TopPannel.TabIndex = 2;
            this.TopPannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPannel_MouseDown);
            // 
            // hideButton
            // 
            this.hideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.CheckedState.Parent = this.hideButton;
            this.guna2Transition1.SetDecoration(this.hideButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.hideButton.HoverState.Image = global::Course_work.Properties.Resources.minus_active;
            this.hideButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.HoverState.Parent = this.hideButton;
            this.hideButton.Image = global::Course_work.Properties.Resources.minus__1_;
            this.hideButton.ImageRotate = 0F;
            this.hideButton.Location = new System.Drawing.Point(1319, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hideButton.PressedState.Parent = this.hideButton;
            this.hideButton.Size = new System.Drawing.Size(16, 16);
            this.hideButton.TabIndex = 1;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.guna2Transition1.SetDecoration(this.closeButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.closeButton.HoverState.Image = global::Course_work.Properties.Resources.cancel_active;
            this.closeButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Image = global::Course_work.Properties.Resources.cancel;
            this.closeButton.ImageRotate = 0F;
            this.closeButton.Location = new System.Drawing.Point(1351, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.PressedState.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.TabIndex = 0;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.buttonsPanel.Controls.Add(this.queriesButton);
            this.buttonsPanel.Controls.Add(this.marksButton);
            this.buttonsPanel.Controls.Add(this.d_pButton);
            this.buttonsPanel.Controls.Add(this.subjectsButton);
            this.buttonsPanel.Controls.Add(this.LectorsButton);
            this.buttonsPanel.Controls.Add(this.groupsButton);
            this.buttonsPanel.Controls.Add(this.studentsButton);
            this.guna2Transition1.SetDecoration(this.buttonsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 50);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.ShadowDecoration.BorderRadius = 10;
            this.buttonsPanel.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.buttonsPanel.ShadowDecoration.Depth = 50;
            this.buttonsPanel.ShadowDecoration.Parent = this.buttonsPanel;
            this.buttonsPanel.Size = new System.Drawing.Size(1379, 50);
            this.buttonsPanel.TabIndex = 3;
            // 
            // queriesButton
            // 
            this.queriesButton.AllowDrop = true;
            this.queriesButton.Animated = true;
            this.queriesButton.AutoRoundedCorners = true;
            this.queriesButton.BorderRadius = 24;
            this.queriesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.queriesButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.queriesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.queriesButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.queriesButton.CheckedState.Parent = this.queriesButton;
            this.queriesButton.CustomBorderColor = System.Drawing.Color.Black;
            this.queriesButton.CustomImages.Parent = this.queriesButton;
            this.guna2Transition1.SetDecoration(this.queriesButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.queriesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.queriesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.queriesButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queriesButton.ForeColor = System.Drawing.Color.White;
            this.queriesButton.HoverState.Parent = this.queriesButton;
            this.queriesButton.Location = new System.Drawing.Point(1182, 0);
            this.queriesButton.Name = "queriesButton";
            this.queriesButton.ShadowDecoration.Parent = this.queriesButton;
            this.queriesButton.Size = new System.Drawing.Size(197, 50);
            this.queriesButton.TabIndex = 7;
            this.queriesButton.Text = "Запросы";
            this.queriesButton.Click += new System.EventHandler(this.queriesButton_Click);
            // 
            // marksButton
            // 
            this.marksButton.AllowDrop = true;
            this.marksButton.Animated = true;
            this.marksButton.AutoRoundedCorners = true;
            this.marksButton.BorderRadius = 24;
            this.marksButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.marksButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.marksButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.marksButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.marksButton.CheckedState.Parent = this.marksButton;
            this.marksButton.CustomBorderColor = System.Drawing.Color.Black;
            this.marksButton.CustomImages.Parent = this.marksButton;
            this.guna2Transition1.SetDecoration(this.marksButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.marksButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.marksButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.marksButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.marksButton.ForeColor = System.Drawing.Color.White;
            this.marksButton.HoverState.Parent = this.marksButton;
            this.marksButton.Location = new System.Drawing.Point(985, 0);
            this.marksButton.Name = "marksButton";
            this.marksButton.ShadowDecoration.Parent = this.marksButton;
            this.marksButton.Size = new System.Drawing.Size(197, 50);
            this.marksButton.TabIndex = 5;
            this.marksButton.Text = "Успеваемость";
            this.marksButton.Click += new System.EventHandler(this.marksButton_Click);
            // 
            // d_pButton
            // 
            this.d_pButton.AllowDrop = true;
            this.d_pButton.Animated = true;
            this.d_pButton.AutoRoundedCorners = true;
            this.d_pButton.BorderRadius = 24;
            this.d_pButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.d_pButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.d_pButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.d_pButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.d_pButton.CheckedState.Parent = this.d_pButton;
            this.d_pButton.CustomBorderColor = System.Drawing.Color.Black;
            this.d_pButton.CustomImages.Parent = this.d_pButton;
            this.guna2Transition1.SetDecoration(this.d_pButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.d_pButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.d_pButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.d_pButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_pButton.ForeColor = System.Drawing.Color.White;
            this.d_pButton.HoverState.Parent = this.d_pButton;
            this.d_pButton.Location = new System.Drawing.Point(788, 0);
            this.d_pButton.Name = "d_pButton";
            this.d_pButton.ShadowDecoration.Parent = this.d_pButton;
            this.d_pButton.Size = new System.Drawing.Size(197, 50);
            this.d_pButton.TabIndex = 6;
            this.d_pButton.Text = "Дисциплины Преподаватели";
            this.d_pButton.TextFormatNoPrefix = true;
            this.d_pButton.Click += new System.EventHandler(this.d_pButton_Click);
            // 
            // subjectsButton
            // 
            this.subjectsButton.AllowDrop = true;
            this.subjectsButton.Animated = true;
            this.subjectsButton.AutoRoundedCorners = true;
            this.subjectsButton.BorderRadius = 24;
            this.subjectsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.subjectsButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.subjectsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.subjectsButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.subjectsButton.CheckedState.Parent = this.subjectsButton;
            this.subjectsButton.CustomBorderColor = System.Drawing.Color.Black;
            this.subjectsButton.CustomImages.Parent = this.subjectsButton;
            this.guna2Transition1.SetDecoration(this.subjectsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subjectsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.subjectsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.subjectsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subjectsButton.ForeColor = System.Drawing.Color.White;
            this.subjectsButton.HoverState.Parent = this.subjectsButton;
            this.subjectsButton.Location = new System.Drawing.Point(591, 0);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.ShadowDecoration.Parent = this.subjectsButton;
            this.subjectsButton.Size = new System.Drawing.Size(197, 50);
            this.subjectsButton.TabIndex = 2;
            this.subjectsButton.Text = "Дисциплины";
            this.subjectsButton.Click += new System.EventHandler(this.subjectsButton_Click);
            // 
            // LectorsButton
            // 
            this.LectorsButton.AllowDrop = true;
            this.LectorsButton.Animated = true;
            this.LectorsButton.AutoRoundedCorners = true;
            this.LectorsButton.BorderRadius = 24;
            this.LectorsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LectorsButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.LectorsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.LectorsButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.LectorsButton.CheckedState.Parent = this.LectorsButton;
            this.LectorsButton.CustomBorderColor = System.Drawing.Color.Black;
            this.LectorsButton.CustomImages.Parent = this.LectorsButton;
            this.guna2Transition1.SetDecoration(this.LectorsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LectorsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LectorsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.LectorsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LectorsButton.ForeColor = System.Drawing.Color.White;
            this.LectorsButton.HoverState.Parent = this.LectorsButton;
            this.LectorsButton.Location = new System.Drawing.Point(394, 0);
            this.LectorsButton.Name = "LectorsButton";
            this.LectorsButton.ShadowDecoration.Parent = this.LectorsButton;
            this.LectorsButton.Size = new System.Drawing.Size(197, 50);
            this.LectorsButton.TabIndex = 1;
            this.LectorsButton.Text = "Преподаватели";
            this.LectorsButton.Click += new System.EventHandler(this.LectorsButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.AllowDrop = true;
            this.groupsButton.Animated = true;
            this.groupsButton.AutoRoundedCorners = true;
            this.groupsButton.BorderRadius = 24;
            this.groupsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.groupsButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.groupsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.groupsButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.groupsButton.CheckedState.Parent = this.groupsButton;
            this.groupsButton.CustomBorderColor = System.Drawing.Color.Black;
            this.groupsButton.CustomImages.Parent = this.groupsButton;
            this.guna2Transition1.SetDecoration(this.groupsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.groupsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupsButton.ForeColor = System.Drawing.Color.White;
            this.groupsButton.HoverState.Parent = this.groupsButton;
            this.groupsButton.Location = new System.Drawing.Point(197, 0);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.ShadowDecoration.Parent = this.groupsButton;
            this.groupsButton.Size = new System.Drawing.Size(197, 50);
            this.groupsButton.TabIndex = 8;
            this.groupsButton.Text = "Группы";
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.AllowDrop = true;
            this.studentsButton.Animated = true;
            this.studentsButton.AutoRoundedCorners = true;
            this.studentsButton.BorderRadius = 24;
            this.studentsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.studentsButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.studentsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.studentsButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.studentsButton.CheckedState.Parent = this.studentsButton;
            this.studentsButton.CustomBorderColor = System.Drawing.Color.Black;
            this.studentsButton.CustomImages.Parent = this.studentsButton;
            this.guna2Transition1.SetDecoration(this.studentsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.studentsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentsButton.ForeColor = System.Drawing.Color.White;
            this.studentsButton.HoverState.Parent = this.studentsButton;
            this.studentsButton.Location = new System.Drawing.Point(0, 0);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.ShadowDecoration.Parent = this.studentsButton;
            this.studentsButton.Size = new System.Drawing.Size(197, 50);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "Cтуденты";
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation4;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2Transition1.SetDecoration(this.table, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle12;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.EnableHeadersVisualStyles = false;
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.table.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(975, 645);
            this.table.TabIndex = 1;
            this.table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table.ThemeStyle.HeaderStyle.Height = 23;
            this.table.ThemeStyle.ReadOnly = false;
            this.table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.table.ThemeStyle.RowsStyle.Height = 24;
            this.table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // tablePanel
            // 
            this.tablePanel.AutoSize = true;
            this.tablePanel.Controls.Add(this.table);
            this.guna2Transition1.SetDecoration(this.tablePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tablePanel.Location = new System.Drawing.Point(0, 109);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.ShadowDecoration.Parent = this.tablePanel;
            this.tablePanel.Size = new System.Drawing.Size(975, 645);
            this.tablePanel.TabIndex = 4;
            // 
            // marksPanel
            // 
            this.marksPanel.Controls.Add(this.studentField);
            this.marksPanel.Controls.Add(this.lectorField);
            this.marksPanel.Controls.Add(this.subjectField);
            this.marksPanel.Controls.Add(this.label16);
            this.marksPanel.Controls.Add(this.marksField);
            this.marksPanel.Controls.Add(this.label15);
            this.marksPanel.Controls.Add(this.absentCountField);
            this.marksPanel.Controls.Add(this.label14);
            this.marksPanel.Controls.Add(this.label13);
            this.marksPanel.Controls.Add(this.label9);
            this.guna2Transition1.SetDecoration(this.marksPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.marksPanel.Location = new System.Drawing.Point(981, 274);
            this.marksPanel.Name = "marksPanel";
            this.marksPanel.ShadowDecoration.Parent = this.marksPanel;
            this.marksPanel.Size = new System.Drawing.Size(386, 480);
            this.marksPanel.TabIndex = 13;
            this.marksPanel.Visible = false;
            // 
            // studentField
            // 
            this.studentField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.studentField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.studentField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentField.FocusedState.Parent = this.studentField;
            this.studentField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.studentField.HoverState.Parent = this.studentField;
            this.studentField.ItemHeight = 30;
            this.studentField.ItemsAppearance.Parent = this.studentField;
            this.studentField.Location = new System.Drawing.Point(15, 214);
            this.studentField.Name = "studentField";
            this.studentField.ShadowDecoration.Parent = this.studentField;
            this.studentField.Size = new System.Drawing.Size(361, 36);
            this.studentField.TabIndex = 22;
            this.studentField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentField_MouseClick);
            // 
            // lectorField
            // 
            this.lectorField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lectorField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lectorField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lectorField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lectorField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lectorField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lectorField.FocusedState.Parent = this.lectorField;
            this.lectorField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lectorField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.lectorField.HoverState.Parent = this.lectorField;
            this.lectorField.ItemHeight = 30;
            this.lectorField.ItemsAppearance.Parent = this.lectorField;
            this.lectorField.Location = new System.Drawing.Point(15, 360);
            this.lectorField.Name = "lectorField";
            this.lectorField.ShadowDecoration.Parent = this.lectorField;
            this.lectorField.Size = new System.Drawing.Size(361, 36);
            this.lectorField.TabIndex = 21;
            this.lectorField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lectorField_MouseClick);
            // 
            // subjectField
            // 
            this.subjectField.Animated = true;
            this.subjectField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.subjectField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subjectField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subjectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subjectField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subjectField.FocusedState.Parent = this.subjectField;
            this.subjectField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subjectField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.subjectField.HoverState.Parent = this.subjectField;
            this.subjectField.ItemHeight = 30;
            this.subjectField.ItemsAppearance.Parent = this.subjectField;
            this.subjectField.Location = new System.Drawing.Point(15, 286);
            this.subjectField.Name = "subjectField";
            this.subjectField.ShadowDecoration.Parent = this.subjectField;
            this.subjectField.Size = new System.Drawing.Size(361, 36);
            this.subjectField.TabIndex = 20;
            this.subjectField.SelectedIndexChanged += new System.EventHandler(this.subjectField_SelectedIndexChanged);
            this.subjectField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subjectField_MouseClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(11, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Преподаватель";
            // 
            // marksField
            // 
            this.marksField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.marksField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.marksField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.marksField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marksField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.marksField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.marksField.FocusedState.Parent = this.marksField;
            this.marksField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.marksField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.marksField.HoverState.Parent = this.marksField;
            this.marksField.ItemHeight = 30;
            this.marksField.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.marksField.ItemsAppearance.Parent = this.marksField;
            this.marksField.Location = new System.Drawing.Point(15, 71);
            this.marksField.Name = "marksField";
            this.marksField.ShadowDecoration.Parent = this.marksField;
            this.marksField.Size = new System.Drawing.Size(361, 36);
            this.marksField.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Количество пропусков";
            // 
            // absentCountField
            // 
            this.absentCountField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.absentCountField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.absentCountField.DefaultText = "";
            this.absentCountField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.absentCountField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.absentCountField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.absentCountField.DisabledState.Parent = this.absentCountField;
            this.absentCountField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.absentCountField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.absentCountField.FocusedState.Parent = this.absentCountField;
            this.absentCountField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.absentCountField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.absentCountField.HoverState.Parent = this.absentCountField;
            this.absentCountField.Location = new System.Drawing.Point(15, 142);
            this.absentCountField.MaxLength = 3;
            this.absentCountField.Name = "absentCountField";
            this.absentCountField.PasswordChar = '\0';
            this.absentCountField.PlaceholderText = "";
            this.absentCountField.SelectedText = "";
            this.absentCountField.ShadowDecoration.Parent = this.absentCountField;
            this.absentCountField.Size = new System.Drawing.Size(361, 36);
            this.absentCountField.TabIndex = 15;
            this.absentCountField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.absentCountField_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Дисциплина";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(11, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Cтудент";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Оценка";
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.label10);
            this.subjectsPanel.Controls.Add(this.label11);
            this.subjectsPanel.Controls.Add(this.subjectHoursField);
            this.subjectsPanel.Controls.Add(this.subjectNameField);
            this.guna2Transition1.SetDecoration(this.subjectsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subjectsPanel.Location = new System.Drawing.Point(981, 274);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.ShadowDecoration.Parent = this.subjectsPanel;
            this.subjectsPanel.Size = new System.Drawing.Size(386, 480);
            this.subjectsPanel.TabIndex = 11;
            this.subjectsPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Количество часов";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Название";
            // 
            // subjectHoursField
            // 
            this.subjectHoursField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.subjectHoursField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subjectHoursField.DefaultText = "";
            this.subjectHoursField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subjectHoursField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subjectHoursField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subjectHoursField.DisabledState.Parent = this.subjectHoursField;
            this.subjectHoursField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subjectHoursField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subjectHoursField.FocusedState.Parent = this.subjectHoursField;
            this.subjectHoursField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subjectHoursField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subjectHoursField.HoverState.Parent = this.subjectHoursField;
            this.subjectHoursField.Location = new System.Drawing.Point(11, 251);
            this.subjectHoursField.Name = "subjectHoursField";
            this.subjectHoursField.PasswordChar = '\0';
            this.subjectHoursField.PlaceholderText = "";
            this.subjectHoursField.SelectedText = "";
            this.subjectHoursField.ShadowDecoration.Parent = this.subjectHoursField;
            this.subjectHoursField.Size = new System.Drawing.Size(361, 36);
            this.subjectHoursField.TabIndex = 2;
            // 
            // subjectNameField
            // 
            this.subjectNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.subjectNameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subjectNameField.DefaultText = "";
            this.subjectNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subjectNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subjectNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subjectNameField.DisabledState.Parent = this.subjectNameField;
            this.subjectNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subjectNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subjectNameField.FocusedState.Parent = this.subjectNameField;
            this.subjectNameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subjectNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subjectNameField.HoverState.Parent = this.subjectNameField;
            this.subjectNameField.Location = new System.Drawing.Point(11, 180);
            this.subjectNameField.Name = "subjectNameField";
            this.subjectNameField.PasswordChar = '\0';
            this.subjectNameField.PlaceholderText = "";
            this.subjectNameField.SelectedText = "";
            this.subjectNameField.ShadowDecoration.Parent = this.subjectNameField;
            this.subjectNameField.Size = new System.Drawing.Size(361, 36);
            this.subjectNameField.TabIndex = 1;
            // 
            // groupsPanel
            // 
            this.groupsPanel.Controls.Add(this.label12);
            this.groupsPanel.Controls.Add(this.cypherField);
            this.guna2Transition1.SetDecoration(this.groupsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupsPanel.Location = new System.Drawing.Point(981, 274);
            this.groupsPanel.Name = "groupsPanel";
            this.groupsPanel.ShadowDecoration.Parent = this.groupsPanel;
            this.groupsPanel.Size = new System.Drawing.Size(386, 480);
            this.groupsPanel.TabIndex = 12;
            this.groupsPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Шифр";
            // 
            // cypherField
            // 
            this.cypherField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.cypherField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cypherField.DefaultText = "";
            this.cypherField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cypherField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cypherField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cypherField.DisabledState.Parent = this.cypherField;
            this.cypherField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cypherField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cypherField.FocusedState.Parent = this.cypherField;
            this.cypherField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cypherField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cypherField.HoverState.Parent = this.cypherField;
            this.cypherField.Location = new System.Drawing.Point(10, 221);
            this.cypherField.Name = "cypherField";
            this.cypherField.PasswordChar = '\0';
            this.cypherField.PlaceholderText = "";
            this.cypherField.SelectedText = "";
            this.cypherField.ShadowDecoration.Parent = this.cypherField;
            this.cypherField.Size = new System.Drawing.Size(361, 36);
            this.cypherField.TabIndex = 1;
            // 
            // lectorsPanel
            // 
            this.lectorsPanel.Controls.Add(this.label8);
            this.lectorsPanel.Controls.Add(this.label7);
            this.lectorsPanel.Controls.Add(this.label6);
            this.lectorsPanel.Controls.Add(this.tMiddleNameField);
            this.lectorsPanel.Controls.Add(this.tSurnameField);
            this.lectorsPanel.Controls.Add(this.tNameField);
            this.guna2Transition1.SetDecoration(this.lectorsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lectorsPanel.Location = new System.Drawing.Point(981, 274);
            this.lectorsPanel.Name = "lectorsPanel";
            this.lectorsPanel.ShadowDecoration.Parent = this.lectorsPanel;
            this.lectorsPanel.Size = new System.Drawing.Size(386, 480);
            this.lectorsPanel.TabIndex = 10;
            this.lectorsPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя";
            // 
            // tMiddleNameField
            // 
            this.tMiddleNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tMiddleNameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tMiddleNameField.DefaultText = "";
            this.tMiddleNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tMiddleNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tMiddleNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tMiddleNameField.DisabledState.Parent = this.tMiddleNameField;
            this.tMiddleNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tMiddleNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tMiddleNameField.FocusedState.Parent = this.tMiddleNameField;
            this.tMiddleNameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tMiddleNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tMiddleNameField.HoverState.Parent = this.tMiddleNameField;
            this.tMiddleNameField.Location = new System.Drawing.Point(13, 268);
            this.tMiddleNameField.Name = "tMiddleNameField";
            this.tMiddleNameField.PasswordChar = '\0';
            this.tMiddleNameField.PlaceholderText = "";
            this.tMiddleNameField.SelectedText = "";
            this.tMiddleNameField.ShadowDecoration.Parent = this.tMiddleNameField;
            this.tMiddleNameField.Size = new System.Drawing.Size(361, 36);
            this.tMiddleNameField.TabIndex = 3;
            // 
            // tSurnameField
            // 
            this.tSurnameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tSurnameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tSurnameField.DefaultText = "";
            this.tSurnameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tSurnameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tSurnameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tSurnameField.DisabledState.Parent = this.tSurnameField;
            this.tSurnameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tSurnameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tSurnameField.FocusedState.Parent = this.tSurnameField;
            this.tSurnameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tSurnameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tSurnameField.HoverState.Parent = this.tSurnameField;
            this.tSurnameField.Location = new System.Drawing.Point(13, 204);
            this.tSurnameField.Name = "tSurnameField";
            this.tSurnameField.PasswordChar = '\0';
            this.tSurnameField.PlaceholderText = "";
            this.tSurnameField.SelectedText = "";
            this.tSurnameField.ShadowDecoration.Parent = this.tSurnameField;
            this.tSurnameField.Size = new System.Drawing.Size(361, 36);
            this.tSurnameField.TabIndex = 2;
            // 
            // tNameField
            // 
            this.tNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tNameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tNameField.DefaultText = "";
            this.tNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tNameField.DisabledState.Parent = this.tNameField;
            this.tNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tNameField.FocusedState.Parent = this.tNameField;
            this.tNameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tNameField.HoverState.Parent = this.tNameField;
            this.tNameField.Location = new System.Drawing.Point(13, 133);
            this.tNameField.Name = "tNameField";
            this.tNameField.PasswordChar = '\0';
            this.tNameField.PlaceholderText = "";
            this.tNameField.SelectedText = "";
            this.tNameField.ShadowDecoration.Parent = this.tNameField;
            this.tNameField.Size = new System.Drawing.Size(361, 36);
            this.tNameField.TabIndex = 1;
            // 
            // editingPanel
            // 
            this.editingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editingPanel.Controls.Add(this.deleteButton);
            this.editingPanel.Controls.Add(this.updateButton);
            this.editingPanel.Controls.Add(this.addButton);
            this.guna2Transition1.SetDecoration(this.editingPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.editingPanel.Location = new System.Drawing.Point(981, 108);
            this.editingPanel.Name = "editingPanel";
            this.editingPanel.ShadowDecoration.Parent = this.editingPanel;
            this.editingPanel.Size = new System.Drawing.Size(386, 160);
            this.editingPanel.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.guna2Transition1.SetDecoration(this.deleteButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(10, 108);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(361, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.CheckedState.Parent = this.updateButton;
            this.updateButton.CustomImages.Parent = this.updateButton;
            this.guna2Transition1.SetDecoration(this.updateButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.Parent = this.updateButton;
            this.updateButton.Location = new System.Drawing.Point(9, 62);
            this.updateButton.Margin = new System.Windows.Forms.Padding(20);
            this.updateButton.Name = "updateButton";
            this.updateButton.ShadowDecoration.Parent = this.updateButton;
            this.updateButton.Size = new System.Drawing.Size(362, 35);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Изменить";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.guna2Transition1.SetDecoration(this.addButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(9, 14);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(361, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // studentsPanel
            // 
            this.studentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsPanel.Controls.Add(this.groupField);
            this.studentsPanel.Controls.Add(this.ticketNumberField);
            this.studentsPanel.Controls.Add(this.label5);
            this.studentsPanel.Controls.Add(this.label4);
            this.studentsPanel.Controls.Add(this.label3);
            this.studentsPanel.Controls.Add(this.label2);
            this.studentsPanel.Controls.Add(this.label1);
            this.studentsPanel.Controls.Add(this.STmiddleNameField);
            this.studentsPanel.Controls.Add(this.STsurnameField);
            this.studentsPanel.Controls.Add(this.STnameField);
            this.guna2Transition1.SetDecoration(this.studentsPanel, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
            this.studentsPanel.Location = new System.Drawing.Point(981, 275);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.ShadowDecoration.Parent = this.studentsPanel;
            this.studentsPanel.Size = new System.Drawing.Size(386, 479);
            this.studentsPanel.TabIndex = 6;
            this.studentsPanel.Visible = false;
            // 
            // groupField
            // 
            this.groupField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.groupField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.groupField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupField.FocusedState.Parent = this.groupField;
            this.groupField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.groupField.HoverState.Parent = this.groupField;
            this.groupField.ItemHeight = 30;
            this.groupField.ItemsAppearance.Parent = this.groupField;
            this.groupField.Location = new System.Drawing.Point(10, 327);
            this.groupField.Name = "groupField";
            this.groupField.ShadowDecoration.Parent = this.groupField;
            this.groupField.Size = new System.Drawing.Size(361, 36);
            this.groupField.TabIndex = 9;
            this.groupField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.groupField_MouseClick);
            // 
            // ticketNumberField
            // 
            this.ticketNumberField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.ticketNumberField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ticketNumberField.DefaultText = "";
            this.ticketNumberField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ticketNumberField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ticketNumberField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ticketNumberField.DisabledState.Parent = this.ticketNumberField;
            this.ticketNumberField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ticketNumberField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ticketNumberField.FocusedState.Parent = this.ticketNumberField;
            this.ticketNumberField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ticketNumberField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ticketNumberField.HoverState.Parent = this.ticketNumberField;
            this.ticketNumberField.Location = new System.Drawing.Point(10, 255);
            this.ticketNumberField.Name = "ticketNumberField";
            this.ticketNumberField.PasswordChar = '\0';
            this.ticketNumberField.PlaceholderText = "";
            this.ticketNumberField.SelectedText = "";
            this.ticketNumberField.ShadowDecoration.Parent = this.ticketNumberField;
            this.ticketNumberField.Size = new System.Drawing.Size(361, 36);
            this.ticketNumberField.TabIndex = 8;
            this.ticketNumberField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ticketNumberField_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // STmiddleNameField
            // 
            this.STmiddleNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.STmiddleNameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.STmiddleNameField.DefaultText = "";
            this.STmiddleNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STmiddleNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STmiddleNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STmiddleNameField.DisabledState.Parent = this.STmiddleNameField;
            this.STmiddleNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STmiddleNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STmiddleNameField.FocusedState.Parent = this.STmiddleNameField;
            this.STmiddleNameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STmiddleNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STmiddleNameField.HoverState.Parent = this.STmiddleNameField;
            this.STmiddleNameField.Location = new System.Drawing.Point(10, 175);
            this.STmiddleNameField.Name = "STmiddleNameField";
            this.STmiddleNameField.PasswordChar = '\0';
            this.STmiddleNameField.PlaceholderText = "";
            this.STmiddleNameField.SelectedText = "";
            this.STmiddleNameField.ShadowDecoration.Parent = this.STmiddleNameField;
            this.STmiddleNameField.Size = new System.Drawing.Size(361, 36);
            this.STmiddleNameField.TabIndex = 2;
            // 
            // STsurnameField
            // 
            this.STsurnameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.STsurnameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.STsurnameField.DefaultText = "";
            this.STsurnameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STsurnameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STsurnameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STsurnameField.DisabledState.Parent = this.STsurnameField;
            this.STsurnameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STsurnameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STsurnameField.FocusedState.Parent = this.STsurnameField;
            this.STsurnameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STsurnameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STsurnameField.HoverState.Parent = this.STsurnameField;
            this.STsurnameField.Location = new System.Drawing.Point(10, 104);
            this.STsurnameField.Name = "STsurnameField";
            this.STsurnameField.PasswordChar = '\0';
            this.STsurnameField.PlaceholderText = "";
            this.STsurnameField.SelectedText = "";
            this.STsurnameField.ShadowDecoration.Parent = this.STsurnameField;
            this.STsurnameField.Size = new System.Drawing.Size(361, 36);
            this.STsurnameField.TabIndex = 1;
            // 
            // STnameField
            // 
            this.STnameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.STnameField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.STnameField.DefaultText = "";
            this.STnameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STnameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STnameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STnameField.DisabledState.Parent = this.STnameField;
            this.STnameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STnameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STnameField.FocusedState.Parent = this.STnameField;
            this.STnameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STnameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STnameField.HoverState.Parent = this.STnameField;
            this.STnameField.Location = new System.Drawing.Point(10, 40);
            this.STnameField.Name = "STnameField";
            this.STnameField.PasswordChar = '\0';
            this.STnameField.PlaceholderText = "";
            this.STnameField.SelectedText = "";
            this.STnameField.ShadowDecoration.Parent = this.STnameField;
            this.STnameField.Size = new System.Drawing.Size(361, 36);
            this.STnameField.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Transition1.SetDecoration(this.flowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // d_pPanel
            // 
            this.d_pPanel.Controls.Add(this.d_pLectorField);
            this.d_pPanel.Controls.Add(this.d_PSubjectField);
            this.d_pPanel.Controls.Add(this.label20);
            this.d_pPanel.Controls.Add(this.label21);
            this.guna2Transition1.SetDecoration(this.d_pPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.d_pPanel.Location = new System.Drawing.Point(981, 274);
            this.d_pPanel.Name = "d_pPanel";
            this.d_pPanel.ShadowDecoration.Parent = this.d_pPanel;
            this.d_pPanel.Size = new System.Drawing.Size(386, 480);
            this.d_pPanel.TabIndex = 23;
            this.d_pPanel.Visible = false;
            // 
            // d_pLectorField
            // 
            this.d_pLectorField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.d_pLectorField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.d_pLectorField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.d_pLectorField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_pLectorField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.d_pLectorField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.d_pLectorField.FocusedState.Parent = this.d_pLectorField;
            this.d_pLectorField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.d_pLectorField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.d_pLectorField.HoverState.Parent = this.d_pLectorField;
            this.d_pLectorField.ItemHeight = 30;
            this.d_pLectorField.ItemsAppearance.Parent = this.d_pLectorField;
            this.d_pLectorField.Location = new System.Drawing.Point(15, 251);
            this.d_pLectorField.Name = "d_pLectorField";
            this.d_pLectorField.ShadowDecoration.Parent = this.d_pLectorField;
            this.d_pLectorField.Size = new System.Drawing.Size(361, 36);
            this.d_pLectorField.TabIndex = 22;
            this.d_pLectorField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.d_pLectorField_MouseClick);
            // 
            // d_PSubjectField
            // 
            this.d_PSubjectField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.d_PSubjectField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.d_PSubjectField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.d_PSubjectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_PSubjectField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.d_PSubjectField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.d_PSubjectField.FocusedState.Parent = this.d_PSubjectField;
            this.d_PSubjectField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.d_PSubjectField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.d_PSubjectField.HoverState.Parent = this.d_PSubjectField;
            this.d_PSubjectField.ItemHeight = 30;
            this.d_PSubjectField.ItemsAppearance.Parent = this.d_PSubjectField;
            this.d_PSubjectField.Location = new System.Drawing.Point(15, 182);
            this.d_PSubjectField.Name = "d_PSubjectField";
            this.d_PSubjectField.ShadowDecoration.Parent = this.d_PSubjectField;
            this.d_PSubjectField.Size = new System.Drawing.Size(361, 36);
            this.d_PSubjectField.TabIndex = 17;
            this.d_PSubjectField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.d_PSubjectField_MouseClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(11, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 20);
            this.label20.TabIndex = 12;
            this.label20.Text = "Преподаватель";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(11, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 20);
            this.label21.TabIndex = 10;
            this.label21.Text = "Дисциплина";
            // 
            // queryPanel
            // 
            this.queryPanel.Controls.Add(this.label17);
            this.queryPanel.Controls.Add(this.addGrantButton);
            this.queryPanel.Controls.Add(this.checkGrantsButton);
            this.queryPanel.Controls.Add(this.sortOrderPanel);
            this.queryPanel.Controls.Add(this.vectorButton);
            this.queryPanel.Controls.Add(this.secondTaskLabel);
            this.queryPanel.Controls.Add(this.secondTaskField);
            this.queryPanel.Controls.Add(this.transactionButton);
            this.queryPanel.Controls.Add(this.descriptionTextBox);
            this.guna2Transition1.SetDecoration(this.queryPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.queryPanel.Location = new System.Drawing.Point(981, 108);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.ShadowDecoration.Parent = this.queryPanel;
            this.queryPanel.Size = new System.Drawing.Size(386, 650);
            this.queryPanel.TabIndex = 2;
            this.queryPanel.Visible = false;
            // 
            // checkGrantsButton
            // 
            this.checkGrantsButton.CheckedState.Parent = this.checkGrantsButton;
            this.checkGrantsButton.CustomImages.Parent = this.checkGrantsButton;
            this.guna2Transition1.SetDecoration(this.checkGrantsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.checkGrantsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkGrantsButton.ForeColor = System.Drawing.Color.White;
            this.checkGrantsButton.HoverState.Parent = this.checkGrantsButton;
            this.checkGrantsButton.Location = new System.Drawing.Point(11, 199);
            this.checkGrantsButton.Name = "checkGrantsButton";
            this.checkGrantsButton.ShadowDecoration.Parent = this.checkGrantsButton;
            this.checkGrantsButton.Size = new System.Drawing.Size(361, 35);
            this.checkGrantsButton.TabIndex = 8;
            this.checkGrantsButton.Text = "Посмотреть баланс";
            this.checkGrantsButton.TextFormatNoPrefix = true;
            this.checkGrantsButton.Click += new System.EventHandler(this.checkGrantsButton_Click);
            // 
            // sortOrderPanel
            // 
            this.sortOrderPanel.Controls.Add(this.sortOrderLabel);
            this.sortOrderPanel.Controls.Add(this.sortOrderBox);
            this.guna2Transition1.SetDecoration(this.sortOrderPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sortOrderPanel.Location = new System.Drawing.Point(9, 303);
            this.sortOrderPanel.Name = "sortOrderPanel";
            this.sortOrderPanel.ShadowDecoration.Parent = this.sortOrderPanel;
            this.sortOrderPanel.Size = new System.Drawing.Size(367, 100);
            this.sortOrderPanel.TabIndex = 7;
            this.sortOrderPanel.Visible = false;
            // 
            // sortOrderLabel
            // 
            this.sortOrderLabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.sortOrderLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sortOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sortOrderLabel.ForeColor = System.Drawing.Color.White;
            this.sortOrderLabel.Location = new System.Drawing.Point(-1, 0);
            this.sortOrderLabel.Name = "sortOrderLabel";
            this.sortOrderLabel.Size = new System.Drawing.Size(92, 18);
            this.sortOrderLabel.TabIndex = 6;
            this.sortOrderLabel.Text = "Cортировка";
            // 
            // sortOrderBox
            // 
            this.sortOrderBox.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.sortOrderBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sortOrderBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortOrderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sortOrderBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sortOrderBox.FocusedState.Parent = this.sortOrderBox;
            this.sortOrderBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sortOrderBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.sortOrderBox.HoverState.Parent = this.sortOrderBox;
            this.sortOrderBox.ItemHeight = 30;
            this.sortOrderBox.Items.AddRange(new object[] {
            "По имени",
            "По фамилии",
            "По отчеству",
            "По номеру билета",
            "По номеру группы"});
            this.sortOrderBox.ItemsAppearance.Parent = this.sortOrderBox;
            this.sortOrderBox.Location = new System.Drawing.Point(0, 21);
            this.sortOrderBox.Name = "sortOrderBox";
            this.sortOrderBox.ShadowDecoration.Parent = this.sortOrderBox;
            this.sortOrderBox.Size = new System.Drawing.Size(367, 36);
            this.sortOrderBox.TabIndex = 5;
            this.sortOrderBox.SelectedIndexChanged += new System.EventHandler(this.sortOrderBox_SelectedIndexChanged);
            // 
            // vectorButton
            // 
            this.vectorButton.CheckedState.Parent = this.vectorButton;
            this.vectorButton.CustomImages.Parent = this.vectorButton;
            this.guna2Transition1.SetDecoration(this.vectorButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.vectorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vectorButton.ForeColor = System.Drawing.Color.White;
            this.vectorButton.HoverState.Parent = this.vectorButton;
            this.vectorButton.Location = new System.Drawing.Point(11, 129);
            this.vectorButton.Name = "vectorButton";
            this.vectorButton.ShadowDecoration.Parent = this.vectorButton;
            this.vectorButton.Size = new System.Drawing.Size(361, 35);
            this.vectorButton.TabIndex = 4;
            this.vectorButton.Text = "Процедура с векторной функцией";
            this.vectorButton.TextFormatNoPrefix = true;
            this.vectorButton.Click += new System.EventHandler(this.vectorButton_Click);
            // 
            // secondTaskLabel
            // 
            this.secondTaskLabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.secondTaskLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.secondTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.secondTaskLabel.ForeColor = System.Drawing.Color.White;
            this.secondTaskLabel.Location = new System.Drawing.Point(10, -2);
            this.secondTaskLabel.Name = "secondTaskLabel";
            this.secondTaskLabel.Size = new System.Drawing.Size(79, 18);
            this.secondTaskLabel.TabIndex = 3;
            this.secondTaskLabel.Text = "Задание 2";
            // 
            // secondTaskField
            // 
            this.secondTaskField.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.secondTaskField, Guna.UI2.AnimatorNS.DecorationType.None);
            this.secondTaskField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.secondTaskField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondTaskField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondTaskField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondTaskField.FocusedState.Parent = this.secondTaskField;
            this.secondTaskField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.secondTaskField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.secondTaskField.HoverState.Parent = this.secondTaskField;
            this.secondTaskField.ItemHeight = 30;
            this.secondTaskField.Items.AddRange(new object[] {
            "2a",
            "2b",
            "коррелированный select",
            "коррелированный from",
            "коррелированный where",
            "некоррелированный select",
            "некоррелированный from",
            "некоррелированный where",
            "2d",
            "2e"});
            this.secondTaskField.ItemsAppearance.Parent = this.secondTaskField;
            this.secondTaskField.Location = new System.Drawing.Point(11, 19);
            this.secondTaskField.Name = "secondTaskField";
            this.secondTaskField.ShadowDecoration.Parent = this.secondTaskField;
            this.secondTaskField.Size = new System.Drawing.Size(361, 36);
            this.secondTaskField.TabIndex = 2;
            this.secondTaskField.SelectedIndexChanged += new System.EventHandler(this.secondTaskField_SelectedIndexChanged);
            // 
            // transactionButton
            // 
            this.transactionButton.CheckedState.Parent = this.transactionButton;
            this.transactionButton.CustomImages.Parent = this.transactionButton;
            this.guna2Transition1.SetDecoration(this.transactionButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.transactionButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transactionButton.ForeColor = System.Drawing.Color.White;
            this.transactionButton.HoverState.Parent = this.transactionButton;
            this.transactionButton.Location = new System.Drawing.Point(11, 78);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.ShadowDecoration.Parent = this.transactionButton;
            this.transactionButton.Size = new System.Drawing.Size(361, 35);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "Транзакция";
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.descriptionTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.Parent = this.descriptionTextBox;
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.descriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.FocusedState.Parent = this.descriptionTextBox;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.HoverState.Parent = this.descriptionTextBox;
            this.descriptionTextBox.Location = new System.Drawing.Point(9, 423);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.PlaceholderText = "";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.ShadowDecoration.Parent = this.descriptionTextBox;
            this.descriptionTextBox.Size = new System.Drawing.Size(367, 219);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // addGrantButton
            // 
            this.addGrantButton.CheckedState.Parent = this.addGrantButton;
            this.addGrantButton.CustomImages.Parent = this.addGrantButton;
            this.guna2Transition1.SetDecoration(this.addGrantButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addGrantButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addGrantButton.ForeColor = System.Drawing.Color.White;
            this.addGrantButton.HoverState.Parent = this.addGrantButton;
            this.addGrantButton.Location = new System.Drawing.Point(11, 249);
            this.addGrantButton.Name = "addGrantButton";
            this.addGrantButton.ShadowDecoration.Parent = this.addGrantButton;
            this.addGrantButton.Size = new System.Drawing.Size(361, 35);
            this.addGrantButton.TabIndex = 9;
            this.addGrantButton.Text = "Пополнить баланс";
            this.addGrantButton.Click += new System.EventHandler(this.addGrantButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(10, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 18);
            this.label17.TabIndex = 10;
            this.label17.Text = "Стипендиальный фонд";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1379, 805);
            this.Controls.Add(this.queryPanel);
            this.Controls.Add(this.editingPanel);
            this.Controls.Add(this.marksPanel);
            this.Controls.Add(this.subjectsPanel);
            this.Controls.Add(this.lectorsPanel);
            this.Controls.Add(this.studentsPanel);
            this.Controls.Add(this.d_pPanel);
            this.Controls.Add(this.groupsPanel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.TopPannel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPannel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.marksPanel.ResumeLayout(false);
            this.marksPanel.PerformLayout();
            this.subjectsPanel.ResumeLayout(false);
            this.subjectsPanel.PerformLayout();
            this.groupsPanel.ResumeLayout(false);
            this.groupsPanel.PerformLayout();
            this.lectorsPanel.ResumeLayout(false);
            this.lectorsPanel.PerformLayout();
            this.editingPanel.ResumeLayout(false);
            this.studentsPanel.ResumeLayout(false);
            this.studentsPanel.PerformLayout();
            this.d_pPanel.ResumeLayout(false);
            this.d_pPanel.PerformLayout();
            this.queryPanel.ResumeLayout(false);
            this.queryPanel.PerformLayout();
            this.sortOrderPanel.ResumeLayout(false);
            this.sortOrderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel TopPannel;
        private Guna.UI2.WinForms.Guna2ImageButton closeButton;
        private Guna.UI2.WinForms.Guna2Panel buttonsPanel;
        private Guna.UI2.WinForms.Guna2ImageButton hideButton;
        private Guna.UI2.WinForms.Guna2TileButton studentsButton;
        private Guna.UI2.WinForms.Guna2TileButton subjectsButton;
        private Guna.UI2.WinForms.Guna2TileButton LectorsButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel tablePanel;
        private Guna.UI2.WinForms.Guna2DataGridView table;
        private Guna.UI2.WinForms.Guna2TileButton d_pButton;
        private Guna.UI2.WinForms.Guna2TileButton marksButton;
        private Guna.UI2.WinForms.Guna2TileButton queriesButton;
        private Guna.UI2.WinForms.Guna2Panel editingPanel;
        private Guna.UI2.WinForms.Guna2Panel studentsPanel;
        private Guna.UI2.WinForms.Guna2TextBox STmiddleNameField;
        private Guna.UI2.WinForms.Guna2TextBox STsurnameField;
        private Guna.UI2.WinForms.Guna2TextBox STnameField;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox groupField;
        private Guna.UI2.WinForms.Guna2TextBox ticketNumberField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel lectorsPanel;
        private Guna.UI2.WinForms.Guna2TextBox tMiddleNameField;
        private Guna.UI2.WinForms.Guna2TextBox tSurnameField;
        private Guna.UI2.WinForms.Guna2TextBox tNameField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel subjectsPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox subjectHoursField;
        private Guna.UI2.WinForms.Guna2TextBox subjectNameField;
        private Guna.UI2.WinForms.Guna2Panel groupsPanel;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox cypherField;
        private Guna.UI2.WinForms.Guna2Panel marksPanel;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2ComboBox marksField;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox lectorField;
        private Guna.UI2.WinForms.Guna2ComboBox subjectField;
        private Guna.UI2.WinForms.Guna2ComboBox studentField;
        private Guna.UI2.WinForms.Guna2TextBox absentCountField;
        private Guna.UI2.WinForms.Guna2Panel d_pPanel;
        private Guna.UI2.WinForms.Guna2ComboBox d_pLectorField;
        private Guna.UI2.WinForms.Guna2ComboBox d_PSubjectField;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2TileButton groupsButton;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel queryPanel;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private Guna.UI2.WinForms.Guna2Button vectorButton;
        private System.Windows.Forms.Label secondTaskLabel;
        private Guna.UI2.WinForms.Guna2ComboBox secondTaskField;
        private Guna.UI2.WinForms.Guna2Button transactionButton;
        private System.Windows.Forms.Label sortOrderLabel;
        private Guna.UI2.WinForms.Guna2ComboBox sortOrderBox;
        private Guna.UI2.WinForms.Guna2Panel sortOrderPanel;
        private Guna.UI2.WinForms.Guna2Button checkGrantsButton;
        private Guna.UI2.WinForms.Guna2Button addGrantButton;
        private System.Windows.Forms.Label label17;
    }
}

