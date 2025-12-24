class Repo<T> where T : class
{
    public T Data;

}
class Customer
{
    public required string name;
}

class Calculator
{
    public T Calculate<T>(T a,T b)
    {
        return a; 
    }
}

// new() must have  a default constructor


