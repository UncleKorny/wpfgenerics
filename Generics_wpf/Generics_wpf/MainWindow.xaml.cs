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
using System.Collections;

namespace Generics_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ArrayList points, res;
            points = new ArrayList();
            res = new ArrayList();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float x = (float)XnumericUpDown.Value;
            float y = (float)YnumericUpDown.Value;
            Point p = new Point(x, y);
            points.Add(p);
            dataGridView1.Rows.Add(p.x, p.y);
        }


    }
}
