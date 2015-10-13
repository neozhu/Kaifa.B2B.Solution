USE [STEST]
GO

/****** Object:  View [wmwhse1].[INVENTORYREPORT_SGHUB]    Script Date: 2015/10/13 9:00:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE  view [wmwhse1].[INVENTORYREPORT_SGHUB]
AS
select a.[SERIALKEY]
      ,a.[WHSEID]
      ,a.[STORERKEY]
	  ,a.[STORERDUNS]
      ,a.[SKU]
      ,a.[LOT]
      ,a.[LOTTABLE01]
      ,a.[LOTTABLE02]
      ,a.[LOTTABLE03]
      ,a.[LOTTABLE04]
      ,a.[LOTTABLE05]
      ,a.[LOTTABLE06]
      ,a.[LOTTABLE07]
      ,a.[LOTTABLE08]
      ,a.[LOTTABLE09]
      ,a.[LOTTABLE10]
      ,a.[EXTERNALLOT]
      ,a.[LOTTABLE11]
      ,a.[LOTTABLE12]
	  ,a.[STATUS]
      ,CAST((case WHEN a.[qty] > 0 then a.[QTY] else 0 end) as int) QTY
	  ,CAST((case WHEN a.[qty]< 0  then 0 - a.[QTY] else 0 end) as int) HOLDQTY    
      from
(SELECT t1.[SERIALKEY]
      ,t1.[WHSEID]
      ,t1.[STORERKEY]
	  ,t3.[DUNSID] as STORERDUNS
      ,t1.[SKU]
      ,t1.[LOT]
      ,max(t1.[LOTTABLE01]) [LOTTABLE01]
      ,max(t1.[LOTTABLE02]) [LOTTABLE02]
      ,max(t1.[LOTTABLE03]) [LOTTABLE03]
      ,max(t1.[LOTTABLE04]) [LOTTABLE04]
      ,max(t1.[LOTTABLE05]) [LOTTABLE05]
      ,t1.[LOTTABLE06] [LOTTABLE06]
      ,max(t1.[LOTTABLE07]) [LOTTABLE07]
      ,max(t1.[LOTTABLE08]) [LOTTABLE08]
      ,max(t1.[LOTTABLE09]) [LOTTABLE09]
      ,max(t1.[LOTTABLE10]) [LOTTABLE10]
      ,max(t1.[EXTERNALLOT]) [EXTERNALLOT]
      ,max(t1.[LOTTABLE11]) [LOTTABLE11]
      ,max(t1.[LOTTABLE12]) [LOTTABLE12]
	  ,t2.[STATUS]   
      ,SUM(t2.QTY) QTY        
  FROM [wmwhse1].[LOTATTRIBUTE] t1,
		[wmwhse1].[LOTXLOCXID] t2,
		 [wmwhse1].STORER t3
  where t1.[LOT] = t2.[LOT] and t1.[STORERKEY] = t3.[STORERKEY]  
  and t2.[QTY]>0 and t3.[TYPE] = '1'
  and t2.[status] = 'OK' 
  and t1.[LOTTABLE06] = 'OK'
  group by t1.[SERIALKEY]
      ,t1.[WHSEID]
      ,t1.[STORERKEY]
      ,t3.[DUNSID]
      ,t1.[SKU]
      ,t1.[LOT]
      ,t2.[STATUS]
      ,t1.[LOTTABLE06]
   union ALL   
   SELECT t1.[SERIALKEY]
      ,t1.[WHSEID]
      ,t1.[STORERKEY]
	  ,t3.[DUNSID] as STORERDUNS
      ,t1.[SKU]
      ,t1.[LOT]
      ,max(t1.[LOTTABLE01]) [LOTTABLE01]
      ,max(t1.[LOTTABLE02]) [LOTTABLE02]
      ,max(t1.[LOTTABLE03]) [LOTTABLE03]
      ,max(t1.[LOTTABLE04]) [LOTTABLE04]
      ,max(t1.[LOTTABLE05]) [LOTTABLE05]
      ,t1.[LOTTABLE06] [LOTTABLE06]
      ,max(t1.[LOTTABLE07]) [LOTTABLE07]
      ,max(t1.[LOTTABLE08]) [LOTTABLE08]
      ,max(t1.[LOTTABLE09]) [LOTTABLE09]
      ,max(t1.[LOTTABLE10]) [LOTTABLE10]
      ,max(t1.[EXTERNALLOT]) [EXTERNALLOT]
      ,max(t1.[LOTTABLE11]) [LOTTABLE11]
      ,max(t1.[LOTTABLE12]) [LOTTABLE12]
	  ,t2.[STATUS]  
      ,SUM(0-t2.QTY) HOLDQTY        
  FROM [wmwhse1].[LOTATTRIBUTE] t1,
		[wmwhse1].[LOTXLOCXID] t2,
		 [wmwhse1].STORER t3
  where t1.[LOT] = t2.[LOT] and t1.[STORERKEY] = t3.[STORERKEY]  
  and t2.[QTY]>0 and t3.[TYPE] = '1'
  and ((t2.[status] = 'OK' 
  and t1.[LOTTABLE06] <> 'OK') or (t2.[status] <> 'OK'))
  group by t1.[SERIALKEY]
      ,t1.[WHSEID]
      ,t1.[STORERKEY]
      ,t3.[DUNSID]
      ,t1.[SKU]
      ,t1.[LOT]
      ,t2.[STATUS]
      ,t1.[LOTTABLE06])a

GO


