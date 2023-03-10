USE [master]
GO
/****** Object:  Database [Agency]    Script Date: 14.01.2023 8:11:46 ******/
CREATE DATABASE [Agency]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Agency', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Agency.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Agency_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Agency_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Agency] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Agency].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Agency] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Agency] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Agency] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Agency] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Agency] SET ARITHABORT OFF 
GO
ALTER DATABASE [Agency] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Agency] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Agency] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Agency] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Agency] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Agency] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Agency] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Agency] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Agency] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Agency] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Agency] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Agency] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Agency] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Agency] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Agency] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Agency] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Agency] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Agency] SET RECOVERY FULL 
GO
ALTER DATABASE [Agency] SET  MULTI_USER 
GO
ALTER DATABASE [Agency] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Agency] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Agency] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Agency] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Agency] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Agency] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Agency', N'ON'
GO
ALTER DATABASE [Agency] SET QUERY_STORE = OFF
GO
USE [Agency]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[id_pk_adress] [int] IDENTITY(1,1) NOT NULL,
	[a_region] [nvarchar](50) NOT NULL,
	[a_city] [nvarchar](50) NOT NULL,
	[a_street] [nvarchar](50) NOT NULL,
	[a_building] [nvarchar](50) NOT NULL,
	[a_apartment] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_adress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id_pk_client] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[id_adress] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[id_pk_contract] [int] IDENTITY(1,1) NOT NULL,
	[c_conditions] [nvarchar](1000) NULL,
	[c_createdAt] [nvarchar](30) NULL,
	[c_fk_client] [int] NULL,
	[c_fk_employee] [int] NULL,
	[c_fk_status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_contract] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractStatus]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractStatus](
	[id_pk_status] [int] IDENTITY(1,1) NOT NULL,
	[cs_status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[id_pk_document] [int] IDENTITY(1,1) NOT NULL,
	[id_passport] [int] NOT NULL,
	[d_education] [nvarchar](1000) NULL,
	[d_TIN] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_document] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id_pk_employee] [int] IDENTITY(1,1) NOT NULL,
	[id_fk_user] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[id_pk_organization] [int] IDENTITY(1,1) NOT NULL,
	[o_name] [nvarchar](50) NOT NULL,
	[o_email] [nvarchar](100) NOT NULL,
	[o_phoneNumber] [nvarchar](50) NOT NULL,
	[id_fk_adress] [int] NOT NULL,
	[id_fk_client] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_organization] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrgVac]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrgVac](
	[id_pk_orgvac] [int] IDENTITY(1,1) NOT NULL,
	[id_fk_vac] [int] NOT NULL,
	[id_fk_org] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_orgvac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passport]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passport](
	[id_pk_passport] [int] IDENTITY(1,1) NOT NULL,
	[p_number] [int] NOT NULL,
	[p_series] [int] NOT NULL,
	[p_name] [nvarchar](50) NULL,
	[p_surname] [nvarchar](50) NULL,
	[p_patronymic] [nvarchar](50) NULL,
	[p_sex] [nvarchar](50) NOT NULL,
	[p_birth] [nvarchar](30) NULL,
	[id_adress] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_passport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Register](
	[id_pk_register] [int] IDENTITY(1,1) NOT NULL,
	[id_fk_user] [int] NOT NULL,
	[r_email] [nvarchar](100) NOT NULL,
	[r_login] [nvarchar](50) NOT NULL,
	[r_password] [nvarchar](50) NOT NULL,
	[r_isAdmin] [bit] NULL,
	[r_isUser] [bit] NULL,
	[r_isEmployee] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_register] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponseStatus]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponseStatus](
	[id_pk_status] [int] IDENTITY(1,1) NOT NULL,
	[rs_status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDoc]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDoc](
	[id_pk_userdoc] [int] IDENTITY(1,1) NOT NULL,
	[id_fk_user] [int] NOT NULL,
	[id_fk_doc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_userdoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserResponse]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserResponse](
	[id_pk_response] [int] IDENTITY(1,1) NOT NULL,
	[id_fk_vacancy] [int] NOT NULL,
	[id_fk_user] [int] NOT NULL,
	[id_fk_status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_response] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_pk_user] [int] IDENTITY(1,1) NOT NULL,
	[u_name] [nvarchar](50) NOT NULL,
	[u_surname] [nvarchar](50) NOT NULL,
	[u_patronymic] [nvarchar](50) NOT NULL,
	[u_phoneNumber] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacancy]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacancy](
	[id_pk_vacancy] [int] IDENTITY(1,1) NOT NULL,
	[id_organization] [int] NOT NULL,
	[v_profession] [nvarchar](100) NOT NULL,
	[v_description] [nvarchar](1000) NOT NULL,
	[v_contactNumber] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pk_vacancy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD FOREIGN KEY([id_adress])
REFERENCES [dbo].[Adress] ([id_pk_adress])
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [dbo].[Users] ([id_pk_user])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([c_fk_client])
REFERENCES [dbo].[Client] ([id_pk_client])
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([c_fk_employee])
REFERENCES [dbo].[Employee] ([id_pk_employee])
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([c_fk_status])
REFERENCES [dbo].[ContractStatus] ([id_pk_status])
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD FOREIGN KEY([id_passport])
REFERENCES [dbo].[Passport] ([id_pk_passport])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([id_fk_user])
REFERENCES [dbo].[Users] ([id_pk_user])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization]  WITH CHECK ADD FOREIGN KEY([id_fk_adress])
REFERENCES [dbo].[Adress] ([id_pk_adress])
GO
ALTER TABLE [dbo].[Organization]  WITH CHECK ADD FOREIGN KEY([id_fk_client])
REFERENCES [dbo].[Client] ([id_pk_client])
GO
ALTER TABLE [dbo].[OrgVac]  WITH CHECK ADD FOREIGN KEY([id_fk_org])
REFERENCES [dbo].[Organization] ([id_pk_organization])
GO
ALTER TABLE [dbo].[OrgVac]  WITH CHECK ADD FOREIGN KEY([id_fk_vac])
REFERENCES [dbo].[Vacancy] ([id_pk_vacancy])
GO
ALTER TABLE [dbo].[Passport]  WITH CHECK ADD FOREIGN KEY([id_adress])
REFERENCES [dbo].[Adress] ([id_pk_adress])
GO
ALTER TABLE [dbo].[Register]  WITH CHECK ADD FOREIGN KEY([id_fk_user])
REFERENCES [dbo].[Users] ([id_pk_user])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserDoc]  WITH CHECK ADD FOREIGN KEY([id_fk_doc])
REFERENCES [dbo].[Documents] ([id_pk_document])
GO
ALTER TABLE [dbo].[UserDoc]  WITH CHECK ADD FOREIGN KEY([id_fk_user])
REFERENCES [dbo].[Users] ([id_pk_user])
GO
ALTER TABLE [dbo].[UserResponse]  WITH CHECK ADD FOREIGN KEY([id_fk_vacancy])
REFERENCES [dbo].[Vacancy] ([id_pk_vacancy])
GO
ALTER TABLE [dbo].[UserResponse]  WITH CHECK ADD FOREIGN KEY([id_fk_user])
REFERENCES [dbo].[Users] ([id_pk_user])
GO
ALTER TABLE [dbo].[UserResponse]  WITH CHECK ADD FOREIGN KEY([id_fk_status])
REFERENCES [dbo].[ResponseStatus] ([id_pk_status])
GO
ALTER TABLE [dbo].[Vacancy]  WITH CHECK ADD FOREIGN KEY([id_organization])
REFERENCES [dbo].[Organization] ([id_pk_organization])
GO
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddClient]
    @clientName nvarchar(50),
    @clientSurname nvarchar(50),
    @clientPat nvarchar(50),
    @clientNum nvarchar(50),
    @adressRegion nvarchar(50),
    @adressCity nvarchar(50),
    @adressStreet nvarchar(50),
    @adressBuilding nvarchar(50),
    @adressApartment nvarchar(50)
AS DECLARE @a_id int, @u_id int
    BEGIN
        insert into Adress
            (a_region, a_city, a_street, a_building, a_apartment)
        values
            (@adressRegion, @adressCity, @adressStreet, @adressBuilding, @adressApartment);

        select @a_id = id_pk_adress from Adress
        where
            a_apartment = @adressApartment and a_building = @adressBuilding and a_city = @adressCity;

        insert into Users
            (u_name, u_surname, u_patronymic, u_phoneNumber)
        values
            (@clientName, @clientSurname, @clientPat, @clientNum);

        select @u_id = id_pk_user from Users where u_phoneNumber = @clientNum and u_name = @clientName;

        insert into Client (id_user, id_adress) values (@u_id, @a_id);
    END;
GO
/****** Object:  StoredProcedure [dbo].[ADDContract]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ADDContract]
    @contractConditions nvarchar(1000),
    @contractDate nvarchar(50),
    @contractAgentName nvarchar(50),
    @contractAgentSurname nvarchar(50),
    @contractClientName nvarchar(50),
    @contractClientSurname nvarchar(50),
    @contractStatus nvarchar(50)
AS DECLARE @c_id int, @e_id int, @s_id int
    begin
        -- Поиск клиента
        select @c_id = id_pk_client from Client
            inner join Users U on U.id_pk_user = Client.id_user
        where u_name = @contractClientName and u_surname = @contractClientSurname;

        -- Поиск работника
        select @e_id = id_pk_employee from Employee
            inner join Users U on U.id_pk_user = Employee.id_fk_user
        where u_name = @contractAgentName and u_surname = @contractAgentSurname;

        -- Поиск статуса
        select @s_id = id_pk_status from ContractStatus where cs_status = @contractStatus;

        -- Добавление нового контракта
        insert into Contracts
            (c_conditions, c_createdAt, c_fk_client, c_fk_employee, c_fk_status)
        values
            (@contractConditions, @contractDate, @c_id, @e_id, @s_id)
    end;
GO
/****** Object:  StoredProcedure [dbo].[ADDDocument]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADDDocument]
    @passportID int,
    @clientID int,
    @adressID int,
    @documentsID int,

    @passSeries int,
    @passNum int,
    @passBirth nvarchar(50),
    @passSex nvarchar(50),

    @adressRegion nvarchar(50),
    @adressCity nvarchar(50),
    @adressStreet nvarchar(50),
    @adressBuilding nvarchar(50),
    @adressApartment nvarchar(50),

    @docsTIN nvarchar(50),
    @docsEducation nvarchar(50),

    @clientName nvarchar(50),
    @clientSur nvarchar(50),
    @clientPat nvarchar(50)
AS DECLARE @p_id int, @u_id int, @a_id int, @d_id int
BEGIN
    select @p_id = id_pk_passport from Passport where id_pk_passport = @passportID;
    select @u_id = id_user from Client where id_pk_client = @clientID;
    select @a_id = id_pk_adress from Adress where id_pk_adress = @adressID;
    select @d_id = id_pk_document from Documents where id_pk_document = @documentsID;

    insert into Passport
        (p_number, p_series, p_name, p_surname, p_patronymic, p_sex, p_birth, id_adress)
    values
        (@passNum, @passSeries, @clientName, @clientSur, @clientPat, @passSex, @passBirth, @a_id);

    insert into Adress
        (a_region, a_city, a_street, a_building, a_apartment)
    values (@adressRegion, @adressCity, @adressStreet, @adressBuilding, @adressApartment);

    insert into Documents
        (id_passport, d_education, d_TIN)
    values
        (@p_id, @docsEducation, @docsTIN);

    insert into UserDoc (id_fk_user, id_fk_doc) values (@u_id, @d_id)
END;
GO
/****** Object:  StoredProcedure [dbo].[AddOrganization]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddOrganization]
    @orgName nvarchar(50),
    @orgClient nvarchar(50),
    @orgNum nvarchar(50),
    @orgMail nvarchar(50),
    @adressRegion nvarchar(50),
    @adressCity nvarchar(50),
    @adressStreet nvarchar(50),
    @adressBuilding nvarchar(50),
    @adressApartment nvarchar(50)
AS DECLARE @a_id int, @o_id int, @u_id int
    BEGIN
        -- Создаём и ищем адрес
        insert into Adress
            (a_region, a_city, a_street, a_building, a_apartment)
        values
            (@adressRegion, @adressCity, @adressStreet, @adressBuilding, @adressApartment);

        select @a_id = id_pk_adress from Adress
        where
            a_apartment = @adressApartment and a_building = @adressBuilding and a_city = @adressCity;

        -- Ищем пользователя через регистрацию
        select @u_id = id_fk_user from Register where r_login = @orgClient;

        -- Добавляем организацию
        insert into Organization
            (o_name, o_email, o_phoneNumber, id_fk_adress, id_fk_client)
        values
            (@orgName, @orgMail, @orgNum, @a_id, @u_id);
    END;
GO
/****** Object:  StoredProcedure [dbo].[AddUserEmployee]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddUserEmployee] @id_fk_user int as
    BEGIN
        insert into Employee (id_fk_user) values (@id_fk_user);
        UPDATE Register SET r_isEmployee = 'True' where @id_fk_user = Register.id_fk_user;
    END;
GO
/****** Object:  StoredProcedure [dbo].[AddVacancy]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddVacancy]
    @vacOrg nvarchar(50),
    @vacProf nvarchar(50),
    @vacDesc nvarchar(50),
    @vacNumber nvarchar(50)
AS DECLARE @o_id int, @v_id int
    BEGIN
        select @o_id = id_pk_organization from Organization where o_name = @vacOrg;

        insert into Vacancy
            (id_organization, v_profession, v_description, v_contactNumber)
        values
            (@o_id, @vacProf, @vacDesc, @vacNumber);

        select @v_id = id_pk_vacancy from Vacancy where v_profession = @vacProf and v_description = @vacDesc;

        Insert Into OrgVac
            (id_fk_vac, id_fk_org)
        values
            (@v_id, @o_id);
    END;
GO
/****** Object:  StoredProcedure [dbo].[CreateFKRegister]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateFKRegister]
    @u_name nvarchar(50),
    @r_email nvarchar(50),
    @r_login nvarchar(50),
    @r_password nvarchar(50),
    @r_isAdmin bit,
    @r_isUser bit,
    @r_isEmployee bit
AS declare @id_fk_user int
BEGIN
    select @id_fk_user = id_pk_user from Users where Users.u_name = @u_name;
    insert into Register (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee)
    values (@id_fk_user, @r_email, @r_login, @r_password, @r_isAdmin, @r_isUser, @r_isEmployee);
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserFromRegister]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteUserFromRegister]
    @id_pk_register int
AS declare @id_fk_user int
BEGIN
    select @id_fk_user = Register.id_fk_user from Register;
    delete from Users where @id_fk_user = id_pk_user;
    delete from Register where id_pk_register = @id_pk_register;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteVacancy]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteVacancy]
    @vacId int
AS
    BEGIN
        delete from OrgVac where id_fk_vac = @vacId
        delete from UserResponse where id_fk_vacancy = @vacId
        delete from Vacancy where id_pk_vacancy = @vacId
    END;
GO
/****** Object:  StoredProcedure [dbo].[ResponseDelete]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ResponseDelete]
    @responseId int
AS
    BEGIN
        DELETE FROM UserResponse WHERE id_pk_response = @responseId;
    END;
GO
/****** Object:  StoredProcedure [dbo].[ResponseUpdate]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ResponseUpdate]
    @responseId int,
    @responseStatus nvarchar(50)
AS DECLARE @s_id int
    BEGIN
        select @s_id = id_pk_status from ResponseStatus where rs_status = @responseStatus;
        UPDATE UserResponse
        SET id_fk_status = @s_id
        where id_pk_response = @responseId;
    END;
GO
/****** Object:  StoredProcedure [dbo].[ResponseUserInsert]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ResponseUserInsert]
    @r_login nvarchar(50),
    @id_vacancy int
AS DECLARE @id_user int
    BEGIN
        select @id_user = id_fk_user from Register where r_login = @r_login;
        insert into UserResponse (id_fk_vacancy, id_fk_user, id_fk_status) values (@id_vacancy, @id_user, 1);
    END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateContract]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateContract]
    @contractId int,
    @contractConditions nvarchar(50),
    @contractDate nvarchar(50),
    @contractAgentName nvarchar(50),
    @contractAgentSurname nvarchar(50),
    @contractClientName nvarchar(50),
    @contractClientSurname nvarchar(50),
    @contractStatus nvarchar(50)
AS DECLARE @c_id int, @e_id int, @s_id int
    BEGIN
        -- Поиск клиента
        select @c_id = id_pk_client from Client
            inner join Users U on U.id_pk_user = Client.id_user
        where u_name = @contractClientName and u_surname = @contractClientSurname;

        -- Поиск работника
        select @e_id = id_pk_employee from Employee
            inner join Users U on U.id_pk_user = Employee.id_fk_user
        where u_name = @contractAgentName and u_surname = @contractAgentSurname;

        -- Поиск статуса
        select @s_id = id_pk_status from ContractStatus where cs_status = @contractStatus;

        -- Обновление данных
        UPDATE Contracts
        SET
            c_conditions = @contractConditions,
            c_createdAt = @contractDate,
            c_fk_client = @c_id,
            c_fk_employee = @e_id,
            c_fk_status = @s_id
        where id_pk_contract = @contractId;
    END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateDocument]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDocument]
    @passportID int,
    @clientID int,
    @adressID int,
    @documentsID int,

    @passSeries int,
    @passNum int,
    @passBirth nvarchar(50),
    @passSex nvarchar(50),

    @adressRegion nvarchar(50),
    @adressCity nvarchar(50),
    @adressStreet nvarchar(50),
    @adressBuilding nvarchar(50),
    @adressApartment nvarchar(50),

    @docsTIN nvarchar(50),
    @docsEducation nvarchar(50),

    @clientName nvarchar(50),
    @clientSur nvarchar(50),
    @clientPat nvarchar(50)
AS DECLARE @p_id int, @c_id int, @a_id int, @d_id int
BEGIN
    select @p_id = id_pk_passport from Passport where id_pk_passport = @passportID;
    select @a_id = id_pk_adress from Adress where id_pk_adress = @adressID;
    select @d_id = id_pk_document from Documents where id_pk_document = @documentsID;

    UPDATE Passport
    SET p_name = @clientName, p_surname = @clientSur,
        p_patronymic = @clientPat, p_number = @passNum, p_series = @passSeries,
        p_sex = @passSex, p_birth = @passBirth
    WHERE id_pk_passport = @passportID;

    UPDATE Documents
    SET d_TIN = @docsTIN, d_education = @docsEducation
    WHERE id_pk_document = @documentsID;

    UPDATE Adress
    SET a_region = @adressRegion, a_city = @adressCity, a_street = @adressStreet,
        a_building = @adressBuilding, a_apartment = @adressApartment
    WHERE id_pk_adress = @adressID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrganization]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateOrganization]
    @orgId int,
    @orgName nvarchar(50),
    @orgClient nvarchar(50),
    @orgNum nvarchar(50),
    @orgMail nvarchar(50)
as declare @u_id int, @c_id int
begin
    select @u_id = id_fk_user from Register where r_login = @orgClient;

    select @c_id = id_pk_client from Client where id_user = @u_id;

    UPDATE Organization
    SET o_phoneNumber = @orgNum, o_name = @orgName, o_email = @orgMail, id_fk_client = @c_id
    where id_pk_organization = @orgId;
end;
GO
/****** Object:  StoredProcedure [dbo].[UpdateVacancy]    Script Date: 14.01.2023 8:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateVacancy]
    @vacId int,
    @vacProf nvarchar(50),
    @vacOrg nvarchar(50),
    @vacDesc nvarchar(50),
    @vacNumber nvarchar(50)
AS DECLARE @o_id int
    BEGIN
        select @o_id = id_pk_organization from Organization where o_name = @vacOrg ;
        update Vacancy set id_organization = @o_id, v_profession = @vacProf, v_description = @vacDesc, v_contactNumber = @vacNumber where id_pk_vacancy = @vacId;
    END;
GO
USE [master]
GO
ALTER DATABASE [Agency] SET  READ_WRITE 
GO
