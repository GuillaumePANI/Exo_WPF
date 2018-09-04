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
    /// Interaction logic for q7.xaml
    /// </summary>
    public partial class q7 : UserControl
    {
        public q7()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = i;
                liste.Items.Add(item);
            }
        }
    }
}
