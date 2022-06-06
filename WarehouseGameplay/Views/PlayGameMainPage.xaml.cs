using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;
using Xamarin.Essentials;
using Rg.Plugins.Popup.Services;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayGameMainPage : ContentPage
    {
        public PlayGameMainPage()
        {
            InitializeComponent();
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CheckLevelIsLocked();
        }
        private async void LinearSearchButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Binary Search Loading");
            await this.Navigation.PushModalAsync(new LinearSearchPage());
            UserDialogs.Instance.HideLoading();

        }
        private int CheckLevelIsLocked()
        {
            var accessToken = Preferences.Get("accessToken", string.Empty);
           
            if (accessToken == "One")
            {
                lblMissionTwo.Text = string.Empty;
                lblMissionTwo.Text = "🔐";
                return 1;
            }
            else if (accessToken == "Two")
            {
                lblMissionThree.Text = string.Empty;
                lblMissionThree.Text = "🔐";
                return 2;
            }
            else if (accessToken == "Three")
            {
                lblMissionFour.Text = string.Empty;
                lblMissionFour.Text = "🔐";
                return 3;
            }
            else if (accessToken == "Four")
            {
                lblMissionFive.Text = string.Empty;
                lblMissionFive.Text = "🔐";
                return 4;
            }
            else if (accessToken == "Five")
            {
                lblMissionSix.Text = string.Empty;
                lblMissionSix.Text = "🔐";
                return 5;
            }
            else if (accessToken == null)
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "You need to compare product first to swap thanks!"));
                return 0;
            }
            else
            {
                return 0;
            }
        }

        private async void BinarySearchButton_Clicked(object sender, EventArgs e)
        {
            
           
            if (CheckLevelIsLocked() == 1)
            {

                UserDialogs.Instance.ShowLoading("Linear Search Loading");
                await this.Navigation.PushModalAsync(new BinarySearchPage());
                UserDialogs.Instance.HideLoading();
            }
            else
            {
              await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "Hi you need to unlock mission!"));
            }
        }

        private async void InsertionSortButton_Clicked(object sender, EventArgs e)
        {
            if (CheckLevelIsLocked() == 2)
            {
                UserDialogs.Instance.ShowLoading("Insertion Sort Loading");
                await this.Navigation.PushModalAsync(new InsertionSortPage());
                UserDialogs.Instance.HideLoading();
            }
            else
            {
              await  PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "Hi you need to unlock mission!"));
            }
        }

        private async void SelectionSortButton_Clicked(object sender, EventArgs e)
        {
            if (CheckLevelIsLocked() == 3)
            {
                UserDialogs.Instance.ShowLoading("Selection Sort Loading");
                await this.Navigation.PushModalAsync(new SelectionSortingPage());
                UserDialogs.Instance.HideLoading();
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "Hi you need to unlock mission!"));
            }
           
        }

        private async void QuickSortButton_Clicked(object sender, EventArgs e)
        {
            if (CheckLevelIsLocked() == 4)
            {
                UserDialogs.Instance.ShowLoading("Quick Sort Loading");
                await this.Navigation.PushModalAsync(new QuickSortPage());
                UserDialogs.Instance.HideLoading();
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "Hi you need to unlock mission!"));
            }
            
        }
        private async void MergeSorButton_Clicked(object sender, EventArgs e)
        {
            if (CheckLevelIsLocked() == 5)
            {

                UserDialogs.Instance.ShowLoading("Merge Sort Loading");
                await Navigation.PushModalAsync(new MergeSorytPage());
                UserDialogs.Instance.HideLoading();
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "You need to compere product first to swap thanks!"));
            }
        }

        private async void RoboVsPlayerButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Robo Vs Player");
            await Navigation.PushModalAsync(new EasyModePage());
            UserDialogs.Instance.HideLoading();
        }
    }
}