using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class WhisperwindBow : Bow
{
    [Constructable]
    public WhisperwindBow()
    {
        Name = "Whisperwind Bow";
        Hue = Utility.Random(150, 2900);
        MinDamage = Utility.RandomMinMax(20, 55);
        MaxDamage = Utility.RandomMinMax(55, 80);
        Attributes.LowerRegCost = 10;
        Attributes.BonusDex = 10;
        Slayer = SlayerName.SummerWind;
        WeaponAttributes.HitEnergyArea = 20;
        SkillBonuses.SetValues(0, SkillName.Archery, 20.0);
        SkillBonuses.SetValues(1, SkillName.Healing, 10.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public WhisperwindBow(Serial serial) : base(serial)
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
