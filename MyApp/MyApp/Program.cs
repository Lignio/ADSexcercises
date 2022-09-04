namespace MyApp{

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Want to know if a specific year is a leapyear or not?");
        Console.WriteLine("Please enter the year below");

        int year = 0;

        string input = Console.ReadLine();
        try{
             year = int.Parse(input);
             string output = "nay";

    
        if (isLeapYear(year))
        {
            output = "yay";
        }

        Console.WriteLine(output);
        } 
        
        catch (Exception e){
              Console.WriteLine("The input must be an integer!");
            }

        
    }
     public static bool isLeapYear(int year){
        if(year<1582){
            Console.WriteLine("Only years from 1582 and onwards is considered possible leapyears!");
            return false;
        }
        if(year%4==0){
            if(year%100==0){
                if(year%400==0){
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
}

}
