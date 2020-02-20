using P1Login.Models;
using P1Login.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace P1Login.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public UserModel User { get; set; }

        public ICommand ButtonLoginClicked_Command { get; set; }
        public ICommand ButtonSignUpClicked_Command { get; set; }
        public ICommand ButtonEyeClicked_Command { get; set; }
        public ImageSource ImageModel { get; set; }
        public bool IsVisible { get; set; }

        
        public LoginPageViewModel() 
        {
            User = new UserModel();

            ButtonLoginClicked_Command = new Command(async() => {
                if (String.IsNullOrEmpty(User.Name) && String.IsNullOrEmpty(User.Password))
                { await App.Current.MainPage.DisplayAlert("ALERT!", "THERE ARE EMPTY FIELDS", "OK"); }
                else if (String.IsNullOrEmpty(User.Name))
                { await App.Current.MainPage.DisplayAlert("ALERT!", "THE FIELD USERNAME IS EMPTY", "OK"); }
                else if (String.IsNullOrEmpty(User.Password))
                { await App.Current.MainPage.DisplayAlert("ALERT!", "THE FIELD PASSWORD IS EMPTY", "OK"); }
                else
                {
                    await App.Current.MainPage.DisplayAlert("WELCOME", "COMPLETE", "OK");

                    await App.Current.MainPage.Navigation.PushAsync(new MenuPage());
                }

            });
            ButtonSignUpClicked_Command = new Command(async() => {
                await App.Current.MainPage.Navigation.PushAsync(new Page1(User.Name));

            });

            IsVisible = true;
            ImageModel = "eye.png";
            ButtonEyeClicked_Command = new Command(() => {

                
                ImageModel =! IsVisible ? "eye.png" : "eye_off";
                IsVisible = !IsVisible;

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
