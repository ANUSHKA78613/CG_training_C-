using System;


namespace QuickMart;

class SaleTransaction

{
    public string InvoiceNumber{get;set;}="";

 public string? CustomerName{get;set;}="";

public string? ItemName{get;set;}="";

 public int Quantity{get;set;}

public double PurchaseAmount{get;set;}

public double SellingAmount{get;set;}

public string ProfitOrLossStatus{get;set;}="";

 public double ProfitOrLossAmount{get;set;}

 public double ProfitMarginPercent{get;set;}

}
