class Program
{
    static void Main(string[] args)
    {
        ParkingSystem p = new ParkingSystem(1, 1, 0);
        Console.WriteLine(p.addCar(1));
        Console.WriteLine(p.addCar(2));
        Console.WriteLine(p.addCar(3));
        Console.WriteLine(p.addCar(1));

        Console.ReadKey();
    }
}

class ParkingSystem
{
    int big;
    int medium;
    int small;

    public ParkingSystem(int big, int medium, int small)
    {
        this.big = big;
        this.medium = medium;
        this.small = small;
    }

    public bool addCar(int carType)
    {
        if (carType == 1)
        {
            if (big > 0)
            {
                big--;
                return true;
            }
            return false;
        }

        if (carType == 2)
        {
            if (medium > 0)
            {
                medium--;
                return true;
            }
            return false;
        }

        if (carType == 3)
        {
            if (small > 0)
            {
                small--;
                return true;
            }
            return false;
        }

        return false;
    }
}

