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
    public partial class InsertionSortPage : ContentPage
    {
        public static List<int> unsorted = new List<int>();
        private int NumberOfCompere = 0;
        private int NumberOfSwap = 0;
        private int CheakCount = 0;
        private string J_Value;
        private string I_Value;

        public InsertionSortPage()
        {
            InitializeComponent();
            NextButton.IsEnabled = false;
            LoadData();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Q3.png", ""));
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
            }
        }
        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
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
        private  void CompareButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 0)
            {
                Frame_1.BackgroundColor = Color.LightPink;
                Frame_2.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount ==1)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_3.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex2.Text;
                J_Value = PriceIndex3.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 2)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_1.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 3)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.LightPink;
                Frame_4.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex3.Text;
                J_Value = PriceIndex4.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 4)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.LightPink;
                Frame_2.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex2.Text;
                J_Value = PriceIndex3.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 5)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_1.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 6)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_5.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex4.Text;
                J_Value = PriceIndex5.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 7)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_3.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex3.Text;
                J_Value = PriceIndex4.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 8)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.LightPink;
                Frame_2.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex2.Text;
                J_Value = PriceIndex3.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 9)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_1.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 10)
            {
                DoSameBack();
                Frame_5.BackgroundColor = Color.LightPink;
                Frame_6.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex5.Text;
                J_Value = PriceIndex6.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 11)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_5.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex4.Text;
                J_Value = PriceIndex5.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 12)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_3.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex3.Text;
                J_Value = PriceIndex4.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 13)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.LightPink;
                Frame_2.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex2.Text;
                J_Value = PriceIndex3.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 14)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_1.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 15)
            {
                DoSameBack();
                Frame_6.BackgroundColor = Color.LightPink;
                Frame_7.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex6.Text;
                J_Value = PriceIndex7.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 16)
            {
                DoSameBack();
                Frame_5.BackgroundColor = Color.LightPink;
                Frame_6.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex5.Text;
                J_Value = PriceIndex6.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 17)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_5.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex4.Text;
                J_Value = PriceIndex5.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 18)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_3.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex3.Text;
                J_Value = PriceIndex4.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 19)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.LightPink;
                Frame_2.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex2.Text;
                J_Value = PriceIndex3.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 20)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_1.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 21)
            {
                DoSameBack();
                Frame_7.BackgroundColor = Color.LightPink;
                Frame_8.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex7.Text;
                J_Value = PriceIndex8.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 22)
            {
                DoSameBack();
                Frame_6.BackgroundColor = Color.LightPink;
                Frame_7.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex6.Text;
                J_Value = PriceIndex7.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 23)
            {
                DoSameBack();
                Frame_5.BackgroundColor = Color.LightPink;
                Frame_6.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex5.Text;
                J_Value = PriceIndex6.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 24)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_5.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex4.Text;
                J_Value = PriceIndex5.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 25)
            {
                DoSameBack();
                Frame_4.BackgroundColor = Color.LightPink;
                Frame_3.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex3.Text;
                J_Value = PriceIndex4.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;
                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 26)
            {
                DoSameBack();
                Frame_3.BackgroundColor = Color.LightPink;
                Frame_2.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex2.Text;
                J_Value = PriceIndex3.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
            else if (CheakCount == 27)
            {
                DoSameBack();
                Frame_2.BackgroundColor = Color.LightPink;
                Frame_1.BackgroundColor = Color.LightPink;

                I_Value = PriceIndex1.Text;
                J_Value = PriceIndex2.Text;

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = true;

                CheakCount++;
                NumberOfCompere++;
            }
        }
        
        private async void SwapButton_Clicked(object sender, EventArgs e)
        {
            if (CheakCount == 1)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 2)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex2.Text = J_Value;
                    PriceIndex3.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 3)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;
                   
                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 4)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;
                    
                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex3.Text = J_Value;
                    PriceIndex4.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 5)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex2.Text = J_Value;
                    PriceIndex3.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 6)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 7)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex4.Text = J_Value;
                    PriceIndex5.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 8)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex3.Text = J_Value;
                    PriceIndex4.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 9)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex2.Text = J_Value;
                    PriceIndex3.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 10)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 11)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex5.Text = J_Value;
                    PriceIndex6.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 12)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex4.Text = J_Value;
                    PriceIndex5.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 13)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex3.Text = J_Value;
                    PriceIndex4.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 14)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex2.Text = J_Value;
                    PriceIndex3.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 15)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 16)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex6.Text = J_Value;
                    PriceIndex7.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 17)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex5.Text = J_Value;
                    PriceIndex6.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 18)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex4.Text = J_Value;
                    PriceIndex5.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 19)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex3.Text = J_Value;
                    PriceIndex4.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 20)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex2.Text = J_Value;
                    PriceIndex3.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 21)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 22)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex7.Text = J_Value;
                    PriceIndex8.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 23)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex6.Text = J_Value;
                    PriceIndex7.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 24)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex5.Text = J_Value;
                    PriceIndex6.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 25)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex4.Text = J_Value;
                    PriceIndex5.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 26)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex3.Text = J_Value;
                    PriceIndex4.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 27)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex2.Text = J_Value;
                    PriceIndex3.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = true;
                SwapButton.IsEnabled = false;
            }
            else if (CheakCount == 28)
            {
                if (IsTrue(I_Value, J_Value))
                {
                    NumberOfSwap++;

                    IsItemFound(Convert.ToInt32(I_Value));
                    IsItemFound(Convert.ToInt32(J_Value));

                    PriceIndex1.Text = J_Value;
                    PriceIndex2.Text = I_Value;

                    I_Value = string.Empty;
                    J_Value = string.Empty;
                }

                CompareButton.IsEnabled = false;
                SwapButton.IsEnabled = false;
                lblItemSwap.Text = NumberOfSwap.ToString();
                lblNuberOfCompere.Text = NumberOfCompere.ToString();
                NextButton.IsEnabled = true;
                DoSameBack();
                
                await UnlockQuizKey();
                await Key();
                await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/SuccessPopUp.jpg", ""));
            }


        }
        private bool IsTrue(string a, string b)
        {
            if (Convert.ToInt32(a) > Convert.ToInt32(b))
            {
                return true;
            }
            return false;
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
        private Task Key()
        {

            
            lblKey.Text = "Use this key complete Quiz open lock  start next lavel [ 🔑 ]";
            unsorted.Sort();
            foreach (var item in unsorted)
            {
                lblSortedList.Text = lblSortedList.Text + item.ToString() + ",";
            }
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
            lblNuberOfCompere.Text = string.Empty;
            NumberOfCompere = 0;
            NumberOfSwap = 0;
            CheakCount = 0;
            lblItemSwap.Text = string.Empty;
            lblKey.Text = "";
            lblSortedList.Text = string.Empty;

            CompareButton.IsEnabled = true;

            Frame_1.BackgroundColor = Color.LightGreen;
            Frame_2.BackgroundColor = Color.LightGreen;
            Frame_3.BackgroundColor = Color.LightGreen;
            Frame_4.BackgroundColor = Color.LightGreen;
            Frame_5.BackgroundColor = Color.LightGreen;
            Frame_6.BackgroundColor = Color.LightGreen;
            Frame_7.BackgroundColor = Color.LightGreen;
            Frame_8.BackgroundColor = Color.LightGreen;


        }
        private async void LearnInsertionSortQuizButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new InsertionSortQuizPage());
        }
        private async void LearnInsertionSortButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new insertionsortLearningPage());
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            ResetUI();
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new SelectionSortingPage());
        }

        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/Insertion_S.png", ""));
        }
    }
}