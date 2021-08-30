select * from Employees

drop table Employees

CREATE TABLE Employees( --сотрудники
	id uniqueidentifier PRIMARY KEY not null, --код
	FIO nvarchar(max) check(FIO<>N'') not null, --ФИО
	Position nvarchar(20) not null, --должность
	Salary decimal check(Salary>=0) default(42500), --зарплата
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
	(NEWID(), 'Иванов Иван Иванович', 'администратор', 120000, '87070000000','admin', '1234','street 3', GETDATE(), 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\admin.jpg')

select * from Employees

insert into Employees values 
	(NEWID(), 'Работник Обычный Неадмин', 'фармацевт', 100000, '87070009900','farm', 'qwert','street 9', GETDATE(), 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\admin.jpg')


select * from Drugs


CREATE TABLE Products( --таблица препаратов
	id uniqueidentifier PRIMARY KEY not null,  --код препарата
	[Name] nvarchar(max) check([Name]<>N'') not null , --название препарата
	Сategory nvarchar(max), --категория 
	Manufacturer nvarchar(max) , --код поставщика
	PurchasePrice decimal check(PurchasePrice>0),  --закупочная цена
	SellingPrice decimal check(SellingPrice>0),   --продаваемая цена
	Recipe nvarchar(5) check(Recipe in ('есть', 'нет')),  --рецепт
	ReleaseDate datetime not null,  --дата изготовления
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
	(NEWID(), 'Зитмак', 'Антибиотики', 'Вирион', 2300, 3000, 'есть', '06/03/2021', '01/01/2024', 2, 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\akriderm.jpg')


insert into Products values 
	(NEWID(), 'Терафлю', 'Противопростудные', 'ИмБио', 400, 700, 'нет', '01/01/2020', '01/01/2023', 12, 'C:\Users\ww\source\repos\PharmacyDiplomProject\PharmacyDiplomProject\Resources\Images\Products\teraflu.jpg')




CREATE TABLE Manufacturer( --производители
	id uniqueidentifier PRIMARY KEY not null, -- код производители
	[Name] nvarchar(25) check([Name]<>N'') not null, --название 
	Country nvarchar(25) not null, --страна
	City nvarchar(25) not null,  --город
	[Address] nvarchar(25) not null, --адрес
	Phone nvarchar(25) not null --телефон
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

select * from Products where Сategory = 'витамины'

delete from Products where id='{55D445BD-6A85-4E99-9DB1-2AC7ECA85FBB}'

780224350015
20304050604



update Products set [Description]='Торговое названия
Амоксиклав® 2X  
 
Международное непатентованное название
Нет
 
Лекарственная форма
Таблетки, покрытые пленочной оболочкой 625 мг и 1000 мг
 
Состав
Одна таблетка содержит
активные вещества:  амоксициллин (в форме тригидрата) 500 мг и 
                                     калия клавуланат 125 мг. 
                                    (для Амоксиклав® 2Х, таблетки, покрытые пленочной  
                                    оболочкой 625 мг)
                                     амоксициллин (в форме тригидрата) 875 мг и 
                                     калия клавуланат 125 мг. 
                                    (для Амоксиклав® 2Х, таблетки, покрытые пленочной 
                                    оболочкой 1000 мг)
вспомогательные вещества:
ядро – кремния диоксид коллоидный, кросповидон, натрия кроскармеллоза, магния стеарат, целлюлоза микрокристаллическая 
состав оболочки – гидроксипропилцеллюлоза, этилцеллюлоза, полисорбат 80, триэтилцитрат, тальк, титана диоксид Е 171
 
Описание
Амоксиклав® 2Х таблетки, покрытые пленочной оболочкой 625 мг – таблетки, покрытые пленочной оболочкой белого или почти белого цвета, овальной формы с двояковыпуклой поверхностью 
Амоксиклав® 2Х таблетки, покрытые пленочной оболочкой 1000 мг – таблетки, покрытые пленочной оболочкой белого или почти белого цвета, продолговатой формы с двояковыпуклой поверхностью, с фаской, с гравировкой «875/125» и риской на одной стороне, и гравировкой «АМС» - на другой стороне
 
Фармакотерапевтическая группа
Бета-лактамные антибактериальные препараты в комбинации с ингибиторами  бета-лактамаз.
Код АТС J01CR02.' where id ='{A7EDA014-5C6D-4B34-A444-17107DE53469}'

select * from Products


update Products set [Description]='Торговое название
Кеторол®
 
Международное непатентованное название 
Кеторолак 
 
Лекарственная форма
Таблетки, покрытые пленочной оболочкой 10 мг
 
Состав 
Одна таблетка содержит
активное вещество – кеторолак трометамина 10 мг
вспомогательные вещества: 
целлюлоза микрокристаллическая(тип 102), крахмал кукурузный прежелатинизированный, крахмал кукурузный, кремний диоксид безводный коллоидальный, магния стеарат
состав оболочки: Опадри 03К51148 зеленый (гипрометилцеллюлоза (6срs), титана диоксид Е171, триацетин/глицерин, железа (III) оксид желтый Е172, краситель FD & С №1 (бриллиантовый голубой FCF, алюминиевый лак 11-13 %)
Фармакодинамика
Кеторол® – нестероидное противовоспалительное средство (НПВС), обладающее болеутоляющим и противовоспалительным  действием. Основной механизм действия кеторола, как и у других НПВС, проявляется в его фармакологическом эффекте - ингибировании синтеза простагландинов. НПВС  наиболее активны на периферии.
Кеторол® не оказывает седативного или анксиолитического действия, не влияет на опиоидные рецепторы. Кеторол® не обладает угнетающим действием на дыхательный центр и не усиливает угнетение дыхания и седативный эффект, вызываемые опиоидными аналгетиками. Кеторол® не вызывает лекарственной зависимости. После резкой отмены препарата симптомы отмены не возникают. ' where id ='{FCC34B55-4FF2-4237-A48D-286331D1349E}'

update Products set [Description]='Аскорбиновая кислота драже №200 (Алтайвитамины)
Торговое название 
Аскорбиновая кислота 
 
Международное непатентованное название
Аскорбиновая кислота 
 
Лекарственная форма
Драже 50 мг
 
Состав
Одно драже содержит
активное  вещество - кислота аскорбиновая (витамин С) 50 мг,
вспомогательные вещества – сахароза (сахар), патока крахмальная, мука пшеничная, тальк,  ароматизатор пищевой «Лимон», масло подсолнечное, воск пчелиный.
   
Описание 
Драже шарообразной формы от белого до светло-кремового цвета 
 
Фармакотерапевтическая группа 
Витамины. Аскорбиновая кислота в чистом виде. Аскорбиновая кислота.
Код АТХ  А11GА01' where id ='{31CE50FB-9054-42D9-ADAB-1D31675C0B53}'

update Products set [Description]='Зитмак 125мг тб №6
Торговое название
Зитмак 500
Зитмак 250
Зитмак 125

Международное непатентованное название
Азитромицин  
  Лекарственная форма Таблетки, покрытые пленочной оболочкой, 500 мг, 250 мг и 125 мг
Состав
Одна таблетка содержит
активное вещество - азитромицина дигидрат 524.0 мг или 262.0 мг или  131.0 мг эквивалентно 500 мг, 250 мг  и 125 мг азитромицина соответственно,
вспомогательные вещества: крахмал прежелатинизированный, LHPC 21, натрия лаурилсульфат, натрия кроскармеллоза, кальция гидрофосфат дигидрат, аэросил 200, лактоза безводная, магния стеарат,
состав оболочки: гидроксипропилметилцеллюлоза, целлюлоза микрокристаллическая, титана диоксид, макрогол – 40 ОЕ стеарат. 
Описание

Таблетки, покрытые пленочной оболочкой  белого цвета, продолговатой формы, с риской на одной стороне.

Фармакотерапевтическая группа

Противомикробные препараты для системного использования. Макролиды

Код АТС J01FA10' where id ='{6BA50BED-0490-41AA-83CD-3E02BD896378}'


select * from Products
select * from Products
update Products set [Description]='Супрастин 25мг тб №20 //
Торговое название 
Супрастин® 
 
Международное непатентованное название  
Хлоропирамин
 
Лекарственная форма   
Таблетки
 
Состав 
Одна таблетка содержит 
активное вещество -  хлоропирамина гидрохлорид 25 мг,
вспомогательные вещества: кислота стеариновая, желатин, натрия карбокиметилкрахмал (тип А), тальк, крахмал картофельный, лактозы моногидрат.
 
Описание 
Белые или серовато-белые таблетки в виде диска с фаской, с гравировкой «SUPRASTIN» на одной стороне и риской - на другой стороне таблетки, без или почти без запаха. 
 
Фармакотерапевтическая группа
Антигистаминные препараты системного действия. Этилендиамины замещенные. 
Код ATC R06A C03
 
Фармакологические свойства
Фармакокинетика
После приема внутрь хлоропирамин быстро всасывается из желудочно-кишечного тракта. Его терапевтический эффект развивается в течение 15-30 минут после приема внутрь, достигает максимума в течение первого часа после приема и сохраняется в течение 3-6 часов. Хорошо распределяется в организме, включая центральную нервную систему. Связывание с белками плазмы -  7,9%. Пик связывания отмечен при рН 7,4. Метаболизируется в печени. Выводится преимущественно почками в виде метаболитов. У детей выведение препарата происходит быстрее, чем у взрослых пациентов.' where id ='{97A36C2C-8079-4947-BAB8-72BC8138730E}'


update Products set [Description]='Гексавит драже №50 (Алтайвитамины)
Торговое название
Гексавит
 
Международное непатентованное название
Нет
 
Лекарственная форма
Драже
 
Состав
Одно драже содержит
активные вещества:      
ретинола пальмитат  (витамин А)                      2,75 мг (5000 МЕ)
тиамина гидрохлорид (витамин В1)                   2,00 мг
кислота аскорбиновая (витамин С)                             70,00 мг
рибофлавин (витамин В2)                                  2,00 мг
пиридоксина гидрохлорид (витамин В6)          2,00 мг
никотинамид                                                      15,00 мг
вспомогательные вещества: воск пчелиный, мука пшеничная, подсолнечника масло, патока крахмальная, сахароза (сахар), тальк, ароматизатор пищевой "Лимон".
 
Описание
Драже шарообразной формы, от желтого до желто-оранжевого цвета, со слабым характерным запахом.
 
Фармакотерапевтическая группа
 Витамины. Поливитамины.
Код АТХ A11ВА
 
Фармакологические свойства
Комплексный поливитаминный препарат, действие которого обусловлено эффектами входящих в его состав витаминов.' where id ='{AC806957-FBE4-4170-A7CE-586F55317C18}'



select * from Products

update Products set [Description] = '' where id='{7698524E-32F6-4ED7-AC01-B3F04D34070D}'


update Products set Count=Count+2 where id ='{6BA50BED-0490-41AA-83CD-3E02BD896378}'


203040506045