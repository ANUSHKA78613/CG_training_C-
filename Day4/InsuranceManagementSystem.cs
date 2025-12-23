using System;

//part-1
sealed class Authentication
{
    public void Print(string username,int password)
    {
        if(username == "anushka" && password == 12345)
        {
           Console.WriteLine("Authentication successful");   
        }
        else
        {
              Console.WriteLine("Authentication failed");
        }
          
    }
}
// part - 2
abstract class InsurancePolicy
{
    public string name{get;set;}
    public int PolicyNumber
    { get;init;}
protected double premium;
    public double Premium
    {
     get {
        return premium;  
     }

        set
        {
            if (value > 0)
            {
                premium = value;
            }
        }
    }
public virtual double calculate()
    {
     return premium;   
    }
public void Display()
    {
       Console.WriteLine("Insurance Policy"); 
    }
}
// PART -3
class LifeInsurance : InsurancePolicy
{
    public override double calculate()
    {
       return premium + 500;
    }
      public new void Display()
    {
        Console.WriteLine("Life Insurance Policy");
}
}
class HealthInsurance : InsurancePolicy
{
    public sealed override double calculate()
    {
        return premium+300;
    }
}

//part 4class Policy
class Policy
{
    Dictionary<int, string> policies = new Dictionary<int, string>();

    // Indexer using Policy ID
    public string this[int policyID]
    {
        get
        {
            return policies[policyID];
        }
        set
        {
            policies[policyID] = value;
        }
    }

    // Indexer using Holder Name
    public int this[string holderName]
    {
        get
        {
            return policies.FirstOrDefault(p => p.Value == holderName).Key;
        }
    }
}