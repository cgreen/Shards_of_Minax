using System;
using Server.Items;
using Server.Network;

namespace Server.Mobiles
{
    [CorpseName("a lurking fear corpse")]
    public class Drolatic : BaseCreature
    {
        private DateTime m_NextTerrorize;
        private DateTime m_NextFeedOnFear;
        private DateTime m_NextDarkReflection;
        private DateTime m_NextFearAura;
        private bool m_AbilitiesInitialized;
        private bool m_FearAuraActive;

        [Constructable]
        public Drolatic()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "Drolatic the Lurking Fear";
            Body = 4; // Gargoyle body
            Hue = 1755; // Dark purple hue
			BaseSoundID = 372;

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

            m_AbilitiesInitialized = false; // Set the flag to false
            m_FearAuraActive = false;
        }

        public Drolatic(Serial serial)
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
                    Random rand = new Random();
                    m_NextTerrorize = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_NextFeedOnFear = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_NextDarkReflection = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_NextFearAura = DateTime.UtcNow + TimeSpan.FromSeconds(rand.Next(1, 30));
                    m_AbilitiesInitialized = true; // Set the flag to prevent re-initializing
                }

                if (DateTime.UtcNow >= m_NextTerrorize)
                {
                    Terrorize();
                }

                if (DateTime.UtcNow >= m_NextFeedOnFear)
                {
                    FeedOnFear();
                }

                if (DateTime.UtcNow >= m_NextDarkReflection)
                {
                    DarkReflection();
                }

                if (DateTime.UtcNow >= m_NextFearAura)
                {
                    FearAura();
                }
            }
        }

        private void Terrorize()
        {
            PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "* Drolatic instills terror in the air! *");
            PlaySound(0x1F2); // Horrible sound effect
            FixedEffect(0x376A, 10, 16);

            foreach (Mobile m in GetMobilesInRange(5))
            {
                if (m != this && m.Alive)
                {
                    m.SendMessage("You are overwhelmed with fear by Drolatic!");
                    // Reduce attack and defense capabilities
                    m.Damage((int)(m.Hits * 0.1), this);
                    m.FixedEffect(0x376A, 10, 16);
                }
            }

            m_NextTerrorize = DateTime.UtcNow + TimeSpan.FromSeconds(45);
        }

        private void FeedOnFear()
        {
            if (Combatant != null)
            {
                Mobile target = Combatant as Mobile;
                if (target.Alive)
                {
                    int damage = Utility.RandomMinMax(15, 25);
                    target.Damage(damage, this);
                    Hits = Math.Min(Hits + damage, HitsMax);
                    PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "* Drolatic feeds on your fear and becomes enraged! *");
                    PlaySound(0x1F5); // Dark sound effect

                    // Increase Drolatic's stats temporarily
                    SetStr(Str + 40);
                    SetDex(Dex + 30);
                    SetInt(Int + 20);
                    Timer.DelayCall(TimeSpan.FromSeconds(15), EndEnrage);
                }
            }

            m_NextFeedOnFear = DateTime.UtcNow + TimeSpan.FromSeconds(30);
        }

        private void EndEnrage()
        {
            SetStr(Str - 40);
            SetDex(Dex - 30);
            SetInt(Int - 20);
        }

        private void FearAura()
        {
            if (!m_FearAuraActive)
            {
                m_FearAuraActive = true;
                PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "* A chilling aura of fear surrounds Drolatic! *");
                PlaySound(0x1F3); // Fearful sound effect

                Timer.DelayCall(TimeSpan.FromSeconds(30), () => m_FearAuraActive = false);
            }

            foreach (Mobile m in GetMobilesInRange(3))
            {
                if (m != this && m.Alive)
                {
                    m.SendMessage("You feel a wave of dread from Drolatic's aura!");
                    m.Damage(5, this); // Periodic damage
                }
            }

            m_NextFearAura = DateTime.UtcNow + TimeSpan.FromSeconds(30);
        }

        private void DarkReflection()
        {
            PublicOverheadMessage(MessageType.Regular, 0x3B2, true, "* Drolatic summons dark reflections! *");
            PlaySound(0x1F5); // Dark sound effect
            FixedEffect(0x376A, 10, 16);

            Point3D loc = GetSpawnPosition(2);

            if (loc != Point3D.Zero)
            {
                DarkReflectionClone clone = new DarkReflectionClone(this);
                clone.MoveToWorld(loc, Map);

                Timer.DelayCall(TimeSpan.FromSeconds(30), new TimerCallback(delegate() 
                {
                    if (!clone.Deleted)
                        clone.Delete(); 
                }));

                m_NextDarkReflection = DateTime.UtcNow + TimeSpan.FromMinutes(2);
            }
        }

        private Point3D GetSpawnPosition(int range)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = X + Utility.RandomMinMax(-range, range);
                int y = Y + Utility.RandomMinMax(-range, range);
                int z = Map.GetAverageZ(x, y);

                Point3D p = new Point3D(x, y, z);

                if (Map.CanSpawnMobile(p))
                    return p;
            }

            return Point3D.Zero;
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
            m_AbilitiesInitialized = false; // Reset the initialization flag
            m_FearAuraActive = false;
        }
    }

    public class DarkReflectionClone : BaseCreature
    {
        private Mobile m_Master;

        public DarkReflectionClone(Mobile master)
            : base(AIType.AI_Melee, FightMode.None, 10, 1, 0.2, 0.4)
        {
            m_Master = master;

            Body = master.Body;
            Hue = master.Hue;
            Name = master.Name;

            SetStr(50);
            SetDex(50);
            SetInt(50);

            SetHits(100);

            SetDamage(5, 15);

            SetResistance(ResistanceType.Physical, 50);
            SetResistance(ResistanceType.Fire, 50);
            SetResistance(ResistanceType.Cold, 50);
            SetResistance(ResistanceType.Poison, 50);
            SetResistance(ResistanceType.Energy, 50);

            VirtualArmor = 40;
        }

        public DarkReflectionClone(Serial serial)
            : base(serial)
        {
        }

        public override bool DeleteCorpseOnDeath { get { return true; } }

        public override void OnThink()
        {
            if (m_Master == null || m_Master.Deleted)
            {
                Delete();
                return;
            }

            if (Combatant == null)
                Combatant = m_Master.Combatant;

            if (Combatant != null)
            {
                // Attack the combatant
                Combatant.Damage(Utility.RandomMinMax(5, 10), this);
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
            writer.Write(m_Master);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            m_Master = reader.ReadMobile();
        }
    }
}