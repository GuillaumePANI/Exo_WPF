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
        }
    }
}
