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
    /// Логика взаимодействия для SimpeNum.xaml
    /// </summary>
    public partial class SimpeNum : Page
    {
        Utils utils = new Utils();
        public SimpeNum()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<int> numbers = new List<int>();

            try
            {
                int from = Int32.Parse(first.Text);
                int to = Int32.Parse(second.Text);

                utils.getSimpleByRange(from, to).ForEach(p=> numbers.Add(p));
                StringBuilder result = new StringBuilder();

                numbers.ForEach(p => result.Append("-" + p.ToString() + "-"));

                resultTextBox.Text = result.Insert(0, "Result: ", 1).ToString();
                compareLabel.Content = ($"Count: {numbers.Count}\n" +
                    $"{to}/ln({to}) = {Math.Round((to / Math.Log(to)), 1).ToString()}");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect parameter");
            }

        }
    }
}
