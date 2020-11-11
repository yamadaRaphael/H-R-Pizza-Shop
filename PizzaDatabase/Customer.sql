CREATE TABLE [dbo].[Customer] (
    [CustomerId]          INT PRIMARY KEY IDENTITY  (1, 1) NOT NULL ,
    [CustomerFirstName]   VARCHAR(50) NOT NULL,
    [CustomerLastName]    VARCHAR(50) NOT NULL,
    [CustomerAddress]     VARCHAR(50) NOT NULL,
    [CustomerPhoneNumber] VARCHAR(50) NOT NULL,
);