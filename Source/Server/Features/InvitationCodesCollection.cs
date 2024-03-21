using System;
using System.Collections.Generic;

namespace Server.Features
{
    public class InvitationCodesCollection
    {
        public List<Guid> invitationCodes;

        public InvitationCodesCollection()
        {
            invitationCodes = new List<Guid>();
        }

        public void AddInvitationCode(Guid invitationCode)
        {
            invitationCodes.Add(invitationCode);
        }
    }
}
