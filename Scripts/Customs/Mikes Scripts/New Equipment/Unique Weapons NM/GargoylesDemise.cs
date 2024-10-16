using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class GargoylesDemise : ExecutionersAxe
{
    [Constructable]
    public GargoylesDemise()
    {
        Name = "Gargoyle's Demise";
        Hue = Utility.Random(1, 3000);
        MinDamage = Utility.RandomMinMax(50, 90);
        MaxDamage = Utility.RandomMinMax(100, 250);
        Attributes.BonusHits = 40;
        Attributes.RegenHits = 3;
        Slayer = SlayerName.GargoylesFoe;
        Slayer2 = SlayerName.BalronDamnation;
        WeaponAttributes.HitFireball = 40;
        WeaponAttributes.BattleLust = 30;
        SkillBonuses.SetValues(0, SkillName.Lumberjacking, 20.0);
        SkillBonuses.SetValues(1, SkillName.Anatomy, 15.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public GargoylesDemise(Serial serial) : base(serial)
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
