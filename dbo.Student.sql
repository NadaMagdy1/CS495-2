CREATE TABLE [dbo].[Student] (
    [S_ID]        INT           NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Gender]      NVARCHAR (1)  NOT NULL,
    [BirthDate]   DATETIME      NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [PhoneNumber] NVARCHAR (50) NOT NULL,
    [Address]     NCHAR (50)    NOT NULL,
    [Password]    INT           NOT NULL,
    [Nationality] NVARCHAR (50) NOT NULL,
    [Faculty]     INT           NOT NULL,
    [Bus]         NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([S_ID] ASC)
);

