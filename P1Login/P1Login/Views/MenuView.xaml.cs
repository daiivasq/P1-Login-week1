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
    public partial class MenuView : ContentView
    {
        public static readonly BindableProperty ImageModelProperty = BindableProperty.Create(nameof(ImageModel), typeof(ImageSource), typeof(MenuView), default(ImageSource));
        public ImageSource ImageModel
        {
            get => (ImageSource)GetValue(MenuView.ImageModelProperty);
            set => SetValue(MenuView.ImageModelProperty, value);
        }

        public static readonly BindableProperty FirstTextProperty = BindableProperty.Create(nameof(FirstText),typeof(string),typeof(MenuView), String.Empty);

        public string FirstText
        {
            get => (string)GetValue(MenuView.FirstTextProperty);
            set => SetValue(MenuView.FirstTextProperty, value);
        }

        public static readonly BindableProperty SecondTextProperty = BindableProperty.Create(nameof(SecondText), typeof(string), typeof(MenuView), String.Empty);

        public string SecondText 
        {
            get => (string)GetValue(MenuView.SecondTextProperty);
            set => SetValue(MenuView.SecondTextProperty, value);
        }

        public MenuView()
        {
            InitializeComponent();
        }
    }
}