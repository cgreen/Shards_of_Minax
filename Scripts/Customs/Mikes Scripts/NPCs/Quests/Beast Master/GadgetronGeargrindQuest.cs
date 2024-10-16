using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Engines.Quests;
using System.Collections.Generic;

namespace Server.Engines.Quests
{
    public class GadgetronGeargrindQuest : BaseQuest
    {
        public override bool DoneOnce { get { return true; } }

        public override object Title { get { return "Gadgetron Geargrind's Mechanical Challenge"; } }

        public override object Description
        {
            get
            {
                return 
                    "Greetings, adventurer! I am Gadgetron Geargrind, master of all things mechanical. " +
                    "To prove your worth and gain access to my exclusive shop, you must demonstrate your " +
                    "skills by defeating some of the most advanced mechanical beasts ever constructed. Complete these tasks:\n\n" +
                    "1. Destroy an Aegis Construct.\n" +
                    "2. Overcome an Arbiter Drone.\n" +
                    "3. Defeat a Mimicron.\n" +
                    "4. Vanquish a Nemesis Unit.\n" +
                    "5. Obliterate an Omega Sentinel.\n" +
                    "6. Crush an Overlord Mk II.\n" +
                    "7. Annihilate a Phantom Automaton.\n" +
                    "8. Eradicate a Quantum Guardian.\n" +
                    "9. Deactivate a Synthroid Prime.\n" +
                    "10. Terminate a Talon Machine.\n\n" +
                    "Complete these tasks, and I will grant you access to my exclusive mechanical beast shop!";
            }
        }

        public override object Refuse { get { return "Very well. Return when you are ready to face the mechanical challenge."; } }

        public override object Uncomplete { get { return "You haven't completed all the tasks yet. Keep working on those mechanical beasts!"; } }

        public override object Complete { get { return "Excellent! You have proven yourself against the pinnacle of mechanical engineering. My shop is now open to you!"; } }

        public GadgetronGeargrindQuest() : base()
        {
            AddObjective(new SlayObjective(typeof(AegisConstruct), "Aegis Constructs", 1));
            AddObjective(new SlayObjective(typeof(ArbiterDrone), "Arbiter Drones", 1));
            AddObjective(new SlayObjective(typeof(Mimicron), "Microns", 1));
            AddObjective(new SlayObjective(typeof(NemesisUnit), "Nemesis Units", 1));
            AddObjective(new SlayObjective(typeof(OmegaSentinel), "Omega Sentinels", 1));
            AddObjective(new SlayObjective(typeof(OverlordMkII), "Overlord Mk IIs", 1));
            AddObjective(new SlayObjective(typeof(PhantomAutomaton), "Phantom Automatons", 1));
            AddObjective(new SlayObjective(typeof(QuantumGuardian), "Quantum Guardians", 1));
            AddObjective(new SlayObjective(typeof(SynthroidPrime), "Synthroid Primes", 1));
            AddObjective(new SlayObjective(typeof(TalonMachine), "Talon Machines", 1));

            AddReward(new BaseReward(typeof(Gold), 1500, "1500 Gold"));
            AddReward(new BaseReward(typeof(MechanicalToken), 1, "Mechanical Token"));
        }

        public override void OnCompleted()
        {
            Owner.SendMessage(0x23, "You have completed Gadgetron Geargrind's challenge!");
            Owner.AddToBackpack(new MechanicalToken());
            Owner.PlaySound(CompleteSound);
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


    public class GadgetronGeargrind : MondainQuester
    {
        public override bool IsActiveVendor { get { return true; } }

        public override void InitSBInfo()
        {
            m_SBInfos.Add(new SBGadgetronGeargrind());
        }

        [Constructable]
        public GadgetronGeargrind()
            : base("Gadgetron Geargrind", "Master of Mechanical Beasts")
        {
        }

        public GadgetronGeargrind(Serial serial)
            : base(serial)
        {
        }

        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = false;
            Race = Race.Human;

            Hue = Utility.RandomSkinHue();
            HairItemID = Utility.RandomList(0x203B, 0x2049, 0x2048);
            HairHue = Utility.RandomHairHue();
            FacialHairItemID = Utility.RandomList(0x203E, 0x203F, 0x2040, 0x2041, 0x204B, 0x204C, 0x204D);
            FacialHairHue = HairHue;
        }

        public override void InitOutfit()
        {
            AddItem(new Backpack());
            AddItem(new Boots(Utility.RandomNeutralHue()));
            AddItem(new LongPants(Utility.RandomNeutralHue()));
            AddItem(new FancyShirt(Utility.RandomNeutralHue()));
            AddItem(new Cloak(Utility.RandomNeutralHue()));
        }

        public override void VendorBuy(Mobile from)
        {
            PlayerMobile player = from as PlayerMobile;
            if (player != null)
            {
                Item token = player.Backpack.FindItemByType(typeof(MechanicalToken));
				Item masterToken = player.Backpack.FindItemByType(typeof(MasterToken));

                if (token != null || masterToken != null)
                {
                    SayTo(from, "Welcome to my mechanical beast shop!");
                    base.VendorBuy(from);
                }
                else
                {
                    SayTo(from, "You must have a Mechanical Token to access my shop.");
                }
            }
        }

        public override Type[] Quests
        {
            get
            {
                return new Type[]
                {
                    typeof(GadgetronGeargrindQuest)
                };
            }
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


    public class SBGadgetronGeargrind : SBInfo
    {
        private System.Collections.Generic.List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private IShopSellInfo m_SellInfo = new InternalSellInfo();

        public SBGadgetronGeargrind()
        {
        }

        public override System.Collections.Generic.List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }
        public override IShopSellInfo SellInfo { get { return m_SellInfo; } }

        public class InternalBuyInfo : System.Collections.Generic.List<GenericBuyInfo>
        {
            public InternalBuyInfo()
            {
                // Add the mechanical-themed creatures here
                Add(new AnimalBuyInfo(1, typeof(AegisConstruct), 2000, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(ArbiterDrone), 1800, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(Mimicron), 1500, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(NemesisUnit), 2200, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(OmegaSentinel), 2500, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(OverlordMkII), 2700, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(PhantomAutomaton), 2300, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(QuantumGuardian), 2400, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(SynthroidPrime), 2600, 10, 0x2F5, 0));
                Add(new AnimalBuyInfo(1, typeof(TalonMachine), 2800, 10, 0x2F5, 0));
            }
        }

        public class InternalSellInfo : GenericSellInfo
        {
            public InternalSellInfo()
            {
            }
        }
    }
}
