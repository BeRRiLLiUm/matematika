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

namespace matematika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public void MainWindo()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, res, a, b, c, d;
            //res = 0;
            x = Convert.ToDouble(TextBox1.Text);
            y = Convert.ToDouble(TextBox2.Text);
            a = x + y;
            b= y + 1;
            c = a / b;
            a = x * y - 12;
            b = 34 + x;
            d = a / b;

            res = c - d ;
            TextBox3.Text = res.ToString();
            

        }
    }
}
