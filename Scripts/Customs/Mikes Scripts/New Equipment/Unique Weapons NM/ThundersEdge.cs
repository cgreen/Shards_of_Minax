using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class ThundersEdge : LargeBattleAxe
{
    [Constructable]
    public ThundersEdge()
    {
        Name = "Thunder's Edge";
        Hue = Utility.Random(1, 3000);
        MinDamage = Utility.RandomMinMax(55, 95);
        MaxDamage = Utility.RandomMinMax(100, 250);
        Attributes.WeaponSpeed = 25;
        Attributes.CastSpeed = -1;
        Slayer = SlayerName.BloodDrinking;
        Slayer2 = SlayerName.DragonSlaying;
        WeaponAttributes.HitLightning = 35;
        WeaponAttributes.HitLowerAttack = 20;
        SkillBonuses.SetValues(0, SkillName.Lumberjacking, 20.0);
        SkillBonuses.SetValues(1, SkillName.Chivalry, 15.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public ThundersEdge(Serial serial) : base(serial)
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
