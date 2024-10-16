using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class VipersKiss : Dagger
{
    [Constructable]
    public VipersKiss()
    {
        Name = "Viper's Kiss";
        Hue = Utility.Random(1, 3000);
        MinDamage = Utility.RandomMinMax(20, 50);
        MaxDamage = Utility.RandomMinMax(100, 250);
        Attributes.BonusDex = 20;
        Attributes.AttackChance = 25;
        Slayer = SlayerName.ReptilianDeath;
        WeaponAttributes.HitPoisonArea = 60;
        WeaponAttributes.HitLeechStam = 30;
        SkillBonuses.SetValues(0, SkillName.Poisoning, 20.0);
        SkillBonuses.SetValues(1, SkillName.Hiding, 10.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public VipersKiss(Serial serial) : base(serial)
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
