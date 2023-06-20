/* using System;
 
class Program {
 
    public static void Main()
    {
        string str2 = "Que Bendicion ahhhh muchachos!!! : compaltan,compaltan,compaltan,compaltan,compaltan,compaltan,compaltan,compaltan";
 
        string upperstr2 = str2.ToUpper();
 
        Console.WriteLine(upperstr2);
    }
} */


using System;
class CONTADOR {
 
    public static void Main()
    {
        String str = "angelPenetradorMamadisimo";
        Console.WriteLine("Palabra  : {0}\n", str);
 
        char[] ch = { 's' };
        Console.WriteLine(str.IndexOfAny(ch) + 1);
 
        char[] ch1 = { 'a', 'b', 'c', 'e', 'f' };
 
        Console.WriteLine(str.IndexOfAny(ch1) + 1);
 
        char[] ch2 = { 'a', 'b', 'c' };
 
        int m = str.IndexOfAny(ch2);
        if (m > -1)
            Console.Write(m);
        else
            Console.WriteLine("Not Found");
    }
}
