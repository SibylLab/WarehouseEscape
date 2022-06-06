using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WarehouseGameplay.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LinearSearchPage : ContentPage
    {
        public static List<int> unsorted = new List<int>();
        private int NumberOfCompare = 0;
        private string SelectedIndexVal = "";

        private int resultItem;
        private int slectedtItem;


        public LinearSearchPage()
        {
            InitializeComponent();
            LoadData();
            NextButton.IsEnabled = false;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Q1.png", ""));
                return false;
            });
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
            lblSelectedItem.Text = SelectedItemFromListRandomNumber().ToString();
        }
        private  int  SelectedItemFromListRandomNumber()
        {
            var items = unsorted.Count;
            Random random = new Random();
            slectedtItem =  random.Next(items);
            resultItem = unsorted.ElementAt(slectedtItem);
           
            return resultItem;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ResetUI();
            unsorted.Clear();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LearnLinearSearhQuizButton.IsEnabled = false;
            
        }
        private Task UnlockQuizKey()
        {
            if (lblKey.Text != "")
            {
                LearnLinearSearhQuizButton.IsEnabled = true;
            }

            return Task.CompletedTask;
        }
        private void ResetUI()
        {

            lblSelectedItem.Text = "";
            lblItemIndex.Text = "";
            unsorted.Clear();
            LoadData();
            lblNuberOfCompere.Text = string.Empty;
            lblSelectedItemOutPut.Text = string.Empty;
            lblUnsortedList.Text = string.Empty;
            NumberOfCompare = 0;
            SelectedIndexVal = "";
            resultItem = 0;
            slectedtItem = 0;
            lblKey.Text = "";
            Frame_1.BackgroundColor = Color.LightGreen;
            Frame_2.BackgroundColor = Color.LightGreen;
            Frame_3.BackgroundColor = Color.LightGreen;
            Frame_4.BackgroundColor = Color.LightGreen;
            Frame_5.BackgroundColor = Color.LightGreen;
            Frame_6.BackgroundColor = Color.LightGreen;
            Frame_7.BackgroundColor = Color.LightGreen;
            Frame_8.BackgroundColor = Color.LightGreen;

            PriceIndex1.TextColor = Color.LightGreen;
            PriceIndex2.TextColor = Color.LightGreen;
            PriceIndex3.TextColor = Color.LightGreen;
            PriceIndex4.TextColor = Color.LightGreen;
            PriceIndex5.TextColor = Color.LightGreen;
            PriceIndex6.TextColor = Color.LightGreen;
            PriceIndex7.TextColor = Color.LightGreen;
            PriceIndex8.TextColor = Color.LightGreen;
        }

        private async void CompareButton_Clicked(object sender, EventArgs e)
        {
            if (SelectedIndexVal != "")
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", "The required Item is successfuly find in this list."));
            }
            else
            {
                LinearSearchUIHandler();
                CheakIsCompered();
                if (SelectedIndexVal != "")
                {
                    await IsComperedBackgrounColor();
                    int index = unsorted.IndexOf(Convert.ToInt32(lblSelectedItem.Text));
                    lblItemIndex.Text = index.ToString();
                    await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
                }
                Key();
               await UnlockQuizKey();
            }
        }
        private void LinearSearchUIHandler()
        {
            if (NumberOfCompare == 0 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.Gold;
                if (PriceIndex1.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex1.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex1.Text;
                }
            }
            else if (NumberOfCompare == 1 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue; 
                Frame_2.BackgroundColor = Color.Gold;
                if (PriceIndex2.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex2.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex2.Text;
                }
            }
            else if (NumberOfCompare == 2 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.Gold;
                if (PriceIndex3.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex3.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex3.Text;
                    PriceIndex4.TextColor = Color.Black;
                }
            }
            else if (NumberOfCompare == 3 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.Gold;
                if (PriceIndex4.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex4.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex4.Text;
                    PriceIndex5.TextColor = Color.Black;
                }
            }
            else if (NumberOfCompare == 4 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.LightBlue;
                Frame_5.BackgroundColor = Color.Gold;
                if (PriceIndex5.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex5.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex5.Text;
                }
            }
            else if (NumberOfCompare == 5 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.LightBlue;
                Frame_5.BackgroundColor = Color.LightBlue;
                Frame_6.BackgroundColor = Color.Gold;
                if (PriceIndex6.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex6.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex6.Text;
                    PriceIndex6.TextColor = Color.Black;
                }
            }
            else if (NumberOfCompare == 6 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.LightBlue;
                Frame_5.BackgroundColor = Color.LightBlue;
                Frame_6.BackgroundColor = Color.LightBlue;
                Frame_7.BackgroundColor = Color.Gold;
                if (PriceIndex7.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex7.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex7.Text;
                }
            }
            else if (NumberOfCompare == 7 && SelectedIndexVal == "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.LightBlue;
                Frame_5.BackgroundColor = Color.LightBlue;
                Frame_6.BackgroundColor = Color.LightBlue;
                Frame_7.BackgroundColor = Color.LightBlue;
                Frame_8.BackgroundColor = Color.Gold;
                if (PriceIndex8.Text != lblSelectedItem.Text)
                {
                    NumberOfCompare++;
                    PriceIndex8.TextColor = Color.Black;
                }
                else
                {
                    SelectedIndexVal = PriceIndex8.Text;
                }
            }
        }
        private void CheakIsCompered()
        {
            if (SelectedIndexVal != "")
            {
                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.LightBlue;
                Frame_5.BackgroundColor = Color.LightBlue;
                Frame_6.BackgroundColor = Color.LightBlue;
                Frame_7.BackgroundColor = Color.LightBlue;
                Frame_8.BackgroundColor = Color.LightBlue;

                PriceIndex1.TextColor = Color.Black;
                PriceIndex2.TextColor = Color.Black;
                PriceIndex3.TextColor = Color.Black;
                PriceIndex4.TextColor = Color.Black;
                PriceIndex5.TextColor = Color.Black;
                PriceIndex6.TextColor = Color.Black;
                PriceIndex7.TextColor = Color.Black;
                PriceIndex8.TextColor = Color.Black;
                NumberOfCompare += 1;
                lblNuberOfCompere.Text = NumberOfCompare.ToString();
                lblSelectedItemOutPut.Text = lblSelectedItem.Text;
                NextButton.IsEnabled = true;
                lblItemIndex.Text = slectedtItem.ToString();

            }
        }
        private Task IsComperedBackgrounColor()
        {
            if (PriceIndex1.Text == lblSelectedItem.Text)
            {
                Frame_1.BackgroundColor = Color.Gold;
            }
            if (PriceIndex2.Text == lblSelectedItem.Text)
            {
                Frame_2.BackgroundColor = Color.Gold;
            }
            if (PriceIndex3.Text == lblSelectedItem.Text)
            {
                Frame_3.BackgroundColor = Color.Gold;
            }
            if (PriceIndex4.Text == lblSelectedItem.Text)
            {
                Frame_4.BackgroundColor = Color.Gold;
            }
            if (PriceIndex5.Text == lblSelectedItem.Text)
            {
                Frame_5.BackgroundColor = Color.Gold;
            }
            if (PriceIndex6.Text == lblSelectedItem.Text)
            {
                Frame_6.BackgroundColor = Color.Gold;
            }
            if (PriceIndex7.Text == lblSelectedItem.Text)
            {
                Frame_7.BackgroundColor = Color.Gold;
            }
            if (PriceIndex8.Text == lblSelectedItem.Text)
            {
                Frame_8.BackgroundColor = Color.Gold;
            }
            return Task.CompletedTask;
        }

        private void Key()
        {
            if (SelectedIndexVal != "")
            {
                lblKey.Text = "Use this key complete Quiz open lock  start next lavel [ 🔑 ]";
            }
        }
        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            ResetUI();
        }

        private async void LearnLinearSearhButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new LinearSearchLearningPage());
        }

        private async void LearnLinearSearhQuizButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LinearSearchQuizPage());
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new BinarySearchPage());
        }

        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Linearhelp.png", ""));
        }
    }
}