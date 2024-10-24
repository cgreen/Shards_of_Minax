using System;
using Server;
using Server.Items;
using Server.Mobiles;
using System.Collections.Generic;

namespace Server.Items
{
    public class WalrusFeeder : Barrel
    {
        private static List<WalrusFeeder> Feeders = new List<WalrusFeeder>();

        [Constructable]
        public WalrusFeeder()
        {
            Name = "Walrus Feeder";
            ItemID = 0x0E83;
            Feeders.Add(this);
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
            list.Add("Place Pears inside to raise walruses");
        }

        public static void Initialize()
        {
            EventSink.WorldSave += new WorldSaveEventHandler(OnWorldSave);
        }

        private static void OnWorldSave(WorldSaveEventArgs e)
        {
            foreach (WalrusFeeder feeder in Feeders)
            {
                if (feeder != null && !feeder.Deleted)
                {
                    feeder.CheckAndSpawnWalrus();
                }
            }
        }

        private void CheckAndSpawnWalrus()
        {
            Item pear = FindItemByType(typeof(Pear));

            if (pear != null && pear.Amount > 0)
            {
                pear.Consume(1); // Consume one pear
                Point3D walrusLocation = GetRandomAdjacentEmptyLocation();
                if (Map != null && walrusLocation != Point3D.Zero)
                {
                    Walrus walrus = new Walrus();
                    walrus.MoveToWorld(walrusLocation, Map);
                }
            }
        }

        private Point3D GetRandomAdjacentEmptyLocation()
        {
            List<Point3D> emptyLocations = new List<Point3D>();
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0) continue; // Skip the center spot
                    Point3D testPoint = new Point3D(X + x, Y + y, Z);
                    if (Map != null && Map.CanSpawnMobile(testPoint))
                        emptyLocations.Add(testPoint);
                }
            }

            if (emptyLocations.Count > 0)
                return emptyLocations[Utility.Random(emptyLocations.Count)];

            return Point3D.Zero; // No valid location found
        }

        public WalrusFeeder(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            Feeders.Add(this);
        }
    }
}
