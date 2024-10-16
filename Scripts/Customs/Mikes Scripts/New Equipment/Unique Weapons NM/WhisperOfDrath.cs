using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class WhisperOfDrath : Kryss
{
    [Constructable]
    public WhisperOfDrath()
    {
        Name = "Whisper of Death";
        Hue = Utility.Random(1, 3000);
        MinDamage = Utility.RandomMinMax(20, 50);
        MaxDamage = Utility.RandomMinMax(100, 250);
        Attributes.BonusDex = 25;
        Attributes.BonusHits = 10;
        Slayer = SlayerName.LizardmanSlaughter;
        Slayer2 = SlayerName.ScorpionsBane;
        WeaponAttributes.HitFatigue = 30;
        WeaponAttributes.HitLowerAttack = 40;
        SkillBonuses.SetValues(0, SkillName.Ninjitsu, 20.0);
        SkillBonuses.SetValues(1, SkillName.Hiding, 20.0);
        XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public WhisperOfDrath(Serial serial) : base(serial)
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
