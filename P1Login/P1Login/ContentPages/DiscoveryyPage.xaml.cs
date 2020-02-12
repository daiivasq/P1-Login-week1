using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1Login.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryyPage : ContentPage
    {
        public DiscoveryyPage()
        {
            InitializeComponent();
        }

        private void BarsAndHotel_Tapped(object sender, EventArgs e)
        {
            var select = (MenuView)sender;
            if (select.BackgroundColor == Color.Default)
            {
                select.BackgroundColor = Color.Red;
            }
            else
            {
                select.BackgroundColor = Color.Default;
            }
          
        }

        private void FineDining_Tapped(object sender, EventArgs e)
        {
            var select = (MenuView)sender;
            if (select.BackgroundColor == Color.Default)
            {
                select.BackgroundColor = Color.Red;
            }
            else
            {
                select.BackgroundColor = Color.Default;
            }
        }

        private void Coffes_Tapped(object sender, EventArgs e)
        {
            var select = (MenuView)sender;
            if (select.BackgroundColor == Color.Default)
            {
                select.BackgroundColor = Color.Red;
            }
            else
            {
                select.BackgroundColor = Color.Default;
            }
        }

        private void Nearby_Tapped(object sender, EventArgs e)
        {
            var select = (MenuView)sender;
            if (select.BackgroundColor == Color.Default)
            {
                select.BackgroundColor = Color.Red;
            }
            else
            {
                select.BackgroundColor = Color.Default;
            }
        }

        private void FastFoods_Tapped(object sender, EventArgs e)
        {
            var select = (MenuView)sender;
            if (select.BackgroundColor == Color.Default)
            {
                select.BackgroundColor = Color.Red;
            }
            else
            {
                select.BackgroundColor = Color.Default;
            }
        }

        private void FeaturedFoods_Tapped(object sender, EventArgs e)
        {
            var select = (MenuView)sender;
            if (select.BackgroundColor == Color.Default)
            {
                select.BackgroundColor = Color.Red;
            }
            else
            {
                select.BackgroundColor = Color.Default;
            }
        }
      

    }
}