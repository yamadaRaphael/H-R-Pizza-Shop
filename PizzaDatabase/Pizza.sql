CREATE TABLE [dbo].[Pizza] (
    [PizzaId]      INT   IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [PizzaName]    VARCHAR(50)  NOT NULL,
    [PizzaDescription] VARCHAR(200)   NOT NULL 
);

