using Acr.UserDialogs;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningPage : ContentPage
    {
        public LearningPage()
        {
            InitializeComponent();
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        private async void LinearSearhButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Linear Search Loding");
            await this.Navigation.PushModalAsync(new LinearSearchLearningPage());
            UserDialogs.Instance.HideLoading();
        }

        private async void BinarySearhButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Binary Searh Loding");
            await this.Navigation.PushModalAsync(new BinarySearchLearnigPage());
            UserDialogs.Instance.HideLoading();
        }

        private async void InsertionSortButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Insertion Sort Loding");
            await this.Navigation.PushModalAsync(new insertionsortLearningPage());
            UserDialogs.Instance.HideLoading();
        }

        private async void SelectionSorButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Selection Sort Loding");
            await this.Navigation.PushModalAsync(new SelectionSortLearningPage());
            UserDialogs.Instance.HideLoading();
        }

        private async void QuickSortButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Quick Sort Loding");
            await this.Navigation.PushModalAsync(new QuicksortLearnigPage());
            UserDialogs.Instance.HideLoading();
        }

        private async void MergeSortButton_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Merge Sort Loding");
            await this.Navigation.PushModalAsync(new MergesortLearnigPage());
            UserDialogs.Instance.HideLoading();
        }
    }
}