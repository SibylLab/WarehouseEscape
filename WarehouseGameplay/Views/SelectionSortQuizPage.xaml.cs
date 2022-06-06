
using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using WarehouseGameplay.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectionSortQuizPage : ContentPage
    {
        int _choice = 0;
        int score = 100;
        private int QUESTIONS_COUNT = 4;
        private int CurrentQuestion = 1;

        public SelectionSortQuizPage()
        {
            InitializeComponent();
            ((SelectionSortQuestionViewModel)BindingContext).LoadQuestions();

            btnAnswerOne.Clicked += (sender, ea) =>
            {
                if (((SelectionSortQuestionViewModel)BindingContext).CheckIfCorrect(1)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((SelectionSortQuestionViewModel)BindingContext).CheckIfCorrect(2)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerThree.Clicked += (sender, ea) =>
            {
                if (((SelectionSortQuestionViewModel)BindingContext).CheckIfCorrect(3))
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
                ((SelectionSortQuestionViewModel)BindingContext).ChooseNewQuestion();
            }
            else
            {
                NavigateToEndPage();
            }
        }

        private async void NavigateToEndPage()
        {
            string MissionFour = "Four";
            Preferences.Set("accessToken", MissionFour);
            QUESTIONS_COUNT = 1;
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/popUp.png", "You have unlocked 🔓 Mission Four Successfuly 🏆 Now move to the next Mission"));
            //await CloseThisPage();
        }

        private async void ButtonClose_Clicked(object sender, EventArgs e)
        {
            await CloseThisPage();
        }

        private async Task CloseThisPage()
        {
            await this.Navigation.PopAsync(false);
        }
    }
}