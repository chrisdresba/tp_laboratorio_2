USE [master];
CREATE DATABASE FabricaGuitarras;
GO
USE FabricaGuitarras
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[instrumentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[clavijas] [varchar](50) NULL,
	[color] [varchar](50) NULL,
	[cuerdas] [varchar](50) NULL,
	[microfono] [varchar](50) NULL,
 CONSTRAINT [PK_instrumentos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO
INSERT INTO instrumentos(categoria,modelo,clavijas,color,cuerdas,microfono) values
('Acustica','Washburn M18','TresMasTres','Negro','DaddarioAcustica','Si'),
('Clasica','Alpujarra80','ClasicaNacional','Negro','ErnieBallClasica','Si'),
('Electrica','Prs 335','TresMasTres','Verde','ErnieBallElectrica','DosHumbucker')

GO

CREATE TABLE [dbo].[stockElementos](
	[clave] [varchar](50) NULL,
	[ecualizador] [int] NULL,
	[clavijerosClasicaNacional] [int] NULL,
	[clavijerosClasicaImportado] [int] NULL,
	[clavijerosTresMasTresVintage] [int] NULL,
	[clavijerosTresMasTres] [int] NULL,
	[clavijerosSeisEnLinea] [int] NULL,
	[colorNaturalML] [int] NULL,
	[colorNegroML] [int] NULL,
	[colorVerdeML] [int] NULL,
	[colorAzulML] [int] NULL,
	[colorRojoML] [int] NULL,
	[encordadosDaddarioClasica] [int] NULL,
	[encordadosDaddarioAcustica] [int] NULL,
	[encordadosDaddarioElectrica] [int] NULL,
	[encordadosErnieBallClasica] [int] NULL,
	[encordadosErnieBallAcustica] [int] NULL,
	[encordadosErnieBallElectrica] [int] NULL,
	[microfonosSimple] [int] NULL,
	[microfonosHumbucker] [int] NULL
) ON [PRIMARY]

GO

INSERT INTO stockElementos(clave,ecualizador,clavijerosClasicaNacional,clavijerosClasicaImportado,clavijerosTresMasTresVintage,
clavijerosTresMasTres,clavijerosSeisEnLinea,colorNaturalML,colorNegroML,colorVerdeML,colorAzulML,
colorRojoML,encordadosDaddarioClasica,encordadosDaddarioAcustica,encordadosDaddarioElectrica,
encordadosErnieBallClasica,encordadosErnieBallAcustica,encordadosErnieBallElectrica,microfonosSimple,
microfonosHumbucker) values ('Guitarras',50,100,100,100,100,100,1000,1000,1000,1000,1000,100,100,100,100,100,100,100,100)

