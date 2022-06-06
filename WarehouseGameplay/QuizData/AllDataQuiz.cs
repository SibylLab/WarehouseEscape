using System;
using System.Collections.Generic;
using System.Text;
using WarehouseGameplay.Models;

namespace WarehouseGameplay.QuizData
{
    public class AllQuiz
    {
        public AllQuiz()
        {
            
        }
        public static List<WarehouseGameplay.Models.MergeSortQuiz> MergeSorQuizzes()
        {
            List<MergeSortQuiz> quizzes = new List<Models.MergeSortQuiz>()
            {

                new MergeSortQuiz
                {
                    Question = " Merge sort uses which of the following technique to implement sorting?",
                    Answer1 = "Linear search ",
                    Answer2 = "Divide and conquer",
                    Answer3 = "Divding list 1 time",
                    CorrectAnswer = 2
                },

                new MergeSortQuiz
                {
                    Question = " How do merge sorts work?",
                    Answer1 =" By splitting the list into single elements before merging them back together, one sublist at a time.",
                    Answer2 = " Taking one item at a time from an unsorted list, each new item is compared with the previous until its place is found.",
                    Answer3 = " Each item in the list is compared with the following item starting with the last value till the first.",
                    CorrectAnswer = 1
                },

                new MergeSortQuiz
                {
                    Question = "What are the correct intermediate steps of the following item set when it is being sorted with the Merge sort? 15,20,10,18?",
                    Answer1 =" 15,18,10,20 -- 10,18,15,20 -- 10,15,18,20",
                    Answer2 = " 15,20,10,18 -- 10,15,20,18 -- 10,15,18,20",
                    Answer3 = " 15,10,20,18 -- 15,10,18,20 -- 10,15,18,20",
                    CorrectAnswer = 2
                },
                new MergeSortQuiz
                {
                    Question = " Which element will be in position 5 in the new merged list, when following two lists are to be merged? List 1: 2 4 8 9  List 2: 1 6 11 12 ?",
                    Answer1 =" 4",
                    Answer2 = " 5",
                    Answer3 = " 8",
                    CorrectAnswer = 3
                },

                new MergeSortQuiz
                {
                    Question = " The following two lists are to be merged, which element first goes into the new merged list? List 1:  2, 5, 6,7   List 2:  1, 9, 12, 15",

                    Answer1 =" 1",
                    Answer2 = " 2",
                    Answer3 = " 5",
                    CorrectAnswer = 1
                },


                new MergeSortQuiz
                {

                    Question = "Merge sort uses which of the following technique to implement sorting?",
                    Answer1 ="Backtracking",
                    Answer2 = "Greedy algorithm",
                    Answer3 = "Divide and conquer",
                    CorrectAnswer = 3
                },
                new MergeSortQuiz
                {
                    Question = " Which of the following method is used for sorting in merge sort?",
                    Answer1 ="Merging",
                    Answer2 = "Partitioning",
                    Answer3 = "Exchanging",
                    CorrectAnswer = 1
                },
                new MergeSortQuiz
                {
                    Question = "Which of the following is not a variant of merge sort?",
                    Answer1 ="linear merge sort",
                    Answer2 = "In-place merge sort",
                    Answer3 = "Bottom up merge sort",
                    CorrectAnswer = 2
                },
                new MergeSortQuiz
                {
                    Question = " Which of the following sorting algorithm makes use of merge sort?",
                    Answer1 ="tim sort",
                    Answer2 = "Intro sort",
                    Answer3 = "Bogo sort",
                    CorrectAnswer = 1
                },
                new MergeSortQuiz
                {
                    Question = "Choose the incorrect statement about merge sort from the following?",
                    Answer1 =" it is a comparison based sort",
                    Answer2 = "it is an adaptive algorithm",
                    Answer3 = "it is not an in place algorithm",
                    CorrectAnswer = 2
                }
            };
            return quizzes;
        }
        public static List<WarehouseGameplay.Models.LinearSearchQuiz> LinearSearchQuizzes()
        {
            List<LinearSearchQuiz> quizzes = new List<Models.LinearSearchQuiz>()
            {
                new LinearSearchQuiz
                {
                    Question = "How many comparisons will linear search take to find the value 14 in the list [3, 100, 1, 14, 8, 7, 10, 28]?",
                    Answer1 ="6",
                    Answer2 = "3",
                    Answer3 = "4",
                    CorrectAnswer = 3
                },
                 new LinearSearchQuiz
                {
                    Question = " Which of the following would be an advantage of using linear search?",
                    Answer1 ="If the list of items is large, it will quickly find the item.",
                    Answer2 = " If the item is in the list, it will always be found.",
                    Answer3 = " It only needs one comparision to find the item. ",
                    CorrectAnswer = 2
                },
                 new LinearSearchQuiz
                {
                    Question = "What happens when no “match is found” in linear search algorithm?",
                    Answer1 = "It will check the list at least 10 times before exiting the loop.",
                    Answer2 = "It will check the list once and give the result",
                    Answer3 = "It will give the nearest possible result",
                    CorrectAnswer = 2
                },
                new LinearSearchQuiz
                {
                    Question = "Data should be ordered to apply linear search algorithm?",
                    Answer1 ="yes",
                    Answer2 = "No",
                    Answer3 = "Always",
                    CorrectAnswer = 2
                },
                 new LinearSearchQuiz
                {
                    Question = "The List is as follows: 1,2,3,6,8,10. At what time the element 6 is found if linear search is applied?" ,
                    Answer1 ="4th call",
                    Answer2 = " 3rd call",
                    Answer3 = " 5rd call",
                    CorrectAnswer = 1
                },
                new LinearSearchQuiz
                {
                    Question = "Which of the following would be a good name for linear search?",
                    Answer1 = "Divide and conquer search",
                    Answer2 = "Bubble sort",
                    Answer3 = "Sequential search",
                    CorrectAnswer = 3
                },


                new LinearSearchQuiz
                {
                    Question = " where can linear search be performed?",
                    Answer1 ="Letters",
                    Answer2 = "Numbers",
                    Answer3 = "Both",

                    CorrectAnswer = 3
                },
                new LinearSearchQuiz
                {
                    Question = " Which of the following would be a disadvantage of using linear search?",
                    Answer1 =" If the list of items is large, it will take a long time to find the item ",
                    Answer2 = " If the item is in the list, it might not find it.",
                    Answer3 = " It will work only itemif the items are sorted.",
                    CorrectAnswer = 1
                },
                new LinearSearchQuiz
                {
                    Question = "What will happen if linear search cannot find the item?",
                    Answer1 = " The closest possible result will be returned.",
                    Answer2 = " The search will keep going in a never ending loop.",
                    Answer3 = " Nothing will be returned.",
                    CorrectAnswer = 3
                },
                new LinearSearchQuiz
                {
                    Question = "Which of the following best describes linear search?",
                    Answer1 =" It checks each item in turn.",
                    Answer2 = " Put the items in order, check each item in turn.",
                    Answer3 = " Compare the middle value, lf the item is less than it, look in the left, otherwise look in right.",
                    CorrectAnswer = 1
                },


                new LinearSearchQuiz
                {
                    Question = "which of the following is the advantage of linear search?",
                    Answer1 ="It can only be applied on numbers that are already sorted",
                    Answer2 = "It can search targeted item in one comparison",
                    Answer3 = "It performs well on small sized data set",
                    CorrectAnswer = 3
                },

                new LinearSearchQuiz
                {
                    Question = "what is disadvantage of linear search algorithm?",
                    Answer1 = "It is perfect there is no disadvantage",
                    Answer2 = "It will work only on sorted data items",
                    Answer3 = "Could take too many comparisons which can be too slow to process large data sets",
                    CorrectAnswer = 3
                },
                new LinearSearchQuiz
                {
                    Question = " How many comparisons will linear search make to find the value [Ferry] in the list [Molly, George, Ali, Sarah, Mabel, Sony, Ferry}?",

                    Answer1 =" 6",
                    Answer2 = " 7",
                    Answer3 = " 8",
                    CorrectAnswer = 2
                },


                 new LinearSearchQuiz
                {
                    Question = "which of the following best describes linear search?",
                    Answer1 = "Elements do not need to be in order, check each item in turn",
                    Answer2 = "Put the elements in order, check each item in turn",
                    Answer3 = "Elements do not need to be in order, compare to the middle value, split the list in order and repeat ",
                    CorrectAnswer = 1
                },
            };
            return quizzes;
        }
        public static List<WarehouseGameplay.Models.BinearySearchQuiz> BinarySearchQuizzes()
        {
            List<BinearySearchQuiz> quizzes = new List<Models.BinearySearchQuiz>()
            {

                new BinearySearchQuiz
                {
                    Question = " Which of the following best describes Binary search?",

                    Answer1 =" Put the items in order and compare the middle value, lf the item is less than it, look in the left, otherwise look in right.",
                    Answer2 = " Put the items in order, check each item in turn.",
                    Answer3 = " Compare the middle value, lf the item is less than it, look in the left, otherwise look in right.",
                    CorrectAnswer = 3
                },
                new BinearySearchQuiz
                {
                    Question = " Perform Binary search on this list: [3, 5 , 9, 10 , 23 ].How many comparisons does it take to find number 9?",
                    Answer1 ="1",
                    Answer2 = "2-3",
                    Answer3 = "Can’t find number 9",
                    CorrectAnswer = 1
                },
                new BinearySearchQuiz
                {
                    Question = " How many comparisons would it take to find the value 2 in the following list using a binary? [1, 4, 7, 8, 5, 2, 9]",
                    Answer1 ="2",
                    Answer2 = "6",
                    Answer3 = "Binary search won’t work, the list is out of order",
                    CorrectAnswer = 3
                },


                new BinearySearchQuiz
                {
                    Question = "Which of the following is not an application of binary search?",
                    Answer1 ="Union of intervals",
                    Answer2 = " Debugging",
                    Answer3 = "To search in unordered list",
                    CorrectAnswer = 3
                },
                new BinearySearchQuiz
                {
                    Question = " Binary Search can be categorized into which of the following?",
                    Answer1 =" Brute Force technique",
                    Answer2 = "Divide and conquer",
                    Answer3 = " Greedy algorithm",
                    CorrectAnswer = 2
                },
                new BinearySearchQuiz
                {
                    Question = " Given an array arr = {5,6,77,88,99} and key = 88; How many iterations are done until the element is found?",
                    Answer1 ="3",
                    Answer2 = " 4",
                    Answer3 = " 2",
                    CorrectAnswer = 3
                },
                new BinearySearchQuiz
                {
                    Question = " Given an array arr = {45,77,89,90,94,99,100} and key = 100; What are the mid values(corresponding array",
                    Answer1 ="  90 and 99",
                    Answer2 = "90 and 100",
                    Answer3 = "89 and 94",
                    CorrectAnswer = 1
                }
            };
            return quizzes;
        }
        public static List<WarehouseGameplay.Models.InertionSortQuiz> InertionSortQuizzes()
        {
            List<InertionSortQuiz> quizzes = new List<Models.InertionSortQuiz>()
            {


                new InertionSortQuiz
                {
                    Question = "Which of the following shows how the list will change when it is being sorted with the Insertion sort? [15, 20, 10, 18]?",
                    Answer1 =" 15,20,10,18 -- 20,15,10,18 -- 20,10,15,18 – 10,15,18,20 ",
                    Answer2 = " 15,20,10,18 -- 10,15,20,18 -- 10,15,18,20 -- 10,15,18,20 ",
                    Answer3 = " 15,20,10,18 -- 18,15,20,10 -- 10,18,15,20 -- 10,15,18,20 ",
                    CorrectAnswer = 2
                },
                new InertionSortQuiz
                {
                    Question = " Insertion sort is part of the way through sorting a list of items, with the list shown below. How many comparisons and swaps are needed to sort the next number which is 5? [1 3 4 8 9 || 5 2]?",
                    Answer1 = " 2 comparisons, 3 swaps",
                    Answer2 = " 3 comparisons, 3 swaps",
                    Answer3 = " 3 comparisons, 2 swaps",
                    CorrectAnswer = 3
                },

                new InertionSortQuiz
                {
                    Question = " What operation(s) does the Insertion Sort use to move numbers from the unsorted section to the sorted section of the list?",
                    Answer1 =" Finding the smallest value in the list, put it at the front of the list and shift all of the items down",
                    Answer2 = " Swapping random items until the list is in order",
                    Answer3 = " Finding the smallest item in the list and swapping with the first out of order item",
                    CorrectAnswer = 2
                },
                new InertionSortQuiz
                {
                    Question = " What will be the number of times we go through this list to sort the elements using insertion sort? [14, 12,16, 6, 3, 10?",
                    Answer1 =" 5",
                    Answer2 = " 6",
                    Answer3 = " 7",
                    CorrectAnswer = 1
                },


                new InertionSortQuiz
                {
                    Question = "Which of the following algorithm implementations is similar to that of an insertion sort?",
                    Answer1 =" Binary heap",
                    Answer2 = " Quick sort",
                    Answer3 = " Quick sort",
                    CorrectAnswer = 1
                },
                new InertionSortQuiz
                {
                    Question = "What is the average number of inversions in an array of N distinct numbers?",
                    Answer1 ="N(N-1)/4",
                    Answer2 = "N(N+1)/2",
                    Answer3 = "  N(N-1)/2",
                    CorrectAnswer = 1
                },
                new InertionSortQuiz
                {
                    Question = "Which of the following options contain the correct feature of an insertion sort algorithm?",
                    Answer1 =" dependable",
                    Answer2 = "stable, not in-place",
                    Answer3 = "stable, adaptive",
                    CorrectAnswer = 3
                },
                new InertionSortQuiz
                {
                    Question = "Which of the following sorting algorithms is the fastest for sorting small arrays?",
                    Answer1 ="Quick sort",
                    Answer2 = "Insertion sort",
                    Answer3 = "Heap sort",
                    CorrectAnswer = 2
                }
            };
            return quizzes;
        }
        public static List<WarehouseGameplay.Models.SelectionSortQuiz> SelectionSortQuizzes()
        {
            List<SelectionSortQuiz> quizzes = new List<Models.SelectionSortQuiz>()
            {

                new SelectionSortQuiz
                {
                    Question = " How does Selection sort work?",
                    Answer1 =" Check the item in the middle of the list, and put all of the items less than the middle to left and all the items bigger to right. Keep doing this for the lists to the left and right of the middle.",
                    Answer2 = " Compare each item in the list with its adjacent item and swap them if needed. Keep doing this to the list until no more swaps are made.",
                    Answer3 = " Find the smallest item in the list and exchange it with the left-most unsorted item in the list.",
                    CorrectAnswer = 3
                },

                new SelectionSortQuiz
                {
                    Question = " How many comparisons are required by selection sort to sort the following list into ascending order? [5,4,3,2,1]?",
                    Answer1 =" 5",
                    Answer2 = " 10",
                    Answer3 = " 20",
                    CorrectAnswer = 2
                },
                new SelectionSortQuiz
                {
                    Question = " What is the first step in the selection sort algorithm?",
                    Answer1 =" Find the smallest item in the list ",
                    Answer2 = " Find the largest item in the list ",
                    Answer3 = " Divide the list in half",
                    CorrectAnswer = 1
                },
                new SelectionSortQuiz
                {
                    Question = " What will the list of items look like after the first time selection sort goes through the list to sort it into ascending order: [3 1 4 2]?",
                    Answer1 =" 3 ,2, 4, 1 ",
                    Answer2 = " 1, 3, 4, 2 ",
                    Answer3 = " 2, 4, 1, 3  ",
                    CorrectAnswer = 2
                },
                new SelectionSortQuiz
                {
                    Question = " The list [ 1, 2, 3, 4, 5] is already sorted. How many times will selection sort go through the list before it stops?",
                    Answer1 =" 0 ",
                    Answer2 = " 1 ",
                    Answer3 = " 4",
                    CorrectAnswer = 3
                },


                new SelectionSortQuiz
                {
                    Question = " The given array is arr = {3,4,5,2,1}. The number of iterations in bubble sort and selection sort respectively are",
                    Answer1 ="5 and 4",
                    Answer2 = " 4 and 5",
                    Answer3 = "2 and 4",
                    CorrectAnswer = 1
                },
                new SelectionSortQuiz
                {
                    Question = "What is the best case complexity of selection sort?",
                    Answer1 ="O(nlogn)",
                    Answer2 = "O(logn)",
                    Answer3 = "O(n2)",
                    CorrectAnswer = 3
                },
                new SelectionSortQuiz
                {
                    Question = "It requires no additional storage space",
                    Answer1 ="It is scalable",
                    Answer2 = "Insertion sort",
                    Answer3 = "It works best for inputs which are already sorted",
                    CorrectAnswer = 1
                }
            };
            return quizzes;
        }
        public static List<WarehouseGameplay.Models.QuickSortQuiz> QuickSortQuizzes()
        {
            List<QuickSortQuiz> quizzes = new List<Models.QuickSortQuiz>()
            {
                new QuickSortQuiz
                {
                    Question = "Which of the following sorting algorithms is the fastest?",
                    Answer1 ="Merge sort",
                    Answer2 = " Quick sort",
                    Answer3 = "Insertion sort",
                    CorrectAnswer = 2
                },
                new QuickSortQuiz
                {
                    Question = " Divide and conquer refers to?",
                    Answer1 =" The list being divided into sublists with equal numbers of elements in each, then those sorted sublists are merged back together.",
                    Answer2 = " The list being divided into only two sublists, never more or less, which are sorted and merged back together.",
                    Answer3 = " The list being divided into smaller sublists, then those sorted sublists are merged back together.",
                    CorrectAnswer = 3
                },
                new QuickSortQuiz
                {
                    Question = " what happens when the list is divided into two sublists in quick sort??",
                    Answer1 =" Both sublists are now sorted.",
                    Answer2 = " Sublists are sorted using quicksort and then merged.",
                    Answer3 = " Both lists are merged without performing further action.",
                    CorrectAnswer = 2
                },
                new QuickSortQuiz
                {
                    Question = " Which of the following shows the list after the first iteration of quick sort? [7, 11, 14, 6, 9, 4, 3, 12]?",
                    Answer1 =" 7,6,4,3,9,14,11,12",
                    Answer2 = " 7,6,14,11,9,4,3,1",
                    Answer3 = " 7,6,4,3,14,9,11,12",
                    CorrectAnswer = 2
                },

                new QuickSortQuiz
                {
                    Question = " After the list is first split, what are the possible positions for the smallest item in the array? Assume that no items are equal.?",
                    Answer1 =" It must be in the first position. .",
                    Answer2 = " It must be to the left of the pivot.",
                    Answer3 = " It can be anywhere but the last position.",
                    CorrectAnswer = 3
                },

                new QuickSortQuiz
                {
                    Question = "What is the worst case time complexity of a quick sort algorithm?",
                    Answer1 ="O(N)",
                    Answer2 = "O(N log N)",
                    Answer3 = " O(N2)",
                    CorrectAnswer = 3
                },
                new QuickSortQuiz
                {
                    Question = "Which of the following methods is the most effective for picking the pivot element?",
                    Answer1 ="first element",
                    Answer2 = "last element",
                    Answer3 = "median-of-three partitioning",
                    CorrectAnswer = 3
                },
                new QuickSortQuiz
                {
                    Question = "Which of the following sorting algorithms is used along with quick sort to sort the sub arrays?",
                    Answer1 ="Merge sort",
                    Answer2 = "Insertion sort",
                    Answer3 = "Bubble sort",
                    CorrectAnswer = 2
                },
                new QuickSortQuiz
                {
                    Question = "How many sub arrays does the quick sort algorithm divide the entire array into?",
                    Answer1 ="one",
                    Answer2 = "two",
                    Answer3 = "three",
                    CorrectAnswer = 2
                }
            };
            return quizzes;
        }
    }
}

