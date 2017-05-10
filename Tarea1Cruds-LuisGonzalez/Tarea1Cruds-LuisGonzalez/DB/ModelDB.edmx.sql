
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2017 16:47:19
-- Generated from EDMX file: C:\Users\betty\Documents\GitHub\Tarea1Cruds\Tarea1Cruds-LuisGonzalez\Tarea1Cruds-LuisGonzalez\DB\ModelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [aspnet-Tarea1Cruds-LuisGonzalez-20170509034344];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmpleadoSet'
CREATE TABLE [dbo].[EmpleadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Sueldo] decimal(18,0)  NOT NULL,
    [Departamento_Id] int  NOT NULL
);
GO

-- Creating table 'DepartamentoSet'
CREATE TABLE [dbo].[DepartamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreDepartamento] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [PK_EmpleadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepartamentoSet'
ALTER TABLE [dbo].[DepartamentoSet]
ADD CONSTRAINT [PK_DepartamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Departamento_Id] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [FK_DepartamentoEmpleado]
    FOREIGN KEY ([Departamento_Id])
    REFERENCES [dbo].[DepartamentoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoEmpleado'
CREATE INDEX [IX_FK_DepartamentoEmpleado]
ON [dbo].[EmpleadoSet]
    ([Departamento_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------