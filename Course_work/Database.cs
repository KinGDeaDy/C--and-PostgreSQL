using Npgsql;
using System.Data;
using System.Windows.Forms;
using System;

namespace Course_work
{
    public class Database
    {
        private NpgsqlConnection connection;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public string connectionStatus="Closed";
        public void makeConnect(string login,string password)
        {
            connection = new NpgsqlConnection($"Server=localhost;Port=5433; User Id={login};Password={password}; Database=course_work;");
        }
        public void OpenConnection()
        {
            if (connectionStatus=="Closed")
            {
                connection.Open();
                connectionStatus = connection.State.ToString();
            } 
        }
        public void CloseConnection()
        {
            if (connectionStatus == "Open")
            {
                connection.Close();
                connectionStatus = connection.State.ToString();
            }       
        }
        public void fillTable(string sql,DataGridView table)
        {
            OpenConnection();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connection);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            table.DataSource = dt;
            CloseConnection();
            if (sql.Contains("marksview"))
            {
                table.Columns["id"].Visible = false;
                table.Columns["id"].DisplayIndex = 0;
                table.Columns["id"].Visible = false;
                table.Columns["student"].DisplayIndex = 1;
                table.Columns["mark"].DisplayIndex = 2;
                table.Columns["absent_count"].DisplayIndex = 3;
                table.Columns["subject"].DisplayIndex = 4;
                table.Columns["lector"].DisplayIndex = 5;
                table.Columns["student"].HeaderText = "Студент";
                table.Columns["mark"].HeaderText = "Оценка";
                table.Columns["absent_count"].HeaderText = "Количество пропусков";
                table.Columns["subject"].HeaderText = "Предмет";
                table.Columns["lector"].HeaderText = "Преподаватель";
            }
            else if (sql.Contains("StudentsView"))
            {
                table.Columns["id"].Visible = false;
                table.Columns[1].HeaderText = "Имя";
                table.Columns[2].HeaderText = "Фамилия";
                table.Columns[3].HeaderText = "Отчество";
                table.Columns[4].HeaderText = "Номер билета";
                table.Columns[5].HeaderText = "Группа";
                table.Columns[6].HeaderText = "Стипендия";
            }
            else if (sql.Contains("groupsf"))
            {
                table.Columns["id"].Visible = false;
                table.Columns[1].HeaderText = "Шифр";
                table.Columns[2].HeaderText = "Количество студентов";
            }
            else if (sql.Contains("dpview"))
            {
                table.Columns["id"].Visible = false;
                table.Columns[1].HeaderText = "Имя";
                table.Columns[2].HeaderText = "Фамилия";
                table.Columns[3].HeaderText = "Отчество";
                table.Columns[4].HeaderText = "Предмет";
            }
            else if (sql.Contains("Lectors"))
            {
                table.Columns["id"].Visible = false;
                table.Columns[1].HeaderText = "Имя";
                table.Columns[2].HeaderText = "Фамилия";
                table.Columns[3].HeaderText = "Отчество";
            }
            else if (sql.Contains("subjects"))
            {
                table.Columns["id"].Visible = false;
                table.Columns[1].HeaderText = "Предмет";
                table.Columns[2].HeaderText = "Количество часов";
            }
            table.AutoResizeColumns();
        }
        public void selectItems(string sql, Guna.UI2.WinForms.Guna2ComboBox comboBox)
        {
            OpenConnection();
            comboBox.Items.Clear();
            var cmd = new NpgsqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() == -1)
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string value = reader[0].ToString();
                    comboBox.Items.Add(value);
                }
            }
            CloseConnection();
        }
        public void selectItemsMarks2(Guna.UI2.WinForms.Guna2ComboBox comboBox1, Guna.UI2.WinForms.Guna2ComboBox comboBox2)
        {
            OpenConnection();
            comboBox2.Items.Clear();
            var cmd = new NpgsqlCommand("select l.name,surname,middle_name from subjects_lectors join lectors l on l.id = subjects_lectors.lector_id join subjects s on s.id = subjects_lectors.subject_id where s.name=@subject", connection);
            cmd.Parameters.AddWithValue("subject", comboBox1.Text);
            cmd.ExecuteNonQuery();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0] + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            CloseConnection();
        }
        public void DP(string subject,string lector,string option, DataGridView table)
        {
            try
            {
                int[] indexes = new int[2];
                OpenConnection();
                using (var cmd = new NpgsqlCommand("Select id from subjects where name = @subject", connection))
                {
                    cmd.Parameters.AddWithValue("subject", subject);
                    cmd.ExecuteNonQuery();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indexes[0] = Int32.Parse(reader[0].ToString());
                        }
                    }
                }
                var a = lector.Split(' ');
                using (var cmd = new NpgsqlCommand("Select id from lectors where name = @name and surname = @surname and middle_name = @middle_name", connection))
                {
                    cmd.Parameters.AddWithValue("name", a[0]);
                    cmd.Parameters.AddWithValue("surname", a[1]);
                    cmd.Parameters.AddWithValue("middle_name", a[2]);
                    cmd.ExecuteNonQuery();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indexes[1] = Int32.Parse(reader[0].ToString());
                        }
                    }
                }
                if (option == "insert")
                {
                    using (var cmd = new NpgsqlCommand("Select * from add_dp(@subject,@lector)", connection))
                    {
                        cmd.Parameters.AddWithValue("subject", indexes[0]);
                        cmd.Parameters.AddWithValue("lector", indexes[1]);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("Select * from update_dp(@id,@subject,@lector)", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", table.CurrentRow.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("subject", indexes[0]);
                        cmd.Parameters.AddWithValue("lector", indexes[1]);
                        cmd.ExecuteNonQuery();
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void Student(string name,string surname,string middle_name,string ticket_number,string cypher, string option, DataGridView table)
        {
            try
            {

           
            string group="";

                OpenConnection();
                using (var cmd = new NpgsqlCommand("Select id from Groups where cypher = @group", connection))
                {

                    cmd.Parameters.AddWithValue("group", cypher);
                    cmd.ExecuteNonQuery();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            group = reader[0].ToString();
                        }
                    }
                }
                if (option == "insert")
                {

                    using (var cmd = new NpgsqlCommand("Select * from add_student(@name,@surname,@middle_name,@ticket_number,@group)", connection))
                    {
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("middle_name", middle_name);
                        cmd.Parameters.AddWithValue("ticket_number", Int32.Parse(ticket_number));
                        cmd.Parameters.AddWithValue("group", Int32.Parse(group));
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("Update studentsview set name= @name, surname = @surname, middle_name =@middle_name , ticket_number = @ticket_number, cypher = @cypher where id=@id", connection))
                    {
                        cmd.Parameters.AddWithValue("id", table.CurrentRow.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("middle_name", middle_name);
                        cmd.Parameters.AddWithValue("ticket_number", Int32.Parse(ticket_number));
                        cmd.Parameters.AddWithValue("cypher", cypher);
                        cmd.ExecuteNonQuery();
                    }
                }

                CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void Group(string cypher, string option, DataGridView table)
        {
            try
            {
                if (option == "insert")
                {
                    using (var cmd = new NpgsqlCommand("Select * from add_group(@cypher)", connection))
                    {
                        OpenConnection();
                        cmd.Parameters.AddWithValue("cypher", cypher);
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("Select * from update_group(@id,@cypher)", connection))
                    {
                        OpenConnection();
                        cmd.Parameters.AddWithValue("@id", table.CurrentRow.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("cypher", cypher);
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        public void Lector(string name,string surname,string middle_name, string option, DataGridView table)
        {

                if (option == "insert")
                {
                    using (var cmd = new NpgsqlCommand("Select * from add_lector(@name,@surname,@middle_name)", connection))
                    {
                        OpenConnection();
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("middle_name", middle_name);
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("Select * from update_lector(@id,@name,@surname,@middle_name)", connection))
                    {
                        OpenConnection();
                        cmd.Parameters.AddWithValue("@id", table.CurrentRow.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("middle_name", middle_name);
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }

            
        }
        public void Mark(string mark,string absent_count,string student,string subject, string lector, string option, DataGridView table)
        {
            try
            {
                int[] indexes = new int[2];
                OpenConnection();
                using (var cmd = new NpgsqlCommand("select subjects_lectors.id from subjects_lectors join subjects s on s.id = subjects_lectors.subject_id join lectors l on l.id = subjects_lectors.lector_id where s.name=@subject and l.name=@name and l.surname=@surname and l.middle_name=@middle_name", connection))
                {
                    var a = lector.Split(' ');
                    cmd.Parameters.AddWithValue("@subject", subject);
                    cmd.Parameters.AddWithValue("@name", a[0].Trim());
                    cmd.Parameters.AddWithValue("@surname", a[1].Trim());
                    cmd.Parameters.AddWithValue("@middle_name", a[2].Trim());
                    cmd.ExecuteNonQuery();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indexes[0] = Int32.Parse(reader[0].ToString());
                        }
                    }
                }
                using (var cmd = new NpgsqlCommand("select id from students where name=@name and surname=@surname and middle_name=@middle_name", connection))
                {
                    var a = student.Split(' ');
                    cmd.Parameters.AddWithValue("@name", a[0]);
                    cmd.Parameters.AddWithValue("@surname", a[1]);
                    cmd.Parameters.AddWithValue("@middle_name", a[2]);
                    cmd.ExecuteNonQuery();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indexes[1] = Int32.Parse(reader[0].ToString());
                        }
                    }
                }
                if (option == "insert")
                {
                    using (var cmd = new NpgsqlCommand("select * from add_marks(@mark,@absent_count,@sid,@dpid)", connection))
                    {
                        cmd.Parameters.AddWithValue("@mark", Int32.Parse(mark));
                        cmd.Parameters.AddWithValue("@absent_count", Int32.Parse(absent_count));
                        cmd.Parameters.AddWithValue("@sid", indexes[1]);
                        cmd.Parameters.AddWithValue("@dpid", indexes[0]);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("select * from update_marks(@id,@mark,@absent_count,@sid,@dpid)", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", table.CurrentRow.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("@mark", Int32.Parse(mark));
                        cmd.Parameters.AddWithValue("@absent_count", Int32.Parse(absent_count));
                        cmd.Parameters.AddWithValue("@sid", indexes[1]);
                        cmd.Parameters.AddWithValue("@dpid", indexes[0]);
                        cmd.ExecuteNonQuery();
                    }
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }
        public void Subject(string subject,string hours_count, string option, DataGridView table)
        {
            try
            {
                OpenConnection();
                if (option == "insert")
                {
                    using (var cmd = new NpgsqlCommand("Select * from add_subject(@subject,@hours_count)", connection))
                    {
                        cmd.Parameters.AddWithValue("subject", subject);
                        cmd.Parameters.AddWithValue("hours_count", Int32.Parse(hours_count));
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("call k_UpdateSubject(@id,@subject,@hours_count)", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", table.CurrentRow.Cells["id"].Value);
                        cmd.Parameters.AddWithValue("subject", subject);
                        cmd.Parameters.AddWithValue("hours_count", Int32.Parse(hours_count));
                        cmd.ExecuteNonQuery();
                    }
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void deleteRow(string sql, DataGridView table)
        {
            try
            {
                OpenConnection();
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", table.CurrentRow.Cells["id"].Value);
                    cmd.ExecuteNonQuery();
                }
                CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void sqlTransaction(string sql)
        {
            try
            {
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    OpenConnection();
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
