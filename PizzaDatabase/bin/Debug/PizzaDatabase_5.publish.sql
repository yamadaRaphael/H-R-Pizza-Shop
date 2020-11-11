﻿/*
Deployment script for PizzaDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "PizzaDatabase"
:setvar DefaultFilePrefix "PizzaDatabase"
:setvar DefaultDataPath "C:\Users\Harry\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\Harry\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367)) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Rename refactoring operation with key 39f288e9-aeaa-4bed-b46a-04f5faa5b55f is skipped, element [dbo].[DetailOrder].[PizzaId] (SqlSimpleColumn) will not be renamed to DetailPizzaId';


GO
PRINT N'Rename refactoring operation with key dc0d635a-db8e-4102-85ab-22fb9e507f39 is skipped, element [dbo].[OrderPizza].[OrderId] (SqlSimpleColumn) will not be renamed to OPOrderId';


GO
PRINT N'Rename refactoring operation with key 4f46dbac-cd8e-470a-9aa9-9232b23d3f66 is skipped, element [dbo].[Pizza].[IngredientId] (SqlSimpleColumn) will not be renamed to PizzaIngredientId';


GO
PRINT N'Rename refactoring operation with key df616ffc-8cda-4707-b238-69cdd2559ff5 is skipped, element [dbo].[DetailOrder].[PizzaId] (SqlSimpleColumn) will not be renamed to DetailPizzaId';


GO
PRINT N'Rename refactoring operation with key 3f21260f-9dcc-40a7-ab3d-a537f7d1afd3 is skipped, element [dbo].[DetailOrder].[OrderId] (SqlSimpleColumn) will not be renamed to DetailOrderId';


GO
PRINT N'Rename refactoring operation with key bf19d486-659f-4ab7-b5c0-29ea17adc8c8 is skipped, element [dbo].[PizzaSize].[PizzaId] (SqlSimpleColumn) will not be renamed to SizePizzaId';


GO
PRINT N'Rename refactoring operation with key 6be6bef1-0eb9-4013-9268-0afc59821cee is skipped, element [dbo].[OrderDetail].[PizzaPrice] (SqlSimpleColumn) will not be renamed to DetailPizzaPrice';


GO
PRINT N'Creating [dbo].[Customer]...';


GO
CREATE TABLE [dbo].[Customer] (
    [CustomerId]          INT          IDENTITY (1, 1) NOT NULL,
    [CustomerFirstName]   VARCHAR (50) NOT NULL,
    [CustomerLastName]    VARCHAR (50) NOT NULL,
    [CustomerAddress]     VARCHAR (50) NOT NULL,
    [CustomerPhoneNumber] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);


GO
PRINT N'Creating [dbo].[Ingredient]...';


GO
CREATE TABLE [dbo].[Ingredient] (
    [IngredientId]   INT          IDENTITY (1, 1) NOT NULL,
    [IngredientName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([IngredientId] ASC)
);


GO
PRINT N'Creating [dbo].[Order]...';


GO
CREATE TABLE [dbo].[Order] (
    [OrderId]    INT  IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT  NOT NULL,
    [TotalPrice] REAL NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);


GO
PRINT N'Creating [dbo].[OrderDetail]...';


GO
CREATE TABLE [dbo].[OrderDetail] (
    [DetailOrderId]    INT          NOT NULL,
    [DetailPizzaId]    INT          NOT NULL,
    [DetailPizzaSize]  VARCHAR (50) NOT NULL,
    [PizzaQty]         INT          NOT NULL,
    [DetailPizzaPrice] REAL         NULL,
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED ([DetailPizzaSize] ASC, [DetailPizzaId] ASC, [DetailOrderId] ASC)
);


GO
PRINT N'Creating [dbo].[Pizza]...';


GO
CREATE TABLE [dbo].[Pizza] (
    [PizzaId]           INT          IDENTITY (1, 1) NOT NULL,
    [PizzaName]         VARCHAR (50) NOT NULL,
    [PizzaIngredientId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([PizzaId] ASC)
);


GO
PRINT N'Creating [dbo].[PizzaSize]...';


GO
CREATE TABLE [dbo].[PizzaSize] (
    [SizePizzaId] INT          NOT NULL,
    [Size]        VARCHAR (50) NOT NULL,
    [PizzaPrice]  REAL         NOT NULL,
    PRIMARY KEY CLUSTERED ([SizePizzaId] ASC, [Size] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Order_ToCustomer]...';


GO
ALTER TABLE [dbo].[Order] WITH NOCHECK
    ADD CONSTRAINT [FK_Order_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]);


GO
PRINT N'Creating [dbo].[FK_DetailOrder_ToOrder]...';


GO
ALTER TABLE [dbo].[OrderDetail] WITH NOCHECK
    ADD CONSTRAINT [FK_DetailOrder_ToOrder] FOREIGN KEY ([DetailOrderId]) REFERENCES [dbo].[Order] ([OrderId]);


GO
PRINT N'Creating [dbo].[FK_DetailOrder_ToPizzaSize]...';


GO
ALTER TABLE [dbo].[OrderDetail] WITH NOCHECK
    ADD CONSTRAINT [FK_DetailOrder_ToPizzaSize] FOREIGN KEY ([DetailPizzaId], [DetailPizzaSize]) REFERENCES [dbo].[PizzaSize] ([SizePizzaId], [Size]);


GO
PRINT N'Creating [dbo].[FK_Pizza_Ingredient]...';


GO
ALTER TABLE [dbo].[Pizza] WITH NOCHECK
    ADD CONSTRAINT [FK_Pizza_Ingredient] FOREIGN KEY ([PizzaIngredientId]) REFERENCES [dbo].[Ingredient] ([IngredientId]);


GO
PRINT N'Creating [dbo].[FK_PizzaSize_Pizza]...';


GO
ALTER TABLE [dbo].[PizzaSize] WITH NOCHECK
    ADD CONSTRAINT [FK_PizzaSize_Pizza] FOREIGN KEY ([SizePizzaId]) REFERENCES [dbo].[Pizza] ([PizzaId]);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2c4d747f-e9eb-43c9-86d9-daa01594013b')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2c4d747f-e9eb-43c9-86d9-daa01594013b')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'dc0d635a-db8e-4102-85ab-22fb9e507f39')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('dc0d635a-db8e-4102-85ab-22fb9e507f39')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '39f288e9-aeaa-4bed-b46a-04f5faa5b55f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('39f288e9-aeaa-4bed-b46a-04f5faa5b55f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '1e24e733-41f7-4953-a1b7-52212256772d')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('1e24e733-41f7-4953-a1b7-52212256772d')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '4f46dbac-cd8e-470a-9aa9-9232b23d3f66')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('4f46dbac-cd8e-470a-9aa9-9232b23d3f66')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '6f5e1b2f-7f10-4492-b29f-707c213e476f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('6f5e1b2f-7f10-4492-b29f-707c213e476f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c04a8e3d-cb6a-42dc-a2d1-55d380d3eccd')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c04a8e3d-cb6a-42dc-a2d1-55d380d3eccd')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '671b0e3c-3daf-45e1-b83a-4b93766b8d18')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('671b0e3c-3daf-45e1-b83a-4b93766b8d18')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ee995064-c585-416c-9142-7b14ff8124c3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ee995064-c585-416c-9142-7b14ff8124c3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'df616ffc-8cda-4707-b238-69cdd2559ff5')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('df616ffc-8cda-4707-b238-69cdd2559ff5')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '11d428e9-33ff-46ed-94b7-cf45157f665c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('11d428e9-33ff-46ed-94b7-cf45157f665c')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8e38a458-fee4-4c0c-ada6-0829c6188ea2')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8e38a458-fee4-4c0c-ada6-0829c6188ea2')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '3f21260f-9dcc-40a7-ab3d-a537f7d1afd3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('3f21260f-9dcc-40a7-ab3d-a537f7d1afd3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'bf19d486-659f-4ab7-b5c0-29ea17adc8c8')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('bf19d486-659f-4ab7-b5c0-29ea17adc8c8')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '70cdcd82-e0a0-4fca-a7e3-4cdf6f80738b')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('70cdcd82-e0a0-4fca-a7e3-4cdf6f80738b')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '6be6bef1-0eb9-4013-9268-0afc59821cee')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('6be6bef1-0eb9-4013-9268-0afc59821cee')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '96147ffa-bce5-429a-8d57-e1d92dc4a61f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('96147ffa-bce5-429a-8d57-e1d92dc4a61f')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Order] WITH CHECK CHECK CONSTRAINT [FK_Order_ToCustomer];

ALTER TABLE [dbo].[OrderDetail] WITH CHECK CHECK CONSTRAINT [FK_DetailOrder_ToOrder];

ALTER TABLE [dbo].[OrderDetail] WITH CHECK CHECK CONSTRAINT [FK_DetailOrder_ToPizzaSize];

ALTER TABLE [dbo].[Pizza] WITH CHECK CHECK CONSTRAINT [FK_Pizza_Ingredient];

ALTER TABLE [dbo].[PizzaSize] WITH CHECK CHECK CONSTRAINT [FK_PizzaSize_Pizza];


GO
PRINT N'Update complete.';


GO