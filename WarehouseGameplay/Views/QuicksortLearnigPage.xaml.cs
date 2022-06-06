using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuicksortLearnigPage : ContentPage
    {
        public QuicksortLearnigPage()
        {
            InitializeComponent();
            QuicksortView.Source = "https://www.geeksforgeeks.org/iterative-quick-sort/";
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}