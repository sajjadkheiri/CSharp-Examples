using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Ref_In_Out;

public class Samples
{
    /// <summary>
    /// Give a reference to a storge instead of using 2 variable
    /// Ref : It Lets you to us a reference of a variable instead of 2 different variable
    /// You have to initialize the variable that you should send in input parameter
    /// </summary>
    public void Ref_Caller()
    {
        int counter = 1;

        Console.WriteLine(counter);

        //ChangeData(counter);

        //OR

        Ref_ChangeData(ref counter);

        Console.WriteLine(counter);
    }

    public void Ref_ChangeData(ref int counter)
    {
        counter++;
    }

    /// <summary>
    /// In : You cannot change a value of a variable
    /// You can just use from that value
    /// </summary>
    public void In_Caller()
    {
        int counter = 1;

        Console.WriteLine(counter);

        In_ChangeData(in counter);

        Console.WriteLine(counter);
    }

    public void In_ChangeData(in int counter)
    {
        //Error
        //counter++;

        Console.WriteLine(counter);
    }

    /// <summary>
    /// Out : It is not necessary to initialize the input parameter
    /// </summary>
    public void Out_Caller()
    {
        int counter;
        
        Out_ChangeData(out counter);

        Console.WriteLine(counter);
    }

    public void Out_ChangeData(out int counter)
    {
        counter = 3;
    }
}
