USE Sample


Create Table BusInfo
(
 BusId int  primary key,
 BoardingPoint nvarchar(20),
 TravelDate DATE,
 Amount decimal(10,2),
 Rating int 
)

Insert into BusInfo values(1,'BGL','2017-06-18',400.65,2)
Insert into BusInfo values(2,'HYD','2017-10-05',600.00,3)
Insert into BusInfo values(3,'CHN','2016-07-25',445.95,3)
Insert into BusInfo values(4,'PUN','2017-12-10',543.00,4)
Insert into BusInfo values(5,'MUM','2017-01-28',500.50,4)
Insert into BusInfo values(6,'PUN','2016-03-27',333.55,3)
Insert into BusInfo values(7,'MUM','2016-11-06',510.00,4)

Select * from BusInfo

Create Procedure addBus
 @BusId int ,
 @BoardingPoint nvarchar(20),
 @TravelDate DATE,
 @Amount decimal(10,2),
 @Rating int 
 as 
 Begin
  Insert into BusInfo values(@BusId,@BoardingPoint,@TravelDate,@Amount,@Rating)
  End