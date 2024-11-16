using System;

class Program
{
    public static bool PuestoLimonadas(int[] billetes)
    {
        
        int billetesDe5 = 0;
        int billetesDe10 = 0;

    
        foreach (int billete in billetes)
        {
            if (billete == 5)
            {
                billetesDe5++;
            }
            else if (billete == 10)
            {
                if (billetesDe5 > 0)
                {
                    billetesDe5--; 
                    billetesDe10++; 
                }
                else
                {
                    return false; 
                }
            }
            else if (billete == 20)
            {
               
                if (billetesDe10 > 0 && billetesDe5 > 0)
                {
                    billetesDe10--;
                    billetesDe5--;
                }
               
                else if (billetesDe5 >= 3)
                {
                    billetesDe5 -= 3;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(PuestoLimonadas(new int[] { 5, 5, 5, 10, 20 })); // true
        Console.WriteLine(PuestoLimonadas(new int[] { 5, 5, 10, 10, 20 })); // false
        Console.WriteLine(PuestoLimonadas(new int[] { 10, 10 })); // false
        Console.WriteLine(PuestoLimonadas(new int[] { 5, 5, 10 })); // true
    }
}
