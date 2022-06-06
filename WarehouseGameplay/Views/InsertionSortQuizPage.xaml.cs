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
    public partial class InsertionSortQuizPage : ContentPage
    {
        int _choice = 0;
        int score = 100;
        private int QUESTIONS_COUNT = 4;
        private int CurrentQuestion = 1;

        public InsertionSortQuizPage()
        {
            InitializeComponent();
            ((InsertionSortQuestionViewModel)BindingContext).LoadQuestions();

            btnAnswerOne.Clicked += (sender, ea) =>
            {
                if (((InsertionSortQuestionViewModel)BindingContext).CheckIfCorrect(1)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((InsertionSortQuestionViewModel)BindingContext).CheckIfCorrect(2)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerThree.Clicked += (sender, ea) =>
            {
                if (((InsertionSortQuestionViewModel)BindingContext).CheckIfCorrect(3))
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
                ((InsertionSortQuestionViewModel)BindingContext).ChooseNewQuestion();
            }
            else
            {
                NavigateToEndPage();
            }
        }

        private async void NavigateToEndPage()
        {
            string MissionOne = "Three";
            Preferences.Set("accessToken", MissionOne);
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/popUp.png", "You have unlocked 🔓 Mission Three Successfuly 🏆 Now move to the next Mission"));
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