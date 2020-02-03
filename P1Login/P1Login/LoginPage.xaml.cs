using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1Login
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonLogIn_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserLogin.Text) && String.IsNullOrEmpty(PassWordLogin.Text))
            { await DisplayAlert("ALERT!", "THERE ARE EMPTY FIELDS", "OK"); }
            else if (String.IsNullOrEmpty(UserLogin.Text))
            { await DisplayAlert("ALERT!", "THE FIELD USERNAME IS EMPTY", "OK"); }
            else if (String.IsNullOrEmpty(PassWordLogin.Text))
            { await DisplayAlert("ALERT!", "THE FIELD PASSWORD IS EMPTY", "OK");}
            else
            {  await DisplayAlert("WELCOME", "COMPLETE", "OK");
            }
        }
    }
}
