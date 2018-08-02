
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/02/2018 17:22:19
-- Generated from EDMX file: C:\Users\Haris\source\repos\SrednjeSkole\SrednjeSkole_API\Models\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SrednjeSkole];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_AutorizacijskiToken_dbo_Korisnici_KorisnikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AutorizacijskiToken] DROP CONSTRAINT [FK_dbo_AutorizacijskiToken_dbo_Korisnici_KorisnikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Casovi_dbo_Nastavnici_NastavnikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casovi] DROP CONSTRAINT [FK_dbo_Casovi_dbo_Nastavnici_NastavnikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Izostanci_dbo_Casovi_CasId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Izostanci] DROP CONSTRAINT [FK_dbo_Izostanci_dbo_Casovi_CasId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Izostanci_dbo_Ucenici_UcenikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Izostanci] DROP CONSTRAINT [FK_dbo_Izostanci_dbo_Ucenici_UcenikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_KorisniciUloge_dbo_Korisnici_KorisnikID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisniciUloge] DROP CONSTRAINT [FK_dbo_KorisniciUloge_dbo_Korisnici_KorisnikID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_KorisniciUloge_dbo_Uloge_UlogaID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisniciUloge] DROP CONSTRAINT [FK_dbo_KorisniciUloge_dbo_Uloge_UlogaID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_KorisnikKontakt_dbo_Korisnici_KorisnikKontaktId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisnikKontakt] DROP CONSTRAINT [FK_dbo_KorisnikKontakt_dbo_Korisnici_KorisnikKontaktId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Materijali_dbo_Nastavnici_NastavnikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Materijali] DROP CONSTRAINT [FK_dbo_Materijali_dbo_Nastavnici_NastavnikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Materijali_dbo_Predmeti_PredmetId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Materijali] DROP CONSTRAINT [FK_dbo_Materijali_dbo_Predmeti_PredmetId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Nastavnici_dbo_Korisnici_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Nastavnici] DROP CONSTRAINT [FK_dbo_Nastavnici_dbo_Korisnici_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Obavijesti_dbo_Korisnici_KorisnikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obavijesti] DROP CONSTRAINT [FK_dbo_Obavijesti_dbo_Korisnici_KorisnikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Predaje_dbo_Nastavnici_NastavnikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Predaje] DROP CONSTRAINT [FK_dbo_Predaje_dbo_Nastavnici_NastavnikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Predaje_dbo_SkolskeGodine_SkolskaGodinaId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Predaje] DROP CONSTRAINT [FK_dbo_Predaje_dbo_SkolskeGodine_SkolskaGodinaId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Predaje_dbo_SmjerPredmet_SmjerPredmetId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Predaje] DROP CONSTRAINT [FK_dbo_Predaje_dbo_SmjerPredmet_SmjerPredmetId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Razredi_dbo_Nastavnici_NastavnikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Razredi] DROP CONSTRAINT [FK_dbo_Razredi_dbo_Nastavnici_NastavnikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Razredi_dbo_SkolskeGodine_SkolskaGodinaId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Razredi] DROP CONSTRAINT [FK_dbo_Razredi_dbo_SkolskeGodine_SkolskaGodinaId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Razredi_dbo_Smjerovi_SmjerId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Razredi] DROP CONSTRAINT [FK_dbo_Razredi_dbo_Smjerovi_SmjerId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Smjerovi_dbo_SkolskeGodine_SkolskaGodinaId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Smjerovi] DROP CONSTRAINT [FK_dbo_Smjerovi_dbo_SkolskeGodine_SkolskaGodinaId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_SmjerPredmet_dbo_Predmeti_PredmetId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SmjerPredmet] DROP CONSTRAINT [FK_dbo_SmjerPredmet_dbo_Predmeti_PredmetId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_SmjerPredmet_dbo_Smjerovi_SmjerId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SmjerPredmet] DROP CONSTRAINT [FK_dbo_SmjerPredmet_dbo_Smjerovi_SmjerId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Ucenici_dbo_Korisnici_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ucenici] DROP CONSTRAINT [FK_dbo_Ucenici_dbo_Korisnici_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Ucenici_dbo_Smjerovi_SmjerId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ucenici] DROP CONSTRAINT [FK_dbo_Ucenici_dbo_Smjerovi_SmjerId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UceniciCasovi_dbo_Casovi_CasId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UceniciCasovi] DROP CONSTRAINT [FK_dbo_UceniciCasovi_dbo_Casovi_CasId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UceniciCasovi_dbo_Ucenici_UcenikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UceniciCasovi] DROP CONSTRAINT [FK_dbo_UceniciCasovi_dbo_Ucenici_UcenikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UceniciOcjene_dbo_Predaje_PredajeId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UceniciOcjene] DROP CONSTRAINT [FK_dbo_UceniciOcjene_dbo_Predaje_PredajeId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UceniciOcjene_dbo_Ucenici_UcenikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UceniciOcjene] DROP CONSTRAINT [FK_dbo_UceniciOcjene_dbo_Ucenici_UcenikId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UceniciRazredi_dbo_Razredi_RazredId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UceniciRazredi] DROP CONSTRAINT [FK_dbo_UceniciRazredi_dbo_Razredi_RazredId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UceniciRazredi_dbo_Ucenici_UcenikId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UceniciRazredi] DROP CONSTRAINT [FK_dbo_UceniciRazredi_dbo_Ucenici_UcenikId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AutorizacijskiToken]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AutorizacijskiToken];
GO
IF OBJECT_ID(N'[dbo].[Casovi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casovi];
GO
IF OBJECT_ID(N'[dbo].[Izostanci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Izostanci];
GO
IF OBJECT_ID(N'[dbo].[Korisnici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Korisnici];
GO
IF OBJECT_ID(N'[dbo].[KorisniciUloge]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KorisniciUloge];
GO
IF OBJECT_ID(N'[dbo].[KorisnikKontakt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KorisnikKontakt];
GO
IF OBJECT_ID(N'[dbo].[Materijali]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materijali];
GO
IF OBJECT_ID(N'[dbo].[Nastavnici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nastavnici];
GO
IF OBJECT_ID(N'[dbo].[Obavijesti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Obavijesti];
GO
IF OBJECT_ID(N'[dbo].[Predaje]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Predaje];
GO
IF OBJECT_ID(N'[dbo].[Predmeti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Predmeti];
GO
IF OBJECT_ID(N'[dbo].[Razredi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Razredi];
GO
IF OBJECT_ID(N'[dbo].[SkolskeGodine]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SkolskeGodine];
GO
IF OBJECT_ID(N'[dbo].[Smjerovi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Smjerovi];
GO
IF OBJECT_ID(N'[dbo].[SmjerPredmet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SmjerPredmet];
GO
IF OBJECT_ID(N'[dbo].[Ucenici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ucenici];
GO
IF OBJECT_ID(N'[dbo].[UceniciCasovi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UceniciCasovi];
GO
IF OBJECT_ID(N'[dbo].[UceniciOcjene]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UceniciOcjene];
GO
IF OBJECT_ID(N'[dbo].[UceniciRazredi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UceniciRazredi];
GO
IF OBJECT_ID(N'[dbo].[Uloge]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Uloge];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AutorizacijskiToken'
CREATE TABLE [dbo].[AutorizacijskiToken] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Vrijednost] nvarchar(max)  NULL,
    [KorisnikId] int  NOT NULL,
    [VrijemeEvidentiranja] datetime  NOT NULL,
    [IpAdresa] nvarchar(max)  NULL
);
GO

-- Creating table 'Casovi'
CREATE TABLE [dbo].[Casovi] (
    [CasId] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [Naslov] nvarchar(max)  NULL,
    [Opis] nvarchar(max)  NULL,
    [NastavnikId] int  NOT NULL
);
GO

-- Creating table 'Izostanci'
CREATE TABLE [dbo].[Izostanci] (
    [IzostanakId] int IDENTITY(1,1) NOT NULL,
    [Razlog] nvarchar(max)  NULL,
    [Komentar] nvarchar(max)  NULL,
    [CasId] int  NOT NULL,
    [UcenikId] int  NOT NULL
);
GO

-- Creating table 'Korisnici'
CREATE TABLE [dbo].[Korisnici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [KorisnickoIme] nvarchar(max)  NOT NULL,
    [LozinkaHash] nvarchar(max)  NULL,
    [LozinkaSalt] nvarchar(max)  NULL,
    [Aktivan] bit  NOT NULL,
    [Spol] nvarchar(max)  NULL,
    [DatumRodjenja] datetime  NOT NULL,
    [MjestoRodjenja] nvarchar(max)  NULL,
    [JMBG] nvarchar(13)  NULL,
    [Prebivaliste] nvarchar(max)  NULL
);
GO

-- Creating table 'KorisniciUloge'
CREATE TABLE [dbo].[KorisniciUloge] (
    [KorisniciUlogeId] int IDENTITY(1,1) NOT NULL,
    [UlogaID] int  NOT NULL,
    [KorisnikID] int  NOT NULL
);
GO

-- Creating table 'KorisnikKontakt'
CREATE TABLE [dbo].[KorisnikKontakt] (
    [KorisnikKontaktId] int  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [Telefon] nvarchar(max)  NULL,
    [Adresa] nvarchar(max)  NULL,
    [Grad] nvarchar(max)  NULL,
    [Opstina] nvarchar(max)  NULL
);
GO

-- Creating table 'Materijali'
CREATE TABLE [dbo].[Materijali] (
    [MaterijalId] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NULL,
    [BlobName] nvarchar(max)  NULL,
    [Url] nvarchar(max)  NULL,
    [DateCreated] datetime  NOT NULL,
    [PredmetId] int  NOT NULL,
    [NastavnikId] int  NOT NULL
);
GO

-- Creating table 'Korisnici_Nastavnici'
CREATE TABLE [dbo].[Korisnici_Nastavnici] (
    [Zvanje] nvarchar(max)  NULL,
    [DatumIzboraUZvanje] datetime  NOT NULL,
    [NaucnaOblast] nvarchar(max)  NULL,
    [GodinaZaposlenja] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Obavijesti'
CREATE TABLE [dbo].[Obavijesti] (
    [ObavijestId] int IDENTITY(1,1) NOT NULL,
    [Naslov] nvarchar(max)  NULL,
    [Tekst] nvarchar(max)  NULL,
    [KorisnikId] int  NOT NULL,
    [Datum] datetime  NOT NULL
);
GO

-- Creating table 'Predaje'
CREATE TABLE [dbo].[Predaje] (
    [PredajeId] int IDENTITY(1,1) NOT NULL,
    [NastavnikId] int  NOT NULL,
    [SkolskaGodinaId] int  NOT NULL,
    [SmjerPredmetId] int  NOT NULL
);
GO

-- Creating table 'Predmeti'
CREATE TABLE [dbo].[Predmeti] (
    [PredmetId] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Oznaka] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Razredi'
CREATE TABLE [dbo].[Razredi] (
    [RazredId] int IDENTITY(1,1) NOT NULL,
    [RazredBrojcano] int  NOT NULL,
    [Odjeljenje] nvarchar(max)  NULL,
    [Oznaka] nvarchar(max)  NULL,
    [SkolskaGodinaId] int  NOT NULL,
    [NastavnikId] int  NOT NULL,
    [SmjerId] int  NOT NULL
);
GO

-- Creating table 'SkolskeGodine'
CREATE TABLE [dbo].[SkolskeGodine] (
    [SkolskaGodinaId] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NULL
);
GO

-- Creating table 'Smjerovi'
CREATE TABLE [dbo].[Smjerovi] (
    [SmjerId] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NULL,
    [Opis] nvarchar(max)  NULL,
    [SkolskaGodinaId] int  NOT NULL
);
GO

-- Creating table 'SmjerPredmet'
CREATE TABLE [dbo].[SmjerPredmet] (
    [SmjerPredmetId] int IDENTITY(1,1) NOT NULL,
    [BrojCasova] int  NOT NULL,
    [PredmetId] int  NOT NULL,
    [SmjerId] int  NOT NULL
);
GO

-- Creating table 'Korisnici_Ucenici'
CREATE TABLE [dbo].[Korisnici_Ucenici] (
    [ImeRoditelja] nvarchar(max)  NULL,
    [GodinaUpisa] int  NOT NULL,
    [SmjerId] int  NOT NULL,
    [NazivOsnovneSkole] nvarchar(max)  NULL,
    [ProsjekOcjenaOsnovnaSkola] float  NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UceniciCasovi'
CREATE TABLE [dbo].[UceniciCasovi] (
    [UcenikCasoviId] int IDENTITY(1,1) NOT NULL,
    [UcenikId] int  NOT NULL,
    [CasId] int  NOT NULL
);
GO

-- Creating table 'UceniciOcjene'
CREATE TABLE [dbo].[UceniciOcjene] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UcenikId] int  NOT NULL,
    [PredajeId] int  NOT NULL,
    [Vrijednost] int  NOT NULL,
    [Datum] datetime  NOT NULL,
    [TipOcjene] nvarchar(max)  NULL,
    [Napomena] nvarchar(max)  NULL
);
GO

-- Creating table 'UceniciRazredi'
CREATE TABLE [dbo].[UceniciRazredi] (
    [UcenikRazrediId] int IDENTITY(1,1) NOT NULL,
    [RedniBroj] int  NOT NULL,
    [SkolskaGodina] nvarchar(max)  NULL,
    [UcenikId] int  NOT NULL,
    [RazredId] int  NOT NULL
);
GO

-- Creating table 'Uloge'
CREATE TABLE [dbo].[Uloge] (
    [UlogaId] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NULL,
    [SuperAdministrator] bit  NOT NULL,
    [Administrator] bit  NOT NULL,
    [Nastavnik] bit  NOT NULL,
    [Ucenik] bit  NOT NULL,
    [Roditelj] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AutorizacijskiToken'
ALTER TABLE [dbo].[AutorizacijskiToken]
ADD CONSTRAINT [PK_AutorizacijskiToken]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CasId] in table 'Casovi'
ALTER TABLE [dbo].[Casovi]
ADD CONSTRAINT [PK_Casovi]
    PRIMARY KEY CLUSTERED ([CasId] ASC);
GO

-- Creating primary key on [IzostanakId] in table 'Izostanci'
ALTER TABLE [dbo].[Izostanci]
ADD CONSTRAINT [PK_Izostanci]
    PRIMARY KEY CLUSTERED ([IzostanakId] ASC);
GO

-- Creating primary key on [Id] in table 'Korisnici'
ALTER TABLE [dbo].[Korisnici]
ADD CONSTRAINT [PK_Korisnici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [KorisniciUlogeId] in table 'KorisniciUloge'
ALTER TABLE [dbo].[KorisniciUloge]
ADD CONSTRAINT [PK_KorisniciUloge]
    PRIMARY KEY CLUSTERED ([KorisniciUlogeId] ASC);
GO

-- Creating primary key on [KorisnikKontaktId] in table 'KorisnikKontakt'
ALTER TABLE [dbo].[KorisnikKontakt]
ADD CONSTRAINT [PK_KorisnikKontakt]
    PRIMARY KEY CLUSTERED ([KorisnikKontaktId] ASC);
GO

-- Creating primary key on [MaterijalId] in table 'Materijali'
ALTER TABLE [dbo].[Materijali]
ADD CONSTRAINT [PK_Materijali]
    PRIMARY KEY CLUSTERED ([MaterijalId] ASC);
GO

-- Creating primary key on [Id] in table 'Korisnici_Nastavnici'
ALTER TABLE [dbo].[Korisnici_Nastavnici]
ADD CONSTRAINT [PK_Korisnici_Nastavnici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ObavijestId] in table 'Obavijesti'
ALTER TABLE [dbo].[Obavijesti]
ADD CONSTRAINT [PK_Obavijesti]
    PRIMARY KEY CLUSTERED ([ObavijestId] ASC);
GO

-- Creating primary key on [PredajeId] in table 'Predaje'
ALTER TABLE [dbo].[Predaje]
ADD CONSTRAINT [PK_Predaje]
    PRIMARY KEY CLUSTERED ([PredajeId] ASC);
GO

-- Creating primary key on [PredmetId] in table 'Predmeti'
ALTER TABLE [dbo].[Predmeti]
ADD CONSTRAINT [PK_Predmeti]
    PRIMARY KEY CLUSTERED ([PredmetId] ASC);
GO

-- Creating primary key on [RazredId] in table 'Razredi'
ALTER TABLE [dbo].[Razredi]
ADD CONSTRAINT [PK_Razredi]
    PRIMARY KEY CLUSTERED ([RazredId] ASC);
GO

-- Creating primary key on [SkolskaGodinaId] in table 'SkolskeGodine'
ALTER TABLE [dbo].[SkolskeGodine]
ADD CONSTRAINT [PK_SkolskeGodine]
    PRIMARY KEY CLUSTERED ([SkolskaGodinaId] ASC);
GO

-- Creating primary key on [SmjerId] in table 'Smjerovi'
ALTER TABLE [dbo].[Smjerovi]
ADD CONSTRAINT [PK_Smjerovi]
    PRIMARY KEY CLUSTERED ([SmjerId] ASC);
GO

-- Creating primary key on [SmjerPredmetId] in table 'SmjerPredmet'
ALTER TABLE [dbo].[SmjerPredmet]
ADD CONSTRAINT [PK_SmjerPredmet]
    PRIMARY KEY CLUSTERED ([SmjerPredmetId] ASC);
GO

-- Creating primary key on [Id] in table 'Korisnici_Ucenici'
ALTER TABLE [dbo].[Korisnici_Ucenici]
ADD CONSTRAINT [PK_Korisnici_Ucenici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UcenikCasoviId] in table 'UceniciCasovi'
ALTER TABLE [dbo].[UceniciCasovi]
ADD CONSTRAINT [PK_UceniciCasovi]
    PRIMARY KEY CLUSTERED ([UcenikCasoviId] ASC);
GO

-- Creating primary key on [Id] in table 'UceniciOcjene'
ALTER TABLE [dbo].[UceniciOcjene]
ADD CONSTRAINT [PK_UceniciOcjene]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UcenikRazrediId] in table 'UceniciRazredi'
ALTER TABLE [dbo].[UceniciRazredi]
ADD CONSTRAINT [PK_UceniciRazredi]
    PRIMARY KEY CLUSTERED ([UcenikRazrediId] ASC);
GO

-- Creating primary key on [UlogaId] in table 'Uloge'
ALTER TABLE [dbo].[Uloge]
ADD CONSTRAINT [PK_Uloge]
    PRIMARY KEY CLUSTERED ([UlogaId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KorisnikId] in table 'AutorizacijskiToken'
ALTER TABLE [dbo].[AutorizacijskiToken]
ADD CONSTRAINT [FK_dbo_AutorizacijskiToken_dbo_Korisnici_KorisnikId]
    FOREIGN KEY ([KorisnikId])
    REFERENCES [dbo].[Korisnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AutorizacijskiToken_dbo_Korisnici_KorisnikId'
CREATE INDEX [IX_FK_dbo_AutorizacijskiToken_dbo_Korisnici_KorisnikId]
ON [dbo].[AutorizacijskiToken]
    ([KorisnikId]);
GO

-- Creating foreign key on [NastavnikId] in table 'Casovi'
ALTER TABLE [dbo].[Casovi]
ADD CONSTRAINT [FK_dbo_Casovi_dbo_Nastavnici_NastavnikId]
    FOREIGN KEY ([NastavnikId])
    REFERENCES [dbo].[Korisnici_Nastavnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Casovi_dbo_Nastavnici_NastavnikId'
CREATE INDEX [IX_FK_dbo_Casovi_dbo_Nastavnici_NastavnikId]
ON [dbo].[Casovi]
    ([NastavnikId]);
GO

-- Creating foreign key on [CasId] in table 'Izostanci'
ALTER TABLE [dbo].[Izostanci]
ADD CONSTRAINT [FK_dbo_Izostanci_dbo_Casovi_CasId]
    FOREIGN KEY ([CasId])
    REFERENCES [dbo].[Casovi]
        ([CasId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Izostanci_dbo_Casovi_CasId'
CREATE INDEX [IX_FK_dbo_Izostanci_dbo_Casovi_CasId]
ON [dbo].[Izostanci]
    ([CasId]);
GO

-- Creating foreign key on [CasId] in table 'UceniciCasovi'
ALTER TABLE [dbo].[UceniciCasovi]
ADD CONSTRAINT [FK_dbo_UceniciCasovi_dbo_Casovi_CasId]
    FOREIGN KEY ([CasId])
    REFERENCES [dbo].[Casovi]
        ([CasId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UceniciCasovi_dbo_Casovi_CasId'
CREATE INDEX [IX_FK_dbo_UceniciCasovi_dbo_Casovi_CasId]
ON [dbo].[UceniciCasovi]
    ([CasId]);
GO

-- Creating foreign key on [UcenikId] in table 'Izostanci'
ALTER TABLE [dbo].[Izostanci]
ADD CONSTRAINT [FK_dbo_Izostanci_dbo_Ucenici_UcenikId]
    FOREIGN KEY ([UcenikId])
    REFERENCES [dbo].[Korisnici_Ucenici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Izostanci_dbo_Ucenici_UcenikId'
CREATE INDEX [IX_FK_dbo_Izostanci_dbo_Ucenici_UcenikId]
ON [dbo].[Izostanci]
    ([UcenikId]);
GO

-- Creating foreign key on [KorisnikID] in table 'KorisniciUloge'
ALTER TABLE [dbo].[KorisniciUloge]
ADD CONSTRAINT [FK_dbo_KorisniciUloge_dbo_Korisnici_KorisnikID]
    FOREIGN KEY ([KorisnikID])
    REFERENCES [dbo].[Korisnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_KorisniciUloge_dbo_Korisnici_KorisnikID'
CREATE INDEX [IX_FK_dbo_KorisniciUloge_dbo_Korisnici_KorisnikID]
ON [dbo].[KorisniciUloge]
    ([KorisnikID]);
GO

-- Creating foreign key on [KorisnikKontaktId] in table 'KorisnikKontakt'
ALTER TABLE [dbo].[KorisnikKontakt]
ADD CONSTRAINT [FK_dbo_KorisnikKontakt_dbo_Korisnici_KorisnikKontaktId]
    FOREIGN KEY ([KorisnikKontaktId])
    REFERENCES [dbo].[Korisnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [KorisnikId] in table 'Obavijesti'
ALTER TABLE [dbo].[Obavijesti]
ADD CONSTRAINT [FK_dbo_Obavijesti_dbo_Korisnici_KorisnikId]
    FOREIGN KEY ([KorisnikId])
    REFERENCES [dbo].[Korisnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Obavijesti_dbo_Korisnici_KorisnikId'
CREATE INDEX [IX_FK_dbo_Obavijesti_dbo_Korisnici_KorisnikId]
ON [dbo].[Obavijesti]
    ([KorisnikId]);
GO

-- Creating foreign key on [UlogaID] in table 'KorisniciUloge'
ALTER TABLE [dbo].[KorisniciUloge]
ADD CONSTRAINT [FK_dbo_KorisniciUloge_dbo_Uloge_UlogaID]
    FOREIGN KEY ([UlogaID])
    REFERENCES [dbo].[Uloge]
        ([UlogaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_KorisniciUloge_dbo_Uloge_UlogaID'
CREATE INDEX [IX_FK_dbo_KorisniciUloge_dbo_Uloge_UlogaID]
ON [dbo].[KorisniciUloge]
    ([UlogaID]);
GO

-- Creating foreign key on [NastavnikId] in table 'Materijali'
ALTER TABLE [dbo].[Materijali]
ADD CONSTRAINT [FK_dbo_Materijali_dbo_Nastavnici_NastavnikId]
    FOREIGN KEY ([NastavnikId])
    REFERENCES [dbo].[Korisnici_Nastavnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Materijali_dbo_Nastavnici_NastavnikId'
CREATE INDEX [IX_FK_dbo_Materijali_dbo_Nastavnici_NastavnikId]
ON [dbo].[Materijali]
    ([NastavnikId]);
GO

-- Creating foreign key on [PredmetId] in table 'Materijali'
ALTER TABLE [dbo].[Materijali]
ADD CONSTRAINT [FK_dbo_Materijali_dbo_Predmeti_PredmetId]
    FOREIGN KEY ([PredmetId])
    REFERENCES [dbo].[Predmeti]
        ([PredmetId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Materijali_dbo_Predmeti_PredmetId'
CREATE INDEX [IX_FK_dbo_Materijali_dbo_Predmeti_PredmetId]
ON [dbo].[Materijali]
    ([PredmetId]);
GO

-- Creating foreign key on [NastavnikId] in table 'Predaje'
ALTER TABLE [dbo].[Predaje]
ADD CONSTRAINT [FK_dbo_Predaje_dbo_Nastavnici_NastavnikId]
    FOREIGN KEY ([NastavnikId])
    REFERENCES [dbo].[Korisnici_Nastavnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Predaje_dbo_Nastavnici_NastavnikId'
CREATE INDEX [IX_FK_dbo_Predaje_dbo_Nastavnici_NastavnikId]
ON [dbo].[Predaje]
    ([NastavnikId]);
GO

-- Creating foreign key on [NastavnikId] in table 'Razredi'
ALTER TABLE [dbo].[Razredi]
ADD CONSTRAINT [FK_dbo_Razredi_dbo_Nastavnici_NastavnikId]
    FOREIGN KEY ([NastavnikId])
    REFERENCES [dbo].[Korisnici_Nastavnici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Razredi_dbo_Nastavnici_NastavnikId'
CREATE INDEX [IX_FK_dbo_Razredi_dbo_Nastavnici_NastavnikId]
ON [dbo].[Razredi]
    ([NastavnikId]);
GO

-- Creating foreign key on [SkolskaGodinaId] in table 'Predaje'
ALTER TABLE [dbo].[Predaje]
ADD CONSTRAINT [FK_dbo_Predaje_dbo_SkolskeGodine_SkolskaGodinaId]
    FOREIGN KEY ([SkolskaGodinaId])
    REFERENCES [dbo].[SkolskeGodine]
        ([SkolskaGodinaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Predaje_dbo_SkolskeGodine_SkolskaGodinaId'
CREATE INDEX [IX_FK_dbo_Predaje_dbo_SkolskeGodine_SkolskaGodinaId]
ON [dbo].[Predaje]
    ([SkolskaGodinaId]);
GO

-- Creating foreign key on [SmjerPredmetId] in table 'Predaje'
ALTER TABLE [dbo].[Predaje]
ADD CONSTRAINT [FK_dbo_Predaje_dbo_SmjerPredmet_SmjerPredmetId]
    FOREIGN KEY ([SmjerPredmetId])
    REFERENCES [dbo].[SmjerPredmet]
        ([SmjerPredmetId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Predaje_dbo_SmjerPredmet_SmjerPredmetId'
CREATE INDEX [IX_FK_dbo_Predaje_dbo_SmjerPredmet_SmjerPredmetId]
ON [dbo].[Predaje]
    ([SmjerPredmetId]);
GO

-- Creating foreign key on [PredajeId] in table 'UceniciOcjene'
ALTER TABLE [dbo].[UceniciOcjene]
ADD CONSTRAINT [FK_dbo_UceniciOcjene_dbo_Predaje_PredajeId]
    FOREIGN KEY ([PredajeId])
    REFERENCES [dbo].[Predaje]
        ([PredajeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UceniciOcjene_dbo_Predaje_PredajeId'
CREATE INDEX [IX_FK_dbo_UceniciOcjene_dbo_Predaje_PredajeId]
ON [dbo].[UceniciOcjene]
    ([PredajeId]);
GO

-- Creating foreign key on [PredmetId] in table 'SmjerPredmet'
ALTER TABLE [dbo].[SmjerPredmet]
ADD CONSTRAINT [FK_dbo_SmjerPredmet_dbo_Predmeti_PredmetId]
    FOREIGN KEY ([PredmetId])
    REFERENCES [dbo].[Predmeti]
        ([PredmetId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_SmjerPredmet_dbo_Predmeti_PredmetId'
CREATE INDEX [IX_FK_dbo_SmjerPredmet_dbo_Predmeti_PredmetId]
ON [dbo].[SmjerPredmet]
    ([PredmetId]);
GO

-- Creating foreign key on [SkolskaGodinaId] in table 'Razredi'
ALTER TABLE [dbo].[Razredi]
ADD CONSTRAINT [FK_dbo_Razredi_dbo_SkolskeGodine_SkolskaGodinaId]
    FOREIGN KEY ([SkolskaGodinaId])
    REFERENCES [dbo].[SkolskeGodine]
        ([SkolskaGodinaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Razredi_dbo_SkolskeGodine_SkolskaGodinaId'
CREATE INDEX [IX_FK_dbo_Razredi_dbo_SkolskeGodine_SkolskaGodinaId]
ON [dbo].[Razredi]
    ([SkolskaGodinaId]);
GO

-- Creating foreign key on [SmjerId] in table 'Razredi'
ALTER TABLE [dbo].[Razredi]
ADD CONSTRAINT [FK_dbo_Razredi_dbo_Smjerovi_SmjerId]
    FOREIGN KEY ([SmjerId])
    REFERENCES [dbo].[Smjerovi]
        ([SmjerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Razredi_dbo_Smjerovi_SmjerId'
CREATE INDEX [IX_FK_dbo_Razredi_dbo_Smjerovi_SmjerId]
ON [dbo].[Razredi]
    ([SmjerId]);
GO

-- Creating foreign key on [RazredId] in table 'UceniciRazredi'
ALTER TABLE [dbo].[UceniciRazredi]
ADD CONSTRAINT [FK_dbo_UceniciRazredi_dbo_Razredi_RazredId]
    FOREIGN KEY ([RazredId])
    REFERENCES [dbo].[Razredi]
        ([RazredId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UceniciRazredi_dbo_Razredi_RazredId'
CREATE INDEX [IX_FK_dbo_UceniciRazredi_dbo_Razredi_RazredId]
ON [dbo].[UceniciRazredi]
    ([RazredId]);
GO

-- Creating foreign key on [SkolskaGodinaId] in table 'Smjerovi'
ALTER TABLE [dbo].[Smjerovi]
ADD CONSTRAINT [FK_dbo_Smjerovi_dbo_SkolskeGodine_SkolskaGodinaId]
    FOREIGN KEY ([SkolskaGodinaId])
    REFERENCES [dbo].[SkolskeGodine]
        ([SkolskaGodinaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Smjerovi_dbo_SkolskeGodine_SkolskaGodinaId'
CREATE INDEX [IX_FK_dbo_Smjerovi_dbo_SkolskeGodine_SkolskaGodinaId]
ON [dbo].[Smjerovi]
    ([SkolskaGodinaId]);
GO

-- Creating foreign key on [SmjerId] in table 'SmjerPredmet'
ALTER TABLE [dbo].[SmjerPredmet]
ADD CONSTRAINT [FK_dbo_SmjerPredmet_dbo_Smjerovi_SmjerId]
    FOREIGN KEY ([SmjerId])
    REFERENCES [dbo].[Smjerovi]
        ([SmjerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_SmjerPredmet_dbo_Smjerovi_SmjerId'
CREATE INDEX [IX_FK_dbo_SmjerPredmet_dbo_Smjerovi_SmjerId]
ON [dbo].[SmjerPredmet]
    ([SmjerId]);
GO

-- Creating foreign key on [SmjerId] in table 'Korisnici_Ucenici'
ALTER TABLE [dbo].[Korisnici_Ucenici]
ADD CONSTRAINT [FK_dbo_Ucenici_dbo_Smjerovi_SmjerId]
    FOREIGN KEY ([SmjerId])
    REFERENCES [dbo].[Smjerovi]
        ([SmjerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Ucenici_dbo_Smjerovi_SmjerId'
CREATE INDEX [IX_FK_dbo_Ucenici_dbo_Smjerovi_SmjerId]
ON [dbo].[Korisnici_Ucenici]
    ([SmjerId]);
GO

-- Creating foreign key on [UcenikId] in table 'UceniciCasovi'
ALTER TABLE [dbo].[UceniciCasovi]
ADD CONSTRAINT [FK_dbo_UceniciCasovi_dbo_Ucenici_UcenikId]
    FOREIGN KEY ([UcenikId])
    REFERENCES [dbo].[Korisnici_Ucenici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UceniciCasovi_dbo_Ucenici_UcenikId'
CREATE INDEX [IX_FK_dbo_UceniciCasovi_dbo_Ucenici_UcenikId]
ON [dbo].[UceniciCasovi]
    ([UcenikId]);
GO

-- Creating foreign key on [UcenikId] in table 'UceniciOcjene'
ALTER TABLE [dbo].[UceniciOcjene]
ADD CONSTRAINT [FK_dbo_UceniciOcjene_dbo_Ucenici_UcenikId]
    FOREIGN KEY ([UcenikId])
    REFERENCES [dbo].[Korisnici_Ucenici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UceniciOcjene_dbo_Ucenici_UcenikId'
CREATE INDEX [IX_FK_dbo_UceniciOcjene_dbo_Ucenici_UcenikId]
ON [dbo].[UceniciOcjene]
    ([UcenikId]);
GO

-- Creating foreign key on [UcenikId] in table 'UceniciRazredi'
ALTER TABLE [dbo].[UceniciRazredi]
ADD CONSTRAINT [FK_dbo_UceniciRazredi_dbo_Ucenici_UcenikId]
    FOREIGN KEY ([UcenikId])
    REFERENCES [dbo].[Korisnici_Ucenici]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UceniciRazredi_dbo_Ucenici_UcenikId'
CREATE INDEX [IX_FK_dbo_UceniciRazredi_dbo_Ucenici_UcenikId]
ON [dbo].[UceniciRazredi]
    ([UcenikId]);
GO

-- Creating foreign key on [Id] in table 'Korisnici_Nastavnici'
ALTER TABLE [dbo].[Korisnici_Nastavnici]
ADD CONSTRAINT [FK_Nastavnici_inherits_Korisnici]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Korisnici]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Korisnici_Ucenici'
ALTER TABLE [dbo].[Korisnici_Ucenici]
ADD CONSTRAINT [FK_Ucenici_inherits_Korisnici]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Korisnici]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------