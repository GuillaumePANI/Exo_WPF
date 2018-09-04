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

namespace Wpf_exo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void q1_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Name.Equals("q1"))
                Main.Content = new q1();
            else if (((Button)sender).Name.Equals("q2"))
                Main.Content = new q2();
            else if (((Button)sender).Name.Equals("clear"))
                Main.Content =null;
            else if (((Button)sender).Name.Equals("q3"))
                Main.Content = new q3();
            else if (((Button)sender).Name.Equals("q4"))
                Main.Content = new q4();
            else if (((Button)sender).Name.Equals("q5"))
                Main.Content = new q5();
            else if (((Button)sender).Name.Equals("q6"))
                Main.Content = new q6();
            else if (((Button)sender).Name.Equals("q7"))
                Main.Content = new q7();
            else if (((Button)sender).Name.Equals("q8"))
                Main.Content = new q8();
            else if (((Button)sender).Name.Equals("q9"))
                Main.Content = new q9();
            else if (((Button)sender).Name.Equals("q10"))
                Main.Content = new q10();
        }
    }
}
