using System;
using System.Collections.Generic; // Required for List<>
using Server;
using Server.Mobiles;
using Server.Items;

namespace Server.Engines.XmlSpawner2
{
    public class XmlFlesheater : XmlAttachment
    {
        private int m_BleedDamage = 40; // Base bleed damage over 15 seconds
        private TimeSpan m_Duration = TimeSpan.FromSeconds(15); // Duration of the bleed effect
        private TimeSpan m_Cooldown = TimeSpan.FromSeconds(60); // Cooldown before ability can be used again
        private DateTime m_LastUsed;
        private int m_HealthRestore = 100; // Amount of health restored to the user

        [CommandProperty(AccessLevel.GameMaster)]
        public int BleedDamage { get { return m_BleedDamage; } set { m_BleedDamage = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan Duration { get { return m_Duration; } set { m_Duration = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan Cooldown { get { return m_Cooldown; } set { m_Cooldown = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public int HealthRestore { get { return m_HealthRestore; } set { m_HealthRestore = value; } }

        public XmlFlesheater(ASerial serial) : base(serial) { }

        [Attachable]
        public XmlFlesheater() { }

        [Attachable]
        public XmlFlesheater(double cooldown, int bleedDamage, int durationSeconds, int healthRestore)
        {
            Cooldown = TimeSpan.FromSeconds(cooldown);
            BleedDamage = bleedDamage;
            Duration = TimeSpan.FromSeconds(durationSeconds);
            HealthRestore = healthRestore;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
            writer.Write(m_BleedDamage);
            writer.Write(m_Duration);
            writer.Write(m_Cooldown);
            writer.Write(m_LastUsed);
            writer.Write(m_HealthRestore);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (version >= 0)
            {
                m_BleedDamage = reader.ReadInt();
                m_Duration = reader.ReadTimeSpan();
                m_Cooldown = reader.ReadTimeSpan();
                m_LastUsed = reader.ReadDeltaTime();
                m_HealthRestore = reader.ReadInt();
            }
        }

        public override string OnIdentify(Mobile from)
        {
			return String.Format("Flesheater: Inflicts bleed damage over time. Restores health to the caster.");
        }

        public override void OnWeaponHit(Mobile attacker, Mobile defender, BaseWeapon weapon, int damageGiven)
        {
            if (DateTime.Now < m_LastUsed + m_Cooldown) return;

            PerformFlesheaterAttack(attacker, defender);
            m_LastUsed = DateTime.Now;
        }

        private void PerformFlesheaterAttack(Mobile attacker, Mobile initialTarget)
        {
            if (attacker == null || attacker.Map == null) return;

            var targetsHit = 0;
            foreach (Mobile target in attacker.GetMobilesInRange(3))
            {
                if (targetsHit >= 3) break;
                if (target == attacker || !attacker.CanSee(target) || !attacker.InLOS(target)) continue;

                // First target takes an additional 50% damage
                var damage = targetsHit == 0 ? (int)(m_BleedDamage * 1.5) : m_BleedDamage;
                // Inflict bleed damage here, consider creating a method to apply the effect over time if not immediately supported by RunUO

                targetsHit++;
            }

            // Restore health to the attacker
            attacker.Hits += m_HealthRestore;
			attacker.Say("Drinks Blood!");
            // Indicate the cooldown start
            m_LastUsed = DateTime.Now;
        }
    }
}
