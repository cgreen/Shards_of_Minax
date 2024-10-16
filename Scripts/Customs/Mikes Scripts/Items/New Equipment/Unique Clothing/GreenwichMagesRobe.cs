using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class GreenwichMagesRobe : Robe
{
    [Constructable]
    public GreenwichMagesRobe()
    {
        Name = "Greenwich Mage's Robe";
        Hue = Utility.Random(1, 2500);
        Attributes.LowerManaCost = 10;
        Attributes.CastSpeed = 1;
        SkillBonuses.SetValues(0, SkillName.Magery, 20.0);
        Resistances.Energy = 20;
		XmlAttach.AttachTo(this, new XmlLevelItem());
    }

    public GreenwichMagesRobe(Serial serial) : base(serial)
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