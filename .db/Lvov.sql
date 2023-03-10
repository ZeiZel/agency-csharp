USE [Львов]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractStatus]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrgVac]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passport]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponseStatus]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDoc]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserResponse]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacancy]    Script Date: 14.01.2023 8:21:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Adress] ON 

INSERT [dbo].[Adress] ([id_pk_adress], [a_region], [a_city], [a_street], [a_building], [a_apartment]) VALUES (1, N'Кировская область', N'Киров', N'Герцена', N'43', N'1')
INSERT [dbo].[Adress] ([id_pk_adress], [a_region], [a_city], [a_street], [a_building], [a_apartment]) VALUES (2, N'Мурманская область', N'Мурманск', N'Мурманская', N'11', N'1')
INSERT [dbo].[Adress] ([id_pk_adress], [a_region], [a_city], [a_street], [a_building], [a_apartment]) VALUES (3, N'Кировская область', N'Киров', N'Кирова', N'53', N'2')
INSERT [dbo].[Adress] ([id_pk_adress], [a_region], [a_city], [a_street], [a_building], [a_apartment]) VALUES (4, N'Кировская область', N'Кирово-чепецк', N'Чепецкая', N'34', N'1')
INSERT [dbo].[Adress] ([id_pk_adress], [a_region], [a_city], [a_street], [a_building], [a_apartment]) VALUES (5, N'Московская область', N'Москва', N'Московская', N'198', N'1')
INSERT [dbo].[Adress] ([id_pk_adress], [a_region], [a_city], [a_street], [a_building], [a_apartment]) VALUES (6, N'Кировская область', N'Лянгасово', N'Лянгасовская', N'12', N'1')
SET IDENTITY_INSERT [dbo].[Adress] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([id_pk_client], [id_user], [id_adress]) VALUES (1, 1, 1)
INSERT [dbo].[Client] ([id_pk_client], [id_user], [id_adress]) VALUES (2, 4, 2)
INSERT [dbo].[Client] ([id_pk_client], [id_user], [id_adress]) VALUES (3, 5, 3)
INSERT [dbo].[Client] ([id_pk_client], [id_user], [id_adress]) VALUES (4, 6, 4)
INSERT [dbo].[Client] ([id_pk_client], [id_user], [id_adress]) VALUES (5, 7, 5)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Contracts] ON 

INSERT [dbo].[Contracts] ([id_pk_contract], [c_conditions], [c_createdAt], [c_fk_client], [c_fk_employee], [c_fk_status]) VALUES (1, N'Обязуемся предоставить вам работу на данном предприятии. Честное слово.', N'14/01/2023', 4, 2, 1)
INSERT [dbo].[Contracts] ([id_pk_contract], [c_conditions], [c_createdAt], [c_fk_client], [c_fk_employee], [c_fk_status]) VALUES (2, N'Обязуемся предоставить вам работу на данном предприятии. Честное слово.', N'14/01/2023', 5, 2, 1)
SET IDENTITY_INSERT [dbo].[Contracts] OFF
GO
SET IDENTITY_INSERT [dbo].[ContractStatus] ON 

INSERT [dbo].[ContractStatus] ([id_pk_status], [cs_status]) VALUES (1, N'Заключён')
INSERT [dbo].[ContractStatus] ([id_pk_status], [cs_status]) VALUES (2, N'Выполнен')
INSERT [dbo].[ContractStatus] ([id_pk_status], [cs_status]) VALUES (3, N'Отменён')
SET IDENTITY_INSERT [dbo].[ContractStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[Documents] ON 

INSERT [dbo].[Documents] ([id_pk_document], [id_passport], [d_education], [d_TIN]) VALUES (1, 1, N'Кировский Леспопромышленный', N'1234 1234 1234 1234')
INSERT [dbo].[Documents] ([id_pk_document], [id_passport], [d_education], [d_TIN]) VALUES (2, 2, N'Кировский Авиационный', N'4321 4321 4321 4321')
INSERT [dbo].[Documents] ([id_pk_document], [id_passport], [d_education], [d_TIN]) VALUES (3, 3, N'Кировский Технический Колледж', N'7654 7654 7654 7654')
INSERT [dbo].[Documents] ([id_pk_document], [id_passport], [d_education], [d_TIN]) VALUES (5, 5, N'ВятГУ', N'3456 3465 3456 3456')
INSERT [dbo].[Documents] ([id_pk_document], [id_passport], [d_education], [d_TIN]) VALUES (6, 6, N'Вятский Следственный Колледж', N'9876 8976 9876 9876')
SET IDENTITY_INSERT [dbo].[Documents] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([id_pk_employee], [id_fk_user]) VALUES (1, 2)
INSERT [dbo].[Employee] ([id_pk_employee], [id_fk_user]) VALUES (2, 3)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Organization] ON 

INSERT [dbo].[Organization] ([id_pk_organization], [o_name], [o_email], [o_phoneNumber], [id_fk_adress], [id_fk_client]) VALUES (1, N'Арстоцка', N'arstozka@yandex.ru', N'9628951028', 1, 1)
INSERT [dbo].[Organization] ([id_pk_organization], [o_name], [o_email], [o_phoneNumber], [id_fk_adress], [id_fk_client]) VALUES (2, N'Пользователи', N'userland@yandex.ru', N'1239080982', 2, 2)
INSERT [dbo].[Organization] ([id_pk_organization], [o_name], [o_email], [o_phoneNumber], [id_fk_adress], [id_fk_client]) VALUES (4, N'Алекс и шоколадная фабрика', N'chocolate@yandex.ru', N'1236676213', 3, 3)
SET IDENTITY_INSERT [dbo].[Organization] OFF
GO
SET IDENTITY_INSERT [dbo].[OrgVac] ON 

INSERT [dbo].[OrgVac] ([id_pk_orgvac], [id_fk_vac], [id_fk_org]) VALUES (1, 1, 1)
INSERT [dbo].[OrgVac] ([id_pk_orgvac], [id_fk_vac], [id_fk_org]) VALUES (2, 6, 1)
INSERT [dbo].[OrgVac] ([id_pk_orgvac], [id_fk_vac], [id_fk_org]) VALUES (3, 8, 1)
INSERT [dbo].[OrgVac] ([id_pk_orgvac], [id_fk_vac], [id_fk_org]) VALUES (4, 9, 2)
INSERT [dbo].[OrgVac] ([id_pk_orgvac], [id_fk_vac], [id_fk_org]) VALUES (5, 10, 2)
INSERT [dbo].[OrgVac] ([id_pk_orgvac], [id_fk_vac], [id_fk_org]) VALUES (6, 11, 4)
SET IDENTITY_INSERT [dbo].[OrgVac] OFF
GO
SET IDENTITY_INSERT [dbo].[Passport] ON 

INSERT [dbo].[Passport] ([id_pk_passport], [p_number], [p_series], [p_name], [p_surname], [p_patronymic], [p_sex], [p_birth], [id_adress]) VALUES (1, 1223, 123123, N'Олег', N'Арстоцкин', N'Геннадьевич', N'Мужской', N'20/04/2003', 1)
INSERT [dbo].[Passport] ([id_pk_passport], [p_number], [p_series], [p_name], [p_surname], [p_patronymic], [p_sex], [p_birth], [id_adress]) VALUES (2, 3333, 321321, N'Пользователь', N'Пользователь', N'Пользователь', N'Мужской', N'10/03/1990', 2)
INSERT [dbo].[Passport] ([id_pk_passport], [p_number], [p_series], [p_name], [p_surname], [p_patronymic], [p_sex], [p_birth], [id_adress]) VALUES (3, 2222, 222222, N'Александр', N'Смойлов', N'Юрьевич', N'Мужской', N'11/11/2011', 3)
INSERT [dbo].[Passport] ([id_pk_passport], [p_number], [p_series], [p_name], [p_surname], [p_patronymic], [p_sex], [p_birth], [id_adress]) VALUES (5, 4444, 444444, N'Владимир', N'Стоканов', N'Алексеевич', N'Мужской', N'8/12/1983', 4)
INSERT [dbo].[Passport] ([id_pk_passport], [p_number], [p_series], [p_name], [p_surname], [p_patronymic], [p_sex], [p_birth], [id_adress]) VALUES (6, 3567, 354678, N'Айдул', N'Абдуглы', N'Самбуртович', N'Мужской', N'14/10/1997', 5)
SET IDENTITY_INSERT [dbo].[Passport] OFF
GO
SET IDENTITY_INSERT [dbo].[Register] ON 

INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (1, 1, N'arstozkin@yandex.ru', N'olgzha', N'0573A529266FCE9787482EB2BF484B6E', 0, 1, 0)
INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (2, 2, N'admin@admin', N'admin', N'21232F297A57A5A743894A0E4A801FC3', 1, 1, 1)
INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (3, 3, N'emp@emp', N'employee', N'FA5473530E4D1A5A1E1EB53D2FEDB10C', 0, 1, 1)
INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (4, 4, N'user@user', N'user', N'EE11CBB19052E40B07AAC0CA060C23EE', 0, 1, 0)
INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (5, 5, N'leksAleks@mail.ru', N'leks', N'4F12B4D966228FDADAD89B4D30828E5D', 0, 1, 0)
INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (6, 6, N'stokan@gmail.com', N'stokan', N'9F0FBD1C61FF5C07BB0A612E18C1DB20', 0, 1, 0)
INSERT [dbo].[Register] ([id_pk_register], [id_fk_user], [r_email], [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee]) VALUES (7, 7, N'aidane@yahuuu.com', N'aidane', N'9C1571ADF0EC4B59D77154F90A6F3F4C', 0, 1, 0)
SET IDENTITY_INSERT [dbo].[Register] OFF
GO
SET IDENTITY_INSERT [dbo].[ResponseStatus] ON 

INSERT [dbo].[ResponseStatus] ([id_pk_status], [rs_status]) VALUES (1, N'Отправлен')
INSERT [dbo].[ResponseStatus] ([id_pk_status], [rs_status]) VALUES (2, N'Обработан')
INSERT [dbo].[ResponseStatus] ([id_pk_status], [rs_status]) VALUES (3, N'Отменён')
SET IDENTITY_INSERT [dbo].[ResponseStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[UserDoc] ON 

INSERT [dbo].[UserDoc] ([id_pk_userdoc], [id_fk_user], [id_fk_doc]) VALUES (1, 1, 1)
INSERT [dbo].[UserDoc] ([id_pk_userdoc], [id_fk_user], [id_fk_doc]) VALUES (2, 4, 2)
INSERT [dbo].[UserDoc] ([id_pk_userdoc], [id_fk_user], [id_fk_doc]) VALUES (3, 5, 3)
INSERT [dbo].[UserDoc] ([id_pk_userdoc], [id_fk_user], [id_fk_doc]) VALUES (4, 6, 5)
INSERT [dbo].[UserDoc] ([id_pk_userdoc], [id_fk_user], [id_fk_doc]) VALUES (5, 7, 6)
SET IDENTITY_INSERT [dbo].[UserDoc] OFF
GO
SET IDENTITY_INSERT [dbo].[UserResponse] ON 

INSERT [dbo].[UserResponse] ([id_pk_response], [id_fk_vacancy], [id_fk_user], [id_fk_status]) VALUES (1, 1, 6, 1)
INSERT [dbo].[UserResponse] ([id_pk_response], [id_fk_vacancy], [id_fk_user], [id_fk_status]) VALUES (2, 6, 7, 1)
INSERT [dbo].[UserResponse] ([id_pk_response], [id_fk_vacancy], [id_fk_user], [id_fk_status]) VALUES (3, 8, 6, 2)
INSERT [dbo].[UserResponse] ([id_pk_response], [id_fk_vacancy], [id_fk_user], [id_fk_status]) VALUES (4, 9, 7, 2)
SET IDENTITY_INSERT [dbo].[UserResponse] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (1, N'Олег', N'Арстоцкин', N'Геннадьевич', N'9628951029')
INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (2, N'Админ', N'Админ', N'Админ', N'9999999999')
INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (3, N'Работник', N'Работник', N'Работник', N'8888888888')
INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (4, N'Пользователь', N'Пользователь', N'Пользователь', N'0000000000')
INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (5, N'Александр', N'Смойлов', N'Юрьевич', N'1111111111')
INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (6, N'Владимир', N'Стоканов', N'Алексеевич', N'9538984523')
INSERT [dbo].[Users] ([id_pk_user], [u_name], [u_surname], [u_patronymic], [u_phoneNumber]) VALUES (7, N'Айдул', N'Абдуглы', N'Самбуртович', N'2222222222')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Vacancy] ON 

INSERT [dbo].[Vacancy] ([id_pk_vacancy], [id_organization], [v_profession], [v_description], [v_contactNumber]) VALUES (1, 1, N'Помощник главнокомандующего', N'Очень много помогать нашему несравненному главнокомандующему выполнять его должностные обязанности!', N'9628951028')
INSERT [dbo].[Vacancy] ([id_pk_vacancy], [id_organization], [v_profession], [v_description], [v_contactNumber]) VALUES (6, 1, N'Слесарь', N'Очень много выполнять слесарных работ так, чтобы было не стыдно!', N'9628951028')
INSERT [dbo].[Vacancy] ([id_pk_vacancy], [id_organization], [v_profession], [v_description], [v_contactNumber]) VALUES (8, 1, N'Уборщица', N'Убирать и драять все полы! Опыт работы: от трёх лет!', N'9628951028')
INSERT [dbo].[Vacancy] ([id_pk_vacancy], [id_organization], [v_profession], [v_description], [v_contactNumber]) VALUES (9, 2, N'Администратор', N'Принимать гостей и продавать барную продукцию.', N'1239080982')
INSERT [dbo].[Vacancy] ([id_pk_vacancy], [id_organization], [v_profession], [v_description], [v_contactNumber]) VALUES (10, 2, N'Системник', N'Чинить поломавшиеся компьютеры', N'1239080982')
INSERT [dbo].[Vacancy] ([id_pk_vacancy], [id_organization], [v_profession], [v_description], [v_contactNumber]) VALUES (11, 4, N'Кондитер', N'В Шоколадную Фабрику Алекса приглашаются умелые кондитеры, чтобы 8 часов в день варить его и радовать более 15.000.000 детей по всему миру ежедневно!', N'1236676213')
SET IDENTITY_INSERT [dbo].[Vacancy] OFF
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
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[ADDContract]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[ADDDocument]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[AddOrganization]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[AddUserEmployee]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[AddVacancy]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[CreateFKRegister]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteUserFromRegister]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteVacancy]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[ResponseDelete]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[ResponseUpdate]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[ResponseUserInsert]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateContract]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateDocument]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateOrganization]    Script Date: 14.01.2023 8:21:38 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateVacancy]    Script Date: 14.01.2023 8:21:38 ******/
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
