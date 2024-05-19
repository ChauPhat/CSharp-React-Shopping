use master
go

drop database if exists AnDuy
go

create database AnDuy
go

use AnDuy
go


CREATE TABLE users
(
    ID          int IDENTITY (1,1) PRIMARY KEY,
    Name        nvarchar(255),
    Age         nvarchar(255),
    IsActive    int
);

INSERT INTO AnDuy.dbo.users (ID, Name, Age, IsActive) VALUES (N'string', N'string', 0);
INSERT INTO AnDuy.dbo.users (ID, Name, Age, IsActive) VALUES (N'string', N'string', 0);
INSERT INTO AnDuy.dbo.users (ID, Name, Age, IsActive) VALUES (N'zzxczxc', N'zxc', 1);