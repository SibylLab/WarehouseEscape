using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using WarehouseGameplay.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectionSortingPage : ContentPage
    {
        public  List<int> unsorted = new List<int>();
        public List<int> sortedList = new List<int>();

        private int NumberOfCompere = 0;
        private int NumberOfSwap = 0;
        private int CheakCount = 0;
       
        public SelectionSortingPage()
        {
            InitializeComponent();
            NextButton.IsEnabled = false;
            LoadData();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Q4.png", ""));
                return false;
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            unsorted.Clear();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LearnInsertionSortQuizButton.IsEnabled = false;
            CompareButton.IsEnabled = false;
            SwapButton.IsEnabled = false;
        }
        private void LoadData()
        {
            var rendomPrice = RandomNumber.RandomVal();
            foreach (var rendom in rendomPrice)
            {
                unsorted.Add(rendom);
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
                sortedList.Clear();
                foreach(var item in unsorted)
                {
                    sortedList.Add(item);
                }
            }
        }
        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        private void ResetValue()
        {
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
            }
        }
       
        private void DoSameBack()
        {
            Frame_1.BackgroundColor = Color.LightGreen;
            Frame_2.BackgroundColor = Color.LightGreen;
            Frame_3.BackgroundColor = Color.LightGreen;
            Frame_4.BackgroundColor = Color.LightGreen;
            Frame_5.BackgroundColor = Color.LightGreen;
            Frame_6.BackgroundColor = Color.LightGreen;
            Frame_7.BackgroundColor = Color.LightGreen;
            Frame_8.BackgroundColor = Color.LightGreen;
        }

        private void IsItemFound(int val)
        {
            if (Convert.ToInt32(PriceIndex1.Text) == val)
            {
                Frame_1.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex2.Text) == val)
            {
                Frame_2.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex3.Text) == val)
            {
                Frame_3.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex4.Text) == val)
            {
                Frame_4.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex5.Text) == val)
            {
                Frame_5.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex6.Text) == val)
            {
                Frame_6.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex7.Text) == val)
            {
                Frame_7.BackgroundColor = Color.HotPink;
            }
            else if (Convert.ToInt32(PriceIndex8.Text) == val)
            {
                Frame_8.BackgroundColor = Color.HotPink;
            }
        }
        private async void CompareButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 1)
            {
                Frame_1.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 2)
            {
                Frame_2.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 3)
            {
                Frame_3.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 4)
            {
                Frame_4.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 5)
            {
                Frame_5.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 6)
            {
                Frame_6.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 7)
            {
                Frame_7.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            if (CheakCount == 8)
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
                Frame_8.BackgroundColor = Color.LightPink;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
        }
        private async void SwapButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 1)
            {
               if (MinValue < Convert.ToInt32(PriceIndex1.Text))
               {
                    int price = Convert.ToInt32(PriceIndex1.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex1.Text = MinValue.ToString();
               }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 2)
            {
                if (MinValue < Convert.ToInt32(PriceIndex2.Text))
                {

                    int price = Convert.ToInt32(PriceIndex2.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex2.Text = MinValue.ToString();
                }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 3)
            {
                if (MinValue < Convert.ToInt32(PriceIndex3.Text))
                {

                    int price = Convert.ToInt32(PriceIndex3.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex3.Text = MinValue.ToString();
                }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 4)
            {
                if (MinValue < Convert.ToInt32(PriceIndex4.Text))
                {

                    int price = Convert.ToInt32(PriceIndex4.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex4.Text = MinValue.ToString();
                }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 5)
            {
                if (MinValue < Convert.ToInt32(PriceIndex5.Text))
                {

                    int price = Convert.ToInt32(PriceIndex5.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex5.Text = MinValue.ToString();
                }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 6)
            {
                if (MinValue < Convert.ToInt32(PriceIndex6.Text))
                {

                    int price = Convert.ToInt32(PriceIndex6.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex6.Text = MinValue.ToString();
                }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 6)
            {
                if (MinValue < Convert.ToInt32(PriceIndex6.Text))
                {

                    int price = Convert.ToInt32(PriceIndex6.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex6.Text = MinValue.ToString();
                }
                DoSameBack();

                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = true;
            }
            else if (CheakCount == 7)
            {
                if (MinValue < Convert.ToInt32(PriceIndex7.Text))
                {

                    int price = Convert.ToInt32(PriceIndex7.Text);
                    IsItemSwaped(MinValue, price);
                    PriceIndex7.Text = MinValue.ToString();
                }
                
                unsorted.Sort();
                foreach (var item in unsorted)
                {
                    lblSortedList.Text = lblSortedList.Text + item.ToString() + ",";
                }
                SwapButton.IsEnabled = false;
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = false;
                LearnInsertionSortQuizButton.IsEnabled = true;
                DoSameBack();
                lblItemSwap.Text = NumberOfSwap.ToString();
                lblNuberOfCompare.Text = NumberOfCompere.ToString();
                await Key();
                await UnlockQuizKey();
                NextButton.IsEnabled = true;
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
            }
        }

        Color minValueColor = Color.YellowGreen;
        private int MinValue = 0;
        private void SelectButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 0)
            {
                MinValue = 0;
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 1)
            {
                MinValue = 0;
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 2)
            {
                MinValue = 0;
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 3)
            {
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 4)
            {
                MinValue = 0;
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 5)
            {
                MinValue = 0;
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 6)
            {
                MinValue = 0;
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 7)
            {
                MinValue = sortedList.AsQueryable().Min();
                IsItemFound(MinValue, minValueColor);
                var index = sortedList.IndexOf(MinValue);
                sortedList.RemoveAt(index);
                SelectButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
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
        private void IsItemSwaped(int val, int val2)
        {
            if (Convert.ToInt32(PriceIndex1.Text) == val)
            {
                PriceIndex1.Text = val2.ToString();
                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex2.Text) == val)
            {
                PriceIndex2.Text = val2.ToString();
                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex3.Text) == val)
            {
                PriceIndex3.Text = val2.ToString();

                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex4.Text) == val)
            {
                PriceIndex4.Text = val2.ToString();
                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex5.Text) == val)
            {
                PriceIndex5.Text = val2.ToString();
                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex6.Text) == val)
            {
                PriceIndex6.Text = val2.ToString();
                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex7.Text) == val)
            {
                PriceIndex7.Text = val2.ToString();
                NumberOfSwap++;
            }
            else if (Convert.ToInt32(PriceIndex8.Text) == val)
            {
                PriceIndex8.Text = val2.ToString();
                NumberOfSwap++;
            }
        }
        private Task Key()
        {

            lblNuberOfCompare.Text = NumberOfCompere.ToString();
            lblKey.Text = "Use this key complete Quiz open lock  start next lavel [ 🔑 ]";

            return Task.CompletedTask;
        }
        private Task UnlockQuizKey()
        {
            if (lblKey.Text == "")
            {
                LearnInsertionSortQuizButton.IsEnabled = true;
            }

            return Task.CompletedTask;
        }

        private void ResetUI()
        {

            lblUnsortedList.Text = string.Empty;
            unsorted.Clear();
            LoadData();

            LearnInsertionSortQuizButton.IsEnabled = false;
            lblNuberOfCompare.Text = string.Empty;
            NumberOfCompere = 0;
            NumberOfSwap = 0;
            CheakCount = 0;
            MinValue = 0;

            CompareButton.IsEnabled = false;
            SwapButton.IsEnabled = false;
            SelectButton.IsEnabled = true;

            lblItemSwap.Text = string.Empty;
            lblKey.Text = "";
            lblSortedList.Text = string.Empty;

            Frame_1.BackgroundColor = Color.LightGreen;
            Frame_2.BackgroundColor = Color.LightGreen;
            Frame_3.BackgroundColor = Color.LightGreen;
            Frame_4.BackgroundColor = Color.LightGreen;
            Frame_5.BackgroundColor = Color.LightGreen;
            Frame_6.BackgroundColor = Color.LightGreen;
            Frame_7.BackgroundColor = Color.LightGreen;
            Frame_8.BackgroundColor = Color.LightGreen;


        }
        private async void LearnSelectionSortQuizButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new SelectionSortQuizPage());
        }
        private async void LearnSelectionSortButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new SelectionSortLearningPage());
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            ResetUI();
        }

        
        private async void NextButton_Clicked_1(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new QuickSortPage());
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Selection_S.png", ""));
        }
    }
}