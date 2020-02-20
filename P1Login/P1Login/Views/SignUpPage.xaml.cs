using P1Login.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1Login.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string userLogin)
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();
            EmailSignUp.Text = userLogin;
        }
    }
}