CREATE TABLE [dbo].[Customer] (
    [customerId]     UNIQUEIDENTIFIER NOT NULL,
    [CreateAt]       DATETIME2 (7)    NOT NULL,
    [CreateBy]       NVARCHAR (MAX)   NULL,
    [address]        NVARCHAR (100)   NULL,
    [customerName]   NVARCHAR (100)   NOT NULL,
    [customerType]   INT              NOT NULL,
    [description]    NVARCHAR (200)   NULL,
    [email]          NVARCHAR (100)   NULL,
    [branches]       INT   NOT NULL,
    [organizationId] UNIQUEIDENTIFIER NOT NULL,
    [phone]          NVARCHAR (20)    NULL,
    [thumbUrl]       NVARCHAR (255)   NULL,
    [website]        NVARCHAR (100)   NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([customerId] ASC),
    CONSTRAINT [FK_Customer_Organization_organizationId] FOREIGN KEY ([organizationId]) REFERENCES [dbo].[Organization] ([organizationId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Customer_organizationId]
    ON [dbo].[Customer]([organizationId] ASC);

