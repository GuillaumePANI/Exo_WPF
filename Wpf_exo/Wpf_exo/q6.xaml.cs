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
    /// Interaction logic for q6.xaml
    /// </summary>
    public partial class q6 : UserControl
    {
        public q6()
        {
            InitializeComponent();
            TextBox textbox = new TextBox();
            textbox.Text = "Hello";

            main.Children.Add(textbox);
            
        }
    }
}
