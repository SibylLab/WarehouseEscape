using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using WarehouseGameplay.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickSortQuizPage : ContentPage
    {
        int _choice = 0;
        int score = 100;
        private int QUESTIONS_COUNT = 4;
        private int CurrentQuestion = 1;
        public QuickSortQuizPage()
        {
            InitializeComponent();
            ((QuickSortQuestionViewModel)BindingContext).LoadQuestions();

            btnAnswerOne.Clicked += (sender, ea) =>
            {
                if (((QuickSortQuestionViewModel)BindingContext).CheckIfCorrect(1)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((QuickSortQuestionViewModel)BindingContext).CheckIfCorrect(2)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerThree.Clicked += (sender, ea) =>
            {
                if (((QuickSortQuestionViewModel)BindingContext).CheckIfCorrect(3))
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
                ((QuickSortQuestionViewModel)BindingContext).ChooseNewQuestion();
            }
            else
            {
                NavigateToEndPage();
            }
        }

        private async void NavigateToEndPage()
        {
            string MissionFive = "Five";
            Preferences.Set("accessToken", MissionFive);
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/popUp.png", "You have unlocked 🔓 Mission Five Successfuly 🏆 Now move to the next Mission"));
            //await CloseThisPage();
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await CloseThisPage();
        }

        private async Task CloseThisPage()
        {
            await this.Navigation.PopModalAsync(false);
        }
    }
}