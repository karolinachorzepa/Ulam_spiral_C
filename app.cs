// 1) Generate prime numbers (Sito Eratostenesa)
// 2) Generae spiral in 2D array
// 3) Print spiral on screen (Forms application)

using System;

class App
{
    static void Main()
    {
        PrimeNumbers primeNumbers = new PrimeNumbers(20);
        bool[] numbers = primeNumbers.Generate();
        primeNumbers.Print(numbers);
    }
}
class PrimeNumbers
{
    private readonly int amount;
    public PrimeNumbers(int amount)
    {
        this.amount=amount;
    }
    public bool[] numbers = new bool[amount];
// 100-amount
        for (int i =2; i<amount; i++)
            if (numbers[i]==false)
                for (int j=2 *i ;j<amount; j+=i)
                    numbers[j] = true;
        return numbers;
}

public void Print(bool[] numbers)
{
    for(int i=0; i<amount; i++)
            console.WriteLine(i+" "+numbers[i]);
    }
}
class Spiral
    //Ulam spiral

{
    public void Generate()
    int[,] spiral = new int [5,6];

    int x=2;
    int y=2;

    int step=1;

    for (int currentNumber=1; currentNumber<=30; currentNumber++)
}
}