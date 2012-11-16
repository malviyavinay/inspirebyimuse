  
CREATE procedure [dbo].[Proc_imuse_SendInvitaion]  
  
@InvitationEMailID as varchar(100)  
  
as  
  
begin  
    declare @status as int  
    set @status=(select InvitationSatus from imuse_Invitation where InvitationEMailID=@InvitationEMailID)  
  
 if(@status is null)  
  begin  
   insert into imuse_Invitation(InvitationEMailID,InvitationSatus) values(@InvitationEMailID,'0')  
   select 'rtn'=0      
  end  
 else if(@status=0)  
  begin  
   select 'rtn'=1  
  end  
 else  
  begin  
   select 'rtn'=2  
  end  
end  