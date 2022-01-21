using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
 
namespace dllclientcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.Load("dllsharp");
            Object o = a.CreateInstance("vscode");
            Type t = a.GetType("vscode");

            Object[] numbers = new Object[2];
            numbers[0] = 2;
            numbers[1] = 3;
            MethodInfo mi = t.GetMethod("add");
            Console.WriteLine(mi.Invoke(o, numbers));
            mi = t.GetMethod("sub");
            Console.WriteLine(mi.Invoke(o, numbers));
            //чтобы консоль мгновенно не закрылась
            Console.ReadLine();
        }
    }
}