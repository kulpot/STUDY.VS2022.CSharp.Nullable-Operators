using System;

//ref link:https://www.youtube.com/watch?v=Tj_s5hUCPMM&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=20
//

class MainClass
{
    static void Main()
    {
        int? a = null;
        int? b = null;
        Console.WriteLine(a == b);
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);


        int? i = 5;
        //Nullable<int> j = 6;
        Nullable<int> j = null;
        int? sum = i + j;
        JNullable<int> jI = new JNullable<int>(5);
        //JNullable<int> jJ = new JNullable<int>(6);
        JNullable<int> jJ = new JNullable<int>();
        //JNullable<int> jSum = jI + jJ; // error
        JNullable<int> jSum =
            (jI.HasValue && jJ.HasValue) ?
            new JNullable<int>(jI.Value + jJ.Value) :
            new JNullable<int>();
        Console.WriteLine(sum);
        Console.WriteLine(jSum);
        //Console.WriteLine(j.ToString() == null);
        Console.WriteLine(j.ToString() == "");

        

        //DateTime? d = DateTime.Now;
        //d = d + d;
    }
}