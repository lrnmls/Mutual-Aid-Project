﻿-- Switch to the system (aka master) database
USE master;
GO

-- Delete the DemoDB Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='mutual_aid')
DROP DATABASE mutual_aid;
GO

-- Create a new DemoDB Database
CREATE DATABASE mutual_aid;
GO

-- Switch to the DemoDB Database
USE mutual_aid
GO

BEGIN TRANSACTION;

CREATE TABLE users
(
	id int identity(1,1),
	email varchar(50) not null,
	password varchar(50) not null,
	salt varchar(50) not null,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	phone_number varchar(20) not null,
	county varchar(50) not null,
	role varchar(50) default('user'),
	constraint pk_users primary key (id)
);

CREATE TABLE requests
(
	id int identity(1,1),
	user_id int not null,
	is_accepted bit default 0,
	is_completed bit default 0,
	request_date datetime default sysdatetime(),
	toilet_paper varchar(200),
	paper_towels varchar(200),
	hand_soap varchar(200),
	shampoo	varchar(200),
	conditioner	varchar(200),
	toothpaste varchar(200),
	disinfectant varchar(200),
	dairy varchar(200),
	bread varchar(200),
	produce varchar(200),
	canned_food varchar(200),
	meat varchar(200),
	seafood varchar(200),
	cereal varchar(200),
	pantry varchar(200),
	allergens varchar(200),
	constraint pk_requests primary key (id)
);

CREATE TABLE accepted_requests
(
	accepted_confirmation_id int identity(1,1),
	accepted_request_id int not null,
	accepted_user_id int not null,
	accepted_user_first_name varchar(50) default null,
	accepted_user_last_name varchar(50) default null,
	accepted_user_email varchar(50) default null,
	accepted_user_phone_number varchar(20) default null,
	accepted_date datetime default sysdatetime(),
	constraint pk_accepted_requests primary key (accepted_confirmation_id)
);

CREATE TABLE completed_requests
(
	completed_confirmation_id int identity(1,1),
	completed_request_id int not null,
	completed_user_id int not null,
	completed_user_first_name varchar(50) not null,
	completed_user_last_name varchar(50) not null,
	completed_user_email varchar(50) not null,
	completed_user_phone_number varchar(20) not null,
	completed_date datetime default sysdatetime(),
	constraint pk_completed_requests primary key (completed_confirmation_id)
);

ALTER TABLE requests
ADD CONSTRAINT fk_users
FOREIGN KEY (user_id) REFERENCES users(id)

ALTER TABLE accepted_requests
ADD FOREIGN KEY (accepted_request_id) REFERENCES requests(id)

ALTER TABLE completed_requests
ADD FOREIGN KEY (completed_request_id) REFERENCES requests(id)

ALTER TABLE accepted_requests
ADD FOREIGN KEY (accepted_user_id) REFERENCES users(id)

ALTER TABLE completed_requests
ADD FOREIGN KEY (completed_user_id) REFERENCES users(id)

INSERT INTO users(email, password, salt , role, first_name, last_name, phone_number, county)  
VALUES ('admin@gmail.com','cM/Jkg15L++z8H/0LpRqjhRTOPE=', 'IAaPcpjhjhk=', 'admin', 'Lauren', 'Miles', '9373291424', 'Franklin');

COMMIT TRANSACTION