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
    /// Логика взаимодействия для Nod.xaml
    /// </summary>
    public partial class Nod : Page
    {
        Utils utils = new Utils();

        public Nod()
        {
            InitializeComponent();
        }

        private void buttonForThree_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Int32.Parse(forThreeFirst.Text);
                int b = Int32.Parse(forThreeSecond.Text);
                int c = Int32.Parse(forThreeThird.Text);

                int result = utils.nodForThree(a, b, c);

                labelForThree.Content = "Result: " + result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect parameter");
            }
           
        }

        private void buttonForTwo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Int32.Parse(forTwoFirst.Text);
                int b = Int32.Parse(forTwoSecond.Text);

                int result = utils.nodForTwo(a, b);

                labelForTwo.Content = "Result: " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect parameter");
            }

        }
    }
}
