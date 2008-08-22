using System;
using OpenMetaverse;

namespace Simian
{
    public interface IAvatarManager
    {
        bool SetDefaultAnimation(Agent agent, UUID animID);
        bool AddAnimation(Agent agent, UUID animID);
        bool RemoveAnimation(Agent agent, UUID animID);
        void SendAnimations(Agent agent);
    }
}
