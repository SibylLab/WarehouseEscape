using WarehouseGameplay.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace WarehouseGameplay
{
    public partial class App : Application
    {
        public static int easyModeScour = 100;

        public static int EasyModeScour {
            get
            {
                return easyModeScour;
            }
            set
            {
                easyModeScour = value;
            }
        }

        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
