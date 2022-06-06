using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Rg.Plugins.Popup.Services;
using WarehouseGameplay.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EasyModePageThree : ContentPage
    {
        public static List<int> unsorted = new List<int>();
        private int slectedtItem;
        private int resultItem;
        private int NumberOfComare = 0;

        public EasyModePageThree()
        {
            InitializeComponent();


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
        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync(false);
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new EasyModePageFour());
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("", "Help Text add here .Online Grammar and Writing Checker To Help You Deliver Impeccable, Mistake-free Writing. Grammarly Has a Tool For Just About Every Kind Of Writing You Do. Try It Out For Yourself! AI Writing Assistant. Find and Add Sources Fast. Eliminate Grammar Errors."));
        }
        private void LoadData()
        {
            var randomPrice = RandomNumber.RandomVal();
            foreach (var random in randomPrice)
            {
                unsorted.Add(random);
            }
            unsorted.Sort();
            for (int i = 0; i < unsorted.Count; i++)
            {
                try
                {
                    PriceIndex1.Text = unsorted[0].ToString();
                    PriceIndex3.Text = unsorted[2].ToString();
                    PriceIndex2.Text = unsorted[1].ToString();
                    PriceIndex6.Text = unsorted[5].ToString();
                    PriceIndex7.Text = unsorted[6].ToString();
                    PriceIndex4.Text = unsorted[3].ToString();
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
            var item = Search(unsorted, resultItem);
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

            //lblItemCompare.Text = NumberOfComare.ToString();
            //lblResulInfo.TextColor = Color.Red;
            //lblResulInfo.Text = "Worng answer!";
            //BinaryButton.IsEnabled = false;
            //LinearButton.IsEnabled = false;
            //NextButton.IsEnabled = true;
            //App.EasyModeScour -= 25;

        }
        private int BinarySearch(List<int> arr, int l,
                             int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                NumberOfComare++;
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return BinarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }
        private void BinaryButton_Clicked(object sender, EventArgs e)
        {
            var val = BinarySearch(unsorted, 0, unsorted.Count - 1, resultItem);
            int value = unsorted.ElementAt(slectedtItem);
            if (value > 0)
            {
                IsItemFound(value, Color.Gold);
            }
            lblItemCompare.Text = NumberOfComare.ToString();
            lblResulInfo.TextColor = Color.Green;
            lblResulInfo.Text = "Correct answer!";
            BinaryButton.IsEnabled = false;
            LinearButton.IsEnabled = false;
            NextButton.IsEnabled = true;

            //lblItemCompare.Text = NumberOfComare.ToString();
            //lblResulInfo.TextColor = Color.Red;
            //lblResulInfo.Text = "Worng answer!";
            //BinaryButton.IsEnabled = false;
            //LinearButton.IsEnabled = false;
            //NextButton.IsEnabled = true;
            //App.EasyModeScour -= 25;
        }
    }
}