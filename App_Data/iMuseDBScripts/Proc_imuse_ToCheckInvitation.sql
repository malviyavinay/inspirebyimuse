USE [imuse]
GO

/****** Object:  StoredProcedure [dbo].[Proc_imuse_SendInvitaion]    Script Date: 11/08/2012 16:40:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Proc_imuse_ToCheckInvitation]

@InvitedEMailID as varchar(100)

as

begin
    declare @status	as int
    set @status=(select InvitationSatus from imuse_Invitation where InvitationEMailID=@InvitedEMailID)

	if(@status is null)
		begin			
			select 'rtn'=0    -- 0 -- Not Exist or Invalid Email
		end
	else if(@status=0)
		begin
			select 'rtn'=1	  -- 1 -- Invited but Not Registered
		end
	else
		begin
			select 'rtn'=2    -- 2 -- Invited and Registered
		end
end

GO


