using System;
using Server;

namespace Server.Items
{
    public class SweetsworthToken : Item
    {
        [Constructable]
        public SweetsworthToken() : base(0x2AAA) // Replace with the appropriate item ID
        {
            Weight = 1.0;
            Name = "Sweetsworth Token";
        }

        public SweetsworthToken(Serial serial) : base(serial)
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
}
