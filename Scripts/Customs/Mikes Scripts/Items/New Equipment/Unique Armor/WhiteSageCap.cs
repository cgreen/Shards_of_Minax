using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class WhiteSageCap : LeatherCap
{
    [Constructable]
    public WhiteSageCap()
    {
        Name = "White Sage Cap";
        Hue = Utility.Random(750, 950);
        BaseArmorRating = Utility.RandomMinMax(20, 45);
        Attributes.BonusMana = 20;
        Attributes.LowerManaCost = 10;
        Attributes.RegenMana = 5;
        SkillBonuses.SetValues(0, SkillName.Healing, 15.0);
        SkillBonuses.SetValues(1, SkillName.Meditation, 10.0);
        ColdBonus = 10;
        EnergyBonus = 10;
        FireBonus = 5;
        PhysicalBonus = 10;
        PoisonBonus = 15;
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public WhiteSageCap(Serial serial) : base(serial)
    {
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