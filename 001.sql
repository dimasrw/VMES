/******************************************************************/
/*Скрипт устанвоки базы данный версия 1.00.001 от 09.12.2018 13:27*/
/**/
USE [Contragent]
GO

/****** Object:  Table [dbo].[ContractorFCategory]    Script Date: 09.12.2018 13:26:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/************Метаданные*****************/
CREATE TABLE [dbo].[METAFORM](
	[MID] [int] NOT NULL,
	[MID_NAME] [varchar](120) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[METAGRID](
	[MIT] [int] NULL,
	[GROID] [int] NULL,
	[COL] [tinyint] NULL,
	[COLNAME] [varchar](120) NULL,
	[COLWITH] [int] NULL,
	[VIS] [tinyint] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[METAGRID] ADD  CONSTRAINT [DF_METAGRID_VIS]  DEFAULT ((1)) FOR [VIS]
GO


CREATE PROCEDURE [dbo].[SEL_METAGRID]
@MIT INT,
@GROID INT
AS

SELECT [MIT]
      ,[GROID]
      ,[COL]
      ,[COLNAME]
      ,[COLWITH]
      ,[VIS]
FROM [Contragent].[dbo].[METAGRID]
WHERE MIT=@MIT AND GROID =@GROID
ORDER BY [MIT],[GROID],[COL]
GO

/**********Конец метаданные*************/

CREATE TABLE [dbo].[ContractorFCategory](
	[CategoryFID] [tinyint] NOT NULL,
	[CategoryFName] [varchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ContractorSCategory](
	[CategorySID] [tinyint] NOT NULL,
	[CategorySName] [varchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ContractorTCategory](
	[CategoryTID] [tinyint] NOT NULL,
	[CategoryTName] [varchar](50) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Сontractor](
	[ContractorID] [int] IDENTITY(1,1) NOT NULL,
	[OUTID] [varchar](250) NULL,
	[TIN] [varchar](12) NULL,
	[ContrName] [varchar](250) NULL,
	[CategoryFID] [tinyint] NOT NULL,
	[CategorySID] [tinyint] NOT NULL,
	[CategoryTID] [tinyint] NOT NULL,
	[MARK] [tinyint] NULL,
 CONSTRAINT [PK_Сontractor] PRIMARY KEY CLUSTERED 
(
	[ContractorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Сontractor] ADD  DEFAULT ((0)) FOR [CategoryFID]
GO

ALTER TABLE [dbo].[Сontractor] ADD  DEFAULT ((0)) FOR [CategorySID]
GO

ALTER TABLE [dbo].[Сontractor] ADD  DEFAULT ((0)) FOR [CategoryTID]
GO

CREATE TABLE [dbo].[Deal](
	[DealID] [int] IDENTITY(1,1) NOT NULL,
	[OUTID] [varchar](250) NULL,
	[ContractorID] [int] NOT NULL,
	[DealOID] [varchar](50) NULL,
	[DealDate] [smalldatetime] NULL,
	[DealName] [varchar](200) NULL,
	[DealDueDay] [tinyint] NOT NULL,
	[MARK] [tinyint] NOT NULL,
 CONSTRAINT [PK_Deal] PRIMARY KEY CLUSTERED 
(
	[DealID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Deal] ADD  DEFAULT ((0)) FOR [DealDueDay]
GO

ALTER TABLE [dbo].[Deal] ADD  DEFAULT ((0)) FOR [MARK]
GO

CREATE TABLE [dbo].[Sales](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[OID] [varchar](120) NULL,
	[SalesPID] [int] NOT NULL,
	[ContractorID] [int] NOT NULL,
	[DealID] [int] NOT NULL,
	[SalesNum] [varchar](50) NOT NULL,
	[SalesDate] [smalldatetime] NOT NULL,
	[VAT] [tinyint] NOT NULL,
	[SalesSum] [numeric](18, 2) NOT NULL,
	[SalesBaseSum] [numeric](18, 2) NOT NULL,
	[SalesTrialSum] [numeric](18, 2) NOT NULL,
	[MARK] [tinyint] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sales_VAT]  DEFAULT ((20)) FOR [VAT]
GO

ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sales_SalesSum]  DEFAULT ((0)) FOR [SalesSum]
GO

ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sales_SalesBaseSum]  DEFAULT ((0)) FOR [SalesBaseSum]
GO

ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sales_SalesTrialSum]  DEFAULT ((0)) FOR [SalesTrialSum]
GO

/*Хранимые процедуры*/

/****** Object:  StoredProcedure [dbo].[ADD_Contractor]    Script Date: 09.12.2018 17:22:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


  CREATE PROCEDURE [dbo].[ADD_Contractor]
     
	 
	   @TIN VARCHAR(12)
      ,@ContrName VARCHAR(250)
      ,@CategoryFID TINYINT
      ,@CategorySID TINYINT
      ,@CategoryTID TINYINT
      

  AS
   INSERT INTO [Сontractor]
	   ([OUTID]
	  ,[TIN]
      ,[ContrName]
      ,[CategoryFID]
      ,[CategorySID]
      ,[CategoryTID]
      ,[MARK])
    VALUES (NULL, @TIN,@ContrName,@CategoryFID,@CategorySID,@CategoryTID,0)
  
    SELECT SCOPE_IDENTITY()
GO

CREATE PROCEDURE [dbo].[ADD_Deal]
	@ContractorID INT,
	@DealOID VARCHAR (50),
	@DealDate smalldatetime,
	@DealName VARCHAR (200),
	@DealDueDay tinyint
AS

INSERT INTO Deal
VALUES (NULL,@ContractorID,@DealOID,@DealDate,@DealName,@DealDueDay,0)

SELECT SCOPE_IDENTITY()
GO


CREATE PROCEDURE [dbo].[ADD_Sales_Detail]
	@SalesID INT
 ,@ContractorID INT
 ,@DealID INT
 ,@SalesNum VARCHAR(50)
 ,@SalesDate SMALLDATETIME
 ,@VAT TINYINT
 ,@SalesSum NUMERIC(18,2)
 ,@SalesBaseSum NUMERIC(18,2)
 ,@SalesTrialSum NUMERIC(18,2)
AS

INSERT INTO [Sales]
VALUES (NULL
	  ,@SalesID
      ,@ContractorID
      ,@DealID
      ,@SalesNum
      ,@SalesDate
      ,@VAT
      ,@SalesSum
      ,@SalesBaseSum
      ,@SalesTrialSum
      ,0)

	  SELECT SCOPE_IDENTITY()
GO


CREATE PROCEDURE [dbo].[ADD_Sales_Main]
 @ContractorID INT
 ,@DealID INT
 ,@SalesNum VARCHAR(50)
 ,@SalesDate SMALLDATETIME
 ,@VAT TINYINT
 ,@SalesSum NUMERIC(18,2)
 ,@SalesBaseSum NUMERIC(18,2)
 ,@SalesTrialSum NUMERIC(18,2)
AS

INSERT INTO [Sales]
VALUES (NULL,0
      ,@ContractorID
      ,@DealID
      ,@SalesNum
      ,@SalesDate
      ,@VAT
      ,@SalesSum
      ,@SalesBaseSum
      ,@SalesTrialSum
      ,0)

	  SELECT SCOPE_IDENTITY()
GO


  CREATE PROCEDURE [dbo].[DEL_Contractor]
     
	   @ContractorID INT
	  
  AS
  UPDATE  [Сontractor]
  SET 
	   
	  [MARK]=1
      
   WHERE [ContractorID]=@ContractorID 
GO

CREATE PROCEDURE [dbo].[DEL_Deal]
	@DealID INT
	
AS

UPDATE Deal
SET
    MARK=1
	
WHERE  DealID=@DealID

GO

CREATE PROCEDURE [dbo].[DEL_Sales_Main]
	@SalesID INT
	
  AS

  UPDATE Sales
  SET
	   [MARK]=1 
      
 WHERE [SalesID]=  @SalesID   

GO

CREATE PROCEDURE [dbo].[SEL_Category]
AS

SELECT IND=0, CategoryFID, CategoryFName
FROM ContractorFCategory
UNION ALL
SELECT 1, CategorySID, CategorySName
FROM ContractorSCategory
UNION ALL
SELECT 2, CategoryTID, CategoryTName
FROM ContractorTCategory
GO

CREATE PROCEDURE [dbo].[SEL_Contractor]
  AS
	SELECT 
	A.[ContractorID],A.[CategoryFID],A.[CategorySID],A.[CategoryTID] ,
	A.[TIN], 
	A.[ContrName],  
	B.[CategoryFName],
	C.[CategorySName],
	D.[CategoryTName]
	FROM [Сontractor] A
	LEFT JOIN ContractorFCategory B ON A.[CategoryFID]= B.[CategoryFID]
	LEFT JOIN ContractorSCategory C ON A.[CategorySID]= C.[CategorySID]
	LEFT JOIN ContractorTCategory D ON A.[CategoryTID]= D.[CategoryTID]
	WHERE A.[MARK]=0
	ORDER BY A.[ContrName]
GO

CREATE PROCEDURE [dbo].[SEL_Deal_All]

AS
SELECT A.[DealID]
      ,A.[ContractorID]
	  ,B.[TIN]
	  ,B.[ContrName]
      ,A.[DealOID]
      ,A.[DealDate]
      ,A.[DealName]
      ,A.[DealDueDay]
      
  FROM [Deal] A
  LEFT JOIN [Сontractor] B ON A.ContractorID=B.ContractorID
  WHERE A.[MARK]=0
  ORDER BY B.[ContrName],A.[DealDate]

  GO

  CREATE PROCEDURE [dbo].[SEL_Sales_Detail_All]
@ContractorID INT

AS
SELECT [SalesID]
	   [SalesPID]
      ,[VAT]
	  ,[SalesNum]
      ,[SalesDate]
      ,[SalesSum]
      ,[SalesBaseSum]
       [SalesTrialSum]
      
  FROM [Sales] 
  WHERE SalesPID=@ContractorID AND MARK=0
GO


CREATE PROCEDURE [dbo].[SEL_Sales_Main_All]
AS
SELECT A.[SalesID]
      ,A.[ContractorID]
      ,A.[DealID]
	  ,A.[VAT]
	  ,B.[ContrName]
      ,C.[DealOID]
	  ,C.[DealDate]
	  ,A.[SalesNum]
      ,A.[SalesDate]
      ,A.[SalesSum]
      ,A.[SalesBaseSum]
      ,A.[SalesTrialSum]
      
  FROM [Sales] A 
  LEFT JOIN Сontractor B ON A.ContractorID=B.ContractorID
  LEFT JOIN Deal C ON A.DealID =C.DealID
  WHERE A.SalesPID=0 AND A.MARK=0
GO


  CREATE PROCEDURE [dbo].[UPD_Contractor]
     
	   @ContractorID INT
	  ,@TIN VARCHAR(12)
      ,@ContrName VARCHAR(250)
      ,@CategoryFID TINYINT
      ,@CategorySID TINYINT
      ,@CategoryTID TINYINT
      

  AS
  UPDATE  [Сontractor]
  SET 
	   
	  [TIN]=@TIN
      ,[ContrName]=@ContrName
      ,[CategoryFID]=@CategoryFID
      ,[CategorySID]=@CategorySID 
      ,[CategoryTID]=@CategoryTID
   WHERE [ContractorID]=@ContractorID 
GO


CREATE PROCEDURE [dbo].[UPD_Deal]
	@DealID INT,
	@ContractorID INT,
	@DealOID VARCHAR (50),
	@DealDate smalldatetime,
	@DealName VARCHAR (200),
	@DealDueDay tinyint
AS

UPDATE Deal
SET
    
	ContractorID=@ContractorID,
	DealOID=@DealOID,
	DealDate=@DealDate,
	DealName=@DealName,
	DealDueDay=@DealDueDay

WHERE  DealID=@DealID

GO

CREATE PROCEDURE [dbo].[UPD_Sales_Main]
	@SalesID INT,
	@SalesNum VARCHAR(50),
	@SalesDate SMALLDATETIME,
	@VAT TINYINT,
	@SalesSum NUMERIC(18,2),
	@SalesBaseSum NUMERIC(18,2),
	@SalesTrialSum NUMERIC(18,2)
  AS

  UPDATE Sales
  SET
	   [SalesNum]=@SalesNum 
      ,[SalesDate]=@SalesDate
      ,[VAT]=@VAT
      ,[SalesSum]=@SalesSum
      ,[SalesBaseSum]=@SalesBaseSum
      ,[SalesTrialSum]=@SalesTrialSum
 WHERE [SalesID]=  @SalesID   

GO
/***************************************/
/*** ЗАПОЛНЕНИЕ ДАННЫМИ ПО УМОЛЧАНИЮ ***/
/***************************************/


INSERT [dbo].[ContractorFCategory] ([CategoryFID], [CategoryFName]) VALUES (0, N'Не определено')
GO
INSERT [dbo].[ContractorFCategory] ([CategoryFID], [CategoryFName]) VALUES (1, N'ГП')
GO
INSERT [dbo].[ContractorFCategory] ([CategoryFID], [CategoryFName]) VALUES (2, N'ЭСК')
GO
INSERT [dbo].[ContractorFCategory] ([CategoryFID], [CategoryFName]) VALUES (3, N'Юр.лицо')
GO
INSERT [dbo].[ContractorFCategory] ([CategoryFID], [CategoryFName]) VALUES (4, N'Бюджет')
GO
INSERT [dbo].[ContractorSCategory] ([CategorySID], [CategorySName]) VALUES (0, N'Не определено')
GO
INSERT [dbo].[ContractorSCategory] ([CategorySID], [CategorySName]) VALUES (1, N'ФБ')
GO
INSERT [dbo].[ContractorSCategory] ([CategorySID], [CategorySName]) VALUES (2, N'ОБ')
GO
INSERT [dbo].[ContractorSCategory] ([CategorySID], [CategorySName]) VALUES (3, N'МБ')
GO
INSERT [dbo].[ContractorTCategory] ([CategoryTID], [CategoryTName]) VALUES (0, N'Не определено')
GO
INSERT [dbo].[ContractorTCategory] ([CategoryTID], [CategoryTName]) VALUES (1, N'Крупный потребитель')
GO
INSERT [dbo].[ContractorTCategory] ([CategoryTID], [CategoryTName]) VALUES (2, N'Департамент по образованию')
GO
INSERT [dbo].[ContractorTCategory] ([CategoryTID], [CategoryTName]) VALUES (3, N'Комитет культуры')
GO
INSERT [dbo].[ContractorTCategory] ([CategoryTID], [CategoryTName]) VALUES (4, N'Комитет обр-я, науки и м-й политики ВО')
GO
INSERT [dbo].[METAFORM] ([MID], [MID_NAME]) VALUES (1, N'Справочник контрагентов')
GO
INSERT [dbo].[METAFORM] ([MID], [MID_NAME]) VALUES (2, N'Справочник договоров')
GO
INSERT [dbo].[METAFORM] ([MID], [MID_NAME]) VALUES (3, N'Акты выполненных работ')
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 0, N'ContractorID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 1, N'CFID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 2, N'CSID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 3, N'CTID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 4, N'ИНН', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 5, N'Контрагент', 300, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 6, N'Категория 1', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 7, N'Категория 2', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (1, 1, 8, N'Категория 3', 275, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 0, N'DealID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 1, N'ContractorID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 2, N'ИНН', 90, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 3, N'Контрагент', 300, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 4, N'Номер', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 5, N'Дата', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 6, N'Наименование', 350, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (2, 1, 7, N'Оплата', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 0, N'SalesID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 1, N'ContractorID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 2, N'DealID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 3, N'VAT', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 4, N'Контраегент', 300, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 5, N'Договор', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 6, N'Дата', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 7, N'Номер акта', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 8, N'Дата', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 9, N'Сумма', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 10, N'Принято', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 1, 11, N'Оспорено', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 0, N'SalesID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 1, N'SalesPID', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 2, N'VAT', 20, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 3, N'Номер акта', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 4, N'Дата', 100, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 5, N'Сумма', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 6, N'Принято', 120, 1)
GO
INSERT [dbo].[METAGRID] ([MIT], [GROID], [COL], [COLNAME], [COLWITH], [VIS]) VALUES (3, 2, 7, N'Оспорено', 120, 1)
GO

