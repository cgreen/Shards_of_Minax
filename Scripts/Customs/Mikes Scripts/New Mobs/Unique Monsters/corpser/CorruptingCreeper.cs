using System;
using Server.Items;
using Server.Network;

namespace Server.Mobiles
{
    [CorpseName("a corrupted vine corpse")]
    public class CorruptingCreeper : BaseCreature
    {
        private DateTime m_NextDecayField;
        private DateTime m_NextCorruptionTouch;
        private bool m_AbilitiesInitialized; // Flag to track if abilities have been initialized

        [Constructable]
        public CorruptingCreeper()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a corrupting creeper";
            Body = 8; // Corpser body
            Hue = 1390; // Unique dark green hue
			BaseSoundID = 684;

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
            SetResistance(ResistanceType.Poison, 100);
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

        public CorruptingCreeper(Serial serial)
            : base(serial)
        {
        }

		public override bool ReacquireOnMovement
		{
			get
			{
				return !Controlled;
			}
		}
		public override bool AutoDispel
		{
			get
			{
				return !Controlled;
			}
		}

		public override int TreasureMapLevel
		{
			get
			{
				return 5;
			}
		}
		
		public override bool CanAngerOnTame
		{
			get
			{
				return true;
			}
		}

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
                    m_NextDecayField = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_NextCorruptionTouch = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_AbilitiesInitialized = true; // Set the flag to prevent re-initializing
                }

                if (DateTime.UtcNow >= m_NextDecayField)
                {
                    DecayField();
                }

                if (DateTime.UtcNow >= m_NextCorruptionTouch)
                {
                    CorruptionTouch();
                }
            }
        }

        private void DecayField()
        {
            PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "*The Corrupting Creeper spreads decay!*");
            FixedEffect(0x376A, 10, 16); // Dark smoky effect

            foreach (Mobile m in GetMobilesInRange(5))
            {
                if (m != this && m.Alive)
                {
                    m.SendMessage("You are engulfed in a field of decay!");
                    AOS.Damage(m, this, Utility.RandomMinMax(10, 20), 0, 0, 0, 0, 100);
                }
            }

            m_NextDecayField = DateTime.UtcNow + TimeSpan.FromSeconds(30); // Fixed cooldown after ability use
        }

        private void CorruptionTouch()
        {
            if (Combatant is Mobile mobileCombatant && InRange(mobileCombatant, 1))
            {
                PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "*The Corrupting Creeper's touch inflicts corruption!*");

                int debuffAmount = Utility.RandomMinMax(10, 20);
                mobileCombatant.SendMessage("You feel a wave of corruption as the Creeper touches you!");
                AOS.Damage(mobileCombatant, this, 0, debuffAmount, 0, 0, 0, 0);
                
                // Reducing stats
                mobileCombatant.Str -= debuffAmount;
                mobileCombatant.Dex -= debuffAmount;
                mobileCombatant.Int -= debuffAmount;
            }

            m_NextCorruptionTouch = DateTime.UtcNow + TimeSpan.FromSeconds(20); // Fixed cooldown after ability use
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
