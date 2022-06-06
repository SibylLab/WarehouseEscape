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
    public partial class BinarySearchLearnigPage : ContentPage
    {
        public BinarySearchLearnigPage()
        {
            InitializeComponent();
            BinarySearchView.Source = "https://www.geeksforgeeks.org/binary-search/";
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}