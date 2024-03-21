using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Features
{
    public class InvitationCodesCollection
    {
        public List<(string, Guid)> invitationCodes;

        public InvitationCodesCollection()
        {
            invitationCodes = new List<(string, Guid)>();
        }

        public void AddInvitationCode(string email, Guid invitationCode)
        {
            invitationCodes.Add((email, invitationCode));
        }

        public bool CheckIfValidCode(string code)
        {
            return invitationCodes.Any(x => x.Item2.ToString() == code);
        }
    }
}
