namespace consoleapp
{
class Program
{
    public static void Main()
    {
        //taking the user's input for the hours        
        Console.Write("Enter hours (1-12): ");
        int hours = int.Parse(Console.ReadLine());

        //taking the user's input for the minutes
        Console.Write("Enter minutes (0-59): ");
        int minutes = int.Parse(Console.ReadLine());

        //calculating the angle by the hands of hours and minutes the user have input
        double hoursAngle = 0.5 * (60 * hours + minutes);
        double minutesAngle = 6 * minutes;

        /*calculation of lesser angle in degrees by getting the absolute difference between the hours 
        and minutes hands*/
        double angle = Math.Abs(hoursAngle - minutesAngle);
        /*taking the minimum angle and its complementary angle by subtracting the min angle to 360 */
        angle = Math.Min(angle, 360 - angle);

        //console out the calculated angle to degrees
        Console.WriteLine($"The lesser angle between the hour and minute hands you input is {angle} degrees.");
    }
}
}
