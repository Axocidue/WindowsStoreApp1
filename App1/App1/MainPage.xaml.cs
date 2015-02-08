using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            tbkFirst.Text += "\r\n Button Clicked.";
        }

        private void Border_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tbkFirst.Text += "\r\n Border Tapped.";
            e.Handled = true;
        }

        private void pnlFirst_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tbkFirst.Text += "\r\n StackPanel Tapped";
        }
    }
}
