
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/15/2020 09:41:35
-- Generated from EDMX file: E:\DAC Moduls\MicroSoft .Net\VS codes\DBset\DBset\ModelDBset.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mydb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CompModelCustModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustModels] DROP CONSTRAINT [FK_CompModelCustModel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CustModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustModels];
GO
IF OBJECT_ID(N'[dbo].[CompModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompModels];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CustModels'
CREATE TABLE [dbo].[CustModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] real  NOT NULL,
    [CompModelId] int  NOT NULL
);
GO

-- Creating table 'CompModels'
CREATE TABLE [dbo].[CompModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cname] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CustModels'
ALTER TABLE [dbo].[CustModels]
ADD CONSTRAINT [PK_CustModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompModels'
ALTER TABLE [dbo].[CompModels]
ADD CONSTRAINT [PK_CompModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CompModelId] in table 'CustModels'
ALTER TABLE [dbo].[CustModels]
ADD CONSTRAINT [FK_CompModelCustModel]
    FOREIGN KEY ([CompModelId])
    REFERENCES [dbo].[CompModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompModelCustModel'
CREATE INDEX [IX_FK_CompModelCustModel]
ON [dbo].[CustModels]
    ([CompModelId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------