using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for imuseInvitationRegistrationEntity
/// </summary>
/// 

namespace imuse.Common
{
    public class imuseInvitationRegistrationEntity
    {
        public imuseInvitationRegistrationEntity()
        {
        }

        private string userID;
        private string uFName;
        private string uMName;
        private string uLName;
        private string uEmailID;
        private string uEncryptedUEmail;
        private bool uInvitationStatus;
        private bool isUserRegistered;

        

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UFName
        {
            get { return uFName; }
            set { uFName = value; }
        }

        public string UMName
        {
            get { return uMName; }
            set { uMName = value; }
        }

        public string ULName
        {
            get { return uLName; }
            set { uLName = value; }
        }

        public string UEmailID
        {
            get { return uEmailID; }
            set { uEmailID = value; }
        }

        public string UEncryptedUEmail
        {
            get { return uEncryptedUEmail; }
            set { uEncryptedUEmail = value; }
        }

        public bool UInvitationStatus
        {
            get { return uInvitationStatus; }
            set { uInvitationStatus = value; }
        }
        
        public bool IsUserRegistered
        {
            get { return isUserRegistered; }
            set { isUserRegistered = value; }
        }
    }
}