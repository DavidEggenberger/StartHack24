using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool CheckIfValidCode(string code)
        {
            return invitationCodes.Any(x => x.ToString() == code);
        }
    }
}
