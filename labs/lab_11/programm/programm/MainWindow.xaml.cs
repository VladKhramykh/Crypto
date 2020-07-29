using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace programm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void hashBtn_Click(object sender, RoutedEventArgs e)
        {
            if(sourceText.Text.Trim().Length != 0)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    DateTime start1 = DateTime.Now;
                    string hash = GetHash(sha256, sourceText.Text);
                    if(VerifyHash(sha256, sourceText.Text, hash))
                    {
                        hashTextBox.Text = hash;
                        isVerificatedLabel.Content = "Verification successful";
                    }
                    else
                    {
                        isVerificatedLabel.Content = "Verification failed";
                    }
                    TimeSpan procTime1 = DateTime.Now - start1;
                    execLabel.Content = "Ecnryption execution time: " + procTime1.TotalSeconds.ToString() + " sec";
                }
            }
            else
            {
                MessageBox.Show("Please, fill source textbox");
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
           
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {           
            var hashOfInput = GetHash(hashAlgorithm, input);           
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
