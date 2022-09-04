

namespace MyApp{

    public class Leapyear{

        public bool isLeapYear(int year){
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