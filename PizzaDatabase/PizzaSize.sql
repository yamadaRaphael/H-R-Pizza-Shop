CREATE TABLE [dbo].[PizzaSize] (
    [SizePizzaId]    INT  NOT NULL,
    [Size]  VARCHAR(50) NOT NULL,
    [PizzaPrice] REAL NOT NULL, 
	CONSTRAINT [FK_PizzaSize_Pizza] FOREIGN KEY ([SizePizzaId]) REFERENCES [Pizza]([PizzaId]), 
    PRIMARY KEY ([SizePizzaId], [Size]) 
);