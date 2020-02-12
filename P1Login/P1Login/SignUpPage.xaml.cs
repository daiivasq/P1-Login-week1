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
        public Page1(string userLogin)
        {
            InitializeComponent();
            EmailSignUp.Text = userLogin;
        }


        private async void ButtonSignUp_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserSignUp.Text) && String.IsNullOrEmpty(EmailSignUp.Text) && String.IsNullOrEmpty(PassWordSignUp.Text) && String.IsNullOrEmpty(RepeatPass.Text))
            { await DisplayAlert("ALERT!", "THERE ARE EMPTY FIELDS", "OK"); }
            else if (String.IsNullOrEmpty(EmailSignUp.Text))
            { await DisplayAlert("ALERT!", "THE FIELD EMAIL ADDRESS IS EMPTY", "OK"); }
            else if (String.IsNullOrEmpty(UserSignUp.Text)) { await DisplayAlert ("ALERT!", "THE FIELD USERNAME IS EMPTY", "OK"); }
            else if (String.IsNullOrEmpty(PassWordSignUp.Text)) { await DisplayAlert("ALERT!", "THE FIELD PASSWORD IS EMPTY", "OK"); }
            else if (String.IsNullOrEmpty(RepeatPass.Text)) {await DisplayAlert("ALERT!", "THE FIELD 'REPEAT PASSWORD' IS EMPTY", "OK"); }
            else if (PassWordSignUp.Text != RepeatPass.Text)  { await DisplayAlert("ALERT!", "THE PASSWORD ARE NOT EQUAL", "OK"); }
            else 
            {
                await DisplayAlert("WELCOME", "COMPLETE ", "OK");
                await Navigation.PushAsync(new MenuPage());
            }

        }

        private async void ButtonLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}