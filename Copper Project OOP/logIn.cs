using System.Data.SQLite;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Copper_Project_OOP
{
    public partial class logInForm : Form
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();
        private Dictionary<string, int> buttonDurations = new Dictionary<string, int>();


        public logInForm()
        {
            InitializeComponent();
        }


        private void costumer_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string pass = upassword.Text;

            if (AuthenticateCustomer(name, pass))
            {
                string LoggedInUser = name;
                MessageBox.Show("ورود به پنل با موفقیت انجام شد", "Success");

                this.Hide();
                costumer orderForm = new costumer(LoggedInUser);
                var orderform = orderForm;
                orderform.FormClosed += (s, args) => this.Show();
                orderForm.Show();
                
            }
            else
            {
                DialogResult result = MessageBox.Show("کاربر با این نام یافت نشد. آیا مایل به ساخت پنل هستید؟", "User Not Found", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RegisterNewUser(name, pass);
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمزورود اشتباه است", "Error");
                }
            }

            userName.Clear();
            upassword.Clear();
        }

        public static bool AuthenticateCustomer(string name, string password)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT Password FROM Customers WHERE Name = @Name;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    var result = command.ExecuteScalar();
                    return result != null && result.ToString() == password;
                }
            }
        }

        private void RegisterNewUser(string name, string password)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string LoggedInUser = name;
                try
                {
                    connection.Open();
                    string insertQuery = @"
                    INSERT INTO Customers (Name, Password, OrderAmount)
                    VALUES (@Name, @Password, @OrderAmount);";
                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@OrderAmount", 0);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("پنل کاربری ایجاد شد", "Success");

                    costumer orderForm = new costumer(LoggedInUser);
                    orderForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    return;
                }
            }

        }

        private void worker_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string pass = upassword.Text;

            AuthenticateUser(name, pass);
        }

        private void AuthenticateUser(string name, string password)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT User_Role FROM Users WHERE Username = @Username AND Password = @Password;";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", name);
                        command.Parameters.AddWithValue("@Password", password);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();
                            MessageBox.Show(".ورود به پنل با موفقیت انجام شد", "Welcome");

                            OpenFormForRole(role);
                        }
                        else
                        {
                            MessageBox.Show("!نام کاربری یا رمزورود اشتباه است", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ارتباط با پایگاه داده: {ex.Message}", "Database Error");
            }

            userName.Clear();
            upassword.Clear();
        }

        private void OpenFormForRole(string role)
        {
            Form nextForm;

            switch (role)
            {
                case "StoreKeeper":
                    nextForm = new storeKeeper(0.0f);
                    break;
                case "ProductManager":
                    nextForm = new productManage();
                    break;
                case "SaleManager":
                    nextForm = new saleManage();
                    break;
                case "ProductOperator":
                    nextForm = new productOperator();
                    break;
                case "QualityCheck":
                    nextForm = new qualityCheck(0.0d, 0);
                    break;
                default:
                    MessageBox.Show("نقش کاربری نامعتبر است", "Error");
                    return;
            }

            nextForm.Show();
        }
    }}


