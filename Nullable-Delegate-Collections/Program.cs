

//string name = null;
//int? num = null;
////if (name==null)
////{
////    Console.WriteLine("Bosdur");
////}
//int? n = 5;
//GetPersonById(n);
//static void  GetPersonById(int? id)
//{
//    if (id == null)
//    {
//        Console.WriteLine("NotFound");
//    }
//}

using Nullable_Delegate_Collections;
using Nullable_Delegate_Collections.Constans;
using Nullable_Delegate_Collections.Exeptions;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System.Runtime.InteropServices;

//PracticeDelegate calculate = new PracticeDelegate();
////calculate.CheckDelegate();
//calculate.CheckWord();
//calculate.ShowString();



//int[] arr = { 1, 2, 3 };
//arr[5] = 100;

//try
//{
//    int n = 5;
//    int m = 0;
//    Divide(n, m);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}
//Divide(5, 1);
//static void Divide(int n, int m)
//{
//    bool isSuccess = false;
//    try
//    {
//        var res = n / m;
//        Console.WriteLine(res);
//        isSuccess = true;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        isSuccess = false;

//    }
//    finally
//    {
//        string message = string.Empty;
//        if (isSuccess)
//        {
//           message="Register is ok";
//        }
//        else
//        {
//           message="Something is wrong";    
//        }
//         SendEmail(message);
//    }


//}

//static void SendEmail(string message)
//{
//    Console.WriteLine(message);
//}
//Divide1(5,0);
//static void Divide1(int n, int m)
//{
//    try
//    {
//        var res = n / m;
//        Console.WriteLine(res);

//    }
//    catch (IndexOutOfRangeException ex)
//    {
//        Console.WriteLine(ex.Message);


//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine(ex.Message);

//    }



//}

//Login("test", "pervin12345");
//static void Login(string username,string password)
//{
//	try
//	{
//		if (username=="pervin123"&&password=="pervin12345")
//		{
//			Console.WriteLine("Login is succes");
//		}
//		else
//		{
//			throw new InvaliLoginException(ExceptinsMessages.InvalidLogin );
//		}
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}


//IEmployeeService employee = new EmployeeService();
//var result=employee.GetCountByAge(20);
//Console.WriteLine(result);