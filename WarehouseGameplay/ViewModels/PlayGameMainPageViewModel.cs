using WarehouseGameplay.Views;
using MvvmHelpers;
using System;
using Xamarin.Forms;

namespace WarehouseGameplay.ViewModels
{
    public class PlayGameMainPageViewModel : BaseViewModel
    {
        public Command NaveGateToPlayGameMainPageCommand { get; set; }
        public Command NaveGateToPlayLearnPageCommand { get; set; }
        public INavigation Navigation { get; set; }

        public PlayGameMainPageViewModel(INavigation  navigation)
        {
            Navigation = navigation;
            NaveGateToPlayGameMainPageCommand = new Command(await =>  NaveGateToPlayGameMainPage());
            NaveGateToPlayLearnPageCommand = new Command(await => NaveGateToPlayLearnPage());
        }

        private async void NaveGateToPlayLearnPage()
        {
            await Navigation.PushModalAsync(new LearningPage());
        }

        private async void NaveGateToPlayGameMainPage()
        {
            await Navigation.PushAsync(new LinearSearchPage());
        }
    }
}
