using System;
using System.Linq;

using Server.Targeting;

namespace Server.Items
{
    public interface ILockpickable : IPoint2D
    {
        int LockLevel { get; set; }
        bool Locked { get; set; }
        Mobile Picker { get; set; }
        int MaxLockLevel { get; set; }
        int RequiredSkill { get; set; }
        void LockPick(Mobile from);
    }

    [FlipableAttribute(0x14fc, 0x14fb)]
    public class Lockpick : Item
    {
        public virtual bool IsSkeletonKey { get { return false; } }
        public virtual int SkillBonus { get { return 0; } }

        [Constructable]
        public Lockpick()
            : this(1)
        {
        }

        [Constructable]
        public Lockpick(int amount)
            : base(0x14FC)
        {
            Stackable = true;
            Amount = amount;
        }

        public Lockpick(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (version == 0 && Weight == 0.1)
                Weight = -1;
        }

        public override void OnDoubleClick(Mobile from)
        {
            from.SendLocalizedMessage(502068); // What do you want to pick?
            from.Target = new InternalTarget(this);
        }

        public virtual void OnUse()
        {
        }

        protected virtual void BeginLockpick(Mobile from, ILockpickable item)
        {
            if (item.Locked)
            {
                if (item is TreasureMapChest && TreasureMapInfo.NewSystem && !((TreasureMapChest)item).Guardians.All(g => g.Deleted))
                {
                    from.SendLocalizedMessage(1115991); // You must destroy all the guardians before you can unlock the chest.
                }
                else
                {
                    from.PlaySound(0x241);
                    Timer.DelayCall(TimeSpan.FromMilliseconds(200.0), EndLockpick, new object[] { item, from });
                }
            }
            else
            {
                // The door is not locked
                from.SendLocalizedMessage(502069); // This does not appear to be locked
            }
        }

        protected virtual void BrokeLockPickTest(Mobile from)
        {
            // When failed, a 25% chance to break the lockpick
            if (!IsSkeletonKey && Utility.Random(4) == 0)
            {
                // You broke the lockpick.
                SendLocalizedMessageTo(from, 502074);

                from.PlaySound(0x3A4);
                Consume();
            }
        }

		protected virtual void EndLockpick(object state)
		{
			object[] objs = (object[])state;
			ILockpickable lockpickable = objs[0] as ILockpickable;
			Mobile from = objs[1] as Mobile;

			Item item = (Item)lockpickable;

			if (!from.InRange(item.GetWorldLocation(), 1))
				return;

			if (lockpickable.LockLevel == 0 || lockpickable.LockLevel == -255)
			{
				// LockLevel of 0 means that the door can't be picklocked
				// LockLevel of -255 means it's magic locked
				item.SendLocalizedMessageTo(from, 502073); // This lock cannot be picked by normal means
				return;
			}

			if (from.Skills[SkillName.Lockpicking].Value < lockpickable.RequiredSkill - SkillBonus)
			{
				// The LockLevel is higher than the LockPicking of the player
				item.SendLocalizedMessageTo(from, 502072); // You don't see how that lock can be manipulated.
				return;
			}

			int maxlevel = lockpickable.MaxLockLevel;
			int minLevel = lockpickable.LockLevel;

			if (lockpickable is Skeletonkey)
			{
				minLevel -= SkillBonus;
				maxlevel -= SkillBonus; // Regulars subtract the bonus from the max level
			}

			bool success = this is MasterSkeletonKey || from.CheckTargetSkill(SkillName.Lockpicking, lockpickable, minLevel, maxlevel);

			if (success)
			{
				// Success! Pick the lock!
				OnUse();

				item.SendLocalizedMessageTo(from, 502076); // The lock quickly yields to your skill.
				from.PlaySound(0x4A);
				lockpickable.LockPick(from);

				// Increase skill by 0.5 on successful attempt
				if (from.Skills[SkillName.Lockpicking].Value < from.Skills[SkillName.Lockpicking].Cap)
				{
					from.Skills[SkillName.Lockpicking].Base += 0.5;
					if (from.Skills[SkillName.Lockpicking].Base > from.Skills[SkillName.Lockpicking].Cap)
						from.Skills[SkillName.Lockpicking].Base = from.Skills[SkillName.Lockpicking].Cap;
				}
			}
			else
			{
				// The player failed to pick the lock
				BrokeLockPickTest(from);
				item.SendLocalizedMessageTo(from, 502075); // You are unable to pick the lock.

				// Increase skill by 0.1 on failed attempt
				if (from.Skills[SkillName.Lockpicking].Value < from.Skills[SkillName.Lockpicking].Cap)
				{
					from.Skills[SkillName.Lockpicking].Base += 0.1;
					if (from.Skills[SkillName.Lockpicking].Base > from.Skills[SkillName.Lockpicking].Cap)
						from.Skills[SkillName.Lockpicking].Base = from.Skills[SkillName.Lockpicking].Cap;
				}

				if (item is TreasureMapChest)
				{
					var chest = (TreasureMapChest)item;

					if (TreasureMapInfo.NewSystem)
					{
						if (!chest.FailedLockpick)
						{
							chest.FailedLockpick = true;
						}
					}
					else if (chest.Items.Count > 0 && 0.25 > Utility.RandomDouble())
					{
						Item toBreak = chest.Items[Utility.Random(chest.Items.Count)];

						if (!(toBreak is Container))
						{
							toBreak.Delete();
							Effects.PlaySound(item.Location, item.Map, 0x1DE);
							from.SendMessage(0x20, "The sound of gas escaping is heard from the chest.");
						}
					}
				}
			}
		}


        private class InternalTarget : Target
        {
            private Lockpick m_Item;

            public InternalTarget(Lockpick item)
                : base(1, false, TargetFlags.None)
            {
                m_Item = item;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (m_Item.Deleted)
                    return;

                if (targeted is ILockpickable)
                {
                    m_Item.BeginLockpick(from, (ILockpickable)targeted);
                }
                else
                {
                    from.SendLocalizedMessage(501666); // You can't unlock that!
                }
            }
        }
    }
}
