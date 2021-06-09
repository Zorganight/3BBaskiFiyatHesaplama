using System;
using System.Windows;

namespace WpfApp2
{
    /// Bu kod 09.06.2021 gününde yazılmış ve nasıl çözüldüğü bilinmiyordur.

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string grnm = "";
        private string isnm = "";
        private string flnm = "";
        int flint;
        int grint;
        int isint;

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
                isint = Int32.Parse(isnm.ToString());
                grint = Int32.Parse(grnm.ToString());
                flint = Int32.Parse(flnm.ToString());
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Lütfen bir değer giriniz.");

            }

            Double net = grint + flint + 1 + isint;
            Double kar = (net * 30 / 100) + net;
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
