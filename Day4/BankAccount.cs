using System;

class BankAccount
{
    public int balancee;
    public int actno;
    public BankAccount(int balancee,int actno)
    {
        this.balancee = balancee;
        this.actno = actno;
    }
   
}
// derived class must call a constructor....
class FixedDeposit : BankAccount
{
    int time;
    double roi,fdamt;
    public FixedDeposit(int time,double roi,double fdamt) : base(40000,101)
    {
        this.time = time;
        this.roi = roi;
        this.fdamt = fdamt;
        Console.WriteLine($"Fixed Deposit account created {time} {roi} {fdamt} {balancee} {actno}");
    }
}
