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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string grnm = "";
        private string ısnm = "";
        private string flnm = "";


        public MainWindow()
        {
            InitializeComponent();


        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {

            grnm = gr.Text;
            ısnm = ıs.Text;
            flnm = fl.Text;
            int ısint = Int32.Parse(ısnm.ToString());
            int grint = Int32.Parse(grnm.ToString());
            int flint = Int32.Parse(flnm.ToString());
            double net = grint * (flint / 1000) + 1 + ısint;
            double kar = (net * 30 / 100) + net;
            lb.Text = $"Net fiyat: {net}";
            nm.Text = $"Kar ile birlikte fiyat:{kar}";

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
