CREATE TABLE [dbo].[M_勘定科目] (
    [勘定科目コード] INT           NOT NULL,
    [勘定科目名]   NVARCHAR (50) NOT NULL,
    [勘定区分]    INT           NOT NULL,
    [流動損益区分]  INT           NOT NULL,
    [集計区分]    INT           NOT NULL,
    [管理番号]    INT           NOT NULL,
    [集計科目]    BIT           NOT NULL,
    [集計科目コード] INT           NOT NULL,
    CONSTRAINT [PK_M_勘定科目] PRIMARY KEY CLUSTERED ([勘定科目コード] ASC)
);

