create table MobileDetails(MobileName varchar (30)primary key,Model varchar (25),RamGb varchar (15),Version varchar (20),price int,MobileNo bigint)
insert into MobileDetails values('Vivo','Y12','128/4GB','Lolipop9',12000,5676543278)
insert into MobileDetails values('Oppo','Reno5','64/3GB','C9',15000,5675543278)
insert into MobileDetails values('Realme','Note5','128/8GB','SnapDrigen',16000,5676543878)
insert into MobileDetails values('Redmi','C9','128/3GB','Snapdrigen11+',10000,5676545278)
insert into MobileDetails values('SamsungGalexy','S12','132/8GB','Octocore',32000,5674143278)
insert into MobileDetails values('Nokia5G','XR20','128/4GB','Military',53000,5676043278)
insert into MobileDetails values('Honar','P50','128/6GB','SnapDrigen',30000,5676543278)
insert into MobileDetails values('oneplus','11','265/16GB','SnapDrigen8gen2',62000,5676643278)
insert into MobileDetails values('SonyExperia','Xq-Ct72','265/8GB','Snapdrigen',100000,5676540078)
insert into MobileDetails values('GooglePixel','7Pro','128/4GB','Stromy',43000,5606543278)

select * from MobileDetails where MobileName='GooglePixel'and Model='7Pro'
select * from MobileDetails where MobileName='GooglePixel'or price=25000 
select * from MobileDetails order by MobileName
select distinct Version from MobileDetails--do not repeated word print
select price  from MobileDetails order by LEN(price)









select *from MobileDetails