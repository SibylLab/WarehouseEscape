using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using WarehouseGameplay.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MergeSorytPage : ContentPage
    {

        MergeSortHelper mergeSortHelper = new MergeSortHelper();
        public static List<int> unsorted = new List<int>();

        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> result = new List<int>();
        List<int> priceList = new List<int>();

        private int countDividedItem = 0;
        private int numberOfDividedList = 0;
        private int numberOfMerge = 0;

        public MergeSorytPage()
        {
            InitializeComponent();
            unsorted.Clear();
            LoadData();

            foreach (var item in unsorted)
            {
                lblUnsortedList.Text = lblUnsortedList.Text + item.ToString() + ",";
            }
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Q6.png", ""));
                return false;
            });
        }
        protected  override void OnAppearing()
        {
            base.OnAppearing();
            LearnMergeSortQuicButton.IsEnabled = false;
            Merge.IsEnabled = false;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ResetPageUI();
            unsorted.Clear();
        }
        private void LoadData()
        {
            var randomPrice = RandomNumber.RandomVal();
            foreach (var rendom in randomPrice)
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
            }
        }
        private void SetListVal(List<int> l, List<int> r)
        {
            foreach (var item in l)
            {
                lblLeftList.Text = lblLeftList.Text + item.ToString() + ",";
            }

            foreach (var item in r)
            {
                lblRightList.Text = lblRightList.Text + item.ToString() + ",";
            }
        }

        private async void MergeSortUIHandller()
        {
            if (numberOfMerge != 0)
            {
                ResetPageUI();
            }
            if (countDividedItem == 0)
            {
                left.Clear();
                right.Clear();

                lblLeftList.Text = string.Empty;
                lblRightList.Text = string.Empty;

                Frame_1.BackgroundColor = Color.LightBlue;
                Frame_2.BackgroundColor = Color.LightBlue;
                Frame_3.BackgroundColor = Color.LightBlue;
                Frame_4.BackgroundColor = Color.LightBlue;
                Frame_5.BackgroundColor = Color.LightPink;
                Frame_6.BackgroundColor = Color.LightPink;
                Frame_7.BackgroundColor = Color.LightPink;
                Frame_8.BackgroundColor = Color.LightPink;

                left.Add(Convert.ToInt32(PriceIndex1.Text));
                left.Add(Convert.ToInt32(PriceIndex2.Text));
                left.Add(Convert.ToInt32(PriceIndex3.Text));
                left.Add(Convert.ToInt32(PriceIndex4.Text));

                right.Add(Convert.ToInt32(PriceIndex5.Text));
                right.Add(Convert.ToInt32(PriceIndex6.Text));
                right.Add(Convert.ToInt32(PriceIndex7.Text));
                right.Add(Convert.ToInt32(PriceIndex8.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);

            }
            else if (countDividedItem == 1)
            {

                left.Clear();
                right.Clear();
                lblLeftList.Text = string.Empty;
                lblRightList.Text = string.Empty;

                Frame_1.BackgroundColor = Color.LightYellow;
                Frame_2.BackgroundColor = Color.LightYellow;
                Frame_3.BackgroundColor = Color.GreenYellow;
                Frame_4.BackgroundColor = Color.GreenYellow;

                left.Add(Convert.ToInt32(PriceIndex1.Text));
                left.Add(Convert.ToInt32(PriceIndex2.Text));
                right.Add(Convert.ToInt32(PriceIndex3.Text));
                right.Add(Convert.ToInt32(PriceIndex4.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);

            }
            else if (countDividedItem == 2)
            {
                left.Clear();
                right.Clear();
                lblRightList.Text = string.Empty;
                lblLeftList.Text = string.Empty;

                Frame_5.BackgroundColor = Color.OrangeRed;
                Frame_6.BackgroundColor = Color.OrangeRed;
                Frame_7.BackgroundColor = Color.Orange;
                Frame_8.BackgroundColor = Color.Orange;

                left.Add(Convert.ToInt32(PriceIndex5.Text));
                left.Add(Convert.ToInt32(PriceIndex6.Text));
                right.Add(Convert.ToInt32(PriceIndex7.Text));
                right.Add(Convert.ToInt32(PriceIndex8.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);

            }
            else if (countDividedItem == 3)
            {
                left.Clear();
                right.Clear();
                lblRightList.Text = string.Empty;

                Frame_1.BackgroundColor = Color.Green;
                Frame_2.BackgroundColor = Color.DarkOliveGreen;

                right.Add(Convert.ToInt32(PriceIndex1.Text));
                right.Add(Convert.ToInt32(PriceIndex2.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);

            }
            else if (countDividedItem == 4)
            {

                left.Clear();
                right.Clear();
                lblLeftList.Text = string.Empty;

                Frame_3.BackgroundColor = Color.HotPink;
                Frame_4.BackgroundColor = Color.Gray;

                left.Add(Convert.ToInt32(PriceIndex3.Text));
                left.Add(Convert.ToInt32(PriceIndex4.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);
            }
            else if (countDividedItem == 5)
            {

                left.Clear();
                right.Clear();
                lblRightList.Text = string.Empty;

                Frame_5.BackgroundColor = Color.Accent;
                Frame_6.BackgroundColor = Color.Azure;
                right.Add(Convert.ToInt32(PriceIndex5.Text));
                right.Add(Convert.ToInt32(PriceIndex6.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);
            }
            else if (countDividedItem == 6)
            {

                left.Clear();
                right.Clear();
                lblRightList.Text = string.Empty;

                Frame_7.BackgroundColor = Color.Lime;
                Frame_8.BackgroundColor = Color.BlanchedAlmond;

                right.Add(Convert.ToInt32(PriceIndex7.Text));
                right.Add(Convert.ToInt32(PriceIndex8.Text));

                countDividedItem++;
                numberOfDividedList += 2;
                SetListVal(left, right);

                lblLeftList.Text = "--------------------------";
                lblRightList.Text = "-------------------------";
            }
            else if (countDividedItem == 7)
            {
                Middel.IsEnabled = false;
                Merge.IsEnabled = true;
            }

            lblNuberOfDividedList.Text = numberOfDividedList.ToString();
        }
        private void DividedButton_Clicked(object sender, EventArgs e)
        {
            MergeSortUIHandller();
        }
        private async void Merge_Clicked(object sender, EventArgs e)
        {
            if (countDividedItem != 7)
            {
                if(numberOfMerge == 7)
                {
                    Merge.IsEnabled = false;
                    await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
                }
            }
            else
            {
                await MergeTaskUIHandler();
                ShowSortedData();
                await UnlockQuizKey();

                if (numberOfMerge == 7)
                {
                    countDividedItem = 0;
                }
            }

        }

        private async Task MergeTaskUIHandler()
        {
            if (numberOfMerge == 0)
            {
                priceList.Add(Convert.ToInt32(PriceIndex1.Text));
                priceList.Add(Convert.ToInt32(PriceIndex2.Text));

                Frame_1.BackgroundColor = Color.Yellow;
                Frame_2.BackgroundColor = Color.Yellow;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex1.Text = priceList[0].ToString();
                    PriceIndex2.Text = priceList[1].ToString();
                }
            }
            else if (numberOfMerge == 1)
            {
                priceList.Clear();

                priceList.Add(Convert.ToInt32(PriceIndex3.Text));
                priceList.Add(Convert.ToInt32(PriceIndex4.Text));

                Frame_3.BackgroundColor = Color.LightGoldenrodYellow;
                Frame_4.BackgroundColor = Color.LightGoldenrodYellow;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex3.Text = priceList[0].ToString();
                    PriceIndex4.Text = priceList[1].ToString();
                }
            }
            else if (numberOfMerge == 2)
            {
                priceList.Clear();

                priceList.Add(Convert.ToInt32(PriceIndex5.Text));
                priceList.Add(Convert.ToInt32(PriceIndex6.Text));

                Frame_5.BackgroundColor = Color.DimGray;
                Frame_6.BackgroundColor = Color.DimGray;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex5.Text = priceList[0].ToString();
                    PriceIndex6.Text = priceList[1].ToString();
                }
            }
            else if (numberOfMerge == 3)
            {
                priceList.Clear();

                priceList.Add(Convert.ToInt32(PriceIndex7.Text));
                priceList.Add(Convert.ToInt32(PriceIndex8.Text));

                Frame_7.BackgroundColor = Color.LightSteelBlue;
                Frame_8.BackgroundColor = Color.LightSteelBlue;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex7.Text = priceList[0].ToString();
                    PriceIndex8.Text = priceList[1].ToString();
                }
            }
            else if (numberOfMerge == 4)
            {
                priceList.Clear();

                priceList.Add(Convert.ToInt32(PriceIndex1.Text));
                priceList.Add(Convert.ToInt32(PriceIndex2.Text));
                priceList.Add(Convert.ToInt32(PriceIndex3.Text));
                priceList.Add(Convert.ToInt32(PriceIndex4.Text));

                Frame_1.BackgroundColor = Color.BlanchedAlmond;
                Frame_2.BackgroundColor = Color.BlanchedAlmond;
                Frame_3.BackgroundColor = Color.BlanchedAlmond;
                Frame_4.BackgroundColor = Color.BlanchedAlmond;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex1.Text = priceList[0].ToString();
                    PriceIndex2.Text = priceList[1].ToString();
                    PriceIndex3.Text = priceList[2].ToString();
                    PriceIndex4.Text = priceList[3].ToString();
                }
            }
            else if (numberOfMerge == 5)
            {
                priceList.Clear();

                priceList.Add(Convert.ToInt32(PriceIndex5.Text));
                priceList.Add(Convert.ToInt32(PriceIndex6.Text));
                priceList.Add(Convert.ToInt32(PriceIndex7.Text));
                priceList.Add(Convert.ToInt32(PriceIndex8.Text));

                Frame_5.BackgroundColor = Color.LightYellow;
                Frame_6.BackgroundColor = Color.LightYellow;
                Frame_7.BackgroundColor = Color.LightYellow;
                Frame_8.BackgroundColor = Color.LightYellow;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex5.Text = priceList[0].ToString();
                    PriceIndex6.Text = priceList[1].ToString();
                    PriceIndex7.Text = priceList[2].ToString();
                    PriceIndex8.Text = priceList[3].ToString();
                }
            }
            else if (numberOfMerge == 6)
            {
                priceList.Clear();

                priceList.Add(Convert.ToInt32(PriceIndex1.Text));
                priceList.Add(Convert.ToInt32(PriceIndex2.Text));
                priceList.Add(Convert.ToInt32(PriceIndex3.Text));
                priceList.Add(Convert.ToInt32(PriceIndex4.Text));
                priceList.Add(Convert.ToInt32(PriceIndex5.Text));
                priceList.Add(Convert.ToInt32(PriceIndex6.Text));
                priceList.Add(Convert.ToInt32(PriceIndex7.Text));
                priceList.Add(Convert.ToInt32(PriceIndex8.Text));

                Frame_1.BackgroundColor = Color.LightSkyBlue;
                Frame_2.BackgroundColor = Color.LightSkyBlue;
                Frame_3.BackgroundColor = Color.LightSkyBlue;
                Frame_4.BackgroundColor = Color.LightSkyBlue;
                Frame_5.BackgroundColor = Color.LightSkyBlue;
                Frame_6.BackgroundColor = Color.LightSkyBlue;
                Frame_7.BackgroundColor = Color.LightSkyBlue;
                Frame_8.BackgroundColor = Color.LightSkyBlue;

                priceList.Sort();
                numberOfMerge++;

                for (int i = 0; i < priceList.Count; i++)
                {
                    PriceIndex1.Text = priceList[0].ToString();
                    PriceIndex2.Text = priceList[1].ToString();
                    PriceIndex3.Text = priceList[2].ToString();
                    PriceIndex4.Text = priceList[3].ToString();
                    PriceIndex5.Text = priceList[4].ToString();
                    PriceIndex6.Text = priceList[5].ToString();
                    PriceIndex7.Text = priceList[6].ToString();
                    PriceIndex8.Text = priceList[7].ToString();
                }
            }
            else if (numberOfMerge == 7)
            {
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/popUp.png", "⭐⭐⭐⭐⭐"));
            }
        }
        public void ShowSortedData()
        {
            if (numberOfMerge == 7)
            {
                result = mergeSortHelper.MergeSort(unsorted);
                lblNuberOfCompere.Text = MergeSortHelper.NumberOfCompereInUnsortedData().ToString();
                Key();
                try
                {
                    foreach (var item in result)
                    {
                        lblSortedList.Text = lblSortedList.Text + item.ToString() + ",";
                    }
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex);
                }
            }
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await CloseMergeSortPage();
        }

        private async Task CloseMergeSortPage()
        {
            await Navigation.PopModalAsync(false);
        }

        private async void LearnMergeSortButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuicksortLearnigPage());
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            ResetPageUI();
        }

        private void ResetPageUI()
        {
            Middel.IsEnabled = true;
            unsorted.Clear();
            countDividedItem = 0;
            lblNuberOfDividedList.Text = string.Empty;
            lblLeftList.Text = string.Empty;
            lblRightList.Text = string.Empty;
            lblNuberOfCompere.Text = string.Empty;
            lblSortedList.Text = string.Empty;

            Frame_1.BackgroundColor = Color.LightGreen;
            Frame_2.BackgroundColor = Color.LightGreen;
            Frame_3.BackgroundColor = Color.LightGreen;
            Frame_4.BackgroundColor = Color.LightGreen;
            Frame_5.BackgroundColor = Color.LightGreen;
            Frame_6.BackgroundColor = Color.LightGreen;
            Frame_7.BackgroundColor = Color.LightGreen;
            Frame_8.BackgroundColor = Color.LightGreen;

            lblLockKey1.Text = "";
            numberOfDividedList = 0;
            numberOfMerge = 0;
            result.Clear();
            LoadData();
        }
        private  Task UnlockQuizKey()
        {
            NextButton.IsEnabled = true;
            if (lblLockKey1.Text != "")
            {
                LearnMergeSortQuicButton.IsEnabled = true;
            }

            return Task.CompletedTask;
        }
        private void Key()
        {
            if (countDividedItem == 7)
            {
                lblLockKey1.Text = "Use this key complete Quiz open lock  start next lavel [ 🔑 ]";
            }
        }

        private async void LearnMergeSortQuicButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MergeSortQuizPage());
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new EasyModePage());
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Merge_S.png", ""));
        }
    }
}

