using System;

class LabExer2_Alburan_Tom
{
    static void Main()
    {
        // dito po for the uniqueness lang po, nag greeting ako and binago ko po yung first line po ng nandun po sa example pic na nasa lab exercise2
        Console.WriteLine("Hello! My name is Tom, Let me help you to calculate the average of 5 grades.");
        Console.WriteLine("Please enter 5 grades, one by one:");

        Console.WriteLine();

        // dito po nag declare po ng array na paglalagyan ng mga grades po natin para mamaya
        int[] grades = new int[5];
        int total = 0;

        // dito po kukuha ng grades (limang grades po na user inputted) 
        for (int t = 0; t < grades.Length; t++)
        {
            Console.Write("Enter grade #" + (t + 1) + ": "); // bale dito na po yung user input, hihingi na po siya ng grade. bawat input po na yun bale papasok po siya sa array kanina dun po siya mag s-store. And sa bawat input po lalabas yung "Enter Grade #"
            grades[t] = Convert.ToInt32(Console.ReadLine()); // dito po kinonvert ko po yung user inputted kanina into integer
            total += grades[t]; // dito sa section naman na po na 'to, ia-add yung grades po para makuha ang total
        }

        // dito naman po yung kung saan ica-calculate na yung average na user inputted po kanina or nilagay po natin kanina
        double average = (double)total / grades.Length;

        // dito po print out ng pinaka total or average na ng pinag add na grades kanina. then yung average po kanina na double kinonvert po siya into string then nilagyan ko po ng f1 para po maformat po yung magiging output po na isang digit lang po yung ipapakita after decimal point. and yung f1 po kasi is format specifier po.
        Console.WriteLine("\nThe average is " + average.ToString("F1") + " and rounded off to " + Math.Round(average));  // after po ng pag convert ng average into string, pinrint out ko po yung round up/down ng makukuhang average po. Bale yung purpose po ng Math.Round() is to round up or down yung  nakapaloob po dito into whole number po

        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");

        
        Console.ReadKey();
    }
}

