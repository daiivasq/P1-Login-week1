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
        public ICommand GestureBeerCommand { get; set; }
        public ICommand GestureDiningCommand { get; set; }
        public ICommand GestureCoffeCommand { get; set; }
        public ICommand GestureNearbyCommand { get; set; }
        public ICommand GestureFastFoodCommand { get; set; }
        public ICommand GestureFeaturedFoodCommand { get; set; }
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


            GestureBeerCommand = new Command(() => {
                if (ColorBeer == Color.White)
                {
                    ColorBeer = Color.Red;
                    ColorDining = ColorCoffe = ColorNearby = ColorFastFood = ColorFeatured = Color.White;

                }
                else
                {
                    ColorBeer = Color.White;
                }
            });
            GestureDiningCommand = new Command(() => {
                if (ColorDining == Color.White)
                {
                    ColorDining = Color.Red;
                    ColorBeer = ColorCoffe = ColorNearby = ColorFastFood = ColorFeatured = Color.White;

                }
                else
                {
                    ColorDining = Color.Red;
                }
            });
            GestureCoffeCommand = new Command(() => {

                if (ColorCoffe == Color.White)
                {
                     ColorCoffe = Color.Red;
                    ColorBeer = ColorDining = ColorNearby = ColorFastFood = ColorFeatured = Color.White;
                }
                else
                {
                    ColorCoffe = Color.White;
                }
            });
            GestureNearbyCommand = new Command(() => {

                if (ColorNearby == Color.White)
                {
                    ColorNearby = Color.Red;
                    ColorBeer = ColorDining = ColorCoffe = ColorFastFood = ColorFeatured = Color.White;
                }
                else
                {
                    ColorNearby = Color.White;
                }
            });
            GestureFastFoodCommand = new Command(() => {

                if (ColorFastFood == Color.White)
                {
                    ColorFastFood = Color.Red;
                   ColorBeer = ColorDining = ColorCoffe = ColorNearby = ColorFeatured = Color.White;
                }
                else
                {
                    ColorFastFood = Color.White;
                }
            });
            GestureFeaturedFoodCommand = new Command(() => {

                if (ColorFeatured == Color.White)
                {
                    ColorFeatured = Color.Red;
                    ColorBeer = ColorDining = ColorCoffe = ColorNearby = ColorFastFood = Color.White;
                }
                else
                {
                    ColorFeatured = Color.White;
                }
            });

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
