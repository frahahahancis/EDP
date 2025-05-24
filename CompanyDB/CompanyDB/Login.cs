using System.Text;
using System.Security.Cryptography;


namespace CompanyDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoadSavedCredentials();
        }

        private const string filePath = "credentials.dat";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Usernametxt.Text == "admin" && Passwordtxt.Text == "password123") // Replace with actual validation
            {
                MessageBox.Show("Login Successful!");

                if (RmBtn.Checked)
                {
                    string data = $"{Usernametxt.Text}|{Passwordtxt.Text}";
                    string encryptedData = Encrypt(data);
                    File.WriteAllText(filePath, encryptedData);
                }
                else
                {
                    if (File.Exists(filePath))
                        File.Delete(filePath);
                }

                // **Open the MainForm**
                Employees mainForm = new Employees();
                mainForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }


        }



        private void LoadSavedCredentials()
        {
            if (File.Exists(filePath))
            {
                string encryptedData = File.ReadAllText(filePath);
                string decryptedData = Decrypt(encryptedData);

                string[] parts = decryptedData.Split('|');
                if (parts.Length == 2)
                {
                    Usernametxt.Text = parts[0];
                    Passwordtxt.Text = parts[1];
                    RmBtn.Checked = true;
                }
            }
        }

        private string Encrypt(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("abcdefghijklmnop"); // **Ensure a secure key**
                aes.IV = new byte[16]; // Default IV (should be randomized for better security)
                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(bytes, 0, bytes.Length);
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        private string Decrypt(string encryptedData)
        {
            byte[] bytes = Convert.FromBase64String(encryptedData);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("abcdefghijklmnop");
                aes.IV = new byte[16];
                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] decryptedBytes = decryptor.TransformFinalBlock(bytes, 0, bytes.Length);
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }

    }
}
