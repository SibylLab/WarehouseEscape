using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickSortPage : ContentPage
    {

        public static List<int> unsorted = new List<int>() {44,88,77,22,66,11, 99,33};

        private int NumberOfCompere = 0;
        private int NumberOfSwap = 0;
        private int CheakCount = 0;

        public QuickSortPage()
        {
            InitializeComponent();
            //NextButton.IsEnabled = false;
            CompareButton.IsEnabled = false;
            SwapButton.IsEnabled = false;
            LoadData();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Q5.png", ""));
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
            LearnQuickSortQuizButton.IsEnabled = false;
            
        }
        private void LoadData()
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
                lblUnsortedList.Text = "";
                foreach (var item in unsorted)
                {
                    lblUnsortedList.Text = lblUnsortedList.Text + item.ToString() + ",";
                }
            }
        }

        private void IsItemFound(int val, Color color)
        {
            if (Convert.ToInt32(PriceIndex1.Text) == val)
            {
                Frame_1.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex2.Text) == val)
            {
                Frame_2.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex3.Text) == val)
            {
                Frame_3.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex4.Text) == val)
            {
                Frame_4.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex5.Text) == val)
            {
                Frame_5.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex6.Text) == val)
            {
                Frame_6.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex7.Text) == val)
            {
                Frame_7.BackgroundColor = color;
            }
            else if (Convert.ToInt32(PriceIndex8.Text) == val)
            {
                Frame_8.BackgroundColor = color;
            }
        }

        private void IsPovit(int val)
        {
            if (Convert.ToInt32(PriceIndex1.Text) == val)
            {
                PriceIndex1.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex2.Text) == val)
            {
                PriceIndex2.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex3.Text) == val)
            {
                PriceIndex3.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex4.Text) == val)
            {
                PriceIndex4.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex5.Text) == val)
            {
                PriceIndex5.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex6.Text) == val)
            {
                PriceIndex6.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex7.Text) == val)
            {
                PriceIndex7.Text = val.ToString();
            }
            else if (Convert.ToInt32(PriceIndex8.Text) == val)
            {
                PriceIndex8.Text = val.ToString();
            }
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        private string pivot = "";
        private void PivotButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 0)
            {
                pivot = PriceIndex1.Text;
                lblPivotItem.Text = pivot.ToString();
                IsItemFound(Convert.ToInt32(pivot), Color.LightPink);
                PivotButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 1)
            {
                pivot = PriceIndex1.Text;
                lblPivotItem.Text = pivot.ToString();
                DoSameBack();
                IsItemFound(Convert.ToInt32(pivot), Color.LightPink);
                PivotButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 2)
            {
                pivot = PriceIndex1.Text;
                lblPivotItem.Text = pivot.ToString();
                DoSameBack();
                IsItemFound(Convert.ToInt32(pivot), Color.LightPink);
                PivotButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 3)
            {
                pivot = PriceIndex4.Text;
                lblPivotItem.Text = pivot.ToString();
                DoSameBack();
                IsItemFound(Convert.ToInt32(pivot), Color.LightPink);
                PivotButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 4)
            {
                lblPivotItem.Text = string.Empty;
                pivot = PriceIndex5.Text;
                lblPivotItem.Text = pivot.ToString();
                DoSameBack();
                IsItemFound(Convert.ToInt32(pivot), Color.LightPink);
                PivotButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
            else if (CheakCount == 5)
            {
                lblPivotItem.Text = string.Empty;
                pivot = PriceIndex7.Text;
                lblPivotItem.Text = pivot.ToString();
                DoSameBack();
                IsItemFound(Convert.ToInt32(pivot), Color.LightPink);
                PivotButton.IsEnabled = false;
                CompareButton.IsEnabled = true;
                CheakCount++;
            }
        }
        
        private int ComareCount = 0;
        private void CompareButton_Clicked(object sender, EventArgs e)
        {
            if (ComareCount == 0)
            {
                Frame_2.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
            }
            else if (ComareCount == 1)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
                
            }
            else if (ComareCount == 2)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
                
            }
            else if (ComareCount == 3)
            {
                DoSameBack();
                Frame_5.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
                
            }
            else if (ComareCount == 4)
            {
                DoSameBack();
                Frame_6.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
                
            }
            else if (ComareCount == 5)
            {
                DoSameBack();
                Frame_7.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
                
            }
            else if (ComareCount == 6)
            {
                DoSameBack();
                Frame_8.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;
                
            }
            else if (ComareCount == 7)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 8)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 9)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 10)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 11)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 12)
            {
                DoSameBack();
                Frame_6.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 11)
            {
                DoSameBack();
                Frame_7.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }
            else if (ComareCount == 13)
            {
                DoSameBack();
                Frame_8.BackgroundColor = Color.YellowGreen;
                IsItemFound(Convert.ToInt32(lblPivotItem.Text), Color.YellowGreen);
                ComareCount++;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                NumberOfCompere++;

            }

        }

        private int isPlus = 1;
        private string CheachIvalue()
        {
            if (isPlus == 0)
            {
                return PriceIndex1.Text;
            }
            else if (isPlus == 1)
            {
                return PriceIndex2.Text;
            }
            else if (isPlus == 2)
            {
                return PriceIndex3.Text;
            }
            else if (isPlus == 3)
            {
                return PriceIndex4.Text;
            }
            else if (isPlus == 4)
            {
                return PriceIndex5.Text;
            }
            else if (isPlus == 5)
            {
                return PriceIndex6.Text;
            }
            else if (isPlus == 6)
            {
                return PriceIndex7.Text;
            }
            else if (isPlus == 7)
            {
                return PriceIndex8.Text;
            }
            
            return string.Empty;
        }
        private void SwapIvalue(string swapValue)
        {
            if (isPlus == 0)
            {
                PriceIndex1.Text = swapValue;
            }
            else if (isPlus == 1)
            {
                PriceIndex2.Text = swapValue;
            }
            else if (isPlus == 2)
            {
                PriceIndex3.Text = swapValue;
            }
            else if (isPlus == 3)
            {
                PriceIndex4.Text = swapValue;
            }
            else if (isPlus == 4)
            {
                PriceIndex5.Text = swapValue;
            }
            else if (isPlus == 5)
            {
                PriceIndex6.Text = swapValue;
            }
            else if (isPlus == 6)
            {
                PriceIndex7.Text = swapValue;
            }
            else if (isPlus == 7)
            {
                PriceIndex8.Text = swapValue;
            }
        }
        private int SwapCount = 0;
        private int iValue = 0;
        private int Jvalue = 0;
        private Color hotPink = Color.HotPink;
        private async void SwapButton_Clicked(object sender, EventArgs e)
        {
            if (SwapCount == 0)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex2.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex2.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex2.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, Color.HotPink);
                    IsItemFound(iValue, Color.HotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 1)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex3.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex3.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex3.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 2)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex4.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex4.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex4.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 3)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex5.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex5.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex5.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 4)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex6.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex6.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex6.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 5)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex7.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex7.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex7.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 6)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex8.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex8.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex8.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);

                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;

                    iValue = Convert.ToInt32(PriceIndex4.Text);
                    Jvalue = Convert.ToInt32(PriceIndex1.Text);

                    PriceIndex1.Text = iValue.ToString();
                    PriceIndex4.Text = Jvalue.ToString();

                    iValue = 0;
                    Jvalue = 0;
                    lblPivotItem.Text = string.Empty;
                }

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = false;
                DivideButton.IsEnabled = true;
                isPlus = 0;
                DoSameBack();
            }
            else if (SwapCount == 7)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex2.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex2.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex2.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 8)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex3.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex3.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex3.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);
                    iValue = 0;
                    Jvalue = 0;
                    isPlus++;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (SwapCount == 9)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex4.Text)))
                {
                    iValue = Convert.ToInt32(CheachIvalue());
                    Jvalue = Convert.ToInt32(PriceIndex4.Text);

                    SwapIvalue(Jvalue.ToString());
                    PriceIndex4.Text = iValue.ToString();
                    NumberOfSwap++;

                    IsItemFound(Jvalue, hotPink);
                    IsItemFound(iValue, hotPink);

                    iValue = 0;
                    Jvalue = 0;

                    iValue = Convert.ToInt32(PriceIndex4.Text);
                    Jvalue = Convert.ToInt32(PriceIndex1.Text);

                    PriceIndex1.Text = iValue.ToString();
                    PriceIndex4.Text = Jvalue.ToString();

                    iValue = 0;
                    Jvalue = 0;
                    lblPivotItem.Text = string.Empty;
                }

                isPlus = 1;
                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = false;
                DivideButton.IsEnabled = true;
                DoSameBack();
            }
            else if (SwapCount == 10)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex2.Text)))
                {
                    NumberOfSwap++;
                }

                iValue = Convert.ToInt32(PriceIndex1.Text);
                Jvalue = Convert.ToInt32(PriceIndex2.Text);
                IsItemFound(Jvalue, hotPink);
                IsItemFound(iValue, hotPink);
                PriceIndex2.Text = iValue.ToString();
                PriceIndex1.Text = Jvalue.ToString();

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = false;
                DivideButton.IsEnabled = true;
            }
            else if (SwapCount == 11)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex4.Text)))
                {
                    NumberOfSwap++;
                }

                SwapButton.IsEnabled = false;
                CompareButton.IsEnabled = false;
                DivideButton.IsEnabled = true;
                isPlus = 1;
            }
            else if (SwapCount == 12)
            {
                SwapCount++;
                if (IsTrue(Convert.ToInt32(lblPivotItem.Text), Convert.ToInt32(PriceIndex6.Text)))
                {
                    NumberOfSwap++;
                }

                SwapButton.IsEnabled = false;
                CompareButton.IsEnabled = false;
                DivideButton.IsEnabled = true;
            }
            else if (SwapCount == 13)
            {
                SwapButton.IsEnabled = false;
                CompareButton.IsEnabled = false;
                DivideButton.IsEnabled = false;
                PivotButton.IsEnabled = false;

                iValue = 0;
                Jvalue = 0;

                iValue = Convert.ToInt32(PriceIndex7.Text);
                Jvalue = Convert.ToInt32(PriceIndex8.Text);

                PriceIndex8.Text = iValue.ToString();
                PriceIndex7.Text = Jvalue.ToString();

                DoSameBack();
                await UnlockQuizKey();
                await Key();
                unsorted.Sort();

                lblNuberOfCompere.Text = NumberOfCompere.ToString();
                lblItemSwap.Text = NumberOfSwap.ToString();

                foreach (var item in unsorted)
                {
                    lblSortedList.Text = lblSortedList.Text + item.ToString() + ",";
                }
              

                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
            }
        }
        private int DivideCount = 0;
        private void DivideButton_Clicked(object sender, EventArgs e)
        {
            if (DivideCount == 0)
            {
                //Left Half arry

                Frame_1.BackgroundColor = Color.YellowGreen;
                Frame_2.BackgroundColor = Color.YellowGreen;
                Frame_3.BackgroundColor = Color.YellowGreen;
                Frame_4.BackgroundColor = Color.YellowGreen;

                //Right Half Arry

                Frame_6.BackgroundColor = Color.LightGreen;
                Frame_7.BackgroundColor = Color.LightGreen;
                Frame_8.BackgroundColor = Color.LightGreen;
                Frame_5.BackgroundColor = Color.BlueViolet;

                DivideButton.IsEnabled = false;
                PivotButton.IsEnabled = true;
                DivideCount++;
            }
            else if (DivideCount == 1)
            {
                Frame_1.BackgroundColor = Color.Purple;
                Frame_2.BackgroundColor = Color.Purple;
                Frame_3.BackgroundColor = Color.Gray;
                Frame_4.BackgroundColor = Color.ForestGreen;

                DivideButton.IsEnabled = false;
                PivotButton.IsEnabled = true;
                DivideCount++;
            }
            else if (DivideCount == 2)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.Yellow;
                DivideButton.IsEnabled = false;
                PivotButton.IsEnabled = true;
                DivideCount++;
            }
            else if (DivideCount == 3)
            {
                DoSameBack();
                Frame_8.BackgroundColor = Color.Orange;
                Frame_5.BackgroundColor = Color.Orange;
                Frame_6.BackgroundColor = Color.Maroon;
                Frame_7.BackgroundColor = Color.Orange;

                DivideButton.IsEnabled = false;
                PivotButton.IsEnabled = true;
                DivideCount++;
            }
            else if (DivideCount == 4)
            {
                DoSameBack();
                Frame_8.BackgroundColor = Color.Plum;
                Frame_7.BackgroundColor = Color.Maroon;
                DivideButton.IsEnabled = false;
                PivotButton.IsEnabled = true;
                DivideCount++;
            }
        }
        private bool IsTrue(int pivot, int Jvalue)
        {
            if (Jvalue < pivot)
            {
                return true;
            }

            return false;
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
            Frame_1.BackgroundColor = Color.LightBlue;
            Frame_2.BackgroundColor = Color.LightBlue;
            Frame_3.BackgroundColor = Color.LightBlue;
            Frame_4.BackgroundColor = Color.LightBlue;
            Frame_5.BackgroundColor = Color.LightBlue;
            Frame_6.BackgroundColor = Color.LightBlue;
            Frame_7.BackgroundColor = Color.LightBlue;
            Frame_8.BackgroundColor = Color.LightBlue;

        }
        private Task Key()
        {

            lblNuberOfCompere.Text = NumberOfCompere.ToString();
            lblKey.Text = "Use this key complete Quiz open lock  start next lavel [ 🔑 ]";
            lblItemSwap.Text = NumberOfSwap.ToString();
            return Task.CompletedTask;
        }
        private Task UnlockQuizKey()
        {
            NextButton.IsEnabled = true;
            if (lblKey.Text == "")
            {
                LearnQuickSortQuizButton.IsEnabled = true;
            }

            return Task.CompletedTask;
        }

        private void ResetUI()
        {
            PivotButton.IsEnabled = true;
            LearnQuickSortQuizButton.IsEnabled = false;
            lblUnsortedList.Text = string.Empty;
            lblSortedList.Text = string.Empty;
            unsorted = new List<int>() { 44, 88, 77, 22, 66, 11, 99, 33 };

            LoadData();

            lblNuberOfCompere.Text = string.Empty;
            NumberOfCompere = 0;
            NumberOfSwap = 0;
            CheakCount = 0;
            isPlus = 1;
            DivideCount = 0;
            SwapCount = 0;
            ComareCount = 0;
            lblPivotItem.Text = string.Empty;
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
        private async void LearnQuickSortQuizButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new QuickSortQuizPage());
        }

        private async void LearnQuickSortButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new QuicksortLearnigPage());
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            ResetUI();

        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new MergeSorytPage());
        }
        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Quick_S.png", ""));
        }
    }
}