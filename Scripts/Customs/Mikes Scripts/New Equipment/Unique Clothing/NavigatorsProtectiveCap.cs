using System;
using Server;
using Server.Items;
using Server.Engines.XmlSpawner2;

public class NavigatorsProtectiveCap : Cap
{
    [Constructable]
    public NavigatorsProtectiveCap()
    {
        Name = "Navigator's Protective Cap";
        Hue = Utility.Random(400, 2400);
        ClothingAttributes.LowerStatReq = 4;
        Attributes.NightSight = 1;
        SkillBonuses.SetValues(0, SkillName.Cartography, 20.0);
        SkillBonuses.SetValues(1, SkillName.DetectHidden, 10.0);
        Resistances.Cold = 10;
        Resistances.Physical = 15;
    }

    public NavigatorsProtectiveCap(Serial serial) : base(serial)
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
