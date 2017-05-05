CREATE TABLE [dbo].[T_仕訳] (
    [伝票番号]    NCHAR (12)    NOT NULL,
    [仕訳番号]    INT           NOT NULL,
    [勘定科目コード] INT           NOT NULL,
    [金額]      DECIMAL (18)  NOT NULL,
    [摘要]      NVARCHAR (50) NOT NULL,
    [貸借]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([伝票番号] ASC, [仕訳番号] ASC)
);

