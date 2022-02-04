using System;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        private string grnm = "";
        private string isnm = "";
        private string flnm = "";
        double isint;
        double grint;
        double flint;


        public MainWindow()
        {
            InitializeComponent();
            gram.Text = "0";
            ss.Text = "0";
            fl.Text = "0";
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {


            try
            {

                grnm = gram.Text;
                isnm = ss.Text;
                flnm = fl.Text;
                isint = double.Parse(isnm.ToString());
                grint = double.Parse(grnm.ToString());
                flint = double.Parse(flnm.ToString());

            }
            catch (System.FormatException)
            {

                MessageBox.Show("Lütfen bir değer giriniz.");

            }

            double net = (flint / 1000) * grint + 1 + isint;
            double kar = (net * 30 / 100) + net;
            lb.Text = $"Net fiyat:{net}";
            nm.Text = $"Kar ile birlikte fiyat:{kar}";



        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ıs_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
