using System;
using Server;
using Server.Spells;
using Server.Network;
using Server.Mobiles;

namespace Server.ACC.CSS.Systems.ForagersGuidebook
{
    public abstract class ForagersGuidebookSpell : CSpell
    {
        public ForagersGuidebookSpell(Mobile caster, Item scroll, SpellInfo info)
            : base(caster, scroll, info)
        {
        }

        public abstract SpellCircle Circle { get; }

        public override SkillName CastSkill { get { return SkillName.Camping; } }
        public override SkillName DamageSkill { get { return SkillName.Forensics; } }
        public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds(3 * CastDelaySecondsPerTick); } }
        public override bool ClearHandsOnCast { get { return false; } }

        public override void GetCastSkills(out double min, out double max)
        {
            min = RequiredSkill;
            max = RequiredSkill;
        }

        public override int GetMana()
        {
            return RequiredMana;
        }

        public override bool ConsumeReagents()
        {
            return true;
        }
        
        public override TimeSpan GetCastDelay()
        {
            return TimeSpan.FromSeconds(CastDelay);
        }
    }
}
