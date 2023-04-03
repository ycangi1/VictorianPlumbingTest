CREATE TABLE [dbo].[Order] (
    [OrderId]       INT        IDENTITY (1, 1) NOT NULL,
    [CustomerName]  NCHAR (10) NOT NULL,
    [OrderedAt]     DATETIME   NOT NULL,
    [CancelledDate] DATETIME   NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

