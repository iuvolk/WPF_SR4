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

namespace WPF_SR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateGr.Text);
            double sumDollar = Convert.ToDouble(sumGr.Text);
            double resDollar = rateDollar * sumDollar;
            resSumGr.Text = resDollar.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateEu.Text);
            double sumDollar = Convert.ToDouble(sumEu.Text);
            double resDollar = rateDollar * sumDollar;
            resSumEu.Text = resDollar.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateDr.Text);
            double sumDollar = Convert.ToDouble(sumDr.Text);
            double resDollar = rateDollar * sumDollar;
            resSumDr.Text = resDollar.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double measInch = Convert.ToDouble(measureInch.Text);
            double resInchToMeters = measInch / 39.37;
            resultInchToMeters.Text = resInchToMeters.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double measFoot = Convert.ToDouble(measureFoot.Text);
            double resFootToMeters = measFoot / 3.281;
            resultFootToMeters.Text = resFootToMeters.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double measMiles = Convert.ToDouble(measureMiles.Text);
            double resMilesToMeters = measMiles * 1609;
            resultMilesToMeters.Text = resMilesToMeters.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double measVersta = Convert.ToDouble(measureVersta.Text);
            double resVerstaToMeters = measVersta * 1067;
            resultVerstaToMeters.Text = resVerstaToMeters.ToString();
        }
    }
}
