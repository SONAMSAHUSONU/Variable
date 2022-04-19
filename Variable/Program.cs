/*using System;

    class Program
    {
        static void Main(string[] args)
        {
        Boolean isValid = true;
        SByte level = 23;
        short value = 20;
        int score = 20;
        long range = 25;
        byte age = 40;
        ushort s1 = 30;
        uint total = 60;
        ulong Range = 70;
        float number = 55.30f;
        double s2 = 66.55;
        char ch = 'x';
        Decimal bal = 80;


        Console.WriteLine(isValid);
        Console.WriteLine(level);
        Console.WriteLine(value);
        Console.WriteLine(score);
        Console.WriteLine(range);
        Console.WriteLine(age);
        Console.WriteLine(s1);
        Console.WriteLine(total);
        Console.WriteLine(Range);
        Console.WriteLine(number);
        Console.WriteLine(s2);
        Console.WriteLine(ch);
        Console.WriteLine(bal);
        Console.ReadLine();
        }
    }

  */  

/*using System;
class Employe
{
   // public static const int a = 20;
   // const keyword we can not start with static keyword inside the class in program execution
   //complie time constant 
   
     public const int i = 100;//refrence variable

    static void Main(string[] args)
    {
        const int j = 200;
        
        //Employe obj = new Employe();
        Console.WriteLine(i);
        //Console.WriteLine(obj.i); //we can not call on veriable namelike this 
        Console.WriteLine(j);

        Console.ReadLine();
    }
}

*/
/*using System;
class Employe
{
    readonly int k = 300;//it is also constant 
    // runtime const 
    static void Main(string[] args)
    {
        // readonly int a = 300; //we can't inizlaied inside the method 
        //k  = 400;//we can't change the value
        Employe obj = new Employe();
        Console.WriteLine(obj.k);

        Console.ReadLine();
    }
}
*/

/*using System;
class Employe
{
    readonly static int i =300;//we can use static in readonly keyword
    readonly int k = 500;
    //we can change the value though constructor
    Employe() //constructore body
    {

        k = 400;
    }
    static void Main(string[] args)
    {
        

       Employe obj = new Employe();

        Console.WriteLine(i);
        Console.WriteLine(obj.k);

        Console.ReadLine();
    }
}

*/
/*using System;
public static class Employe
{
    readonly static int k = 500;
    //we can change the value though constructor
    static Employe() //constructore body
    {

        k = 400;
    }
    static void Main(string[] args)
    {

        Console.WriteLine(k);

       

        Console.ReadLine();
    }
}
*/
/*using System;
public static class Employe
{
    public static readonly string address = "Vidisha";//readonly keyword is not implicitly we have
    //to difined though static keyword expilicitly, becouse it is rum time keyword 
    public static string lastName = "Sahu";//expilicity, means defined by user, we can difined
    public const string fristName ="Sonam";//implicity , it is by default declear as static, 
    //if by declear expilicity then it is showing illigal key
    //static, in const we have predifiend static keyword 
    //gloable access 
    static void Main(string[] args)
    {
        Console.WriteLine(address);
        Console.WriteLine(lastName);
        Console.WriteLine(Employe.fristName);

        Console.ReadLine();
    }
}
// static member can be acciess through class name or directly
//non static member can be access by object refrence variable 
//non static member can not access by classname
//constant by default is the static 
 */