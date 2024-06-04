using System;
using System.Linq;
using System.Windows.Forms;

namespace Azure_Project_Task_1
{

    public partial class LoginPage : Form
    {
        UserEntities _db = new UserEntities();

        private void ShowDatabase()
        {
           Databaseshower dat = new Databaseshower();
           dat.FormClosed += new FormClosedEventHandler(OnDatabaseShowerExit);
           dat.Show();
        }
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            bool UserFound = false;
            string Username = UsernameTextBox.Text;
            string Password = PasswordTextbox.Text;
            var users = _db.Users.ToList();
            foreach (var i in users)
            {
                string PersonUsername = i.Username.Trim();
                string PersonPassword = i.Password.Trim();

                if (Username == PersonUsername)
                {
                    UserFound = true;
                    if (Password != PersonPassword)
                    {
                        MessageBox.Show("Wrong Password");
                        break;
                    }

                    MessageBox.Show("password is correct");

                    _db.Users.Where(p => p.Id == i.Id)
                    .ToList()
                    .ForEach(x => x.LastLoginDateTime = DateTime.Now);
                    _db.SaveChanges();

                    WindowState = FormWindowState.Minimized;

                    ShowDatabase();

                }
            }
            if (!UserFound)
            {
                MessageBox.Show("User Not Found");
            }
        }

        void OnDatabaseShowerExit(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
