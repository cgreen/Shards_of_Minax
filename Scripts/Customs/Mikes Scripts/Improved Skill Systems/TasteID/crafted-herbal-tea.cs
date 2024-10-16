using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
    public class CraftedHerbalTea : Food
    {
        [Constructable]
        public CraftedHerbalTea() : base(0x15FC)
        {
            Weight = 1.0;
            FillFactor = 1;
            Name = "Crafted Herbal Tea";
			Hue = 2634;
        }

        public CraftedHerbalTea(Serial serial) : base(serial)
        {
        }

        public override bool Eat(Mobile from)
        {
            if (from.Skills[SkillName.TasteID].Base < 70.0)
            {
                from.SendMessage("You need at least 70 Taste Identification skill to enjoy this.");
                return false;
            }

            int bonusValue = 20 + (int)((from.Skills[SkillName.TasteID].Value - 70) / 3);
            from.AddStatMod(new StatMod(StatType.Dex, "CraftedHerbalTea_Dex", bonusValue, TimeSpan.FromMinutes(35)));
            from.AddStatMod(new StatMod(StatType.Int, "CraftedHerbalTea_ManaRegen", 5, TimeSpan.FromMinutes(35)));
            from.SendMessage("You feel more agile and your mind feels clearer!");

            return base.Eat(from);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}