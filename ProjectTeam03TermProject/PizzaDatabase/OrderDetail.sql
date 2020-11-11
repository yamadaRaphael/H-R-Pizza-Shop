CREATE TABLE [dbo].[OrderDetail]
(
	[DetailOrderId] INT NOT NULL,
	[DetailPizzaId] INT NOT NULL,
	[DetailPizzaSize] VARCHAR(50) NOT NULL,
	[PizzaQty]     INT  NOT NULL,
    [DetailPizzaPrice]   REAL NOT NULL, 
	CONSTRAINT [FK_DetailOrder_ToPizzaSize] FOREIGN KEY ([DetailPizzaId],[DetailPizzaSize]) REFERENCES [PizzaSize]([SizePizzaId],[Size]), 
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY ([DetailPizzaSize], [DetailPizzaId], [DetailOrderId]) 
)
