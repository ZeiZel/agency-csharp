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
	id_user int not null FOREIGN KEY REFERENCES Users(id_pk_user),
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
	c_createdAt nvarchar(30)
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
    id_fk_user int not null foreign key references Users (id_pk_user)
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



-- INSERTS

-- insert into Users
--     (u_name, u_surname, u_patronymic, u_phoneNumber)
-- values
--     ('Олег', 'Ларионов', 'Олегович', '1234567891');
-- insert into Users
--     (u_name, u_surname, u_patronymic, u_phoneNumber)
-- values
--     ('Валерий', 'Львов', 'Владимирович', '1234567892');
-- insert into Users
--     (u_name, u_surname, u_patronymic, u_phoneNumber)
-- values
--     ('Александр', 'Марков', 'Юрьевич', '1234567893');
-- insert into Users
--     (u_name, u_surname, u_patronymic, u_phoneNumber)
-- values
--     ('Организатор', 'Организатор', 'Организатор', '1234567894');
--
-- insert into Register
--     (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee)
-- values
--     (1, 'oleg@yandex.ru', 'oleg', 'oleg', 1, 1, 1);
-- insert into Register
--     (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee)
-- values
--     (2, 'valery@yandex.ru', 'valery', 'valery', 0, 1, 1);
-- insert into Register
--     (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee)
-- values
--     (3, 'alek@yandex.ru', 'alek', 'alek', 0, 1, 0);
-- insert into Register
--     (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee)
-- values
--     (4, 'org@yandex.ru', 'org', 'org', 0, 1, 0);
--
-- insert into Employee (id_fk_user) values (2);
--













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
values ('Krizbyt', 'arstozka@yandex.ru', '1234567890', 2, 1);

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
    (1, 2);

insert into OrgVac
    (id_fk_vac, id_fk_org)
values
    (1, 1);

insert into UserDoc
    (id_fk_user, id_fk_doc)
values
    (2, 1);