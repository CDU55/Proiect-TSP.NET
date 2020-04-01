
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 16:32:54
-- Generated from EDMX file: C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\Proiecte\Proiect_TSPNET\Proiect_TSPNET\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Proiect];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MediaItemsLocations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaItems] DROP CONSTRAINT [FK_MediaItemsLocations];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaItemsPersons_MediaItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaItemsPersons] DROP CONSTRAINT [FK_MediaItemsPersons_MediaItems];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaItemsPersons_Persons]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaItemsPersons] DROP CONSTRAINT [FK_MediaItemsPersons_Persons];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaItemsDynamicProperties_MediaItems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaItemsDynamicProperties] DROP CONSTRAINT [FK_MediaItemsDynamicProperties_MediaItems];
GO
IF OBJECT_ID(N'[dbo].[FK_MediaItemsDynamicProperties_DynamicProperties]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MediaItemsDynamicProperties] DROP CONSTRAINT [FK_MediaItemsDynamicProperties_DynamicProperties];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MediaItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaItems];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO
IF OBJECT_ID(N'[dbo].[DynamicProperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DynamicProperties];
GO
IF OBJECT_ID(N'[dbo].[MediaItemsPersons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaItemsPersons];
GO
IF OBJECT_ID(N'[dbo].[MediaItemsDynamicProperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediaItemsDynamicProperties];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MediaItems'
CREATE TABLE [dbo].[MediaItems] (
    [ItemId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Extension] nvarchar(max)  NOT NULL,
    [IsPhoto] bit  NOT NULL,
    [MarkedForDelete] bit  NOT NULL,
    [PermanentDelete] bit  NOT NULL,
    [Date] datetime  NOT NULL,
    [EventsEventId] int  NULL,
    [Location_LocationId] int  NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [LocationId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Region] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [PersonId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Group] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DynamicProperties'
CREATE TABLE [dbo].[DynamicProperties] (
    [PropertyId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [EventId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MediaItemsPersons'
CREATE TABLE [dbo].[MediaItemsPersons] (
    [MediaItems_ItemId] int  NOT NULL,
    [Persons_PersonId] int  NOT NULL
);
GO

-- Creating table 'MediaItemsDynamicProperties'
CREATE TABLE [dbo].[MediaItemsDynamicProperties] (
    [MediaItems_ItemId] int  NOT NULL,
    [DynamicProperties_PropertyId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ItemId] in table 'MediaItems'
ALTER TABLE [dbo].[MediaItems]
ADD CONSTRAINT [PK_MediaItems]
    PRIMARY KEY CLUSTERED ([ItemId] ASC);
GO

-- Creating primary key on [LocationId] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([LocationId] ASC);
GO

-- Creating primary key on [PersonId] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- Creating primary key on [PropertyId] in table 'DynamicProperties'
ALTER TABLE [dbo].[DynamicProperties]
ADD CONSTRAINT [PK_DynamicProperties]
    PRIMARY KEY CLUSTERED ([PropertyId] ASC);
GO

-- Creating primary key on [EventId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([EventId] ASC);
GO

-- Creating primary key on [MediaItems_ItemId], [Persons_PersonId] in table 'MediaItemsPersons'
ALTER TABLE [dbo].[MediaItemsPersons]
ADD CONSTRAINT [PK_MediaItemsPersons]
    PRIMARY KEY CLUSTERED ([MediaItems_ItemId], [Persons_PersonId] ASC);
GO

-- Creating primary key on [MediaItems_ItemId], [DynamicProperties_PropertyId] in table 'MediaItemsDynamicProperties'
ALTER TABLE [dbo].[MediaItemsDynamicProperties]
ADD CONSTRAINT [PK_MediaItemsDynamicProperties]
    PRIMARY KEY CLUSTERED ([MediaItems_ItemId], [DynamicProperties_PropertyId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Location_LocationId] in table 'MediaItems'
ALTER TABLE [dbo].[MediaItems]
ADD CONSTRAINT [FK_MediaItemsLocations]
    FOREIGN KEY ([Location_LocationId])
    REFERENCES [dbo].[Locations]
        ([LocationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaItemsLocations'
CREATE INDEX [IX_FK_MediaItemsLocations]
ON [dbo].[MediaItems]
    ([Location_LocationId]);
GO

-- Creating foreign key on [MediaItems_ItemId] in table 'MediaItemsPersons'
ALTER TABLE [dbo].[MediaItemsPersons]
ADD CONSTRAINT [FK_MediaItemsPersons_MediaItems]
    FOREIGN KEY ([MediaItems_ItemId])
    REFERENCES [dbo].[MediaItems]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persons_PersonId] in table 'MediaItemsPersons'
ALTER TABLE [dbo].[MediaItemsPersons]
ADD CONSTRAINT [FK_MediaItemsPersons_Persons]
    FOREIGN KEY ([Persons_PersonId])
    REFERENCES [dbo].[Persons]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaItemsPersons_Persons'
CREATE INDEX [IX_FK_MediaItemsPersons_Persons]
ON [dbo].[MediaItemsPersons]
    ([Persons_PersonId]);
GO

-- Creating foreign key on [MediaItems_ItemId] in table 'MediaItemsDynamicProperties'
ALTER TABLE [dbo].[MediaItemsDynamicProperties]
ADD CONSTRAINT [FK_MediaItemsDynamicProperties_MediaItems]
    FOREIGN KEY ([MediaItems_ItemId])
    REFERENCES [dbo].[MediaItems]
        ([ItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DynamicProperties_PropertyId] in table 'MediaItemsDynamicProperties'
ALTER TABLE [dbo].[MediaItemsDynamicProperties]
ADD CONSTRAINT [FK_MediaItemsDynamicProperties_DynamicProperties]
    FOREIGN KEY ([DynamicProperties_PropertyId])
    REFERENCES [dbo].[DynamicProperties]
        ([PropertyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaItemsDynamicProperties_DynamicProperties'
CREATE INDEX [IX_FK_MediaItemsDynamicProperties_DynamicProperties]
ON [dbo].[MediaItemsDynamicProperties]
    ([DynamicProperties_PropertyId]);
GO

-- Creating foreign key on [EventsEventId] in table 'MediaItems'
ALTER TABLE [dbo].[MediaItems]
ADD CONSTRAINT [FK_MediaItemsEvents1]
    FOREIGN KEY ([EventsEventId])
    REFERENCES [dbo].[Events]
        ([EventId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaItemsEvents1'
CREATE INDEX [IX_FK_MediaItemsEvents1]
ON [dbo].[MediaItems]
    ([EventsEventId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------