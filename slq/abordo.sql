USE [master]
GO

/****** Object:  Database [Abordo]    Script Date: 20/12/2021 23:50:38 ******/
CREATE DATABASE [Abordo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Abordo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Abordo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Abordo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Abordo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Abordo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Abordo] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Abordo] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Abordo] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Abordo] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Abordo] SET ARITHABORT OFF 
GO

ALTER DATABASE [Abordo] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Abordo] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Abordo] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Abordo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Abordo] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Abordo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Abordo] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Abordo] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Abordo] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Abordo] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Abordo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Abordo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Abordo] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Abordo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Abordo] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Abordo] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [Abordo] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Abordo] SET RECOVERY FULL 
GO

ALTER DATABASE [Abordo] SET  MULTI_USER 
GO

ALTER DATABASE [Abordo] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Abordo] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Abordo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Abordo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Abordo] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Abordo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Abordo] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Abordo] SET  READ_WRITE 
GO

