using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Course_work
{
    public partial class MainWindow : Form
    {
        Database database;
        string Login;
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        public MainWindow(Database database,string login)
        {
            InitializeComponent();
            Login = login;
            this.database = database;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            if (login == "User")
            {
                editingPanel.Hide();
                tablePanel.Dock = DockStyle.Fill;
                queriesButton.Hide();
                foreach (var item in buttonsPanel.Controls.OfType<Control>())
                {
                    item.Width = 172;
                }
            }
                
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            Application.Exit();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPannel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            database.fillTable("SELECT * from StudentsView", table);
            

        }
        public void panelHiding()
        {
            guna2Transition1.HideSync(lectorsPanel);
            guna2Transition1.HideSync(groupsPanel);
            guna2Transition1.HideSync(studentsPanel);
            guna2Transition1.HideSync(d_pPanel);
            guna2Transition1.HideSync(marksPanel);
            guna2Transition1.HideSync(subjectsPanel);
            if (!queriesButton.Checked && Login!="User")
            {
                guna2Transition1.HideSync(queryPanel);
                guna2Transition1.ShowSync(editingPanel);
            }
            
                                 
        }

        private void LectorsButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            database.fillTable("Select * from Lectors", table);  
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            database.fillTable("Select * from subjects", table);         
        }

        private void marksButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            database.fillTable("Select * from marksview", table); 
        }

        private void d_pButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            database.fillTable("Select * from dpview", table);
        }
        private void groupsButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            database.fillTable("Select * from groups", table);
        }
        private void queriesButton_Click(object sender, EventArgs e)
        {
            panelHiding();
            if (queriesButton.Checked)
            {
                guna2Transition1.HideSync(editingPanel);
                guna2Transition1.ShowSync(queryPanel);
                
            }
        }
        public bool checkFill(string value)
        {
            if (value=="dp")
                return !string.IsNullOrEmpty(d_pLectorField.Text) && !string.IsNullOrEmpty(d_PSubjectField.Text);
            if (value == "students")
                return !string.IsNullOrEmpty(STnameField.Text) && !string.IsNullOrEmpty(STsurnameField.Text) && !string.IsNullOrEmpty(ticketNumberField.Text) && !string.IsNullOrEmpty(STmiddleNameField.Text) && !string.IsNullOrEmpty(ticketNumberField.Text) && !string.IsNullOrEmpty(groupField.Text);
            if (value == "groups")
                return !string.IsNullOrEmpty(cypherField.Text);
            if (value == "lectors")
                return !string.IsNullOrEmpty(tNameField.Text) && !string.IsNullOrEmpty(tSurnameField.Text) && !string.IsNullOrEmpty(tMiddleNameField.Text);
            if (value == "marks")
                return !string.IsNullOrEmpty(marksField.Text) && !string.IsNullOrEmpty(absentCountField.Text) && !string.IsNullOrEmpty(studentField.Text) && !string.IsNullOrEmpty(subjectField.Text) && !string.IsNullOrEmpty(lectorField.Text);
            if (value == "subjects")
                return !string.IsNullOrEmpty(subjectNameField.Text) && !string.IsNullOrEmpty(subjectHoursField.Text);
            return false;
        }
        public void panelChecking()
        {
            if (studentsButton.Checked)
            {
                if (lectorsPanel.Visible)
                    guna2Transition1.HideSync(lectorsPanel);
                if (subjectsPanel.Visible)
                    guna2Transition1.HideSync(subjectsPanel);
                if (marksPanel.Visible)
                    guna2Transition1.HideSync(marksPanel);
                if (d_pPanel.Visible)
                    guna2Transition1.HideSync(d_pPanel);
                if (groupsPanel.Visible)
                    guna2Transition1.HideSync(groupsPanel);
                guna2Transition1.ShowSync(studentsPanel);
            }
            if (LectorsButton.Checked)
            {
                if (studentsPanel.Visible)
                    guna2Transition1.HideSync(studentsPanel);
                if (subjectsPanel.Visible)
                    guna2Transition1.HideSync(subjectsPanel);
                if (marksPanel.Visible)
                    guna2Transition1.HideSync(marksPanel);
                if (d_pPanel.Visible)
                    guna2Transition1.HideSync(d_pPanel);
                if (groupsPanel.Visible)
                    guna2Transition1.HideSync(groupsPanel);
                guna2Transition1.ShowSync(lectorsPanel);
            }
            if (subjectsButton.Checked)
            {
                if (lectorsPanel.Visible)
                    guna2Transition1.HideSync(lectorsPanel);
                if (studentsPanel.Visible)
                    guna2Transition1.HideSync(studentsPanel);
                if (marksPanel.Visible)
                    guna2Transition1.HideSync(marksPanel);
                if (d_pPanel.Visible)
                    guna2Transition1.HideSync(d_pPanel);
                if (groupsPanel.Visible)
                    guna2Transition1.HideSync(groupsPanel);
                guna2Transition1.ShowSync(subjectsPanel);
            }
            if (marksButton.Checked)
            {
                if (lectorsPanel.Visible)
                    guna2Transition1.HideSync(lectorsPanel);
                if (subjectsPanel.Visible)
                    guna2Transition1.HideSync(subjectsPanel);
                if (studentsPanel.Visible)
                    guna2Transition1.HideSync(studentsPanel);
                if (d_pPanel.Visible)
                    guna2Transition1.HideSync(d_pPanel);
                if (groupsPanel.Visible)
                    guna2Transition1.HideSync(groupsPanel);
                guna2Transition1.ShowSync(marksPanel);
            }
            if (d_pButton.Checked)
            {
                if (lectorsPanel.Visible)
                    guna2Transition1.HideSync(lectorsPanel);
                if (subjectsPanel.Visible)
                    guna2Transition1.HideSync(subjectsPanel);
                if (marksPanel.Visible)
                    guna2Transition1.HideSync(marksPanel);
                if (studentsPanel.Visible)
                    guna2Transition1.HideSync(studentsPanel);
                if (groupsPanel.Visible)
                    guna2Transition1.HideSync(groupsPanel);
                guna2Transition1.ShowSync(d_pPanel);
            }
            if (groupsButton.Checked)
            {
                if (lectorsPanel.Visible)
                    guna2Transition1.HideSync(lectorsPanel);
                if (subjectsPanel.Visible)
                    guna2Transition1.HideSync(subjectsPanel);
                if (marksPanel.Visible)
                    guna2Transition1.HideSync(marksPanel);
                if (studentsPanel.Visible)
                    guna2Transition1.HideSync(studentsPanel);
                if (d_pPanel.Visible)
                    guna2Transition1.HideSync(d_pPanel);
                guna2Transition1.ShowSync(groupsPanel);
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        { 
            panelChecking();
            if (checkFill("dp"))
            {
                database.DP(d_PSubjectField.Text, d_pLectorField.Text,"insert",table);
                database.fillTable("Select * from dpview", table);
                d_PSubjectField.Items.Clear();d_pLectorField.Items.Clear();
            }
            if (checkFill("students"))
            {
                database.Student(STnameField.Text, STsurnameField.Text, STmiddleNameField.Text, ticketNumberField.Text, groupField.Text, "insert",table);
                database.fillTable("SELECT * from StudentsView", table);
                STnameField.Clear();STsurnameField.Clear();STmiddleNameField.Clear();ticketNumberField.Clear();groupField.Items.Clear();
            }
            if (checkFill("groups"))
            {
                database.Group(cypherField.Text,"insert",table);
                database.fillTable("Select * from groups", table);
                cypherField.Clear();
            }
            if (checkFill("lectors"))
            {
                database.Lector(tNameField.Text, tSurnameField.Text, tMiddleNameField.Text,"insert",table);
                database.fillTable("Select * from Lectors", table);
                tNameField.Clear();tSurnameField.Clear();tMiddleNameField.Clear();
            }
            if (checkFill("marks"))
            {
                database.Mark(marksField.Text, absentCountField.Text, studentField.Text, subjectField.Text, lectorField.Text,"insert",table);
                database.fillTable("Select * from marksview", table);
                absentCountField.Clear();studentField.Items.Clear();subjectField.Items.Clear();lectorField.Items.Clear();
            }
            if (checkFill("subjects"))
            {
                database.Subject(subjectNameField.Text, subjectHoursField.Text,"insert",table);
                database.fillTable("Select * from subjects", table);
                subjectField.Items.Clear();subjectHoursField.Clear();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (table.CurrentRow != null)
            {
                if (studentsButton.Checked)
                {
                    database.deleteRow("select * from delete_student(@id)", table);
                    database.fillTable("SELECT * from StudentsView", table);
                }
                if (groupsButton.Checked)
                {
                    database.deleteRow("select * from delete_group(@id)", table);
                    database.fillTable("Select * from groups", table);
                }
                if (LectorsButton.Checked)
                {
                    database.deleteRow("select * from delete_lector(@id)", table);
                    database.fillTable("Select * from Lectors", table);
                }
                if (subjectsButton.Checked)
                {
                    database.deleteRow("select * from delete_subject(@id)", table);
                    database.fillTable("Select * from subjects", table);
                }
                if (marksButton.Checked)
                {
                    database.deleteRow("select * from delete_mark(@id)", table);
                    database.fillTable("Select * from marksview", table);
                }
                if (d_pButton.Checked)
                {
                    database.deleteRow("select * from delete_dp(@id)", table);
                    database.fillTable("Select * from dpview", table);
                }
            } 
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            panelChecking();
            if (table.CurrentRow!=null)
            {
                if (checkFill("dp"))
                {
                    database.DP(d_PSubjectField.Text, d_pLectorField.Text, "update", table);
                    database.fillTable("Select * from dpview", table);
                    d_PSubjectField.Items.Clear(); d_pLectorField.Items.Clear();
                }
                if (checkFill("students"))
                {
                    database.Student(STnameField.Text, STsurnameField.Text, STmiddleNameField.Text, ticketNumberField.Text, groupField.Text, "update", table);
                    database.fillTable("SELECT * from StudentsView", table);
                    STnameField.Clear(); STsurnameField.Clear(); STmiddleNameField.Clear(); ticketNumberField.Clear(); groupField.Items.Clear();
                }
                if (checkFill("groups"))
                {
                    database.Group(cypherField.Text, "update", table);
                    database.fillTable("Select * from groups", table);
                    cypherField.Clear();
                }
                if (checkFill("lectors"))
                {
                    database.Lector(tNameField.Text, tSurnameField.Text, tMiddleNameField.Text, "update", table);
                    database.fillTable("Select * from Lectors", table);
                    tNameField.Clear(); tSurnameField.Clear(); tMiddleNameField.Clear();
                }
                if (checkFill("marks"))
                {
                    database.Mark(marksField.Text, absentCountField.Text, studentField.Text, subjectField.Text, lectorField.Text, "update", table);
                    database.fillTable("Select * from marksview", table);
                    absentCountField.Clear(); studentField.Items.Clear(); subjectField.Items.Clear(); lectorField.Items.Clear();
                }
                if (checkFill("subjects"))
                {
                    database.Subject(subjectNameField.Text, subjectHoursField.Text, "update", table);
                    database.fillTable("Select * from subjects", table);
                    subjectField.Items.Clear(); subjectHoursField.Clear();
                }
            }
            
        }

        private void subjectField_MouseClick(object sender, MouseEventArgs e)
        {
            database.selectItems("select name from Subjects", subjectField);
        }

        private void lectorField_MouseClick(object sender, MouseEventArgs e)
        {
            database.selectItemsMarks2(subjectField, lectorField);
        }

        private void studentField_MouseClick(object sender, MouseEventArgs e)
        {
            database.selectItems("SELECT name || ' ' || surname || ' ' || middle_name from Students", studentField);
        }

        private void groupField_MouseClick(object sender, MouseEventArgs e)
        {
            database.selectItems("SELECT cypher from Groups", groupField);
        }

        private void d_PSubjectField_MouseClick(object sender, MouseEventArgs e)
        {
            database.selectItems("SELECT name from Subjects", d_PSubjectField);
        }

        private void d_pLectorField_MouseClick(object sender, MouseEventArgs e)
        {
            database.selectItems("SELECT name || ' ' || surname || ' ' || middle_name from Lectors", d_pLectorField);
        }

        private void subjectField_SelectedIndexChanged(object sender, EventArgs e)
        {
            lectorField.Items.Clear();
        }

        private void absentCountField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
        private void ticketNumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void secondTaskField_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(sortOrderPanel);
            descriptionTextBox.Text = "";
            if (secondTaskField.Text == "2a")
            {
                database.fillTable("select marks.id,С.surname,С.name,С.middle_name,S.name AS subject,case WHEN mark=5 THEN 'Отлично' " +
                    "WHEN mark=4 THEN 'Хорошо' WHEN mark=3 THEN 'Удовлетворительно' WHEN mark=2 THEN 'Пересдача' end as mark " +
                    " from marks  join students С on С.id = marks.student_id JOIN subjects_lectors SL on SL.id = marks.subjects_lectors_id " +
                    "JOIN subjects S on S.id = SL.subject_id ORDER BY surname;", table);
                descriptionTextBox.Text = "Запрос выводит оценки на сессии с заменой на буквенный аналог";
                table.Columns["id"].Visible = false;
                table.Columns["surname"].DisplayIndex = 1;
                table.Columns["name"].DisplayIndex = 2;
                table.Columns["middle_name"].DisplayIndex = 3;
                table.Columns["subject"].DisplayIndex = 4;
                table.Columns["mark"].DisplayIndex = 5;
                table.Columns["surname"].HeaderText = "Фамилия";
                table.Columns["name"].HeaderText = "Имя";
                table.Columns["middle_name"].HeaderText = "Отчество";
                table.Columns["subject"].HeaderText = "Предмет";
                table.Columns["mark"].HeaderText = "Оценка";
            }
            else if (secondTaskField.Text == "2b")
            {
                database.fillTable("select * from studentsview", table);
                table.Columns["surname"].HeaderText = "Фамилия";
                table.Columns["name"].HeaderText = "Имя";
                table.Columns["middle_name"].HeaderText = "Отчество";
                table.Columns["id"].Visible = false;
                table.Columns["ticket_number"].HeaderText = "Номер билета";
                table.Columns["cypher"].HeaderText = "Шифр";
                table.Columns["grant"].HeaderText = "Стипендия";
                table.AutoResizeColumns();
                guna2Transition1.ShowSync(sortOrderPanel);

            }
            else if (secondTaskField.Text == "коррелированный select")
            {
                database.fillTable("select id,name,surname,middle_name, (select round(avg(mark),2) from marks where student_id= students.id) as middle_mark from students;", table);
                table.Columns["id"].Visible = false;
                table.Columns["surname"].DisplayIndex = 1;
                table.Columns["name"].DisplayIndex = 2;
                table.Columns["middle_name"].DisplayIndex = 3;
                table.Columns["middle_mark"].DisplayIndex = 4;
                table.Columns["surname"].HeaderText = "Фамилия";
                table.Columns["name"].HeaderText = "Имя";
                table.Columns["middle_name"].HeaderText = "Отчество";
                table.Columns["middle_mark"].HeaderText = "Средняя оценка";
                descriptionTextBox.Text = "Запрос выводит среднюю оценку студентов на сессии";
                table.AutoResizeColumns();
            }
            else if (secondTaskField.Text == "коррелированный from")
            {
                database.fillTable("select sub.id,name,surname,middle_name,cypher from groups g cross join lateral " +
                    " (select * from students student where cypher='ИТ-19' and g.id=student.group_id) sub;", table);
                table.Columns["cypher"].HeaderText = "Шифр";
                descriptionTextBox.Text = "Запрос выводит студентов определённой группы";
            }
            else if (secondTaskField.Text == "коррелированный where")
            {
                database.fillTable("select* from groups WHERE exists(select * from students where groups.id = group_id);", table);
                descriptionTextBox.Text = "Запрос выводит группы, где есть студенты";
                table.Columns["cypher"].HeaderText = "Шифр";
                table.Columns["students_count"].HeaderText = "Количество студентов";
            }
            else if (secondTaskField.Text == "некоррелированный select")
            {
                database.fillTable("select (select surname from students where five_count(id)>3 limit 1);", table);
                descriptionTextBox.Text = "Запрос выводит фамилию одного студента, у которого больше трёх пятёрок на сессии";
                table.Columns["surname"].HeaderText = "Фамилия";
            }
            else if (secondTaskField.Text == "некоррелированный from")
            {   
                database.fillTable("select * from(select mark, absent_count from marks) as foo where foo.absent_count < 10;", table);
                descriptionTextBox.Text = "Запрос выводит оценки студентов у которых меньше 10 пропусков";
                table.Columns["mark"].HeaderText = "Оценка";
                table.Columns["absent_count"].HeaderText = "Количество пропусков";
                table.AutoResizeColumns();
            }
            else if (secondTaskField.Text == "некоррелированный where")
            {
                database.fillTable("select count(mark) as five_count from marks where mark = (select max(mark) from marks);", table);
                descriptionTextBox.Text = "Запрос выводит общее количество пятёрок на сессии";
                table.Columns["five_count"].HeaderText = "Количество пятёрок";
            }
            else if (secondTaskField.Text == "2d")
            {
                database.fillTable("select name,surname,middle_name from marks join students s on s.id = marks.student_id group by name, surname, middle_name having max(mark)>4;", table);
                descriptionTextBox.Text = "Запрос выводит студентов у которых есть пятёрки на сессии";
                table.Columns["surname"].HeaderText = "Фамилия";
                table.Columns["name"].HeaderText = "Имя";
                table.Columns["middle_name"].HeaderText = "Отчество";
            }
            else if (secondTaskField.Text == "2e")
            {
                database.fillTable("select * from marksview where subject=ANY('{Программирование,Алгебра}');", table);
                descriptionTextBox.Text = "Запрос выводит оценки по программированию и алгебре";
            }
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            database.sqlTransaction("call make_grant()");
            database.fillTable("select grant_summary from grants", table);
            table.Columns["grant_summary"].HeaderText = "Баланс";
        }

        private void vectorButton_Click(object sender, EventArgs e)
        {
            database.fillTable("select five_count(42);", table);
            descriptionTextBox.Text = "Запрос выводит количество пятёрок у студента по id=42";
            table.Columns["five_count"].HeaderText = "Количество пятёрок";
        }

        private void sortOrderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortOrderBox.Text == "По имени")
                database.fillTable("select * from studentsview order by name", table);
            if (sortOrderBox.Text == "По фамилии")
                database.fillTable("select * from studentsview order by surname", table);
            if (sortOrderBox.Text == "По отчеству")
                database.fillTable("select * from studentsview order by middle_name", table);
            if (sortOrderBox.Text == "По номеру билета")
                database.fillTable("select * from studentsview order by ticket_number", table);
            if (sortOrderBox.Text == "По номеру группы")
                database.fillTable("select * from studentsview order by cypher", table);
        }

        private void checkGrantsButton_Click(object sender, EventArgs e)
        {
            database.fillTable("select grant_summary from grants", table);
            table.Columns["grant_summary"].HeaderText = "Баланс";
        }

        private void addGrantButton_Click(object sender, EventArgs e)
        {
            database.sqlTransaction("update grants set grant_summary=100000");
            database.fillTable("select grant_summary from grants", table);
            table.Columns["grant_summary"].HeaderText = "Баланс";
        }
    }
}