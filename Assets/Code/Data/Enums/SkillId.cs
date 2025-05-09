using System.ComponentModel;

namespace Code.Data.Enums
{
    public enum SkillId
    {
        None = -1,
        Attack = 0,
        SplitShot = 1,
        ShadowDash = 2,
        Repeater = 3,
        Reflexes = 4,
        OldBell = 50,
        Judgement = 67,
        DoubleKnives = 69,
        Lasso = 71,
        SlowTime = 74,
        ClosedBody = 157,
        Bombardment = 201,
        [Description("Summon the Guard")]
        SummonTheGuard = 203,
        Matadeira = 209,
        HolyRosary = 210,
        [Description("Veil of Quills")]
        VeilOfQuills = 211,
    }
}