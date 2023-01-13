-- DATABASE

create table Users (
	id_pk_user int identity(1,1) not null primary key,
	u_name nvarchar(50) not null,
	u_surname nvarchar(50) not null,
	u_patronymic nvarchar(50) not null,
	u_phoneNumber nvarchar(50) not null
);

create table Register (
    id_pk_register int identity(1,1) not null primary key,
    id_fk_user int not null FOREIGN KEY REFERENCES Users(id_pk_user) ON DELETE CASCADE,
    r_email nvarchar(100) not null,
    r_login nvarchar(50) not null,
	r_password nvarchar(50) not null,
	r_isAdmin bit,
	r_isUser bit,
	r_isEmployee bit,
);

create table Adress (
	id_pk_adress int identity(1,1) not null primary key,
	a_region nvarchar(50) not null,
	a_city nvarchar(50) not null,
	a_street nvarchar(50) not null,
	a_building nvarchar(50) not null,
	a_apartment nvarchar(50) not null
);

create table Client (
	id_pk_client int identity(1,1) not null primary key,
	id_user int not null FOREIGN KEY REFERENCES Users(id_pk_user) ON DELETE CASCADE,
	id_adress int not null foreign key references Adress (id_pk_adress)
);

create table Employee (
	id_pk_employee int identity(1,1) not null primary key,
	id_fk_user int not null foreign key references Users (id_pk_user) ON DELETE CASCADE
);

create table Organization (
	id_pk_organization int identity(1,1) not null primary key,
	o_name nvarchar(50) not null,
	o_email nvarchar(100) not null,
	o_phoneNumber nvarchar(50) not null,
	id_fk_adress int not null foreign key references Adress (id_pk_adress),
	id_fk_client int not null foreign key references Client (id_pk_client)
);

create table Vacancy (
	id_pk_vacancy int identity(1,1) not null primary key,
	id_organization int not null foreign key references Organization (id_pk_organization),
	v_profession nvarchar(100) not null,
	v_description nvarchar(1000) not null,
	v_contactNumber nvarchar(50) not null
);

create table OrgVac (
    id_pk_orgvac int identity(1,1) not null primary key,
    id_fk_vac int not null foreign key references Vacancy(id_pk_vacancy),
    id_fk_org int not null foreign key references Organization(id_pk_organization)
);

create table Contracts (
	id_pk_contract int identity(1,1) not null primary key,
	c_conditions nvarchar(1000),
	c_createdAt nvarchar(30),
	c_fk_client int foreign key references Client(id_pk_client),
    c_fk_employee int foreign key references Employee(id_pk_employee)
);

-- статус контракта пользователя
create table ContractStatus (
	id_pk_status int identity(1,1) not null primary key,
	cs_status nvarchar(50) not null
);

insert into ContractStatus (cs_status) values ('Заключён');
insert into ContractStatus (cs_status) values ('Выполнен');
insert into ContractStatus (cs_status) values ('Отменён');

create table Passport (
	id_pk_passport int identity(1,1) not null primary key,
	p_number int not null,
	p_series int not null,
	p_name nvarchar(50),
	p_surname nvarchar(50),
	p_patronymic nvarchar(50),
	p_sex nvarchar(50) not null,
	p_birth nvarchar(30),
	id_adress int not null foreign key references Adress (id_pk_adress)
);

create table Documents (
	id_pk_document int identity(1,1) not null primary key,
	id_passport int not null foreign key references Passport (id_pk_passport),
	d_education nvarchar(1000),
	d_TIN nvarchar(1000),
);

create table UserDoc (
    id_pk_userdoc int identity(1,1) primary key not null,
    id_fk_user int not null foreign key references Users (id_pk_user),
    id_fk_doc int not null foreign key references Documents (id_pk_document)
);

create table UserResponse (
    id_pk_response int identity(1,1) not null primary key,
    id_fk_vacancy int not null foreign key references Vacancy (id_pk_vacancy),
    id_fk_user int not null foreign key references Users (id_pk_user),
    id_fk_status int not null foreign key references ResponseStatus (id_pk_status)
);

-- статус обработки отклика пользователя
create table ResponseStatus (
    id_pk_status int identity(1,1) not null primary key,
    rs_status nvarchar(50) not null
);

insert into ResponseStatus (rs_status) values ('Отправлен');
insert into ResponseStatus (rs_status) values ('Обработан');
insert into ResponseStatus (rs_status) values ('Отменён');

-- -- PROCEDURES
--
-- CREATE PROCEDURE CreateFKRegister
--     @u_name nvarchar(50),
--     @r_email nvarchar(50),
--     @r_login nvarchar(50),
--     @r_password nvarchar(50),
--     @r_isAdmin bit,
--     @r_isUser bit,
--     @r_isEmployee bit
-- AS declare @id_fk_user int
-- BEGIN
--     select @id_fk_user = id_pk_user from Users where Users.u_name = @u_name;
--     insert into Register (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee)
--     values (@id_fk_user, @r_email, @r_login, @r_password, @r_isAdmin, @r_isUser, @r_isEmployee);
-- END;
--
-- CREATE PROCEDURE DeleteUserFromRegister
--     @id_pk_register int
-- AS declare @id_fk_user int
-- BEGIN
--     select @id_fk_user = Register.id_fk_user from Register;
--     delete from Users where @id_fk_user = id_pk_user;
--     delete from Register where id_pk_register = @id_pk_register;
-- END;
--
-- create procedure AddUserEmployee @id_fk_user int as
--     BEGIN
--         insert into Employee (id_fk_user) values (@id_fk_user);
--         UPDATE Register SET r_isEmployee = 'True' where @id_fk_user = Register.id_fk_user;
--     END;

-- create procedure ResponseUserInsert
--     @r_login nvarchar(50),
--     @id_vacancy int
-- AS DECLARE @id_user int
--     BEGIN
--         select @id_user = id_fk_user from Register where r_login = @r_login;
--         insert into UserResponse (id_fk_vacancy, id_fk_user) values (@id_vacancy, @id_user);
--     END;

-- Тут была осуществлена попытка убрать все контсрейнты ----------------------------------------------------------
-- alter table Vacancy nocheck constraint all

-- create procedure UpdateVacancy
--     @vacId int,
--     @vacProf nvarchar(50),
--     @vacOrg nvarchar(50),
--     @vacDesc nvarchar(50),
--     @vacNumber nvarchar(50)
-- AS DECLARE @o_id int
--     BEGIN
--         select @o_id = id_pk_organization from Organization where o_name = @vacOrg ;
--         update Vacancy set id_organization = @o_id, v_profession = @vacProf, v_description = @vacDesc, v_contactNumber = @vacNumber where id_pk_vacancy = @vacId;
--     END;

-- create procedure DeleteVacancy
--     @vacId int
-- AS
--     BEGIN
--         delete from OrgVac where id_fk_vac = @vacId
--         delete from UserResponse where id_fk_vacancy = @vacId
--         delete from Vacancy where id_pk_vacancy = @vacId
--     END;

-- create procedure AddVacancy
--     @vacOrg nvarchar(50),
--     @vacProf nvarchar(50),
--     @vacDesc nvarchar(50),
--     @vacNumber nvarchar(50)
-- AS DECLARE @o_id int, @v_id int
--     BEGIN
--         select @o_id = id_pk_organization from Organization where o_name = @vacOrg;
--
--         insert into Vacancy
--             (id_organization, v_profession, v_description, v_contactNumber)
--         values
--             (@o_id, @vacProf, @vacDesc, @vacNumber);
--
--         select @v_id = id_pk_vacancy from Vacancy where v_profession = @vacProf and v_description = @vacDesc;
--
--         Insert Into OrgVac
--             (id_fk_vac, id_fk_org)
--         values
--             (@v_id, @o_id);
--     END;

-- Добавление клиента
-- create procedure AddClient
--     @clientName nvarchar(50),
--     @clientSurname nvarchar(50),
--     @clientPat nvarchar(50),
--     @clientNum nvarchar(50),
--     @adressRegion nvarchar(50),
--     @adressCity nvarchar(50),
--     @adressStreet nvarchar(50),
--     @adressBuilding nvarchar(50),
--     @adressApartment nvarchar(50)
-- AS DECLARE @a_id int, @u_id int
--     BEGIN
--         insert into Adress
--             (a_region, a_city, a_street, a_building, a_apartment)
--         values
--             (@adressRegion, @adressCity, @adressStreet, @adressBuilding, @adressApartment);
--
--         select @a_id = id_pk_adress from Adress
--         where
--             a_apartment = @adressApartment and a_building = @adressBuilding and a_city = @adressCity;
--
--         insert into Users
--             (u_name, u_surname, u_patronymic, u_phoneNumber)
--         values
--             (@clientName, @clientSurname, @clientPat, @clientNum);
--
--         select @u_id = id_pk_user from Users where u_phoneNumber = @clientNum and u_name = @clientName;
--
--         insert into Client (id_user, id_adress) values (@u_id, @a_id);
--     END;

-- Добюавление организации
-- create procedure AddOrganization
--     @orgName nvarchar(50),
--     @orgClient nvarchar(50),
--     @orgNum nvarchar(50),
--     @orgMail nvarchar(50),
--     @adressRegion nvarchar(50),
--     @adressCity nvarchar(50),
--     @adressStreet nvarchar(50),
--     @adressBuilding nvarchar(50),
--     @adressApartment nvarchar(50)
-- AS DECLARE @a_id int, @o_id int, @u_id int
--     BEGIN
--         -- Создаём и ищем адрес
--         insert into Adress
--             (a_region, a_city, a_street, a_building, a_apartment)
--         values
--             (@adressRegion, @adressCity, @adressStreet, @adressBuilding, @adressApartment);
--
--         select @a_id = id_pk_adress from Adress
--         where
--             a_apartment = @adressApartment and a_building = @adressBuilding and a_city = @adressCity;
--
--         -- Ищем пользователя через регистрацию
--         select @u_id = id_fk_user from Register where r_login = @orgClient;
--
--         -- Добавляем организацию
--         insert into Organization
--             (o_name, o_email, o_phoneNumber, id_fk_adress, id_fk_client)
--         values
--             (@orgName, @orgMail, @orgNum, @a_id, @u_id);
--     END;

-- Изменение данных организации
-- create procedure UpdateOrganization
--     @orgId int,
--     @orgName nvarchar(50),
--     @orgClient nvarchar(50),
--     @orgNum nvarchar(50),
--     @orgMail nvarchar(50)
-- as declare @u_id int, @c_id int
-- begin
--     select @u_id = id_fk_user from Register where r_login = @orgClient;
--
--     select @c_id = id_pk_client from Client where id_user = @u_id;
--
--     UPDATE Organization
--     SET o_phoneNumber = @orgNum, o_name = @orgName, o_email = @orgMail, id_fk_client = @c_id
--     where id_pk_organization = @orgId;
-- end;

-- Обновление контракта
-- create procedure UpdateContract
--     @contractId int,
--     @contractConditions nvarchar(50),
--     @contractDate nvarchar(50),
--     @contractAgentName nvarchar(50),
--     @contractAgentSurname nvarchar(50),
--     @contractClientName nvarchar(50),
--     @contractClientSurname nvarchar(50),
--     @contractStatus nvarchar(50)
-- AS DECLARE @c_id int, @e_id int, @s_id int
--     BEGIN
--         -- Поиск клиента
--         select @c_id = id_pk_client from Client
--             inner join Users U on U.id_pk_user = Client.id_user
--         where u_name = @contractClientName and u_surname = @contractClientSurname;
--
--         -- Поиск работника
--         select @e_id = id_pk_employee from Employee
--             inner join Users U on U.id_pk_user = Employee.id_fk_user
--         where u_name = @contractAgentName and u_surname = @contractAgentSurname;
--
--         -- Поиск статуса
--         select @s_id = id_pk_status from ContractStatus where cs_status = @contractStatus;
--
--         -- Обновление данных
--         UPDATE Contracts
--         SET
--             c_conditions = @contractConditions,
--             c_createdAt = @contractDate,
--             c_fk_client = @c_id,
--             c_fk_employee = @e_id,
--             c_fk_status = @s_id
--         where id_pk_contract = @contractId;
--     END;

-- Обновление отклика
-- CREATE PROCEDURE ResponseUpdate
--     @responseId int,
--     @responseStatus nvarchar(50)
-- AS DECLARE @s_id int
--     BEGIN
--         select @s_id = id_pk_status from ResponseStatus where rs_status = @responseStatus;
--         UPDATE UserResponse
--         SET id_fk_status = @s_id
--         where id_pk_response = @responseId;
--     END;

-- Удаление отклика
-- CREATE PROCEDURE ResponseDelete
--     @responseId int
-- AS
--     BEGIN
--         DELETE FROM UserResponse WHERE id_pk_response = @responseId;
--     END;

-- Добавление контракта
-- create procedure ADDContract
--     @contractConditions nvarchar(1000),
--     @contractDate nvarchar(50),
--     @contractAgentName nvarchar(50),
--     @contractAgentSurname nvarchar(50),
--     @contractClientName nvarchar(50),
--     @contractClientSurname nvarchar(50),
--     @contractStatus nvarchar(50)
-- AS DECLARE @c_id int, @e_id int, @s_id int
--     begin
--         -- Поиск клиента
--         select @c_id = id_pk_client from Client
--             inner join Users U on U.id_pk_user = Client.id_user
--         where u_name = @contractClientName and u_surname = @contractClientSurname;
--
--         -- Поиск работника
--         select @e_id = id_pk_employee from Employee
--             inner join Users U on U.id_pk_user = Employee.id_fk_user
--         where u_name = @contractAgentName and u_surname = @contractAgentSurname;
--
--         -- Поиск статуса
--         select @s_id = id_pk_status from ContractStatus where cs_status = @contractStatus;
--
--         -- Добавление нового контракта
--         insert into Contracts
--             (c_conditions, c_createdAt, c_fk_client, c_fk_employee, c_fk_status)
--         values
--             (@contractConditions, @contractDate, @c_id, @e_id, @s_id)
--     end;
-- Обновление документов
-- CREATE PROCEDURE ADDDocument
--     @passportID int,
--     @clientID int,
--     @adressID int,
--     @documentsID int,
--
--     @passSeries int,
--     @passNum int,
--     @passBirth nvarchar(50),
--     @passSex nvarchar(50),
--
--     @adressRegion nvarchar(50),
--     @adressCity nvarchar(50),
--     @adressStreet nvarchar(50),
--     @adressBuilding nvarchar(50),
--     @adressApartment nvarchar(50),
--
--     @docsTIN nvarchar(50),
--     @docsEducation nvarchar(50),
--
--     @clientName nvarchar(50),
--     @clientSur nvarchar(50),
--     @clientPat nvarchar(50)
-- AS DECLARE @p_id int, @u_id int, @a_id int, @d_id int
-- BEGIN
--     select @p_id = id_pk_passport from Passport where id_pk_passport = @passportID;
--     select @u_id = id_user from Client where id_pk_client = @clientID;
--     select @a_id = id_pk_adress from Adress where id_pk_adress = @adressID;
--     select @d_id = id_pk_document from Documents where id_pk_document = @documentsID;
--
--     insert into Passport
--         (p_number, p_series, p_name, p_surname, p_patronymic, p_sex, p_birth, id_adress)
--     values
--         (@passNum, @passSeries, @clientName, @clientSur, @clientPat, @passSex, @passBirth, @a_id);
--
--     insert into Adress
--         (a_region, a_city, a_street, a_building, a_apartment)
--     values (@adressRegion, @adressCity, @adressStreet, @adressBuilding, @adressApartment);
--
--     insert into Documents
--         (id_passport, d_education, d_TIN)
--     values
--         (@p_id, @docsEducation, @docsTIN);
--
--     insert into UserDoc (id_fk_user, id_fk_doc) values (@u_id, @d_id)
-- END;

-- Добавление документов
-- CREATE PROCEDURE UpdateDocument
--     @passportID int,
--     @clientID int,
--     @adressID int,
--     @documentsID int,
--
--     @passSeries int,
--     @passNum int,
--     @passBirth nvarchar(50),
--     @passSex nvarchar(50),
--
--     @adressRegion nvarchar(50),
--     @adressCity nvarchar(50),
--     @adressStreet nvarchar(50),
--     @adressBuilding nvarchar(50),
--     @adressApartment nvarchar(50),
--
--     @docsTIN nvarchar(50),
--     @docsEducation nvarchar(50),
--
--     @clientName nvarchar(50),
--     @clientSur nvarchar(50),
--     @clientPat nvarchar(50)
-- AS DECLARE @p_id int, @c_id int, @a_id int, @d_id int
-- BEGIN
--     select @p_id = id_pk_passport from Passport where id_pk_passport = @passportID;
--     select @a_id = id_pk_adress from Adress where id_pk_adress = @adressID;
--     select @d_id = id_pk_document from Documents where id_pk_document = @documentsID;
--
--     UPDATE Passport
--     SET p_name = @clientName, p_surname = @clientSur,
--         p_patronymic = @clientPat, p_number = @passNum, p_series = @passSeries,
--         p_sex = @passSex, p_birth = @passBirth
--     WHERE id_pk_passport = @passportID;
--
--     UPDATE Documents
--     SET d_TIN = @docsTIN, d_education = @docsEducation
--     WHERE id_pk_document = @documentsID;
--
--     UPDATE Adress
--     SET a_region = @adressRegion, a_city = @adressCity, a_street = @adressStreet,
--         a_building = @adressBuilding, a_apartment = @adressApartment
--     WHERE id_pk_adress = @adressID;
-- END;


-- INSERTS

insert into Adress
    (a_region, a_city, a_street, a_building, a_apartment)
values ('Kirov obl', 'Kirov', 'Kiorov street', '97', '1');

insert into Adress
    (a_region, a_city, a_street, a_building, a_apartment)
values ('Arstozka obl', 'Kirov', 'Arstozka street', '92', '2');

insert into Client
    (id_user, id_adress)
values (1, 1);

insert into Client
    (id_user, id_adress)
values (2, 2);

insert into Organization
    (o_name, o_email, o_phoneNumber, id_fk_adress, id_fk_client)
values ('Krizbyt', 'arstozka@yandex.ru', '1234567890', 2, 7);

insert into Vacancy
    (id_organization, v_profession, v_description, v_contactNumber)
values (1, 'Главный уборщик', 'Малов слов', '1234567834');

insert into Passport
    (p_number, p_series, p_name, p_surname, p_patronymic, p_sex, p_birth, id_adress)
values
    ('2342', '123123', 'Александр', 'Марков', 'Юрьевич', 'male', '11/01/2003', 1);

insert into Contracts
    (c_conditions, c_createdAt)
values
    ('Очень много договорённостей было на этот счёт...', '20/11/2003');

insert into Documents
    (id_passport, d_education, d_TIN)
values
    (1, 'Кировский авиационный', '1231 1231 1231 1231');

insert into UserResponse
    (id_fk_vacancy, id_fk_user)
values
    (3, 2);

insert into OrgVac
    (id_fk_vac, id_fk_org)
values
    (1, 1);

insert into UserDoc
    (id_fk_user, id_fk_doc)
values
    (2, 1);