using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using WarehouseGameplay.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MergeSortQuizPage : ContentPage
    {
        int _choice = 0;
        int score = 100;
        private int QUESTIONS_COUNT = 4;
        private int CurrentQuestion = 1;

        public MergeSortQuizPage()
        {
            InitializeComponent();
            ((MergeSortQuestionViewModel)BindingContext).LoadQuestions();

            btnAnswerOne.Clicked += (sender, ea) =>
            {
                if (((MergeSortQuestionViewModel)BindingContext).CheckIfCorrect(1)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((MergeSortQuestionViewModel)BindingContext).CheckIfCorrect(2)) DoAnswer();
                else
                {
                    score = score / 2;
                }
            };

            btnAnswerThree.Clicked += (sender, ea) =>
            {
                if (((MergeSortQuestionViewModel)BindingContext).CheckIfCorrect(3))
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
                ((MergeSortQuestionViewModel)BindingContext).ChooseNewQuestion();
            }
            else
            {
                NavigateToEndPage();
            }
        }

        private async void NavigateToEndPage()
        {
            string MissionSix = "Six";
            Preferences.Set("accessToken", MissionSix);
            await PopupNavigation.Instance.PushAsync(new PopUpMessageBox("Resources/drawable/popUp.png", "You have unlocked 🔓 Mission Six Successfuly 🏆 Now move to the next Mission"));
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