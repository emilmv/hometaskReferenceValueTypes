using System.Buffers;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;

namespace hometaskReferenceValueTypes;



internal class Program
{
    static void Main(string[] args)
    {
        #region Task1

        //int[] array = { 1, -2, -3, 4, -5 };

        //convertNegatives(ref array);

        #endregion

        #region Task2

        //Repeat("Ha!",3);

        #endregion

        #region Task3

        //Console.WriteLine(isPalendrome("fafafafaf"));

        #endregion

        #region Task4
        
        //string word = "ggff32553fefagas";

        //removeRepeatingChars(word);

        #endregion

        #region Task5


        //string word = "Salam";

        //Console.WriteLine(reverseWord(word));


        #endregion

        #region Task6


        //string word = "salam necesen salam necesen";
        //changeString(word);



        #endregion

        #region Task7

        //int[] arr = { 1, 2, 4, 5, 6, 7, 88, 5, 43, 32, 6 };

        //bubbleSort(arr);
        //foreach (int i in arr)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region Task8

        //string word = "salam necesen?";

        //Console.WriteLine(firstFourLetters(word));

        #endregion

    }



    static void convertNegatives(ref int[] array)
    {
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array[temp] = array[i];
                temp++;
            }
            else if (array[i] < 0)
            {
                array[temp] = array[i] + (array[i] * -2);
                temp++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }


    }

    static void Repeat(string word, int count)
    {
        StringBuilder newWord = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            newWord.Append(word[i]);
        }
        for (int i = 1; i < count; i++)
        {
            newWord.Append(word);
        }

        Console.WriteLine(newWord);
    }

    static string isPalendrome(string word)
    {

        int count = 0;
        StringBuilder newWord = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            newWord.Append(word[i]);
        }
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == newWord[i])
            {
                count++;
                if (count == newWord.Length)
                {
                    return word+" sozu - Palendromdur";
                }
            }

        }
        return word+" sozu - Palendrom deyil";

    }

    static void removeRepeatingChars(string word)
    {
        string newWord = "";
        bool exists = true;
        foreach (char c in word)
        {
            exists = false;
            foreach (char d in newWord)
            {
                if (d == c)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                newWord += c;
            }

        }
        Console.WriteLine(newWord);



    }

    static StringBuilder reverseWord(string word)
    {
        StringBuilder newWord = new StringBuilder();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            newWord.Append(word[i]);
        }
        return newWord;
    }

    static void changeString(string word)
    {
        string newWord = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i]!=' ') 
            {
                newWord += word[i];
            }
            if (i == word.Length - 1 || word[i + 1] == ' ')
            { 
                Console.WriteLine(newWord);
                newWord = string.Empty;
            }
        }
    }

    static void bubbleSort(int[] arr)
    {
        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    static StringBuilder firstFourLetters(string word)
    {
        StringBuilder newWord = new StringBuilder();

        for (int i = 0; i < 4; i++)
        {
            newWord.Append(word[i]);
        }


        return newWord;
    }




}











