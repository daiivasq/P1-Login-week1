using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        private async void ButtonSignUp_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserSignUp.Text) && String.IsNullOrEmpty(PassWordSignUp.Text))
            {
                await DisplayAlert("ALERT!", "THERE ARE EMPTY FIELDS", "OK");
            }
            else if (PassWordSignUp.Text.Equals(RepeatPass.Text))
            {
                await DisplayAlert("ALERT!", "THE FIELDS ARE NOT EQUAL", "OK");

            }
           else
            {
                await DisplayAlert("WELCOME", " ", "OK");
            }

            
        }
    }
}