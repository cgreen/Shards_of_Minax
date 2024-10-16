using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class HarbingerOfTilence : QuarterStaff
{
    [Constructable]
    public HarbingerOfTilence()
    {
        Name = "Harbinger of Silence";
        Hue = Utility.Random(1, 3000);
        MinDamage = Utility.RandomMinMax(45, 95);
        MaxDamage = Utility.RandomMinMax(100, 250);
        Attributes.BonusInt = 25;
        Attributes.AttackChance = 15;
        Slayer = SlayerName.Exorcism;
        Slayer2 = SlayerName.ArachnidDoom;
        WeaponAttributes.HitLeechMana = 40;
        WeaponAttributes.HitDispel = 35;
        SkillBonuses.SetValues(0, SkillName.SpiritSpeak, 20.0);
        SkillBonuses.SetValues(1, SkillName.Necromancy, 15.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public HarbingerOfTilence(Serial serial) : base(serial)
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