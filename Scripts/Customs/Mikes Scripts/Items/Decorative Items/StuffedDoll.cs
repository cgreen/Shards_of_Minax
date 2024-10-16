using System;
using Server;
using Server.Items;
using Server.Network;

public class StuffedDoll : Item
{
    private static int[] Graphics = new int[]
    {
        0xAC46, 0xAC47, 0xAC48, 0xAC7B, 0xAC7C, 0xAC7D
    };

    [Constructable]
    public StuffedDoll() : base(Graphics[Utility.Random(Graphics.Length)])
    {
        Name = "Stuffed Doll";
        Hue = Utility.Random(1, 3000);

        // Setting the weight to be consistent with other items
        Weight = 1.0;
    }

    public override void OnDoubleClick(Mobile from)
    {
        if (!from.InRange(GetWorldLocation(), 1))
        {
            from.SendLocalizedMessage(500446); // That is too far away.
        }
        else
        {
            from.SendMessage("You find the art wonderful!");
            from.FixedParticles(0x373A, 10, 15, 5018, EffectLayer.Waist);
            from.PlaySound(0x1E0); // Coin sound
        }
    }

    public StuffedDoll(Serial serial) : base(serial)
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