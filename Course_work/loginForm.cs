using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Course_work
{
    public partial class loginForm : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;

        public loginForm()
        {
            this.MouseDown += new MouseEventHandler(loginForm_MouseDown);
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            try
            {
                database.makeConnect(loginTextBox.Text,passwordTextBox.Text);
                database.OpenConnection();
                if (database.connectionStatus=="Open")
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow(database,loginTextBox.Text);
                    mainWindow.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
                    database.CloseConnection();
                    mainWindow.Show();
                }
            }
            catch
            {
                wrongDataLabel.Visible = true;
            }
        }
    }
}
