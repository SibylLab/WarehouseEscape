using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class insertionsortLearningPage : ContentPage
    {
        public insertionsortLearningPage()
        {
            InitializeComponent();
            InsertionSortView.Source = "https://www.geeksforgeeks.org/recursive-insertion-sort/";
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}