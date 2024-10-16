using System;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Engines.Quests;

namespace Server.Engines.Quests
{
    public class ActsOfSacrificeQuest : BaseQuest
    {
        public override bool DoneOnce { get { return false; } } // Repeatable
        public override object Title { get { return "Acts of Sacrifice"; } }
        public override object Description
        {
            get
            {
                return "Greetings, brave soul! The land is in need of sacrifice to balance the scales. " +
                       "You are tasked with either eliminating the cursed creatures or collecting cursed items. " +
                       "Return to me when your task is complete.";
            }
        }

        public override object Refuse { get { return "I understand. If you change your mind, seek me out."; } }

        public override object Uncomplete { get { return "The balance remains disturbed. Please complete your task."; } }

        public override object Complete { get { return "Your sacrifice has restored balance. Here is your reward."; } }

        private static List<Point3D> SpawnLocations = new List<Point3D>
        {
            new Point3D(1262, 504, -4),
            new Point3D(1304, 423, 31),
            new Point3D(1317, 340, 1),
            new Point3D(1389, 302, 32),
            new Point3D(1444, 246, 16),
            new Point3D(1510, 236, -13),
            new Point3D(1497, 288, -8),
            new Point3D(691, 1350, -58),			
            new Point3D(736, 1231, -58),
            new Point3D(680, 1224, -101),
            new Point3D(714, 1136, -81),
            new Point3D(620, 1152, -74),			
            new Point3D(490, 1211, -63),
            new Point3D(353, 1232, -41),
            new Point3D(379, 1099, -65),
            new Point3D(437, 1007, -91),			
            new Point3D(506, 979, -86),
            new Point3D(645, 1023, -83),
            new Point3D(686, 849, -67),
            new Point3D(730, 523, -54),			
            new Point3D(644, 450, -75),
            new Point3D(758, 341, -43),
            new Point3D(652, 297, -50),
            new Point3D(472, 415, -64),			
            new Point3D(387, 330, -50),
            new Point3D(285, 302, -55),
            new Point3D(692, 745, -34),
            new Point3D(1087, 1104, -30),			
            new Point3D(1195, 1238, -19),
            new Point3D(1272, 1292, -21),
            new Point3D(1410, 1249, -16),
            new Point3D(1563, 1231, -18),
            new Point3D(1671, 1134, -8),
            new Point3D(1649, 1028, -20),
            new Point3D(1554, 993, 3),
            new Point3D(1449, 986, -24)	
            // Add more dynamic locations as needed
        };

        private static List<Map> SpawnMaps = new List<Map>
        {
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar,
			Map.Ilshenar,
            Map.Ilshenar,
            Map.Ilshenar
            // Ensure this list matches the SpawnLocations list
        };

        private Mobile m_Target;
        private Item m_QuestItem;

        public ActsOfSacrificeQuest() : base()
        {
            // Randomly decide between kill or collect objective
            if (Utility.RandomBool())
            {
                // Kill Objective
                AddObjective(new SlayObjective(typeof(CursedBeast), "Cursed Beast", 1));
            }
            else
            {
                // Collection Objective
                AddObjective(new ObtainObjective(typeof(CursedItem), "Cursed Item", 1, 0x1F1)); // 0x1F1 is an example item ID
            }

            // Reward: Sacrifice Stone
            AddReward(new BaseReward(typeof(SacrificeStone), 1, "1 Sacrifice Stone"));
            AddReward(new BaseReward(typeof(Gold), 2000, "2000 Gold"));
        }

        public override void OnAccept()
        {
            base.OnAccept();

            int index = Utility.Random(SpawnLocations.Count);
            Point3D location = SpawnLocations[index];
            Map map = SpawnMaps[index];

            string objectiveMessage = "";  // Initialize with an empty string to avoid unassigned variable error

            // Dynamically spawn target or quest item based on objective
            if (Objectives[0] is SlayObjective)
            {
                // Spawn a Cursed Beast
                m_Target = new CursedBeast();
                m_Target.MoveToWorld(location, map);

                objectiveMessage = "A Cursed Beast has been spotted at " + location + " on the Ilshenar map. Seek it out and eliminate the threat.";
                Owner.SendMessage(objectiveMessage);
            }
            else if (Objectives[0] is ObtainObjective)
            {
                // Spawn Cursed Items
                SpawnCursedItems(location, map);

                objectiveMessage = "Cursed Items have been scattered around " + location + " on the Ilshenar map. Please collect them.";
                Owner.SendMessage(objectiveMessage);
            }

            // Give the player a note with the location of the quest objectives
            GiveSimpleNoteToPlayer(objectiveMessage);
        }

        private void SpawnCursedItems(Point3D location, Map map)
        {
            for (int i = 0; i < 5; i++) // Adjust the number if you want to spawn more items
            {
                Item item = new CursedItem();
                item.MoveToWorld(location, map);
            }
        }

        private void GiveSimpleNoteToPlayer(string message)
        {
            SimpleNote note = new SimpleNote();
            note.Name = "Objective Location";
            note.NoteMessage = message;
            Owner.AddToBackpack(note);
        }

        public override void OnCompleted()
        {
            base.OnCompleted();
            Owner.SendMessage("Your sacrifice has restored balance.");
            Owner.PlaySound(0x1F5); // Adjust sound if necessary
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
            // Serialize any additional fields if necessary
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            // Deserialize any additional fields if necessary
        }
    }
}
