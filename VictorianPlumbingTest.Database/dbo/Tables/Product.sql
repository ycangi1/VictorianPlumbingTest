CREATE TABLE [dbo].[Product] (
    [ProductId]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (100) NOT NULL,
    [Summary]    NVARCHAR (500) NOT NULL,
    [Price]      DECIMAL (18)   NOT NULL,
    [CreateDate] DATETIME       NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

