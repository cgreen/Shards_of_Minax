using System;
using Server;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
    public class FootwearSlotChangeTarget : Target
    {
        private FootwearSlotChangeDeed m_Deed;

        public FootwearSlotChangeTarget(FootwearSlotChangeDeed deed) : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (m_Deed.Deleted || m_Deed.RootParent != from)
            {
                from.SendMessage("That deed is no longer valid.");
                return;
            }

            if (target is BaseClothing || target is BaseArmor)
            {
                Item item = (Item)target;
                item.Layer = Layer.Shoes; // Change to footwear slot
                from.SendMessage("The equip slot of the item has been changed to footwear.");
                m_Deed.Delete();
            }
            else
            {
                from.SendMessage("You cannot use the deed on that.");
            }
        }
    }

    public class FootwearSlotChangeDeed : Item
    {
        [Constructable]
        public FootwearSlotChangeDeed() : base(0x14F0)
        {
            Name = "Equip Slot Change Deed (Footwear)";
        }

        public FootwearSlotChangeDeed(Serial serial) : base(serial) { }

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

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendMessage("That needs to be in your backpack to use.");
            }
            else
            {
                from.SendMessage("Which piece of clothing or armor do you want to change the equip slot for?");
                from.Target = new FootwearSlotChangeTarget(this);
            }
        }
    }
}
