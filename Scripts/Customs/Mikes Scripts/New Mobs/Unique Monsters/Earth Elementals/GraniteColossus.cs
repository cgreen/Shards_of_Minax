using System;
using Server.Items;
using Server.Network;

namespace Server.Mobiles
{
    [CorpseName("a granite colossus corpse")]
    public class GraniteColossus : BaseCreature
    {
        private DateTime m_NextGraniteSlam;
        private DateTime m_NextGraniteArmor;
        private bool m_AbilitiesInitialized; // Flag to track if abilities have been initialized

        [Constructable]
        public GraniteColossus()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a granite colossus";
            Body = 14; // Large, stone-like body
            Hue = 1439; // Grayish granite hue
			BaseSoundID = 268;

            SetStr(1000, 1200);
            SetDex(177, 255);
            SetInt(151, 250);
			
            SetHits(700, 1200);
			
            SetDamage(29, 35);
			
            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Fire, 25);
            SetDamageType(ResistanceType.Energy, 25);

            SetResistance(ResistanceType.Physical, 65, 80);
            SetResistance(ResistanceType.Fire, 60, 80);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 65, 80);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.Anatomy, 25.1, 50.0);
            SetSkill(SkillName.EvalInt, 90.1, 100.0);
            SetSkill(SkillName.Magery, 95.5, 100.0);
            SetSkill(SkillName.Meditation, 25.1, 50.0);
            SetSkill(SkillName.MagicResist, 100.5, 150.0);
            SetSkill(SkillName.Tactics, 90.1, 100.0);
            SetSkill(SkillName.Wrestling, 90.1, 100.0);

            Fame = 24000;
            Karma = -24000;

            VirtualArmor = 90;
			
            Tamable = true;
            ControlSlots = 3;
            MinTameSkill = 93.9;

            m_AbilitiesInitialized = false; // Initialize flag
        }

        public GraniteColossus(Serial serial)
            : base(serial)
        {
        }

        public override bool ReacquireOnMovement => !Controlled;
        public override bool AutoDispel => !Controlled;
        public override int TreasureMapLevel => 5;
		public override bool CanAngerOnTame => true;
		public override void GenerateLoot()
		{
			this.AddLoot(LootPack.FilthyRich, 2);
			this.AddLoot(LootPack.Rich);
			this.AddLoot(LootPack.Gems, 8);
		}

        public override void OnThink()
        {
            base.OnThink();

            if (Combatant != null)
            {
                if (!m_AbilitiesInitialized)
                {
                    // Set random intervals for abilities
                    Random rand = new Random();
                    m_NextGraniteSlam = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_NextGraniteArmor = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 60));
                    m_AbilitiesInitialized = true; // Set the flag to prevent re-initializing
                }

                if (DateTime.UtcNow >= m_NextGraniteSlam)
                {
                    PerformGraniteSlam();
                }

                if (DateTime.UtcNow >= m_NextGraniteArmor)
                {
                    ApplyGraniteArmor();
                }
            }
        }

        private void ApplyGraniteArmor()
        {
            // Increase physical resistance by 50% for 15 seconds
            this.SetResistance(ResistanceType.Physical, 90, 105);
            Timer.DelayCall(TimeSpan.FromSeconds(15), () =>
            {
                this.SetResistance(ResistanceType.Physical, 60, 70);
            });

            // Set the next time Granite Armor can be applied
            Random rand = new Random();
            m_NextGraniteArmor = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(30, 60));
        }

        private void PerformGraniteSlam()
        {
            if (Combatant != null)
            {
                Mobile target = Combatant as Mobile;
                if (target != null && target.Alive)
                {
                    int damage = Utility.RandomMinMax(50, 70);
                    target.Damage(damage, this);

                    // Knock back effect
                    if (Utility.RandomBool())
                    {
                        Point3D targetLoc = target.Location;
                        target.Location = new Point3D(targetLoc.X + Utility.RandomMinMax(-2, 2), targetLoc.Y + Utility.RandomMinMax(-2, 2), targetLoc.Z);
                        target.SendMessage("You are knocked back by the colossus's slam!");
                    }

                    PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "* The granite colossus slams the ground with tremendous force! *");

                    // Set the next time Granite Slam can be performed
                    Random rand = new Random();
                    m_NextGraniteSlam = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(30, 60));
                }
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
            
            m_AbilitiesInitialized = false; // Reset flag on deserialize
        }
    }
}
