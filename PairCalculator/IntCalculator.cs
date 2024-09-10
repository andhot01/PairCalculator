namespace PairCalculator;

public class IntCalculator : IIntCalculator
{
    public int Result { get; set; }
    public int Memory { get; set; }


    public void Reset()
    {
        throw new NotImplementedException();
    }

    public void Add(int x)
    {
        if (Result > 0 && x > 0)
        {
            Result += x;
            Result = Math.Abs(Result);
        }
        else
        {
            Result += x;
        }
    }

    public void Subtract(int x)
    {
        if (x < 0)
        {
            Result += Math.Abs(x);
        }
        else
        {
            Result -= x;
        }
    }

    public void Multiply(int x)
    {
        // if x makes result overflow, set result to int.MaxValue
        long temp = (long) Result * x;
        if (temp >= Int32.MaxValue || temp <= Int32.MinValue)
        {
            Result = -1;
        }
        else
        {
            Result *= x;
        }
    }

    public void Divide(int x)
    {
        if (x == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            Result /= x;
        }
    }

    public void Modulus(int x)
    {
        Result %= x;
    }
    
    public void ResetMemory()
    {
        Memory = 0;
    }
    
    public void MemoryAdd()
    {
        Memory += Result;
    }
    
    public void MemorySubtract()
    {
        Memory -= Result;
    }
}