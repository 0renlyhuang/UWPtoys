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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace StoreBooking
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
            Result.Text = "None";
        }

        private string roast = "None";
        private string sweet = "None";
        private string cream = "None";

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuFlyoutItem)sender;
            roast = item.Text;
            display();
        }

        

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuFlyoutItem)sender;
            cream = item.Text;
            display();
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuFlyoutItem)sender;
            sweet = item.Text;
            display();
        }

        private void display()
        {
            Result.Text = roast;
            if (roast == "None")
                return;

            if (!sweet.Equals("None"))
                Result.Text += (" + " + sweet);

            if (!cream.Equals("None"))
                Result.Text += (" + " + cream);               
        }

    }
}
