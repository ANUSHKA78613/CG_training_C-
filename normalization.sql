USE [COLLEGE]
GO

/****** Object:  Table [dbo].[CustomerMaster]    Script Date: 31-01-2026 15:44:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerMaster](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](100) NULL,
	[CustomerPhone] [varchar](20) NULL,
	[CustomerCity] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
------------------------------------
USE [COLLEGE]
GO

/****** Object:  Table [dbo].[OrderItems]    Script Date: 31-01-2026 15:45:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderItems](
	[OrderItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[OrderMaster] ([OrderID])
GO

ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductMaster] ([ProductID])
GO


------------------------------------------------------------
USE [COLLEGE]
GO

/****** Object:  Table [dbo].[OrderMaster]    Script Date: 31-01-2026 15:46:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderMaster](
	[OrderID] [int] NOT NULL,
	[OrderDate] [date] NULL,
	[CustomerID] [int] NULL,
	[SalesPersonID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderMaster]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CustomerMaster] ([CustomerID])
GO

ALTER TABLE [dbo].[OrderMaster]  WITH CHECK ADD FOREIGN KEY([SalesPersonID])
REFERENCES [dbo].[SalesPersons] ([SalesPersonID])
GO

-------------------------------------------
USE [COLLEGE]
GO

/****** Object:  Table [dbo].[ProductMaster]    Script Date: 31-01-2026 15:46:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductMaster](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NULL,
	[UnitPrice] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
------------------------------------------
USE [COLLEGE]
GO

/****** Object:  Table [dbo].[SalesPersons]    Script Date: 31-01-2026 15:47:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalesPersons](
	[SalesPersonID] [int] IDENTITY(1,1) NOT NULL,
	[SalesPersonName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesPersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
---------------------------------------------------------------
Select * from CustomerMaster;
Select * from SalesPersons;
Select * from ProductMaster;
Select * from OrderMaster;
Select * from OrderItem;

---q5-----------------------------------
SELECT
    UPPER(CustomerName) AS CustomerName
FROM CustomerMaster;
SELECT MONTH(OrderDate) AS OrderMonth
FROM OrderMaster;
SELECT * FROM OrderMaster WHERE OrderDate >= '2024-01-01'
  AND OrderDate <  '2025-01-01';
  -----------------------------------------------
--q3 ------
SELECT
    SalesPersons.SalesPersonName,SUM(OrderItem.Quantity * OrderItem.UnitPrice) AS TotalSales FROM SalesPersons
JOIN OrderMaster ON SalesPersons.SalesPersonID = OrderMaster.SalesPersonID JOIN OrderItem ON OrderMaster.OrderID = OrderItem.OrderID
GROUP BY SalesPersons.SalesPersonName HAVING SUM(OrderItem.Quantity * OrderItem.UnitPrice) > 60000;
--------------------------
--q4
SELECT DISTINCT TotalSales FROM
(SELECT OrderMaster.OrderID,SUM(OrderItem.Quantity * OrderItem.UnitPrice) AS TotalSales FROM OrderMaster
 JOIN OrderItem ON OrderMaster.OrderID = OrderItem.OrderID GROUP BY OrderMaster.OrderID) as x ORDER BY TotalSales DESC
OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY;





