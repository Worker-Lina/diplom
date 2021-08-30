select * from Employees

drop table Employees

CREATE TABLE Employees( --����������
	id uniqueidentifier PRIMARY KEY not null, --���
	FIO nvarchar(max) check(FIO<>N'') not null, --���
	Position nvarchar(20) not null, --���������
	Salary decimal check(Salary>=0) default(42500), --��������
	Phone nvarchar(12),
	Login nvarchar(max),
	Password nvarchar(max),
	Address nvarchar(150),
	DateOfEmployment datetime,
	PhotoURL nvarchar(max)
);

SELECT e.FIO, e.Position, e.Salary, e.Phone FROM Employees e


select * from  users
delete from users where id =10


set datetimeformat dmy

insert into Employees values 
	(NEWID(), '������ ���� ��������', '�������������', 120000, '87070000000','admin', '1234','street 3', GETDATE(), 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\admin.jpg')

select * from Employees

insert into Employees values 
	(NEWID(), '�������� ������� �������', '���������', 100000, '87070009900','farm', 'qwert','street 9', GETDATE(), 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\admin.jpg')


select * from Drugs


CREATE TABLE Products( --������� ����������
	id uniqueidentifier PRIMARY KEY not null,  --��� ���������
	[Name] nvarchar(max) check([Name]<>N'') not null , --�������� ���������
	�ategory nvarchar(max), --��������� 
	Manufacturer nvarchar(max) , --��� ����������
	PurchasePrice decimal check(PurchasePrice>0),  --���������� ����
	SellingPrice decimal check(SellingPrice>0),   --����������� ����
	Recipe nvarchar(5) check(Recipe in ('����', '���')),  --������
	ReleaseDate datetime not null,  --���� ������������
	SellBeforedate datetime not null,
	[Count] int default 0,
	PhotoURL nvarchar(max)
);
$"insert into Products values ('{product.Name}', '{product.Category}', '{product.Manufacturer}', {product.PurchasePrice}, {product.SellingPrice}, '{product.Recipe}', '{product.ReleaseDate}', '{product.SellBeforeDate}', {product.Count}, '{product.PhotoURL}')";
SELECT * FROM drugs
SELECT * FROM Prescription_of_drugs
SELECT * FROM Manufacturer m

select [group] from Prescription_of_drugs 
SELECT p.id, p.Name, p.sellingPrice, p.Count FROM Products p

select * from Products

C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\amoksiklav.jpg

insert into Products values 
	(NEWID(), '������', '�����������', '������', 2300, 3000, '����', '06/03/2021', '01/01/2024', 2, 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\akriderm.jpg')


insert into Products values 
	(NEWID(), '�������', '�����������������', '�����', 400, 700, '���', '01/01/2020', '01/01/2023', 12, 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\teraflu.jpg')




CREATE TABLE Manufacturer( --�������������
	id uniqueidentifier PRIMARY KEY not null, -- ��� �������������
	[Name] nvarchar(25) check([Name]<>N'') not null, --�������� 
	Country nvarchar(25) not null, --������
	City nvarchar(25) not null,  --�����
	[Address] nvarchar(25) not null, --�����
	Phone nvarchar(25) not null --�������
);

select * from Manufacturer
select * from Products


Update products set PhotoURL = 'C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\citramon.jpg' where id ='{A673E3DE-6CD0-43C7-AA57-98C6DBBB2C19}'
Update products set PhotoURL = 'C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\aminazin.jpg' where id ='{ED238CFB-E74B-46E9-B860-A635CACBF0E3}'
Update products set PhotoURL = 'C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\klofelin.jpg' where id ='{7698524E-32F6-4ED7-AC01-B3F04D34070D}'
Update products set PhotoURL = 'C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\paracetamol.jpg' where id ='{A4D770A2-8863-48B1-8C17-CC1FE5189439}'
Update products set PhotoURL = 'C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\femoston.jpg' where id ='{86EA6599-8402-44F7-856E-D4D27385E668}'
Update products set PhotoURL = 'C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\teraflu.jpg' where id ='{DA7D01EF-E3D6-4046-96A8-DCBD79E56A06}'


insert into Purchases values ('{product.Id}','{purchase.Id}', 2)

create table Receipt
(
	id uniqueidentifier PRIMARY KEY not null,
	[Datetime] DateTime,
	Summa decimal
	
)

drop table Receipt
drop table Purchases


create table Purchases(
	ProductId uniqueidentifier,
	ReceiptId uniqueidentifier,
	CONSTRAINT FK_Purchase_Product FOREIGN KEY(ProductId)
		REFERENCES Products(Id),
	CONSTRAINT FK_Purchase_Receipt FOREIGN KEY(ReceiptId)
		REFERENCES Receipt(Id),
	[Count] int
)


select * from Receipt

select ProductId, sum([count]) from Purchases group by ProductId



select ProductId, (select name from products where id=pu.ProductId ) as name, 
sum([count]) as [count], (select SellingPrice from products where id=pu.ProductId ) as price, 
(select SellingPrice from products where id=pu.ProductId )*sum([count]) as summa
from Purchases pu where (select [DateTime] from Receipt r where pu.ReceiptId = r.id)>=GETDATE()-7
group by ProductId order by sum([count]) desc

select * from Purchases
select * from Receipt 


where (select r.[DateTime], p.ReceiptId from Receipt r join Purchases p on r.id = p.ReceiptId group by p.ReceiptId)>=GETDATE()-7

insert into Receipt values 



select [DateTime] from Receipt where [DateTime]>=GETDATE()-7 order by [DateTime] desc



select GETDATE()-7

create table RecipePatient
(
	id uniqueidentifier PRIMARY KEY not null,
	IIN nvarchar(12) not null,
	RecipePhoto nvarchar(max)
)

insert into Receipt values 
	(NEWID(), '2021/05/20', 4000)


insert into RecipePatient values
	(NEWID(), '203040506045','C:\Users\fizik\Desktop\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\recipe.png')

SELECT *FROM Receipt

select p.name, p.purchasePrice, p.count from products p where count<5

delete products where id='{E0042655-9C41-4254-8A40-54B01B1D0617}'
delete products where id='{E0042655-9C41-4254-8A40-54B01B1D0617}'



ALTER AUTHORIZATION ON DATABASE:: Pharmacy TO [DESKTOP-S7AP05F\DefaultAccount]
ALTER AUTHORIZATION ON DATABASE::Pharmacy TO [DOMAIN\user]

CREATE USER [alina22] FOR LOGIN [alina22]
ALTER ROLE [db_owner] ADD MEMBER [alina22]



alter table products add Category uniqueidentifier 
alter table add

select * from Products where �ategory = '��������'

delete from Products where id='{55D445BD-6A85-4E99-9DB1-2AC7ECA85FBB}'

780224350015
20304050604



update Products set [Description]='�������� ��������
���������� 2X  
 
������������� ��������������� ��������
���
 
������������� �����
��������, �������� ��������� ��������� 625 �� � 1000 ��
 
������
���� �������� ��������
�������� ��������:  ������������ (� ����� ����������) 500 �� � 
                                     ����� ���������� 125 ��. 
                                    (��� ���������� 2�, ��������, �������� ���������  
                                    ��������� 625 ��)
                                     ������������ (� ����� ����������) 875 �� � 
                                     ����� ���������� 125 ��. 
                                    (��� ���������� 2�, ��������, �������� ��������� 
                                    ��������� 1000 ��)
��������������� ��������:
���� � ������� ������� ����������, �����������, ������ ��������������, ������ �������, ��������� �������������������� 
������ �������� � �����������������������, �������������, ���������� 80, �������������, �����, ������ ������� � 171
 
��������
���������� 2� ��������, �������� ��������� ��������� 625 �� � ��������, �������� ��������� ��������� ������ ��� ����� ������ �����, �������� ����� � �������������� ������������ 
���������� 2� ��������, �������� ��������� ��������� 1000 �� � ��������, �������� ��������� ��������� ������ ��� ����� ������ �����, ������������� ����� � �������������� ������������, � ������, � ����������� �875/125� � ������ �� ����� �������, � ����������� ���ѻ - �� ������ �������
 
���������������������� ������
����-��������� ����������������� ��������� � ���������� � ������������  ����-��������.
��� ��� J01CR02.' where id ='{A7EDA014-5C6D-4B34-A444-17107DE53469}'

select * from Products


update Products set [Description]='�������� ��������
�������
 
������������� ��������������� �������� 
��������� 
 
������������� �����
��������, �������� ��������� ��������� 10 ��
 
������ 
���� �������� ��������
�������� �������� � ��������� ����������� 10 ��
��������������� ��������: 
��������� ��������������������(��� 102), ������� ���������� ���������������������, ������� ����������, ������� ������� ��������� �������������, ������ �������
������ ��������: ������ 03�51148 ������� (������������������� (6��s), ������ ������� �171, ���������/��������, ������ (III) ����� ������ �172, ��������� FD & � �1 (������������� ������� FCF, ����������� ��� 11-13 %)
���������������
������� � ������������ ��������������������� �������� (����), ���������� ������������� � ���������������������  ���������. �������� �������� �������� ��������, ��� � � ������ ����, ����������� � ��� ����������������� ������� - ������������� ������� ���������������. ����  �������� ������� �� ���������.
������� �� ��������� ����������� ��� ����������������� ��������, �� ������ �� ��������� ���������. ������� �� �������� ���������� ��������� �� ����������� ����� � �� ��������� ��������� ������� � ���������� ������, ���������� ���������� ������������. ������� �� �������� ������������� �����������. ����� ������ ������ ��������� �������� ������ �� ���������. ' where id ='{FCC34B55-4FF2-4237-A48D-286331D1349E}'

update Products set [Description]='������������ ������� ����� �200 (�������������)
�������� �������� 
������������ ������� 
 
������������� ��������������� ��������
������������ ������� 
 
������������� �����
����� 50 ��
 
������
���� ����� ��������
��������  �������� - ������� ������������ (������� �) 50 ��,
��������������� �������� � �������� (�����), ������ �����������, ���� ���������, �����,  ������������ ������� ������, ����� ������������, ���� ��������.
   
�������� 
����� ������������ ����� �� ������ �� ������-��������� ����� 
 
���������������������� ������ 
��������. ������������ ������� � ������ ����. ������������ �������.
��� ���  �11G�01' where id ='{31CE50FB-9054-42D9-ADAB-1D31675C0B53}'

update Products set [Description]='������ 125�� �� �6
�������� ��������
������ 500
������ 250
������ 125

������������� ��������������� ��������
�����������  
  ������������� ����� ��������, �������� ��������� ���������, 500 ��, 250 �� � 125 ��
������
���� �������� ��������
�������� �������� - ������������ �������� 524.0 �� ��� 262.0 �� ���  131.0 �� ������������ 500 ��, 250 ��  � 125 �� ������������ ��������������,
��������������� ��������: ������� ���������������������, LHPC 21, ������ �������������, ������ ��������������, ������� ����������� ��������, ������� 200, ������� ���������, ������ �������,
������ ��������: ����������������������������, ��������� ��������������������, ������ �������, �������� � 40 �� �������. 
��������

��������, �������� ��������� ���������  ������ �����, ������������� �����, � ������ �� ����� �������.

���������������������� ������

���������������� ��������� ��� ���������� �������������. ���������

��� ��� J01FA10' where id ='{6BA50BED-0490-41AA-83CD-3E02BD896378}'


select * from Products
select * from Products
update Products set [Description]='��������� 25�� �� �20 //
�������� �������� 
��������� 
 
������������� ��������������� ��������  
������������
 
������������� �����   
��������
 
������ 
���� �������� �������� 
�������� �������� -  ������������� ����������� 25 ��,
��������������� ��������: ������� �����������, �������, ������ ������������������� (��� �), �����, ������� ������������, ������� ����������.
 
�������� 
����� ��� ��������-����� �������� � ���� ����� � ������, � ����������� �SUPRASTIN� �� ����� ������� � ������ - �� ������ ������� ��������, ��� ��� ����� ��� ������. 
 
���������������������� ������
��������������� ��������� ���������� ��������. ������������� ����������. 
��� ATC R06A C03
 
����������������� ��������
���������������
����� ������ ������ ������������ ������ ����������� �� ���������-��������� ������. ��� ��������������� ������ ����������� � ������� 15-30 ����� ����� ������ ������, ��������� ��������� � ������� ������� ���� ����� ������ � ����������� � ������� 3-6 �����. ������ �������������� � ���������, ������� ����������� ������� �������. ���������� � ������� ������ -  7,9%. ��� ���������� ������� ��� �� 7,4. ���������������� � ������. ��������� ��������������� ������� � ���� �����������. � ����� ��������� ��������� ���������� �������, ��� � �������� ���������.' where id ='{97A36C2C-8079-4947-BAB8-72BC8138730E}'


update Products set [Description]='�������� ����� �50 (�������������)
�������� ��������
��������
 
������������� ��������������� ��������
���
 
������������� �����
�����
 
������
���� ����� ��������
�������� ��������:      
�������� ���������  (������� �)                      2,75 �� (5000 ��)
������� ����������� (������� �1)                   2,00 ��
������� ������������ (������� �)                             70,00 ��
���������� (������� �2)                                  2,00 ��
����������� ����������� (������� �6)          2,00 ��
�����������                                                      15,00 ��
��������������� ��������: ���� ��������, ���� ���������, ������������� �����, ������ �����������, �������� (�����), �����, ������������ ������� "�����".
 
��������
����� ������������ �����, �� ������� �� �����-���������� �����, �� ������ ����������� �������.
 
���������������������� ������
 ��������. ������������.
��� ��� A11��
 
����������������� ��������
����������� �������������� ��������, �������� �������� ����������� ��������� �������� � ��� ������ ���������.' where id ='{AC806957-FBE4-4170-A7CE-586F55317C18}'



select * from Products

update Products set [Description] = '' where id='{7698524E-32F6-4ED7-AC01-B3F04D34070D}'


update Products set Count=Count+2 where id ='{6BA50BED-0490-41AA-83CD-3E02BD896378}'


203040506045