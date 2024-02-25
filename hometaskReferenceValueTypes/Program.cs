using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;

namespace hometaskReferenceValueTypes;



internal class Program
{
    static void Main(string[] args)
    {
        #region Task1

        //int[] array = { 1,-2, -3, 4, -5 };

        //convertNegatives(ref array);

        #endregion

        #region Task2

        //Repeat("Ha!",3);

        #endregion

        #region Task3

        //Console.WriteLine(isPalendrome("kukukuk"));

        #endregion

        #region Task4fix


        //string word = "safgweafasdwqasfwafs";

        //Console.WriteLine(removeRepeatingLetters(word));

        #endregion

        #region Task5


        //string word = "Salam";

        //Console.WriteLine(reverseWord(word));


        #endregion

        #region Task6yaz




        #endregion

        #region Task7



        #endregion

    }



    static void convertNegatives(ref int[] array)
    {
        int[] arr2 = new int[array.Length];

        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                arr2[temp] = array[i];
                temp++;
            }
            else if (array[i] < 0)
            {
                arr2[temp] = array[i] + (array[i] * -2);
                temp++;
            }
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine(arr2[i]);
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

    static bool isPalendrome(string word)
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
                    return true;
                }
            }

        }
        return false;

    }

    static StringBuilder removeRepeatingLetters(string word)
    {
        StringBuilder newWord = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
          for (int j = i+1; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    newWord.Append(word[i]);
                    break;
                }
            }
        }
        return newWord;



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



}


















