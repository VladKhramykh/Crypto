using lab_05.Alphabets;
using lab_05.Crypto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace lab_05
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch;
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            output.Text = RouteStrategy.encrypt(input.Text);
            stopwatch.Stop();
            timer1.Content = stopwatch.Elapsed.TotalMilliseconds + " ms";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch;
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            output2.Text = RouteStrategy.decrypt(input2.Text);
            stopwatch.Stop();
            timer2.Content = stopwatch.Elapsed.TotalMilliseconds + " ms";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch;
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            output3.Text = MultipleReshuffleStrategy.Encrypt(input3.Text, "ХРАМЫХ", "ВЛАД");
            stopwatch.Stop();
            timer3.Content = stopwatch.Elapsed.TotalMilliseconds + " ms";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch;
            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            output4.Text = MultipleReshuffleStrategy.Decrypt(input4.Text, "ХРАМЫХ", "ВЛАД");
            stopwatch.Stop();
            timer4.Content = stopwatch.Elapsed.TotalMilliseconds + " ms";
        }
    }
}
