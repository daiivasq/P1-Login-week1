using P1Login.Models;
using P1Login.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace P1Login.ViewModels
{
    public class DiscoveryyPageViewModel : INotifyPropertyChanged
    {
        public MenuModel Beer { get; set; }
        public MenuModel Dining { get; set; }
        public MenuModel Coffe { get; set; }
        public MenuModel Nearby { get; set; }
        public MenuModel FastFood { get; set; }
        public MenuModel FeaturedFood { get; set; }

        #region PROP COMMAND
      
        public ICommand GestureGenericCommand { get; set; }
        #endregion
        #region PROP COLOR
        public Color ColorBeer { get; set; }
        public Color ColorDining { get; set; }
        public Color ColorCoffe { get; set; }
        public Color ColorNearby { get; set; }
        public Color ColorFastFood { get; set; }

        public Color ColorFeatured { get; set; }
        #endregion


        public DiscoveryyPageViewModel()
        {
            Beer = new MenuModel();
            Dining = new MenuModel();
            Coffe = new MenuModel();
            Nearby = new MenuModel();
            FastFood = new MenuModel();
            FeaturedFood = new MenuModel();

            Beer.ImageModel = "beer.png";
            Beer.FirstText = "Bars And Hotels";
            Beer.SecondText = "42 place";
            Dining.ImageModel = "camarero.png";
            Dining.FirstText = "Fine Dining";
            Dining.SecondText = "16 place";
            Coffe.ImageModel = "coffe.png";
            Coffe.FirstText = "Cafes";
            Coffe.SecondText = "25 place";
            Nearby.ImageModel = "maps.png";
            Nearby.FirstText = "Nearby";
            Nearby.SecondText = "42 place";
            FastFood.ImageModel = "menu.png";
            FastFood.FirstText = "Fast Foods";
            FastFood.SecondText = "31 place";
            FeaturedFood.ImageModel = "pizza.png";
            FeaturedFood.FirstText = "Featured Foods";
            FeaturedFood.SecondText = "8 place";

         

            GestureGenericCommand = new Command((param) =>
            {
                ColorBeer = param == Beer ? Color.Red : Color.Default;
                ColorDining = param == Dining ? Color.Red : Color.Default;
                ColorCoffe = param == Coffe ? Color.Red : Color.Default;
                ColorNearby = param == Nearby ? Color.Red : Color.Default;
                ColorFastFood = param == FastFood ? Color.Red : Color.Default;
                ColorFeatured = param == FeaturedFood ? Color.Red : Color.Default;

              
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
