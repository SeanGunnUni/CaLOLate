USE [master]
GO

/****** Object:  Database [ItemsDB]    Script Date: 18/12/2019 15:13:39 ******/
CREATE DATABASE [ItemsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ItemsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ItemsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ItemsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ItemsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [ItemsDB] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ItemsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ItemsDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ItemsDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ItemsDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ItemsDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ItemsDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [ItemsDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ItemsDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ItemsDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ItemsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ItemsDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ItemsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ItemsDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ItemsDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ItemsDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ItemsDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ItemsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ItemsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ItemsDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ItemsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ItemsDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ItemsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ItemsDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ItemsDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ItemsDB] SET  MULTI_USER 
GO

ALTER DATABASE [ItemsDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ItemsDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ItemsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ItemsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ItemsDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ItemsDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ItemsDB] SET  READ_WRITE 
GO

