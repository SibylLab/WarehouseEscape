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
    public partial class MediumModePageTwo : ContentPage
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
        public MediumModePageTwo()
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
            await this.Navigation.PushAsync(new MediumModePageThree());
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
            Data();
            sort(Data(), 0, unsorted.Count-1);
            QSort(Data(), 0, unsorted.Count-1);
            Insertionsort(unsorted);
            SelectionSort(unsorted);
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
        private string SelectedSort;
        private int SelectedNumber()
        {
            unsorted.Sort();
            Search(unsorted, Convert.ToInt32(lblPrice.Text));
            lblNumberOfComare.Text = NumberOfComare.ToString();
            NextButton.IsEnabled = true;
            return Convert.ToInt32(lblPrice.Text);
        }
        private  void Sorting_Clicked(object sender, EventArgs e)
        {
            SelectedSort = SortPicker.SelectedItem.ToString();
        }
        private async void Searching_Clicked(object sender, EventArgs e)
        {
            unsorted.Sort();
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
            if (SortPicker.SelectedItem == null || SearchPicker.SelectedItem == null)
            {
                await DisplayAlert("Wrong!", "Please select both fields!!", "Ok");
            }
            else
            {
                if (CheackSort() == SortPicker.SelectedItem.ToString() && SearchPicker.SelectedItem.ToString() == "Binary Search")
                {
                    lblSelectedSort.Text = SortPicker.SelectedItem.ToString();
                    lblSelectedSearch.Text = SearchPicker.SelectedItem.ToString();
                    lblResulInfo.Text = "Your anwser is correct ";
                    lblResulInfo.TextColor = Color.Green;

                    lblInsertionCompare.Text = InsertionCompare.ToString();
                    lblMergeCompare.Text = MergrCompare.ToString();
                    lblQuickCompare.Text = QuickCompare.ToString();
                    lblSelectioCompare.Text = SelectionCompare.ToString();

                    IsItemFound(Convert.ToInt32(lblPrice.Text), Color.Pink);
                    lblQuickCompare.TextColor = Color.Green;
                    lblQSort.TextColor = Color.Green;

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

                    lblInsertionCompare.Text = InsertionCompare.ToString();
                    lblMergeCompare.Text = MergrCompare.ToString();
                    lblQuickCompare.Text = QuickCompare.ToString();
                    lblQuickCompare.TextColor = Color.Green;
                    lblQSort.TextColor = Color.Green;
                    lblSelectioCompare.Text = SelectionCompare.ToString();
                    IsItemFound(Convert.ToInt32(lblPrice.Text), Color.Pink);
                    SortPicker.IsEnabled = false;
                    SearchPicker.IsEnabled = false;
                    NextButton.IsEnabled = true;
                }
            }
            
        }
        private string CheackSort()
        {
            if (MergrCompare < InsertionCompare && MergrCompare < SelectionCompare && MergrCompare < QuickCompare)
            {
                lblNumberOfComare.Text = MergrCompare.ToString();
                return "Merge Sort";
            }
            else if (InsertionCompare < MergrCompare && InsertionCompare < SelectionCompare && InsertionCompare < QuickCompare)
            {
                lblNumberOfComare.Text = InsertionCompare.ToString();
                return "Insertion Sort";
            }
            else if (QuickCompare < MergrCompare && QuickCompare < InsertionCompare && QuickCompare < SelectionCompare)
            {
                lblNumberOfComare.Text = QuickCompare.ToString();
                return "Quick Sort";
            }
            else if (SelectionCompare < QuickCompare && SelectionCompare < InsertionCompare && SelectionCompare < MergrCompare)
            {
                lblNumberOfComare.Text = QuickCompare.ToString();
                return "Selection Sort";
            }
            return "Non";
        }
        private int InsertionCompare = 0;
        private int SelectionCompare = 0;
        private int MergrCompare = 0;
        private int QuickCompare = 0;
        private void Insertionsort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    InsertionCompare++;
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        private void SelectionSort(List<int> arr)
        {
            int n = arr.Count;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                    // Swap the found minimum element with the first
                    // element
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                    SelectionCompare++;
                }
            }
        }
        private int[] Data()
        {
            int[] listArry = unsorted.ToArray();
            return listArry;
        }
        
        
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
       
        void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        private void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;
                MergrCompare++;
                // Sort first and
                // second halves
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }
        public int Partition(int[] arr, int low, int high)
        {
            int temp;
            int pivot = arr[high];

            QuickCompare++;
            // index of smaller element
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {

                // If current element is
                // smaller than or
                // equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high]
            // (or pivot)
            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            return i + 1;
        }

        /* The main function that implements
        QuickSort() arr[] --> Array to be
        sorted,
        low --> Starting index,
        high --> Ending index */
        private void QSort(int[] arr, int low,
                          int high)
        {
            if (low < high)
            {
                /* pi is partitioning index,
                arr[pi] is now at right place */
                int pi = Partition(arr, low, high);
                // Recursively sort elements
                // before partition and after
                // partition
                QSort(arr, low, pi - 1);
                QSort(arr, pi + 1, high);
            }
        }

        private async void HelpButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("", "Help Text add here .Online Grammar and Writing Checker To Help You Deliver Impeccable, Mistake-free Writing. Grammarly Has a Tool For Just About Every Kind Of Writing You Do. Try It Out For Yourself! AI Writing Assistant. Find and Add Sources Fast. Eliminate Grammar Errors."));
        }
    }
}