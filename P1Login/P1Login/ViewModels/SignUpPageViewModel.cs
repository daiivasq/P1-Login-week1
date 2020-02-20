using P1Login.Models;
using P1Login.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace P1Login.ViewModels
{
   public class SignUpPageViewModel
    {
        public UserModel User { get; set; }
        public ICommand ButtonSignUpClicked_Command { get; set; }
        public ICommand ButtonLogin_Command { get; set; }
        public SignUpPageViewModel()
        {
            User = new UserModel();
            ButtonSignUpClicked_Command = new Command(async () => {
                if (String.IsNullOrEmpty(User.Name) && String.IsNullOrEmpty(User.EmailAdress) && String.IsNullOrEmpty(User.Password) && String.IsNullOrEmpty(User.RepeatPassword))
                { await App.Current.MainPage.DisplayAlert("ALERT!", "THERE ARE EMPTY FIELDS", "OK"); }
                else if (String.IsNullOrEmpty(User.EmailAdress))
                { await App.Current.MainPage.DisplayAlert("ALERT!", "THE FIELD EMAIL ADDRESS IS EMPTY", "OK"); }
                else if (String.IsNullOrEmpty(User.Name)) { await App.Current.MainPage.DisplayAlert("ALERT!", "THE FIELD USERNAME IS EMPTY", "OK"); }
                else if (String.IsNullOrEmpty(User.Password)) { await App.Current.MainPage.DisplayAlert("ALERT!", "THE FIELD PASSWORD IS EMPTY", "OK"); }
                else if (String.IsNullOrEmpty(User.RepeatPassword)) { await App.Current.MainPage.DisplayAlert("ALERT!", "THE FIELD 'REPEAT PASSWORD' IS EMPTY", "OK"); }
                else if (User.Password != User.RepeatPassword) { await App.Current.MainPage.DisplayAlert("ALERT!", "THE PASSWORD ARE NOT EQUAL", "OK"); }
                else
                {
                    await App.Current.MainPage.DisplayAlert("WELCOME", "COMPLETE ", "OK");
                    await App.Current.MainPage.Navigation.PushAsync(new MenuPage());
                }

            });
            ButtonLogin_Command = new Command(async () => {
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            });
        }
    }
}
