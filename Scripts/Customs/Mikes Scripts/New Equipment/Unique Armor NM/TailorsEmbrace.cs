using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class TailorsEmbrace : PlateChest
{
    [Constructable]
    public TailorsEmbrace()
    {
        Name = "Tailor's Embrace";
        Hue = Utility.Random(1, 3000);
        BaseArmorRating = Utility.RandomMinMax(65, 75);
        ArmorAttributes.DurabilityBonus = 100;
        ArmorAttributes.LowerStatReq = 50;
        Attributes.BonusInt = 30;
        Attributes.Luck = 200;
        Attributes.EnhancePotions = 50;
        SkillBonuses.SetValues(0, SkillName.Tailoring, 50.0);
        SkillBonuses.SetValues(1, SkillName.Stealing, 30.0);
        PhysicalBonus = 20;
        ColdBonus = 15;
        FireBonus = 15;
        EnergyBonus = 25;
        PoisonBonus = 15;
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public TailorsEmbrace(Serial serial) : base(serial)
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
