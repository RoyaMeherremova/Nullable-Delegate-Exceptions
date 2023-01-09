using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Delegate_Collections
{
    public class PracticeDelegate
    {
        #region Predicate
        //public delegate bool CheckNums(int num);

        //public bool CheckNumByOdd(int number)
        //{
        //    return number % 2 == 1;
        //}
        //public bool CheckNumByEven(int number)=> number % 2 == 0;
        //public bool CheckNumThanFive(int number) => number>5;

        //public void CheckDelegate()
        //{
        //    List<int> list = new List<int>() { 1, 2, 3, 4, 5,7 };
        //    //list.FindAll(m => m > 5);
        //    Console.WriteLine(SumOfListByItems(m => m > 5, list));
        //}

        //static int SumOfListByItems(Predicate<int> func, List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //static int SumOfListByItems(CheckNums func, List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //static int SumOfListByEven(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //static int SumOfListByOdd(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 1)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //public int SumOfListThanFive(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}



        #endregion
        #region Action
        //public delegate void Changestring(string str);

        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());

        //} 
        //public void StringToLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());

        //}
        //public void CheckWord()
        //{
        //    ShowWord(StringToUpper, "Cavid");
        //    ShowWord(StringToLower, "Cavid");

        //Changestring changestring = StringToUpper;
        //changestring +=(string str)=> Console.WriteLine(str.ToLower());
        //changestring("Pervin");
        //Action<string> action = StringToUpper;
        //action += StringToLower;
        //action("Pervin");

        //}


        //public void ShowWord(Changestring func, string str)
        //{
        //    func(str);
        //}
        #endregion
        #region Func
        //public delegate int CheckStrinLength(string str,int age);

        //public int GetStringLength(string word,int num)
        //{
        //    return word.Length+num;
        //}
        //public void ShowString()
        //{
        //    //ShowStringLegth(GetStringLength, "Cavid");
        //    Func<string, int, int> func = GetStringLength;
        //    Console.WriteLine(func("Cahandar", 6));

        //}
        //public void ShowStringLegth(Func<string,int,int> func, string str)=> Console.WriteLine(func(str, 10));

        //public void ShowStringLegth(CheckStrinLength func,string str)
        //{
        //    Console.WriteLine(func(str,10));
        //}

        #endregion

       

    }
}
