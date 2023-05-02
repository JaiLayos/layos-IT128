﻿/*
Deployment script for pub_ItemDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "pub_ItemDB"
:setvar DefaultFilePrefix "pub_ItemDB"
:setvar DefaultDataPath "C:\Users\layos\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\layos\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The type for column Username in table [dbo].[users] is currently  NVARCHAR (20) NOT NULL but is being changed to  VARCHAR (20) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (20) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[users])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering Table [dbo].[users]...';


GO
ALTER TABLE [dbo].[users] ALTER COLUMN [Username] VARCHAR (20) NOT NULL;


GO
PRINT N'Refreshing Procedure [dbo].[spUsers_login]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUsers_login]';


GO
PRINT N'Refreshing Procedure [dbo].[spUsers_register]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spUsers_register]';


GO
PRINT N'Update complete.';


GO