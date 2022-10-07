Begin transaction;
Delete from dbo.Periods;
Insert into dbo.Periods (PeriodId, [Year], [Quarter], [DateFirst], [DateEnd]) values ('IV квартал 2014 г', 2014, 4, '2014-10-01', '2014-12-31 23:59:59');
Insert into dbo.Periods (PeriodId, [Year], [Quarter], [DateFirst], [DateEnd]) values ('I квартал 2015 г', 2015, 1, '2015-01-01', '2015-03-31 23:59:59');
Insert into dbo.Periods (PeriodId, [Year], [Quarter], [DateFirst], [DateEnd]) values ('II квартал 2015 г', 2015, 2, '2015-04-01', '2015-06-30 23:59:59');
Insert into dbo.Periods (PeriodId, [Year], [Quarter], [DateFirst], [DateEnd]) values ('III квартал 2015 г', 2015, 3, '2015-07-01', '2015-09-30 23:59:59');
Insert into dbo.Periods (PeriodId, [Year], [Quarter], [DateFirst], [DateEnd]) values ('IV квартал 2015 г', 2015, 4, '2015-10-01', '2015-12-31 23:59:59');
commit;
Select * From dbo.Periods;
