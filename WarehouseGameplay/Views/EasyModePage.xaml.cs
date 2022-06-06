using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using WarehouseGameplay.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EasyModePage : ContentPage
    {
        public static List<int> unsorted = new List<int>();
        private int slectedtItem;
        private int resultItem;
        private int NumberOfComare = 0;

        public EasyModePage()
        {
            InitializeComponent();
            App.EasyModeScour = 100;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/EASY_Medium.png", ""));
                return false;
            });
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync(false);
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Easy_S.png", ""));
        }
        private async void NextButton_Clicked(object sender, EventArgs e)
        {
           await this.Navigation.PushAsync(new EasyModePageTwo());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            unsorted.Clear();
            BinaryButton.IsEnabled = true;
            LinearButton.IsEnabled = true;
            lblItemCompare.Text = string.Empty;
            lblResulInfo.Text = string.Empty;
            lblUnsortedList.Text = string.Empty;

            LoadData();
        }
        private void LoadData()
        {
            var randomPrice = RandomNumber.RandomVal();
            foreach (var random in randomPrice)
            {
                unsorted.Add(random);
            }
            for (int i = 0; i < unsorted.Count; i++)
            {
                try
                {
                    PriceIndex2.Text = unsorted[1].ToString();
                    PriceIndex1.Text = unsorted[0].ToString();
                    PriceIndex4.Text = unsorted[3].ToString();
                    PriceIndex3.Text = unsorted[2].ToString();
                    PriceIndex6.Text = unsorted[5].ToString();
                    PriceIndex7.Text = unsorted[6].ToString();
                    PriceIndex5.Text = unsorted[4].ToString();
                    PriceIndex8.Text = unsorted[7].ToString();
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex.ToString());
                }
                lblUnsortedList.Text = "";
                foreach (var item in unsorted)
                {
                    lblUnsortedList.Text = lblUnsortedList.Text + item.ToString() + ",";
                }
            }
            lblPrice.Text = SelectedItemFromListRandomNumber().ToString();
        }
        private int SelectedItemFromListRandomNumber()
        {
            var items = unsorted.Count;
            Random random = new Random();
            slectedtItem = random.Next(items);
            resultItem = unsorted.ElementAt(slectedtItem);

            return resultItem;
        }

        private int Search(List<int> arr, int x)
        {
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                NumberOfComare++;
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        private void IsItemFound(int val, Color color)
        {
            if (Convert.ToInt32(PriceIndex1.Text) == val)
            {
                Frame_1.BackgroundColor = color;
                PriceIndex1.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex2.Text) == val)
            {
                Frame_2.BackgroundColor = color;
                PriceIndex2.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex3.Text) == val)
            {
                Frame_3.BackgroundColor = color;
                PriceIndex3.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex4.Text) == val)
            {
                Frame_4.BackgroundColor = color;
                PriceIndex4.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex5.Text) == val)
            {
                Frame_5.BackgroundColor = color;
                PriceIndex5.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex6.Text) == val)
            {
                Frame_6.BackgroundColor = color;
                PriceIndex6.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex7.Text) == val)
            {
                Frame_7.BackgroundColor = color;
                PriceIndex7.TextColor = Color.Black;
            }
            else if (Convert.ToInt32(PriceIndex8.Text) == val)
            {
                Frame_8.BackgroundColor = color;
                PriceIndex8.TextColor = Color.Black;
            }
        }
        private void LinearButton_Clicked(object sender, EventArgs e)
        {
          var item =   Search(unsorted, resultItem);
            int val = unsorted.ElementAt(slectedtItem);
            if (val > 0)
            {
                IsItemFound(val, Color.Gold);
            }
            lblItemCompare.Text = NumberOfComare.ToString();
            lblResulInfo.TextColor = Color.Green;
            lblResulInfo.Text = "Correct answer!";
            BinaryButton.IsEnabled = false;
            LinearButton.IsEnabled = false;
            NextButton.IsEnabled = true;

        }

        private void BinaryButton_Clicked(object sender, EventArgs e)
        {
            lblItemCompare.Text = "infinity";
            lblResulInfo.TextColor = Color.Red;
            lblResulInfo.Text = "Binary search can not be applied on an unsorted list.";
            BinaryButton.IsEnabled = false;
            LinearButton.IsEnabled = false;
            NextButton.IsEnabled = true;
            App.EasyModeScour -= 25;
        }
    }
}