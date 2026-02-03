USE [Test]
GO

/****** Object:  Table [dbo].[Accounts]    Script Date: 03-02-2026 15:38:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] NOT NULL,
	[CustomerID] [int] NULL,
	[AccountNumber] [varchar](20) NULL,
	[AccountType] [varchar](20) NULL,
	[OpeningBalance] [decimal](12, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
--------------------------------------------------------------------------
USE [Test]
GO

/****** Object:  Table [dbo].[Bonus]    Script Date: 03-02-2026 15:38:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bonus](
	[BonusID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NULL,
	[BonusMonth] [int] NULL,
	[BonusYear] [int] NULL,
	[BonusAmount] [decimal](10, 2) NULL,
	[CreatedDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[BonusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bonus]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO


-------------------------------------------------------------------
USE [Test]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 03-02-2026 15:38:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [varchar](100) NULL,
	[PhoneNumber] [varchar](15) NULL,
	[City] [varchar](50) NULL,
	[CreatedDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


-------------------------------------------------------------------------
USE [Test]
GO

/****** Object:  Table [dbo].[Transactions]    Script Date: 03-02-2026 15:39:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] NOT NULL,
	[AccountID] [int] NULL,
	[TransactionDate] [date] NULL,
	[TransactionType] [varchar](10) NULL,
	[Amount] [decimal](12, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO



--------------------------------------------------------------------------
Alter PROCEDURE A
(
    @StartDate DATE,
    @EndDate   DATE,
    @AccountID INT
)
AS
BEGIN
    SELECT(SELECT SUM(Amount) FROM Transactions WHERE AccountID = @AccountID AND TransactionType = 'Deposit' AND TransactionDate BETWEEN @StartDate AND @EndDate) AS TotalDepo,
    (SELECT SUM(Amount) FROM Transactions WHERE AccountID = @AccountID AND TransactionType = 'Withdraw'AND TransactionDate BETWEEN @StartDate AND @EndDate) AS TotalWith;
END
EXEC A @StartDate = '2024-01-01', @EndDate = '2025-01-01',@AccountID = 101
-------------------------------------------------------------------------
Insert into Bonus(AccountID,BonusMonth,BonusYear,BonusAmount,CreatedDate) 
select AccountID, Month(TransactionDate) as BonusMonth,Year(TransactionDate) as BonusYear,1000 as BonusAmount,GetDate() as CreatedDate from Transactions
where TransactionType = 'Deposit' group by AccountId,Month(TransactionDate),Year(TransactionDate) having Sum(Amount) > 50000 
select * from Bonus

-------------------------------------------------
SELECT Customers.CustomerName, Accounts.AccountNumber, Accounts.OpeningBalance + ISNULL(DepositSummary.TotalDeposits, 0)
- ISNULL(WithdrawSummary.TotalWithdrawals, 0) + ISNULL(BonusSummary.TotalBonusAmount, 0) AS CurrentBalance
FROM Accounts AS Accounts INNER JOIN Customers AS Customers ON Customers.CustomerID = Accounts.CustomerID
LEFT JOIN( SELECT Transactions.AccountID,SUM(Transactions.Amount) AS TotalDeposits FROM Transactions AS Transactions
WHERE Transactions.TransactionType = 'Deposit' GROUP BY Transactions.AccountID) AS DepositSummary ON DepositSummary.AccountID = Accounts.AccountID
LEFT JOIN(SELECT Transactions.AccountID, SUM(Transactions.Amount) AS TotalWithdrawals FROM Transactions AS Transactions
WHERE Transactions.TransactionType = 'Withdraw' GROUP BY Transactions.AccountID) AS WithdrawSummary
ON WithdrawSummary.AccountID = Accounts.AccountID  LEFT JOIN (SELECT Bonus.AccountID,SUM(Bonus.BonusAmount) AS TotalBonusAmount
FROM Bonus AS Bonus GROUP BY Bonus.AccountID) AS BonusSummary ON BonusSummary.AccountID = Accounts.AccountID;