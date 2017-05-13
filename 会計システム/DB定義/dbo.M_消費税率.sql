CREATE TABLE [dbo].[M_消費税率] (
    [ID]    INT        IDENTITY (1, 1) NOT NULL,
    [税率]    FLOAT (53) NOT NULL,
    [適用開始日] DATE       NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

