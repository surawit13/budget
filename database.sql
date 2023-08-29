CREATE TABLE tb_user (
    id int IDENTITY(1,1) PRIMARY KEY,
    user_code varchar(255) NOT NULL,
    firstname varchar(255) NOT NULL,
    lastname varchar(255) NOT NULL,
    dob datetime ,
    phone_no varchar(10),
    status  char(4),
    create_by int,
    create_date DATETIME not null,
    update_date datetime,
    update_by int,
);



CREATE TABLE tb_department (
    id int IDENTITY(1,1) PRIMARY KEY,
    name varchar(255) NOT NULL,
    status  char(4),
    create_by int,
    create_date DATETIME not null,
    update_date datetime,
    update_by int,
);



CREATE TABLE tb_relation_deptuser (
    id int IDENTITY(1,1) PRIMARY KEY,
    userid int not null,
    deptid int not null,
    name varchar(255) NOT NULL,
    status  char(4),
    create_by int,
    create_date DATETIME not null,
    update_date datetime,
    update_by int,
);






