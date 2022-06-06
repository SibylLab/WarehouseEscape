using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LinearSearchLearningPage : ContentPage
    {
        public LinearSearchLearningPage()
        {
            InitializeComponent();
            LineerSearchView.Source = "https://www.geeksforgeeks.org/linear-search/";
            
        }

        private  async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}