use TravelHub
Update dbo.�����
set ���� = (SELECT * FROM   OPENROWSET(BULK 'C:\003.jpg',SINGLE_BLOB) AS image)
where ID_������ = '23';
GO