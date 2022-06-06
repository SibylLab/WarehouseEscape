using MvvmHelpers;
using WarehouseGameplay.Models;

namespace WarehouseGameplay.ViewModels
{
    public class OnboardingViewModel : BaseViewModel
    {
        private ObservableRangeCollection<OnboardingModel> items;

        public ObservableRangeCollection<OnboardingModel> Items { get => items;
            set => SetProperty(ref items, value);
        }


        public OnboardingViewModel()
        {
            // create our dummy onboarding items
            Items = new ObservableRangeCollection<OnboardingModel>
            {
                new OnboardingModel
                {
                    Title = "Improved Student Learning",
                    Content = "Learning is the process of acquiring new understanding, knowledge, behaviors.",
                    Image  = "OnboardImage4"
                },
                new OnboardingModel
                {
                    Title = "Master Data Structure",
                    Content = "Arrays and Dynamic Arrays, Maths Algorithms, Combinatorics, Time and Space Complexity Analysis, Recursion and Backtracking.",
                    Image  = "OnboardImage1"
                },
                new OnboardingModel
                {
                    Title = "Fundamental Algorithms",
                    Content = "Searching Algorithms, Sorting Algorithms like Comparison based sorting and Linear time sorting.",
                    Image  = "OnboardImage3"
                },
                new OnboardingModel
                {
                    Title = "System Design",
                    Content = "7 Steps to improve your data structure and algorithm skills.",
                    Image  = "OnboardImage2"
                },
            };


        }

    }
}
