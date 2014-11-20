using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LottoPicker
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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Random random1 = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            Random random4 = new Random();
            Random random5 = new Random();
            Random random6 = new Random();
            Random random7 = new Random();

            int no1 = random1.Next(1, 50);
            int no2 = random1.Next(1, 50);
            int no3 = random1.Next(1, 50);
            int no4 = random1.Next(1, 50);
            int no5 = random1.Next(1, 50);
            int no6 = random1.Next(1, 50);
            int no7 = random1.Next(1, 50);

            number1.Text = no1.ToString();
            number2.Text = no2.ToString();
            number3.Text = no3.ToString();
            number4.Text = no4.ToString();
            number5.Text = no5.ToString();
            number6.Text = no6.ToString();
            bonus.Text = no7.ToString();

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var messageDialog2 = new MessageDialog("Developed by Raymond Dillon");
            await messageDialog2.ShowAsync();
        }

       
    }
}
