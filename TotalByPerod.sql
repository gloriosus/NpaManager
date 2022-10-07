begin
declare @PeriodId varchar(1024);
set @PeriodId = 'I квартал 2015 г';
Select sum(a.Qty) as TotalQty From (
	  Select Count(*) as Qty From NpaI Where PeriodId = @PeriodId
	  UNION ALL
	  Select Count(*) as Qty From NpaII Where PeriodId = @PeriodId
	  UNION ALL
	  Select Count(*) as Qty From NpaIII Where PeriodId = @PeriodId
	  UNION ALL
	  Select Count(*) as Qty From NpaIV Where PeriodId = @PeriodId
	) a;
end