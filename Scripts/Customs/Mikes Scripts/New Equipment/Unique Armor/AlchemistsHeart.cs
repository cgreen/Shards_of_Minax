using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class AlchemistsHeart : PlateChest
{
    [Constructable]
    public AlchemistsHeart()
    {
        Name = "Alchemist's Heart";
        Hue = Utility.Random(500, 750);
        BaseArmorRating = Utility.RandomMinMax(40, 80);
        AbsorptionAttributes.EaterFire = 15;
        ArmorAttributes.LowerStatReq = 20;
        Attributes.BonusMana = 25;
        Attributes.EnhancePotions = 15;
        SkillBonuses.SetValues(0, SkillName.TasteID, 20.0);
        ColdBonus = 10;
        EnergyBonus = 10;
        FireBonus = 15;
        PhysicalBonus = 10;
        PoisonBonus = 10;
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public AlchemistsHeart(Serial serial) : base(serial)
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
