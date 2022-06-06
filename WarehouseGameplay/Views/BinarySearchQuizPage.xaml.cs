using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseGameplay.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BinarySearchQuizPage : ContentPage
    {
        int _choice = 0;
        int score = 100;
        private int QUESTIONS_COUNT = 4;
        private int CurrentQuestion = 1;

        public BinarySearchQuizPage()
        {
            InitializeComponent();
            ((BinarySearchQuestionViewModel)BindingContext).LoadQuestions();

            btnAnswerOne.Clicked += (sender, ea) =>
            {
                if (((BinarySearchQuestionViewModel)BindingContext).CheckIfCorrect(1)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((BinarySearchQuestionViewModel)BindingContext).CheckIfCorrect(2)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerThree.Clicked += (sender, ea) =>
            {
                if (((BinarySearchQuestionViewModel)BindingContext).CheckIfCorrect(3))
                {
                    DoAnswer();
                }
                else
                {
                    score = score / 2;
                }
            };
        }
        private void DoAnswer()
        {
            
            if (CurrentQuestion < QUESTIONS_COUNT)
            {
                CurrentQuestion++;
                ((BinarySearchQuestionViewModel)BindingContext).ChooseNewQuestion();
            }
            else
            {
                NavigateToEndPage();
            }
        }

        private async void NavigateToEndPage()
        {
            string MissionTwo = "Two";
            Preferences.Set("accessToken", MissionTwo);
            OnBackButtonPressed();
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/popUp.png", "You have unlocked 🔓 Mission Two Successfuly 🏆 Now move to the next Mission"));


        }

       
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}