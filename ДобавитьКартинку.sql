use TravelHub
Update dbo.Номер
set Фото = (SELECT * FROM   OPENROWSET(BULK 'C:\003.jpg',SINGLE_BLOB) AS image)
where ID_Номера = '23';
GO