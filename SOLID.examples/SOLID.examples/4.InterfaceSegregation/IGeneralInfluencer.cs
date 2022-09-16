using SOLID.examples.SingleResponsibility;

namespace SOLID.examples.InterfaceSegregation
{
    public interface IGeneralInfluencer
    {
        void ApplyFear(CultMember cultist);
        void ApplyHope(CultMember cultist);
        int AssessPotentialToManipulate();
        bool Bluff();
        bool Charm();
        void DemandPurity(CultMember cultist);
        bool Intimidate();
        void IsolateFromFriendsAndFamily(CultMember cultist);
        bool IsThisGoodForMe();
        bool UseDiplomacy();
    }
}