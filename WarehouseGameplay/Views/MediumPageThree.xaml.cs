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
    public partial class MediumModePageThree : ContentPage
    {
        public static List<int> unsorted = new List<int>();
        private int slectedtItem;
        private int resultItem;
        private int NumberOfComare = 0;
        public List<string> SortList {
            get; set;
        }
        public List<string> SearchList {
            get; set;
        }
        public MediumModePageThree()
        {
            InitializeComponent();
            App.EasyModeScour = 100;

            SortList = new List<string>();
            SortList.Add("None");
            SortList.Add("Insertion Sort");
            SortList.Add("Selection Sort");
            SortList.Add("Merge Sort");
            SortList.Add("Quick Sort");
            SortPicker.ItemsSource = SortList;

            SearchList = new List<string>();
            SearchList.Add("Linear Search");
            SearchList.Add("Binary Search");
            SearchPicker.ItemsSource = SearchList;
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync(false);
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new MediumModePageFour());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            unsorted.Clear();
            lblSelectedSearch.Text = string.Empty;
            lblSelectedSort.Text = string.Empty;
            lblResulInfo.Text = string.Empty;
            lblUnsortedList.Text = string.Empty;
            SortPicker.IsEnabled = true;
            SearchPicker.IsEnabled = true;
            NextButton.IsEnabled = false;

            LoadData();
        }
        private void LoadData()
        {
            var randomPrice = RandomNumber.RandomVal();
            randomPrice.Sort();
            foreach (var random in randomPrice)
            {
                unsorted.Add(random);
            }
            for (int i = 0; i < unsorted.Count; i++)
            {
                try
                {

                    PriceIndex1.Text = unsorted[0].ToString();
                    PriceIndex2.Text = unsorted[1].ToString();
                    PriceIndex3.Text = unsorted[2].ToString();
                    PriceIndex4.Text = unsorted[3].ToString();
                    PriceIndex5.Text = unsorted[4].ToString();
                    PriceIndex6.Text = unsorted[5].ToString();
                    PriceIndex7.Text = unsorted[6].ToString();
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
            var items = 2;
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
        private string SelectedSort;
        private int SelectedNumber()
        {
            unsorted.Sort();
            Search(unsorted, Convert.ToInt32(lblPrice.Text));
            lblNumberOfComare.Text = NumberOfComare.ToString();
            NextButton.IsEnabled = true;
            return Convert.ToInt32(lblPrice.Text);
        }
        private void Sorting_Clicked(object sender, EventArgs e)
        {
            SelectedSort = SortPicker.SelectedItem.ToString();
        }
        private async void Searching_Clicked(object sender, EventArgs e)
        {
            if (SortPicker.SelectedItem == null || SearchPicker.SelectedItem == null)
            {
                await DisplayAlert("Wrong!", "Please select both fields!!", "Ok");
            }
            else
            {
                if (SelectedSort == "None" && SearchPicker.SelectedItem.ToString() == "Linear Search")
                {
                    lblSelectedSort.Text = SortPicker.SelectedItem.ToString();
                    lblSelectedSearch.Text = SearchPicker.SelectedItem.ToString();
                    lblResulInfo.Text = "Your anwser is correct ";
                    lblResulInfo.TextColor = Color.Green;
                    IsItemFound(SelectedNumber(), Color.Yellow);
                    SortPicker.IsEnabled = false;
                    SearchPicker.IsEnabled = false;
                    NextButton.IsEnabled = true;
                }
                else
                {
                    lblSelectedSort.Text = SortPicker.SelectedItem.ToString();
                    lblSelectedSearch.Text = SearchPicker.SelectedItem.ToString();
                    lblResulInfo.Text = "Your anwser is wrong";
                    lblResulInfo.TextColor = Color.Red;
                    IsItemFound(SelectedNumber(), Color.Yellow);
                    NextButton.IsEnabled = true;
                    SortPicker.IsEnabled = false;
                    SearchPicker.IsEnabled = true;
                }
            }
            
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("", "Help Text add here .Online Grammar and Writing Checker To Help You Deliver Impeccable, Mistake-free Writing. Grammarly Has a Tool For Just About Every Kind Of Writing You Do. Try It Out For Yourself! AI Writing Assistant. Find and Add Sources Fast. Eliminate Grammar Errors."));
        }
    }
}