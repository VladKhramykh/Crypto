using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_03
{
    /// <summary>
    /// Логика взаимодействия для ObrMod.xaml
    /// </summary>
    public partial class ObrMod : Page
    {
        Utils utils = new Utils();

        public ObrMod()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Int32.Parse(first.Text);
                int b = Int32.Parse(second.Text);

                int result = utils.ReverseMod(a, b);

                label.Content = " = " + result.ToString();

            }
            catch(ArithmeticException ae)
            {
                MessageBox.Show("Числа не взимно просты");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect parameter");
            }
        }
    }
}
