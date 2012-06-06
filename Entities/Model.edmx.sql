
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2012 10:23:15
-- Generated from EDMX file: C:\Projets\Entities\ProjetDevSupinfo2012\Entities\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [YouFoodDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ZoneServeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Users_Serveur] DROP CONSTRAINT [FK_ZoneServeur];
GO
IF OBJECT_ID(N'[dbo].[FK_ZoneTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableJeu] DROP CONSTRAINT [FK_ZoneTable];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandePlat_Commande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommandePlat] DROP CONSTRAINT [FK_CommandePlat_Commande];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandePlat_Plat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommandePlat] DROP CONSTRAINT [FK_CommandePlat_Plat];
GO
IF OBJECT_ID(N'[dbo].[FK_TableCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommandeJeu] DROP CONSTRAINT [FK_TableCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantZone]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZoneJeu] DROP CONSTRAINT [FK_RestaurantZone];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantManager]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestaurantJeu] DROP CONSTRAINT [FK_RestaurantManager];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeNotificationNotification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TypeNotificationJeu] DROP CONSTRAINT [FK_TypeNotificationNotification];
GO
IF OBJECT_ID(N'[dbo].[FK_NotificationCommande_Notification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NotificationCommande] DROP CONSTRAINT [FK_NotificationCommande_Notification];
GO
IF OBJECT_ID(N'[dbo].[FK_NotificationCommande_Commande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NotificationCommande] DROP CONSTRAINT [FK_NotificationCommande_Commande];
GO
IF OBJECT_ID(N'[dbo].[FK_TypePlatPlat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlatJeu1] DROP CONSTRAINT [FK_TypePlatPlat];
GO
IF OBJECT_ID(N'[dbo].[FK_SpecialitePlat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlatJeu1] DROP CONSTRAINT [FK_SpecialitePlat];
GO
IF OBJECT_ID(N'[dbo].[FK_PlatCarte_Plat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlatCarte] DROP CONSTRAINT [FK_PlatCarte_Plat];
GO
IF OBJECT_ID(N'[dbo].[FK_PlatCarte_Carte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlatCarte] DROP CONSTRAINT [FK_PlatCarte_Carte];
GO
IF OBJECT_ID(N'[dbo].[FK_PlatEnCoursCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlatEnCoursJeu] DROP CONSTRAINT [FK_PlatEnCoursCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_PlatEnCoursCuisinier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Users_Cuisinier] DROP CONSTRAINT [FK_PlatEnCoursCuisinier];
GO
IF OBJECT_ID(N'[dbo].[FK_SpecialiteCarte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarteJeu] DROP CONSTRAINT [FK_SpecialiteCarte];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RestaurantJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestaurantJeu];
GO
IF OBJECT_ID(N'[dbo].[ZoneJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZoneJeu];
GO
IF OBJECT_ID(N'[dbo].[TableJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TableJeu];
GO
IF OBJECT_ID(N'[dbo].[CommandeJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommandeJeu];
GO
IF OBJECT_ID(N'[dbo].[PlatJeu1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlatJeu1];
GO
IF OBJECT_ID(N'[dbo].[CarteJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarteJeu];
GO
IF OBJECT_ID(N'[dbo].[NotificationJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NotificationJeu];
GO
IF OBJECT_ID(N'[dbo].[Commande1Jeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commande1Jeu];
GO
IF OBJECT_ID(N'[dbo].[TypePlatJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypePlatJeu];
GO
IF OBJECT_ID(N'[dbo].[SpecialiteJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SpecialiteJeu];
GO
IF OBJECT_ID(N'[dbo].[LogJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogJeu];
GO
IF OBJECT_ID(N'[dbo].[TypeNotificationJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeNotificationJeu];
GO
IF OBJECT_ID(N'[dbo].[PlatEnCoursJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlatEnCoursJeu];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Users_Serveur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Users_Serveur];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Users_Manager]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Users_Manager];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Users_Cuisinier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Users_Cuisinier];
GO
IF OBJECT_ID(N'[dbo].[CommandePlat]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommandePlat];
GO
IF OBJECT_ID(N'[dbo].[NotificationCommande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NotificationCommande];
GO
IF OBJECT_ID(N'[dbo].[PlatCarte]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlatCarte];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RestaurantJeu'
CREATE TABLE [dbo].[RestaurantJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [Capacite] int  NOT NULL,
    [Tel] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Manager_ID] int  NOT NULL
);
GO

-- Creating table 'ZoneJeu'
CREATE TABLE [dbo].[ZoneJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [RestaurantID] int  NOT NULL
);
GO

-- Creating table 'TableJeu'
CREATE TABLE [dbo].[TableJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Capacite] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL,
    [ZoneID] int  NOT NULL
);
GO

-- Creating table 'CommandeJeu'
CREATE TABLE [dbo].[CommandeJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Reglement] bit  NOT NULL,
    [Prix] float  NOT NULL,
    [CuisinierID] int  NOT NULL,
    [TableID] int  NOT NULL
);
GO

-- Creating table 'PlatJeu1'
CREATE TABLE [dbo].[PlatJeu1] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Prix] float  NOT NULL,
    [TypePlatID] int  NOT NULL,
    [SpecialiteID] int  NOT NULL
);
GO

-- Creating table 'CarteJeu'
CREATE TABLE [dbo].[CarteJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [DateCreation] datetime  NOT NULL,
    [DateDerniereApplication] datetime  NOT NULL,
    [DateProchaineApplication] datetime  NOT NULL,
    [SpecialiteID] int  NOT NULL
);
GO

-- Creating table 'NotificationJeu'
CREATE TABLE [dbo].[NotificationJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Fait] bit  NOT NULL
);
GO

-- Creating table 'Commande1Jeu'
CREATE TABLE [dbo].[Commande1Jeu] (
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'TypePlatJeu'
CREATE TABLE [dbo].[TypePlatJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SpecialiteJeu'
CREATE TABLE [dbo].[SpecialiteJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Image] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LogJeu'
CREATE TABLE [dbo].[LogJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [type] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'TypeNotificationJeu'
CREATE TABLE [dbo].[TypeNotificationJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] datetime  NOT NULL,
    [Notification_ID] int  NOT NULL
);
GO

-- Creating table 'PlatEnCoursJeu'
CREATE TABLE [dbo].[PlatEnCoursJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CommandeID] nvarchar(max)  NOT NULL,
    [CuisinierID] nvarchar(max)  NOT NULL,
    [Commande_ID] int  NOT NULL
);
GO

-- Creating table 'PersonneJeu'
CREATE TABLE [dbo].[PersonneJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonneJeu_Serveur'
CREATE TABLE [dbo].[PersonneJeu_Serveur] (
    [ZoneID] int  NOT NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'PersonneJeu_Manager'
CREATE TABLE [dbo].[PersonneJeu_Manager] (
    [RestaurantID] int  NOT NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'PersonneJeu_Cuisinier'
CREATE TABLE [dbo].[PersonneJeu_Cuisinier] (
    [ID] int  NOT NULL,
    [PlatEnCours_ID] int  NOT NULL
);
GO

-- Creating table 'CommandePlat'
CREATE TABLE [dbo].[CommandePlat] (
    [Commande_ID] int  NOT NULL,
    [Plat_ID] int  NOT NULL
);
GO

-- Creating table 'NotificationCommande'
CREATE TABLE [dbo].[NotificationCommande] (
    [Notification_ID] int  NOT NULL,
    [Commande_ID] int  NOT NULL
);
GO

-- Creating table 'PlatCarte'
CREATE TABLE [dbo].[PlatCarte] (
    [Plat_ID] int  NOT NULL,
    [Carte_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'RestaurantJeu'
ALTER TABLE [dbo].[RestaurantJeu]
ADD CONSTRAINT [PK_RestaurantJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ZoneJeu'
ALTER TABLE [dbo].[ZoneJeu]
ADD CONSTRAINT [PK_ZoneJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TableJeu'
ALTER TABLE [dbo].[TableJeu]
ADD CONSTRAINT [PK_TableJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CommandeJeu'
ALTER TABLE [dbo].[CommandeJeu]
ADD CONSTRAINT [PK_CommandeJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PlatJeu1'
ALTER TABLE [dbo].[PlatJeu1]
ADD CONSTRAINT [PK_PlatJeu1]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CarteJeu'
ALTER TABLE [dbo].[CarteJeu]
ADD CONSTRAINT [PK_CarteJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'NotificationJeu'
ALTER TABLE [dbo].[NotificationJeu]
ADD CONSTRAINT [PK_NotificationJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Commande1Jeu'
ALTER TABLE [dbo].[Commande1Jeu]
ADD CONSTRAINT [PK_Commande1Jeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TypePlatJeu'
ALTER TABLE [dbo].[TypePlatJeu]
ADD CONSTRAINT [PK_TypePlatJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SpecialiteJeu'
ALTER TABLE [dbo].[SpecialiteJeu]
ADD CONSTRAINT [PK_SpecialiteJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'LogJeu'
ALTER TABLE [dbo].[LogJeu]
ADD CONSTRAINT [PK_LogJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TypeNotificationJeu'
ALTER TABLE [dbo].[TypeNotificationJeu]
ADD CONSTRAINT [PK_TypeNotificationJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PlatEnCoursJeu'
ALTER TABLE [dbo].[PlatEnCoursJeu]
ADD CONSTRAINT [PK_PlatEnCoursJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonneJeu'
ALTER TABLE [dbo].[PersonneJeu]
ADD CONSTRAINT [PK_PersonneJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonneJeu_Serveur'
ALTER TABLE [dbo].[PersonneJeu_Serveur]
ADD CONSTRAINT [PK_PersonneJeu_Serveur]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonneJeu_Manager'
ALTER TABLE [dbo].[PersonneJeu_Manager]
ADD CONSTRAINT [PK_PersonneJeu_Manager]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonneJeu_Cuisinier'
ALTER TABLE [dbo].[PersonneJeu_Cuisinier]
ADD CONSTRAINT [PK_PersonneJeu_Cuisinier]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Commande_ID], [Plat_ID] in table 'CommandePlat'
ALTER TABLE [dbo].[CommandePlat]
ADD CONSTRAINT [PK_CommandePlat]
    PRIMARY KEY NONCLUSTERED ([Commande_ID], [Plat_ID] ASC);
GO

-- Creating primary key on [Notification_ID], [Commande_ID] in table 'NotificationCommande'
ALTER TABLE [dbo].[NotificationCommande]
ADD CONSTRAINT [PK_NotificationCommande]
    PRIMARY KEY NONCLUSTERED ([Notification_ID], [Commande_ID] ASC);
GO

-- Creating primary key on [Plat_ID], [Carte_ID] in table 'PlatCarte'
ALTER TABLE [dbo].[PlatCarte]
ADD CONSTRAINT [PK_PlatCarte]
    PRIMARY KEY NONCLUSTERED ([Plat_ID], [Carte_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ZoneID] in table 'PersonneJeu_Serveur'
ALTER TABLE [dbo].[PersonneJeu_Serveur]
ADD CONSTRAINT [FK_ZoneServeur]
    FOREIGN KEY ([ZoneID])
    REFERENCES [dbo].[ZoneJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZoneServeur'
CREATE INDEX [IX_FK_ZoneServeur]
ON [dbo].[PersonneJeu_Serveur]
    ([ZoneID]);
GO

-- Creating foreign key on [ZoneID] in table 'TableJeu'
ALTER TABLE [dbo].[TableJeu]
ADD CONSTRAINT [FK_ZoneTable]
    FOREIGN KEY ([ZoneID])
    REFERENCES [dbo].[ZoneJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZoneTable'
CREATE INDEX [IX_FK_ZoneTable]
ON [dbo].[TableJeu]
    ([ZoneID]);
GO

-- Creating foreign key on [Commande_ID] in table 'CommandePlat'
ALTER TABLE [dbo].[CommandePlat]
ADD CONSTRAINT [FK_CommandePlat_Commande]
    FOREIGN KEY ([Commande_ID])
    REFERENCES [dbo].[CommandeJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Plat_ID] in table 'CommandePlat'
ALTER TABLE [dbo].[CommandePlat]
ADD CONSTRAINT [FK_CommandePlat_Plat]
    FOREIGN KEY ([Plat_ID])
    REFERENCES [dbo].[PlatJeu1]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandePlat_Plat'
CREATE INDEX [IX_FK_CommandePlat_Plat]
ON [dbo].[CommandePlat]
    ([Plat_ID]);
GO

-- Creating foreign key on [TableID] in table 'CommandeJeu'
ALTER TABLE [dbo].[CommandeJeu]
ADD CONSTRAINT [FK_TableCommande]
    FOREIGN KEY ([TableID])
    REFERENCES [dbo].[TableJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TableCommande'
CREATE INDEX [IX_FK_TableCommande]
ON [dbo].[CommandeJeu]
    ([TableID]);
GO

-- Creating foreign key on [RestaurantID] in table 'ZoneJeu'
ALTER TABLE [dbo].[ZoneJeu]
ADD CONSTRAINT [FK_RestaurantZone]
    FOREIGN KEY ([RestaurantID])
    REFERENCES [dbo].[RestaurantJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantZone'
CREATE INDEX [IX_FK_RestaurantZone]
ON [dbo].[ZoneJeu]
    ([RestaurantID]);
GO

-- Creating foreign key on [Manager_ID] in table 'RestaurantJeu'
ALTER TABLE [dbo].[RestaurantJeu]
ADD CONSTRAINT [FK_RestaurantManager]
    FOREIGN KEY ([Manager_ID])
    REFERENCES [dbo].[PersonneJeu_Manager]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantManager'
CREATE INDEX [IX_FK_RestaurantManager]
ON [dbo].[RestaurantJeu]
    ([Manager_ID]);
GO

-- Creating foreign key on [Notification_ID] in table 'TypeNotificationJeu'
ALTER TABLE [dbo].[TypeNotificationJeu]
ADD CONSTRAINT [FK_TypeNotificationNotification]
    FOREIGN KEY ([Notification_ID])
    REFERENCES [dbo].[NotificationJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeNotificationNotification'
CREATE INDEX [IX_FK_TypeNotificationNotification]
ON [dbo].[TypeNotificationJeu]
    ([Notification_ID]);
GO

-- Creating foreign key on [Notification_ID] in table 'NotificationCommande'
ALTER TABLE [dbo].[NotificationCommande]
ADD CONSTRAINT [FK_NotificationCommande_Notification]
    FOREIGN KEY ([Notification_ID])
    REFERENCES [dbo].[NotificationJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Commande_ID] in table 'NotificationCommande'
ALTER TABLE [dbo].[NotificationCommande]
ADD CONSTRAINT [FK_NotificationCommande_Commande]
    FOREIGN KEY ([Commande_ID])
    REFERENCES [dbo].[CommandeJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NotificationCommande_Commande'
CREATE INDEX [IX_FK_NotificationCommande_Commande]
ON [dbo].[NotificationCommande]
    ([Commande_ID]);
GO

-- Creating foreign key on [TypePlatID] in table 'PlatJeu1'
ALTER TABLE [dbo].[PlatJeu1]
ADD CONSTRAINT [FK_TypePlatPlat]
    FOREIGN KEY ([TypePlatID])
    REFERENCES [dbo].[TypePlatJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TypePlatPlat'
CREATE INDEX [IX_FK_TypePlatPlat]
ON [dbo].[PlatJeu1]
    ([TypePlatID]);
GO

-- Creating foreign key on [SpecialiteID] in table 'PlatJeu1'
ALTER TABLE [dbo].[PlatJeu1]
ADD CONSTRAINT [FK_SpecialitePlat]
    FOREIGN KEY ([SpecialiteID])
    REFERENCES [dbo].[SpecialiteJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialitePlat'
CREATE INDEX [IX_FK_SpecialitePlat]
ON [dbo].[PlatJeu1]
    ([SpecialiteID]);
GO

-- Creating foreign key on [Plat_ID] in table 'PlatCarte'
ALTER TABLE [dbo].[PlatCarte]
ADD CONSTRAINT [FK_PlatCarte_Plat]
    FOREIGN KEY ([Plat_ID])
    REFERENCES [dbo].[PlatJeu1]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Carte_ID] in table 'PlatCarte'
ALTER TABLE [dbo].[PlatCarte]
ADD CONSTRAINT [FK_PlatCarte_Carte]
    FOREIGN KEY ([Carte_ID])
    REFERENCES [dbo].[CarteJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlatCarte_Carte'
CREATE INDEX [IX_FK_PlatCarte_Carte]
ON [dbo].[PlatCarte]
    ([Carte_ID]);
GO

-- Creating foreign key on [Commande_ID] in table 'PlatEnCoursJeu'
ALTER TABLE [dbo].[PlatEnCoursJeu]
ADD CONSTRAINT [FK_PlatEnCoursCommande]
    FOREIGN KEY ([Commande_ID])
    REFERENCES [dbo].[CommandeJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlatEnCoursCommande'
CREATE INDEX [IX_FK_PlatEnCoursCommande]
ON [dbo].[PlatEnCoursJeu]
    ([Commande_ID]);
GO

-- Creating foreign key on [PlatEnCours_ID] in table 'PersonneJeu_Cuisinier'
ALTER TABLE [dbo].[PersonneJeu_Cuisinier]
ADD CONSTRAINT [FK_PlatEnCoursCuisinier]
    FOREIGN KEY ([PlatEnCours_ID])
    REFERENCES [dbo].[PlatEnCoursJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlatEnCoursCuisinier'
CREATE INDEX [IX_FK_PlatEnCoursCuisinier]
ON [dbo].[PersonneJeu_Cuisinier]
    ([PlatEnCours_ID]);
GO

-- Creating foreign key on [SpecialiteID] in table 'CarteJeu'
ALTER TABLE [dbo].[CarteJeu]
ADD CONSTRAINT [FK_SpecialiteCarte]
    FOREIGN KEY ([SpecialiteID])
    REFERENCES [dbo].[SpecialiteJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialiteCarte'
CREATE INDEX [IX_FK_SpecialiteCarte]
ON [dbo].[CarteJeu]
    ([SpecialiteID]);
GO

-- Creating foreign key on [ID] in table 'PersonneJeu_Serveur'
ALTER TABLE [dbo].[PersonneJeu_Serveur]
ADD CONSTRAINT [FK_Serveur_inherits_Personne]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[PersonneJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'PersonneJeu_Manager'
ALTER TABLE [dbo].[PersonneJeu_Manager]
ADD CONSTRAINT [FK_Manager_inherits_Personne]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[PersonneJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'PersonneJeu_Cuisinier'
ALTER TABLE [dbo].[PersonneJeu_Cuisinier]
ADD CONSTRAINT [FK_Cuisinier_inherits_Personne]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[PersonneJeu]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------