using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using WarehouseGameplay.Models;
using WarehouseGameplay.QuizData;

namespace WarehouseGameplay.ViewModels
{
    public class SelectionSortQuestionViewModel : INotifyPropertyChanged
    {
        private int _correctAnswer = 0;
        public int CorrectAnswer {
            get
            {
                return this._correctAnswer;
            }
            set
            {
                this._correctAnswer = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("CorrectAnswer"));
            }
        }
        private string _question;
        public string Question {
            get
            {
                return this._question;
            }
            set
            {
                this._question = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Question"));
            }
        }

        private string _answer1;
        public string Answer1 {
            get
            {
                return this._answer1;
            }
            set
            {
                this._answer1 = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer1"));
            }
        }

        private bool _answer1Enabled;
        public bool Answer1Enabled {
            get
            {
                return this._answer1Enabled;
            }
            set
            {
                this._answer1Enabled = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer1Enabled"));
            }
        }

        private string _answer2;
        public string Answer2 {
            get
            {
                return this._answer2;
            }
            set
            {
                this._answer2 = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer2"));
            }
        }

        private bool _answer2Enabled;
        public bool Answer2Enabled {
            get
            {
                return this._answer2Enabled;
            }
            set
            {
                this._answer2Enabled = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer2Enabled"));
            }
        }

        private string _answer3;
        public string Answer3 {
            get
            {
                return this._answer3;
            }
            set
            {
                this._answer3 = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer3"));
            }
        }

        private bool _answer3Enabled;
        public bool Answer3Enabled {
            get
            {
                return this._answer3Enabled;
            }
            set
            {
                this._answer3Enabled = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer3Enabled"));
            }
        }

        private List<SelectionSortQuiz> _questionList;
        List<Models.SelectionSortQuiz> QuestionList {
            get
            {
                return this._questionList;
            }
            set
            {
                this._questionList = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("QuestionList"));
            }
        }

        Random rnd = new Random();

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isLoading;
        public bool IsLoading {
            get
            {
                return this._isLoading;
            }
            set
            {
                this._isLoading = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("IsLoading"));
            }
        }

        private string _message;
        public string Message {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Message"));
            }
        }

        public SelectionSortQuestionViewModel()
        {
            //LoadQuestions();
        }

        public bool CheckIfCorrect(int correct)
        {
            if (CorrectAnswer == correct)
            {
                Message = "Congratulations your answer is Correct ✅";
                return true;
            }
            Message = "Oops Wrong sorry your answer is wrong ❎";
            return true;
        }

        public Task LoadQuestions()
        {
            IsLoading = true;


            try
            {
                QuestionList = AllQuiz.SelectionSortQuizzes();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
            }


            IsLoading = false;
            ChooseNewQuestion();
            return Task.CompletedTask;
        }

        int next = 0;
        public void ChooseNewQuestion()
        {
            IsLoading = true;
            int _questionNumber = next;


            if (_questionNumber == QuestionList.Count)
                return;

            Models.SelectionSortQuiz selectedItem = QuestionList[_questionNumber];
            next++;
            Answer1Enabled = true;
            Answer2Enabled = true;
            Answer3Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;
            Answer3 = selectedItem.Answer3;

            CorrectAnswer = selectedItem.CorrectAnswer;

            IsLoading = false;
        }
    }
}

