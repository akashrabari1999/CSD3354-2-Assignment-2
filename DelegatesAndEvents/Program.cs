using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;



public delegate void MyDelegate();

public class DelegateExercises
{
    void Method3()
    {
        System.Console.WriteLine(MyDelegate.ToString());
    }
}