using System;
using Server;
using Server.Mobiles;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
    // ---------------------------------------------------
    // Bee Circle Materia
    // This materia, when socketed, allows the bearer to summon a circle of bees to attack nearby foes
    // ---------------------------------------------------

    public class BeeCircleMateria : BaseSocketAugmentation
    {
        [Constructable]
        public BeeCircleMateria() : base(0x2809) // Use the item ID for your materia graphic
        {
            Name = "Bee Circle Materia";
            Hue = Utility.RandomMinMax(1, 3000); // Generate a random hue between 1 and 3000
        }
        
        public override int SocketsRequired { get { return 1; } } // Adjust number of sockets required as needed
        
        public override int Icon { get { return 0x2809; } } // Icon for the socketing menu

        public override int IconXOffset { get { return 8; } } // X axis icon offset in the socketing menu

        public override int IconYOffset { get { return 20; } } // Y axis icon offset in the socketing menu

        public BeeCircleMateria(Serial serial) : base(serial)
        {
        }

        public override string OnIdentify(Mobile from)
        {
            return "Summons a circle of bees to attack nearby foes.";
        }

        public override bool OnAugment(Mobile from, object target)
        {
            if (target is BaseWeapon || target is BaseArmor) // Allows for weapon or armor augmentation
            {
                // Attach the Bee Circle effect with specified parameters (example: refractory 15 seconds, damage 20, radius 5, thickness 1)
                XmlAttach.AttachTo(target, new XmlBeeCircle(15.0, 20, 5, 1));
                return true;
            }
            return false;
        }

        public override bool CanAugment(Mobile from, object target)
        {
            // Can augment both weapons and armor
            return target is BaseWeapon || target is BaseArmor;
        }

        public override bool CanRecover(Mobile from, object target, int version)
        {
            // Can recover from both weapons and armor
            return target is BaseWeapon || target is BaseArmor;
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
