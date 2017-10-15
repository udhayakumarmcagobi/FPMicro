USE [FBMicro]
GO
/****** Object:  Table [dbo].[VoucherMaster]    Script Date: 10/15/2017 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VoucherMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VoucherMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VoucherName] [varchar](50) NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_VoucherMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserHomeLoanDetails]    Script Date: 10/15/2017 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserHomeLoanDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserHomeLoanDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BankId] [int] NOT NULL,
	[LoanAmount] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_UserHomeLoanDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[UserHomeLoanDetails] ON
INSERT [dbo].[UserHomeLoanDetails] ([Id], [UserId], [BankId], [LoanAmount]) VALUES (1, 1, 2, CAST(2500000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[UserHomeLoanDetails] OFF
/****** Object:  Table [dbo].[UserDetails]    Script Date: 10/15/2017 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[ContactNo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON
INSERT [dbo].[UserDetails] ([Id], [Name], [ContactNo]) VALUES (1, N'Udhay', N'8884257690')
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
/****** Object:  Table [dbo].[UserBalanceTransferDetails]    Script Date: 10/15/2017 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserBalanceTransferDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserBalanceTransferDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BankId] [int] NOT NULL,
	[LoanAmount] [decimal](18, 0) NOT NULL,
	[isTopUpNeeded] [bit] NOT NULL,
	[TopUpAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_UserBalanceTransferDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[UserBalanceTransferDetails] ON
INSERT [dbo].[UserBalanceTransferDetails] ([Id], [UserId], [BankId], [LoanAmount], [isTopUpNeeded], [TopUpAmount]) VALUES (1, 1, 5, CAST(2500000 AS Decimal(18, 0)), 1, CAST(2500000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[UserBalanceTransferDetails] OFF
/****** Object:  Table [dbo].[BankMaster]    Script Date: 10/15/2017 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BankMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[OfferPercentage] [decimal](18, 2) NULL,
	[BankLogoPath] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_BankMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BankMaster] ON
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (1, N'PNBHFL', CAST(0.40 AS Decimal(18, 2)), N'~/assets/banks/logos/pnbhfl.png', N'Punjab National Bank Housing Finance Limited')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (2, N'HDFC', CAST(0.25 AS Decimal(18, 2)), N'~/assets/banks/logos/hdfc.png', N'HDFC Bank Limited')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (3, N'AXIS', CAST(0.25 AS Decimal(18, 2)), N'~/assets/banks/logos/axis.png', N'AXIS Bank')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (4, N'ICICI', CAST(0.25 AS Decimal(18, 2)), N'~/assets/banks/logos/icici.png', N'ICICI Bank')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (5, N'SBI', CAST(0.10 AS Decimal(18, 2)), N'~/assets/banks/logos/sbi.png', N'State Bank Of India')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (6, N'IDFC', CAST(0.30 AS Decimal(18, 2)), N'~/assets/banks/logos/idfc.png', N'IDFC Bank')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (7, N'Citi Bank', CAST(0.40 AS Decimal(18, 2)), N'~/assets/banks/logos/citi.png', N'Citi Bank')
INSERT [dbo].[BankMaster] ([Id], [Name], [OfferPercentage], [BankLogoPath], [Description]) VALUES (8, N'SCB', CAST(0.40 AS Decimal(18, 2)), N'~/assets/banks/logos/scb.png', N'Standard Chartered Bank')
SET IDENTITY_INSERT [dbo].[BankMaster] OFF
/****** Object:  Table [dbo].[BankLoanDetails]    Script Date: 10/15/2017 16:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BankLoanDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BankLoanDetails](
	[Id] [int] NOT NULL,
	[BankId] [int] NOT NULL,
	[ROIBelow30Lk] [decimal](18, 2) NOT NULL,
	[ROIAbove30Lk] [decimal](18, 2) NOT NULL,
	[ProcessingFeeBelow30Lk] [decimal](18, 2) NOT NULL,
	[ProcessingFeeAbove30Lk] [decimal](18, 2) NOT NULL,
	[MODCharges] [decimal](18, 2) NOT NULL,
	[DocumentCharges] [decimal](18, 2) NOT NULL,
	[ForeClosureCharges] [decimal](18, 2) NULL,
	[PrePaymentCharges] [decimal](18, 2) NULL,
	[OffersIfAny] [varchar](500) NULL,
 CONSTRAINT [PK_BankLoanDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (1, 1, CAST(24.00 AS Decimal(18, 2)), CAST(13.50 AS Decimal(18, 2)), CAST(14.50 AS Decimal(18, 2)), CAST(3.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.60 AS Decimal(18, 2)), CAST(7.50 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (2, 2, CAST(13.00 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(14.50 AS Decimal(18, 2)), CAST(24.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (3, 3, CAST(10.00 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (4, 4, CAST(10.00 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (5, 5, CAST(10.00 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (6, 6, CAST(15.00 AS Decimal(18, 2)), CAST(30.50 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (7, 7, CAST(15.00 AS Decimal(18, 2)), CAST(30.50 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
INSERT [dbo].[BankLoanDetails] ([Id], [BankId], [ROIBelow30Lk], [ROIAbove30Lk], [ProcessingFeeBelow30Lk], [ProcessingFeeAbove30Lk], [MODCharges], [DocumentCharges], [ForeClosureCharges], [PrePaymentCharges], [OffersIfAny]) VALUES (8, 8, CAST(15.00 AS Decimal(18, 2)), CAST(30.50 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(25.50 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(3.70 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(7.40 AS Decimal(18, 2)), N'Offers')
/****** Object:  ForeignKey [FK_BankLoanDetails_BankMaster]    Script Date: 10/15/2017 16:53:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BankLoanDetails_BankMaster]') AND parent_object_id = OBJECT_ID(N'[dbo].[BankLoanDetails]'))
ALTER TABLE [dbo].[BankLoanDetails]  WITH CHECK ADD  CONSTRAINT [FK_BankLoanDetails_BankMaster] FOREIGN KEY([BankId])
REFERENCES [dbo].[BankMaster] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BankLoanDetails_BankMaster]') AND parent_object_id = OBJECT_ID(N'[dbo].[BankLoanDetails]'))
ALTER TABLE [dbo].[BankLoanDetails] CHECK CONSTRAINT [FK_BankLoanDetails_BankMaster]
GO
