using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace P1Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage :Xamarin.Forms.TabbedPage
    {
        public MenuPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}