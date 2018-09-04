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
    /// Interaction logic for q8.xaml
    /// </summary>
    public partial class q8 : UserControl
    {
        public q8()
        {
            InitializeComponent();
            ComboBox combo = new ComboBox();
            combo.Items.Add(new ComboBoxItem() { Content = "test", IsSelected = true, IsEnabled = false });
            main.Children.Add(combo);
            for (int i = 0; i < 5; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                combo.Items.Add(item);
            }

        }
    }
}
