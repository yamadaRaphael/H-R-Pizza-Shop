﻿CREATE TABLE [dbo].[Order] (
    [OrderId]    INT  NOT NULL PRIMARY KEY IDENTITY,
    [CustomerId] INT  NOT NULL,
    [TotalPrice] REAL NOT NULL, 
    CONSTRAINT [FK_Order_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId])
);