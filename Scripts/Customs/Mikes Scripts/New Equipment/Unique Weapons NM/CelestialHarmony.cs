using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class CelestialHarmony : Maul
{
    [Constructable]
    public CelestialHarmony()
    {
        Name = "Celestial Harmony";
        Hue = Utility.Random(1, 3000);
        MinDamage = Utility.RandomMinMax(35, 85);
        MaxDamage = Utility.RandomMinMax(100, 250);
        Attributes.BonusInt = 25;
        Attributes.LowerManaCost = 15;
        Attributes.SpellDamage = 10;
        Slayer = SlayerName.ArachnidDoom;
        WeaponAttributes.MageWeapon = -10;
        WeaponAttributes.HitMagicArrow = 50;
        SkillBonuses.SetValues(0, SkillName.Magery, 25.0);
        SkillBonuses.SetValues(1, SkillName.EvalInt, 15.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public CelestialHarmony(Serial serial) : base(serial)
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