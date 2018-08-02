USE [BTARNDATA]
GO
/****** Object:  StoredProcedure [dbo].[proc_GetActivityStatus]    Script Date: 09/16/2015 16:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[proc_GetActivityStatus]
(
 @PIPCode varchar(10),
 @PIPVersion varchar(20),
 @PIPInstanceID nvarchar(255),
 @SourcePartnerName nvarchar(255),
 @DestinationPartnerName nvarchar(255),
 @IsInitiatorActivity bit
)
AS
 
IF (@DestinationPartnerName = 'SEAGATE-AMK' and @PIPCode = 'SG_3B2')
BEGIN
 SET @PIPCode = '3B2'
END
 
IF (@DestinationPartnerName = 'SEAGATE-US' and @PIPCode = 'SG_3B2')
BEGIN
 SET @PIPCode = '3B2'
END
 
IF (@DestinationPartnerName = 'SEAGATE-USML' and @PIPCode = 'SG_3B2')
BEGIN
 SET @PIPCode = '3B2'
END
 
IF (@DestinationPartnerName = 'SEAGATE-AMK' and @PIPCode = 'SG_4B2')
BEGIN
 SET @PIPCode = '4B2'
END
 
IF (@DestinationPartnerName = 'SEAGATE-US' and @PIPCode = 'SG_4B2')
BEGIN
 SET @PIPCode = '4B2'
END
 
IF (@DestinationPartnerName = 'SEAGATE-USML' and @PIPCode = 'SG_4B2')
BEGIN
 SET @PIPCode = '4B2'
END
 
 
 DECLARE @sourcePartnerKey int
 DECLARE @destinationPartnerKey int
 DECLARE @ActivityID nvarchar(255)
 SET @sourcePartnerKey = '-1'
 SET @destinationPartnerKey = '-1'
 SELECT @sourcePartnerKey = PartnerKey FROM PartnerLookup WHERE PartnerName=@SourcePartnerName
 SELECT @destinationPartnerKey = PartnerKey FROM PartnerLookup WHERE PartnerName=@DestinationPartnerName
 SELECT TOP 1 CurrentStatus
  FROM ActivityTracking tblAT
  WHERE tblAT.PIPCode = @PIPCode AND
   tblAT.PIPVersion = @PIPVersion AND
   tblAT.PIPInstanceID = @PIPInstanceID AND
   tblAT.SourcePartnerKey = @sourcePartnerKey AND
   tblAT.DestinationPartnerKey = @destinationPartnerKey AND
   tblAT.IsInitiatorActivity = @IsInitiatorActivity





USE [BTARNCONFIG]
GO
/****** Object:  StoredProcedure [dbo].[GetTPAConfigData]    Script Date: 09/16/2015 16:47:17 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetTPAConfigData](
 @PIPCode char(20),
 @PIPVersion char(10),
 @HomePartnerName nvarchar(255),
 @TradingPartnerName nvarchar(255),
 @IsHomeRoleInitiator tinyint)
AS
 DECLARE @homePartnerKey int
 DECLARE @tradingPartnerKey int
 SET @homePartnerKey = '-1'
 SET @tradingPartnerKey = '-1'
 SELECT @homePartnerKey = PartnerKey FROM PartnerLookup WHERE PartnerName=@HomePartnerName
 SELECT @tradingPartnerKey = PartnerKey FROM PartnerLookup WHERE PartnerName=@TradingPartnerName
 if (@homePartnerKey = -1 and @HomePartnerName <> '')
 BEGIN
  INSERT INTO PartnerLookup(PartnerName) VALUES(@HomePartnerName)
  SELECT @homePartnerKey = @@IDENTITY
 END
 if (@tradingPartnerKey = -1 and @TradingPartnerName <> '')
 BEGIN
  INSERT INTO PartnerLookup(PartnerName) VALUES(@TradingPartnerName)
  SELECT @tradingPartnerKey = @@IDENTITY
 END
 
IF (@TradingPartnerName = 'SEAGATE-AMK' and @PIPCode = '3B2')
BEGIN
 SET @PIPCode = 'SG_' + @PIPCode
END
IF (@TradingPartnerName = 'SEAGATE-US' and @PIPCode = '3B2')
BEGIN
 SET @PIPCode = 'SG_' + @PIPCode
END
IF (@TradingPartnerName = 'SEAGATE-USML' and @PIPCode = '3B2')
BEGIN
 SET @PIPCode = 'SG_' + @PIPCode
END
 
IF (@TradingPartnerName = 'SEAGATE-AMK' and @PIPCode = '4B2')
BEGIN
 SET @PIPCode = 'SG_' + @PIPCode
END
IF (@TradingPartnerName = 'SEAGATE-US' and @PIPCode = '4B2')
BEGIN
 SET @PIPCode = 'SG_' + @PIPCode
END
IF (@TradingPartnerName = 'SEAGATE-USML' and @PIPCode = '4B2')
BEGIN
 SET @PIPCode = 'SG_' + @PIPCode
END
 
 SELECT tc.*
 FROM TPAConfig tc, PIPConfig pc
 WHERE @PIPCode = pc.Code
  AND @PIPVersion = pc.Version
  AND @homePartnerKey = tc.HomePartnerKey
  AND @tradingPartnerKey = tc.TradingPartnerKey
  AND pc.ID = tc.PIPID
  AND @IsHomeRoleInitiator = tc.IsHomeRoleInitiator
  AND Status = '1'
 ORDER BY tc.Name