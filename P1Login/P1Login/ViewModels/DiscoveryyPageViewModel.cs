using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace P1Login.ViewModels
{
    public class DiscoveryyPageViewModel : INotifyPropertyChanged
    {
        #region PROP COMMAND
        public ICommand GestureBeerCommand { get; set; }
        public ICommand GestureDiningCommand { get; set; }
        public ICommand GestureCoffeCommand { get; set; }
        public ICommand GestureNearbyCommand { get; set; }
        public ICommand GestureFastFoodCommand { get; set; }
        public ICommand GestureFeaturedFoodCommand { get; set; }
        #endregion
        #region PROP COLOR
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }
        public Color Color4 { get; set; }
        public Color Color5 { get; set; }

        public Color Color6 { get; set; }
        #endregion

        public DiscoveryyPageViewModel()
        {
            
            GestureBeerCommand = new Command(() => {

                if (Color1 == Color.Default)
                {
                    Color1 = Color.Red;
                    Color2 = Color3 = Color4 = Color5 = Color6 = Color.Default;
                }
                else
                {
                    Color1 = Color.Red;
                  
                    
                }
            });
            GestureDiningCommand = new Command(() => {

                if (Color2 == Color.Default)
                {
                    Color2 = Color.Red;
                    Color1 = Color3 = Color4 = Color5 = Color6 = Color.Default;
                }
                else
                {
                    Color2 = Color.Red;

                }
            });
            GestureCoffeCommand = new Command(() => {

                if (Color3 == Color.Default)
                {
                    Color3 = Color.Red;
                    Color1 = Color2 = Color4 = Color5 = Color6 = Color.Default;
                }
                else
                {
                    Color3 = Color.Default;

                }
            });
            GestureNearbyCommand = new Command(() => {

                if (Color4 == Color.Default)
                {
                    Color4 = Color.Red;
                    Color1 = Color2 = Color3 = Color5 = Color6 = Color.Default;
                }
                else
                {
                    Color4 = Color.Default;
                }
            }); GestureFastFoodCommand = new Command(() => {

                if (Color5 == Color.Default)
                {
                    Color5 = Color.Red;
                    Color1 = Color2 = Color3 = Color4 = Color6 = Color.Default;
                }
                else
                {

                    Color5 = Color.Default;
                }
            }); GestureFeaturedFoodCommand = new Command(() => {

                if (Color6 == Color.Default)
                {
                    Color6 = Color.Red;
                    Color1 = Color2 = Color3 = Color4 = Color5 = Color.Default;
                }
                else
                {
                    Color6 = Color.Default;
                }
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
