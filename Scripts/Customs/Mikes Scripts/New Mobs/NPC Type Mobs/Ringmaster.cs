using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("corpse of a ringmaster")]
    public class Ringmaster : BaseCreature
    {
        private TimeSpan m_SpeechDelay = TimeSpan.FromSeconds(10.0); // time between ringmaster's speech
        private DateTime m_NextSpeechTime;
        
        [Constructable]
        public Ringmaster() : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Hue = Utility.RandomSkinHue();
            Body = 0x190; 
            Name = "Ringmaster";
            
            Item trousers = new LongPants(Utility.RandomRedHue());
            Item shirt = new FancyShirt(Utility.RandomNeutralHue());
            Item shoes = new Boots();

            AddItem(trousers);
            AddItem(shirt);
            AddItem(shoes);
            
            // Abilities and stats
			SetStr( 800, 1200 );
			SetDex( 177, 255 );
			SetInt( 151, 250 );

			SetHits( 600, 1000 );

			SetDamage( 10, 20 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Fire, 25 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 65, 80 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 25.1, 50.0 );
			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 95.5, 100.0 );
			SetSkill( SkillName.Meditation, 25.1, 50.0 );
			SetSkill( SkillName.MagicResist, 100.5, 150.0 );
			SetSkill( SkillName.Tactics, 90.1, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );
			SetSkill(SkillName.Anatomy, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Archery, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.ArmsLore, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Bushido, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Chivalry, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Fencing, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Lumberjacking, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Ninjitsu, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Parry, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Swords, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Tactics, Utility.RandomMinMax(50, 100));
			SetSkill(SkillName.Wrestling, Utility.RandomMinMax(50, 100));

			Tamable = true;
			ControlSlots = Utility.RandomMinMax(1, 5);
			MinTameSkill = Utility.RandomMinMax(1, 100);

			Fame = 6000;
			Karma = -6000;

			VirtualArmor = 58;

            m_NextSpeechTime = DateTime.Now + m_SpeechDelay;
        }

        public override void OnThink()
        {
            base.OnThink();

            if (DateTime.Now >= m_NextSpeechTime && Combatant != null)
            {
                int phrase = Utility.Random(3);

                switch (phrase)
                {
                    case 0: Say("Behold, the show begins!"); SummonCircusCreature(); break;
                    case 1: Say("Enter, my performers!"); SummonCircusCreature(); break;
                    case 2: Say("Let's spice up the performance!"); SummonCircusCreature(); break;
                }

                m_NextSpeechTime = DateTime.Now + m_SpeechDelay;
            }
        }
		
		public override int Damage(int amount, Mobile from)
		{
			Mobile combatant = this.Combatant as Mobile;

			if (combatant != null && combatant.Map == this.Map && combatant.InRange(this, 8))
			{
				if (Utility.RandomBool())
				{
					int phrase = Utility.Random(3);

					switch (phrase)
					{
						case 0: Say("Behold, the show begins!"); SummonCircusCreature(); break;
						case 1: Say("Enter, my performers!"); SummonCircusCreature(); break;
						case 2: Say("Let's spice up the performance!"); SummonCircusCreature(); break;
					}

					m_NextSpeechTime = DateTime.Now + m_SpeechDelay;				
				}
			}

			return base.Damage(amount, from);
		}

        public void SummonCircusCreature()
        {
            BaseCreature creature;

            switch (Utility.Random(3))
            {
                default:
                case 0: creature = new Jester(); break;
                case 1: creature = new EvilClown(); break;
                case 2: creature = new BlackBear(); break;
            }

            creature.MoveToWorld(this.Location, this.Map);
            creature.Combatant = this.Combatant;
        }

        public override void GenerateLoot()
        {
            PackGem();
            PackGold(200, 250);
			AddLoot(LootPack.Rich);  // Even richer loot than before
        }

        public Ringmaster(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
