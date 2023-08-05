create table RegID
(
Id int not null primary key identity(1,1),
Fullname nvarchar (200) not null,
Email nvarchar (200) not null,
MobileNum bigint not null,
Gender nvarchar (200) not null
);

create or alter procedure IDInsert(@Fullname nvarchar (200),@Email nvarchar (200),@MobileNum bigint,@Gender nvarchar (200))
as
begin
insert into RegID (Fullname,Email,MobileNum,Gender) values (@Fullname,@Email,@MobileNum,@Gender)
end

Exec IDInsert 'Ajay Kumar','Ajay@123',9159880650,'Male'

Create  or alter procedure IDSelect
as
begin
Select * from RegID
end

Exec IDSelect

Create or alter procedure IDSelect(@Id int)
as
begin
Select * from RegID where Id = @Id;
end


alter procedure IDUpdate(@Id int,@Fullname nvarchar (200),@Email nvarchar (200),@MobileNum bigint,@Gender nvarchar (200))
as
begin
update RegID 
set
Fullname = @Fullname,
Email = @Email,
MobileNum = @MobileNum,
Gender = @Gender
where
Id = @Id
end

Exec IDUpdate 1,'Sibi','Sibi@113',915874582,'Male'

Create Procedure IDDelete(@del int)
as
begin
delete from RegID where Id = @del
end

Exec IDDelete 1
