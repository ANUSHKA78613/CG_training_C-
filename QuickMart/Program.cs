class Program
{
    public static SaleTransaction LastTransaction { get; set; } = null!;
    public static bool HasLastTransaction;

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n======================= QuickMart Traders =======================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit\n");
            Console.Write("Enter your option: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateTransaction();
                    HasLastTransaction = true;
                    break;

                case 2:
                    if (HasLastTransaction)
                        Display();
                    else
                        Console.WriteLine("\nNo transaction available. Please create a new transaction first.\n");
                    break;

                case 3:
                    if (HasLastTransaction)
                        Calculate();
                    else
                        Console.WriteLine("\nNo transaction available. Please create a new transaction first.\n");
                    break;

                case 4:
                    Console.WriteLine("\nThank you. Application closed normally.\n");
                    break;

                default:
                    Console.WriteLine("\nInvalid Option!!\n");
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------------");
        }
        while (choice != 4);
    }

    public static void CreateTransaction()
    {
        SaleTransaction sale = new SaleTransaction();

        while (true)
        {
            Console.Write("\nEnter Invoice No: ");
            string? inv = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(inv))
            {
                sale.InvoiceNumber = inv;
                break;
            }
            Console.WriteLine("Enter valid invoice number!!");
        }

        Console.Write("Enter Customer Name: ");
        sale.CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        sale.ItemName = Console.ReadLine();

        while (true)
        {
            Console.Write("Enter Quantity: ");
            sale.Quantity = Convert.ToInt32(Console.ReadLine());
            if (sale.Quantity > 0)
                break;
            Console.WriteLine("Enter valid quantity!!");
        }

        while (true)
        {
            Console.Write("Enter Purchase Amount (total): ");
            sale.PurchaseAmount = Convert.ToDouble(Console.ReadLine());
            if (sale.PurchaseAmount > 0)
                break;
            Console.WriteLine("Enter valid purchase amount!!");
        }

        while (true)
        {
            Console.Write("Enter Selling Amount (total): ");
            sale.SellingAmount = Convert.ToDouble(Console.ReadLine());
            if (sale.SellingAmount >= 0)
                break;
            Console.WriteLine("Enter valid selling amount!!");
        }

        if (sale.SellingAmount != sale.PurchaseAmount)
        {
            sale.ProfitOrLossStatus =
                sale.SellingAmount > sale.PurchaseAmount ? "PROFIT" : "LOSS";
            sale.ProfitOrLossAmount =
                Math.Abs(sale.SellingAmount - sale.PurchaseAmount);
        }
        else
        {
            sale.ProfitOrLossStatus = "BREAK-EVEN";
            sale.ProfitOrLossAmount = 0;
        }

        sale.ProfitMarginPercent =
            (sale.ProfitOrLossAmount / sale.PurchaseAmount) * 100;

        LastTransaction = sale;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        Calculate();
    }

    public static void Calculate()
    {
        Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: ₹{LastTransaction.ProfitOrLossAmount:F2}");

        if (LastTransaction.ProfitOrLossStatus.Equals("PROFIT"))
        {
            Console.WriteLine(
                $"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}%\n");
        }
    }

    public static void Display()
    {
        Console.WriteLine($"\nInvoiceNo: {LastTransaction.InvoiceNumber}");
        Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
        Console.WriteLine($"Item: {LastTransaction.ItemName}");
        Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
        Console.WriteLine($"Purchase Amount: ₹{LastTransaction.PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: ₹{LastTransaction.SellingAmount:F2}");
        Calculate();
    }
}
