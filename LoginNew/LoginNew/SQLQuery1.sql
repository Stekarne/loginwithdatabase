 USE [C:\USERS\AYSEN\DESKTOP\SOURCE\REPOS\LOGINNEW\LOGINNEW\TESTLOGIN.MDF]

GO


SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

create  PROC [dbo].[ContactAddOrEdit]

@mode varchar(20),

@ID int,

@username varchar(50),

@password varchar(50)

AS

BEGIN

IF @mode = 'Add'

BEGIN

       INSERT INTO login

       (

       username,

       password

       )

       VALUES

       (

       @username,

       @password

       )

END

ELSE

BEGIN

       UPDATE login

       SET

       username = @username,

       password = @password

       WHERE ID = @ID

END

 

 

END







 

