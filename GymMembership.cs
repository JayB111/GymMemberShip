using System;

class GymMembership
{
    public static int CalculateMembershipPrice(int age, bool wantsPremium)
    {
        int basePrice;

        
        if (age < 19 || age > 64)
        {
            basePrice = 2200;
        }
        else
        {
            basePrice = 3100;
        }

       
        if (wantsPremium)
        {
            basePrice += 300;
        }

        return basePrice;
    }

    static void Main(string[] args)
    {
        
        int age = 19; 
        bool wantsPremium = true;

        int price = CalculateMembershipPrice(age, wantsPremium);

       
        Console.WriteLine($"The total price is: {price}");
    }
}

