IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Cadastrars] (
    [IdCli] int NOT NULL IDENTITY,
    [NomeCli] nvarchar(40) NOT NULL,
    [CPFCli] char(11) NOT NULL,
    [NasCli] date NOT NULL,
    [CEPCli] char(9) NULL,
    [BairroCli] char(25) NULL,
    [EnderecoCli] char(25) NULL,
    [NumeroCli] char(7) NOT NULL,
    [TelefoneCli] char(13) NOT NULL,
    [EmailCli] char(30) NULL,
    [Situacao] nvarchar(9) NOT NULL,
    CONSTRAINT [PK_Cadastrars] PRIMARY KEY ([IdCli])
);
GO

CREATE TABLE [Contatos] (
    [IdContato] int NOT NULL IDENTITY,
    [NomeContato] nvarchar(40) NOT NULL,
    [EmailContato] char(20) NOT NULL,
    [MsgContato] char(25) NULL,
    CONSTRAINT [PK_Contatos] PRIMARY KEY ([IdContato])
);
GO

CREATE TABLE [Destinos] (
    [IdDestino] int NOT NULL IDENTITY,
    [CPFCli] char(11) NOT NULL,
    [PartidaDestino] char(25) NULL,
    [NomeDestino] nvarchar(40) NOT NULL,
    [HoraDestino] char(25) NULL,
    [DataDestina] char(25) NOT NULL,
    CONSTRAINT [PK_Destinos] PRIMARY KEY ([IdDestino])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211217023751_FistMigration', N'5.0.13');
GO

COMMIT;
GO

