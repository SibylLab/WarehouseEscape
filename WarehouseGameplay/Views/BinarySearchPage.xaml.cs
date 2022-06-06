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
    public partial class BinarySearchPage : ContentPage
    {
        public static List<int> unsorted = new List<int>();

        private int CheakCount = 0;
        private int slectedtItem = 0;
        private int resultItem = 0;
        private int MidPoint = 0;
        private int NumberOfCompere = 0;
        private int HighHalf =0;
        private int LowHalf = 0;
        private int MidCount = 0;
        private bool leftHalfIsTrue = false;
        private bool rightHalfIsTrue = false;

        public BinarySearchPage()
        {
            InitializeComponent();
            LoadData();
            NextButton.IsEnabled = false;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Q2.png", ""));
                return false;
            });
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
                unsorted.Sort();
                foreach (var item in unsorted)
                {
                    lblUnsortedList.Text = lblUnsortedList.Text + item.ToString() + ",";
                }
            }
            lblSelectedItem.Text = SelectedItemFromListRandomNumber().ToString();
        }
        private int SelectedItemFromListRandomNumber()
        {
            var items = unsorted.Count;
            Random random = new Random();
            slectedtItem = random.Next(items);
            resultItem = unsorted.ElementAt(slectedtItem);

            return resultItem;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
           // unsorted.Clear();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LearnBinarySearhQuizButton.IsEnabled = false;
            MidButton.IsEnabled = false;
            RightHalfButton.IsEnabled = false;
           
        }
        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        private void IsButtonsenabled()
        {
            if (leftHalfButton.IsEnabled == true && RightHalfButton.IsEnabled == true)
            {
                MidButton.IsEnabled = true;
            }
        }
        private void BinarySearch()
        {
            NumberOfCompere += 1;
        }
        Color lowColor = Color.LightBlue;
        int lowHalf;
        private void LowButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 0)
            {
                var lowHalf = unsorted[0];
                LowHalf = unsorted.IndexOf(lowHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(LowHalf), lowColor);
                IsButtonsenabled();
                leftHalfButton.IsEnabled = false;
                RightHalfButton.IsEnabled = true;
            }
            else if (CheakCount == 1)
            {
                if (Convert.ToInt32(lblSelectedItem.Text) > unsorted.ElementAt(MidPoint))
                {
                    lowHalf = unsorted[MidPoint + 1];
                    rightHalfIsTrue = true;
                }
                else
                {
                    if (Convert.ToInt32(lblSelectedItem.Text) < unsorted.ElementAt(MidPoint))
                    {
                        lowHalf = unsorted[0];
                        leftHalfIsTrue = true;
                    }
                }

                LowHalf = unsorted.IndexOf(lowHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(LowHalf), lowColor);
                IsButtonsenabled();

                leftHalfButton.IsEnabled = false;
                RightHalfButton.IsEnabled = true;

            }
            else if (CheakCount == 2 && Frame_7.BackgroundColor == midColor)
            {
                if (Convert.ToInt32(lblSelectedItem.Text) > unsorted.ElementAt(MidPoint))
                {
                    lowHalf = unsorted[6];
                    rightHalfIsTrue = true;
                }
                else
                {
                    if (Convert.ToInt32(lblSelectedItem.Text) < unsorted.ElementAt(MidPoint))
                    {
                        lowHalf = unsorted[4];
                        leftHalfIsTrue = true;
                    }
                }

                LowHalf = unsorted.IndexOf(lowHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(LowHalf), lowColor);
                IsButtonsenabled();
                CompareMidToKey(unsorted.ElementAt(MidPoint));

                leftHalfButton.IsEnabled = false;
                RightHalfButton.IsEnabled = true;
            }
            else if (CheakCount == 2 && Frame_2.BackgroundColor == midColor)
            {
                if (Convert.ToInt32(lblSelectedItem.Text) > unsorted.ElementAt(MidPoint))
                {
                    lowHalf = unsorted[1];
                    rightHalfIsTrue = true;
                }
                else
                {
                    if (Convert.ToInt32(lblSelectedItem.Text) < unsorted.ElementAt(MidPoint))
                    {
                        lowHalf = unsorted[0];
                        leftHalfIsTrue = true;
                    }
                }

                LowHalf = unsorted.IndexOf(lowHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(LowHalf), lowColor);
                IsButtonsenabled();
                CompareMidToKey(unsorted.ElementAt(MidPoint));

                leftHalfButton.IsEnabled = false;
                RightHalfButton.IsEnabled = true;
            }
            else if (Convert.ToInt32(lblSelectedItem.Text) == unsorted[4])
            {
                Frame_5.BackgroundColor = lowColor; 
                IsButtonsenabled();

                leftHalfButton.IsEnabled = false;
                RightHalfButton.IsEnabled = true;
            }
        }
        Color midColor = Color.LightSlateGray;
        private  void MidButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 0)
            {
                NumberOfCompere += 1;
                var mid = (LowHalf + HighHalf) / 2;
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;
                
            }
            else if (CheakCount == 1 && leftHalfIsTrue == true)
            {

                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[1]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;

            }
            else if (CheakCount == 1 && rightHalfIsTrue == true)
            {
                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[6]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;


            }
            else if (Frame_2.BackgroundColor == lowColor && Frame_3.BackgroundColor == highColor)
            {
                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[2]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;


            }
            else if (Frame_1.BackgroundColor == lowColor && Frame_2.BackgroundColor == highColor)
            {
                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[0]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;


            }
            else if (Frame_5.BackgroundColor == lowColor && Frame_7.BackgroundColor == highColor)
            {
                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[5]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;


            }
            else if (Frame_7.BackgroundColor == lowColor && Frame_8.BackgroundColor == highColor)
            {
                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[7]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;


            }
            else if (Frame_5.BackgroundColor == lowColor && Frame_6.BackgroundColor == highColor)
            {
                NumberOfCompere += 1;
                var mid = unsorted.IndexOf(unsorted[4]);
                MidPoint = mid;
                ResetColorList();
                IsItemFound(unsorted.ElementAt(mid), midColor);
                CheakCount++;
                IsComaredTrue(unsorted.ElementAt(mid));
                MidButton.IsEnabled = false;
                leftHalfButton.IsEnabled = true;

            }

        }

        Color highColor = Color.LightPink;
        int highHalf = 0;
        private void HighButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 0)
            {

                var highHalf = unsorted[7];
                HighHalf = unsorted.IndexOf(highHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(HighHalf), highColor);
                IsButtonsenabled();
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
            else if (CheakCount == 1)
            {
                if (Convert.ToInt32(lblSelectedItem.Text) > unsorted.ElementAt(MidPoint))
                {
                    highHalf = unsorted[7];
                    rightHalfIsTrue = true;
                }
                else
                {
                    if (Convert.ToInt32(lblSelectedItem.Text) < unsorted.ElementAt(MidPoint))
                    {
                        highHalf = unsorted[MidPoint - 1];
                        leftHalfIsTrue = true;
                    }
                }

                HighHalf = unsorted.IndexOf(highHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(HighHalf), highColor);
                IsButtonsenabled();
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
            else if (Frame_5.BackgroundColor == lowColor)
            {
                if (Convert.ToInt32(lblSelectedItem.Text) > unsorted.ElementAt(MidPoint))
                {
                    highHalf = unsorted[7];
                    rightHalfIsTrue = true;
                }
                else
                {
                    if (Convert.ToInt32(lblSelectedItem.Text) < unsorted.ElementAt(MidPoint))
                    {
                        highHalf = unsorted[MidPoint];
                        leftHalfIsTrue = true;
                    }
                }

                HighHalf = unsorted.IndexOf(highHalf);
                NextMidSetting();
                IsItemFound(unsorted.ElementAt(HighHalf), highColor);
                IsButtonsenabled();
                CompareMidToKey(unsorted.ElementAt(MidPoint));
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
            else if (Frame_1.BackgroundColor == lowColor)
            {
                Frame_2.BackgroundColor = highColor;
                IsButtonsenabled();
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
            else if (Frame_2.BackgroundColor == lowColor)
            {
                Frame_3.BackgroundColor = highColor;
                IsButtonsenabled();
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
            else if (Convert.ToInt32(lblSelectedItem.Text) == unsorted[7])
            {
                Frame_8.BackgroundColor = highColor;
                IsButtonsenabled();
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
            else if (Convert.ToInt32(lblSelectedItem.Text) == unsorted[4])
            {
                Frame_6.BackgroundColor = highColor;
                IsButtonsenabled();
                MidButton.IsEnabled = true;
                RightHalfButton.IsEnabled = false;
            }
        }
        private void NextMidSetting()
        {
            if (Frame_1.BackgroundColor == Color.LightSlateGray)
            {
                Frame_1.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_2.BackgroundColor == Color.LightSlateGray)
            {
                Frame_2.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_3.BackgroundColor == Color.LightSlateGray)
            {
                Frame_3.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_4.BackgroundColor == Color.LightSlateGray)
            {
                Frame_4.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_5.BackgroundColor == Color.LightSlateGray)
            {
                Frame_5.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_6.BackgroundColor == Color.LightSlateGray)
            {
                Frame_6.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_7.BackgroundColor == Color.LightSlateGray)
            {
                Frame_7.BackgroundColor = Color.LightGreen;
            }
            else if (Frame_8.BackgroundColor == Color.LightSlateGray)
            {
                Frame_8.BackgroundColor = Color.LightGreen;
            }
        }
        private void CompareMidToKey(int midPoint)
        {
            if (Convert.ToInt32(lblSelectedItem.Text) > midPoint)
            {
                rightHalfIsTrue = true;
            }
            else
            {
                if (Convert.ToInt32(lblSelectedItem.Text) < midPoint)
                {
                    leftHalfIsTrue = true;
                }
            }
        }

        private async void IsComaredTrue(int mid)
        {
            if (Convert.ToInt32(lblSelectedItem.Text) == mid)
            {
                NextButton.IsEnabled = true;
                await UnlockQuizKey();
                Key();
                DoSameBack();
                IsItemFound(mid, midColor);
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
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
        private void Key()
        {

            int index = unsorted.IndexOf(Convert.ToInt32(lblSelectedItem.Text));
            lblItemIndex.Text = index.ToString();
            lblNuberOfCompere.Text = NumberOfCompere.ToString();
            lblKey.Text = "Use this key complete Quiz open lock  start next lavel [ 🔑 ]";
            lblSelectedItemOutPut.Text = lblSelectedItem.Text;
        }
        private Task UnlockQuizKey()
        {
            if (lblKey.Text == "")
            {
                LearnBinarySearhQuizButton.IsEnabled = true;
            }

            return Task.CompletedTask;
        }
        private void ResetColorList()
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

            PriceIndex1.TextColor = Color.Black;
            PriceIndex2.TextColor = Color.Black;
            PriceIndex3.TextColor = Color.Black;
            PriceIndex4.TextColor = Color.Black;
            PriceIndex5.TextColor = Color.Black;
            PriceIndex6.TextColor = Color.Black;
            PriceIndex7.TextColor = Color.Black;
            PriceIndex8.TextColor = Color.Black;
        }
        private void ResetUI()
        {

            lblSelectedItem.Text = "";
            lblItemIndex.Text = "";
            lblUnsortedList.Text = string.Empty;

            unsorted.Clear();
            LoadData();

            lblNuberOfCompere.Text = string.Empty;
            lblSelectedItemOutPut.Text = string.Empty;
            

            NumberOfCompere = 0;
            CheakCount = 0;
            resultItem = 0;
            slectedtItem = 0;
            lblKey.Text = "";
            slectedtItem = 0;
            resultItem = 0;
            MidPoint = 0;
            NumberOfCompere = 0;
            HighHalf = 0;
            LowHalf = 0;
            MidCount = 0;
            lowHalf = 0;
            highHalf = 0;
            
            leftHalfIsTrue = false;
            rightHalfIsTrue = false;
            MidButton.IsEnabled = false;

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
        private async void LearnBinarySearhQuizButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new BinarySearchQuizPage());
        }

        private async void LearnBinarySearhButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new BinarySearchLearnigPage());
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            ResetUI();
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new InsertionSortPage());
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Binary_S.png", ""));
        }
    }
}