namespace MyApp{

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Want to know if a specific year is a leapyear or not?");
        Console.WriteLine("Please enter the year below");

        int year = 0;
        string input = Console.ReadLine();
        string output ="nay";
            
        if(parseUserInput(input)){
            year = int.Parse(input);
             if (isLeapYear(year))
        {
            output = "yay";
        }

        Console.WriteLine(output);
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


public static bool parseUserInput(string input){
    int year;
    bool check = int.TryParse(input, out year);
    if(check){
        return true;
    }
    else {
         Console.WriteLine("Input must be an integer!");
         return false;
    }
}
}
}