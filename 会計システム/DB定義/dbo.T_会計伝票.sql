CREATE TABLE [dbo].[T_会計伝票] (
    [伝票番号] NCHAR (12) NOT NULL,
    [計上日]  DATE       NOT NULL,
    PRIMARY KEY CLUSTERED ([伝票番号] ASC)
);

