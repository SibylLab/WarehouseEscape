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
    public partial class EasyModePageFour : ContentPage
    {
        public static List<int> unsorted = new List<int>();
        private int slectedtItem;
        private int resultItem;
        private int NumberOfComare = 0;

        public EasyModePageFour()
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
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("", "Help Text add here .Online Grammar and Writing Checker To Help You Deliver Impeccable, Mistake-free Writing. Grammarly Has a Tool For Just About Every Kind Of Writing You Do. Try It Out For Yourself! AI Writing Assistant. Find and Add Sources Fast. Eliminate Grammar Errors."));
        }
        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new MediumModePageOne());
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
        }
        private int SelectedItemFromListRandomNumber()
        {
            var items = unsorted.Count;
            Random random = new Random();
            slectedtItem = random.Next(items);
            resultItem = unsorted.ElementAt(slectedtItem);

            return resultItem;
        }

        private int Search()
        {
            int val = unsorted.Count / 2;
            return val;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            unsorted.Clear();
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
        private int SearchCompare(List<int> arr, int x)
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
        private void LinearButton_Clicked(object sender, EventArgs e)
        {
            SearchCompare(unsorted, resultItem);
            var item = Search();
            int val = unsorted.ElementAt(item);
            if (val > 0)
            {
                IsItemFound(val, Color.Gold);
            }
            lblItemCompare.Text = "5";
            lblResulInfo.TextColor = Color.Red;
            lblResulInfo.Text = "Worng answer! Question asked the item to be find is in the middle of the list. It could be very a long list, so this algorithm is not a good choice.";
            BinaryButton.IsEnabled = false;
            LinearButton.IsEnabled = false;
            NextButton.IsEnabled = true;
            App.EasyModeScour -= 25;
            IsPassed();

        }
        private async void IsPassed()
        {
            int number = App.EasyModeScour;
            if (number > 50)
            {
              await  PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
              await this.Navigation.PushAsync(new MediumModePageOne());
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/WrongMessage.jpg", "Sorry your not complete this challenge!"));
            }
        
        }
        private void BinaryButton_Clicked(object sender, EventArgs e)
        {
            var item = Search();
            int value = unsorted.ElementAt(item);
            if (value > 0)
            {
                IsItemFound(value, Color.Gold);
            }
            lblItemCompare.Text = "1";
            lblResulInfo.TextColor = Color.Green;
            lblResulInfo.Text = "Correct answer!";
            BinaryButton.IsEnabled = false;
            LinearButton.IsEnabled = false;
            NextButton.IsEnabled = true;
            IsPassed();
        }
    }
}