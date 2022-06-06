using WarehouseGameplay.ViewModels;
using Xamarin.Forms;

namespace WarehouseGameplay
{
    public partial class MainPage : ContentPage
    {
        Page onboardingPage;
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new PlayGameMainPageViewModel(Navigation);

            if (ShouldShowOnboarding() == true)
            {
                App.Current.ModalPopping += Current_ModalPopping;
                onboardingPage = new OnboardingPage();
                Navigation.PushModalAsync(onboardingPage, false);
            }
        }

        private void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            if (e.Modal == onboardingPage)
            {
                FadeBox.FadeTo(0, 400);
                onboardingPage = null;
                App.Current.ModalPopping -= Current_ModalPopping;
            }
        }

        private bool ShouldShowOnboarding()
        {
            return true;
            //return VersionTracking.IsFirstLaunchEver;
        }

        private  void ExitButton_Clicked(object sender, System.EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
