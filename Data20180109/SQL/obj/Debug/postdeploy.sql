/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [janus]
GO

SET IDENTITY_INSERT [dbo].[Product] OFF

INSERT [dbo].[Product] ([Name], [Price]) VALUES ('AAA', 100)
GO

INSERT [dbo].[Product] ([Name], [Price]) VALUES ('BBB', 120)
GO

SET IDENTITY_INSERT [dbo].[Product] ON
GO

GO
