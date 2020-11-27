using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{   
    // Using Sealed Class
    public sealed class A
    {
        int a = 5;
    }

    public class B : A
    {
        int b = 6;
    }

    // Using Private Class
    public private class C
    {
        int a = 5;
    }

    public class D : C
    {
        int b = 6;
    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
