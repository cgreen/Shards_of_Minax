using System;
using System.Collections.Generic;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Commands;

namespace Server.Gumps
{
    public class PowerscrollMVendor
    {
        public static void Initialize()
        {
            CommandSystem.Register("ps90", AccessLevel.Player, new CommandEventHandler(OpenPowerscrolls_OnCommand));
        }

        [Usage("ps90")]
        [Description("Opens a visual representation of available Powerscroll 90.")]
        public static void OpenPowerscrolls_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            if (from != null && from is PlayerMobile)
            {
                PlayerMobile pm = (PlayerMobile)from;
                from.CloseGump(typeof(PowerscrollMVendorGump));
                from.SendGump(new PowerscrollMVendorGump(pm, 0));
            }
        }
    }

    public class PowerscrollMVendorGump : Gump
    {
        private const int ItemsPerPage = 6;
        private PlayerMobile m_Owner;
        private int m_Page;

        private static List<SkillName> AllSkills = new List<SkillName>
        {
            SkillName.Alchemy, SkillName.Anatomy, SkillName.AnimalLore, SkillName.AnimalTaming,
            SkillName.Archery, SkillName.ArmsLore, SkillName.Begging, SkillName.Blacksmith,
            SkillName.Bushido, SkillName.Camping, SkillName.Carpentry, SkillName.Cartography,
            SkillName.Chivalry, SkillName.Cooking, SkillName.DetectHidden, SkillName.Discordance,
            SkillName.EvalInt, SkillName.Fencing, SkillName.Fishing, SkillName.Fletching,
            SkillName.Focus, SkillName.Forensics, SkillName.Healing, SkillName.Herding,
            SkillName.Hiding, SkillName.Imbuing, SkillName.Inscribe, SkillName.ItemID,
            SkillName.Lockpicking, SkillName.Lumberjacking, SkillName.Macing, SkillName.Magery,
            SkillName.MagicResist, SkillName.Meditation, SkillName.Mining, SkillName.Musicianship,
            SkillName.Mysticism, SkillName.Necromancy, SkillName.Ninjitsu, SkillName.Parry,
            SkillName.Peacemaking, SkillName.Poisoning, SkillName.Provocation, SkillName.RemoveTrap,
            SkillName.Snooping, SkillName.Spellweaving, SkillName.SpiritSpeak, SkillName.Stealing,
            SkillName.Stealth, SkillName.Swords, SkillName.Tactics, SkillName.Tailoring,
            SkillName.TasteID, SkillName.Throwing, SkillName.Tinkering, SkillName.Tracking,
            SkillName.Veterinary, SkillName.Wrestling
        };

        public PowerscrollMVendorGump(PlayerMobile owner, int page) : base(50, 50)
        {
            m_Owner = owner;
            m_Page = page;

            AddPage(0);
            AddBackground(0, 0, 600, 400, 9270);
            AddAlphaRegion(10, 10, 580, 380);

            AddHtml(20, 20, 560, 20, "<CENTER><BASEFONT COLOR=#FFFFFF>Powerscroll 90 Vendor</BASEFONT></CENTER>", false, false);

            int pageCount = (AllSkills.Count + ItemsPerPage - 1) / ItemsPerPage;

            if (page > 0)
                AddButton(550, 20, 4014, 4016, 1, GumpButtonType.Reply, 0); // Previous page

            if (page < pageCount - 1)
                AddButton(575, 20, 4005, 4007, 2, GumpButtonType.Reply, 0); // Next page

            AddHtml(-200, 20, 560, 20, String.Format("<CENTER><BASEFONT COLOR=#FFFFFF>Page {0}/{1}</BASEFONT></CENTER>", page + 1, pageCount), false, false);

            for (int i = 0; i < ItemsPerPage; ++i)
            {
                int index = (page * ItemsPerPage) + i;
                if (index >= AllSkills.Count)
                    break;

                SkillName skill = AllSkills[index];

                int xOffset = (i % 3) * 190;
                int yOffset = (i / 3) * 180;

                AddImageTiled(20 + xOffset, 50 + yOffset, 180, 170, 2624);
                AddAlphaRegion(25 + xOffset, 55 + yOffset, 170, 160);

                AddItem(70 + xOffset, 100 + yOffset, 5360); // Powerscroll image
                AddHtml(25 + xOffset, 55 + yOffset, 170, 20, String.Format("<CENTER><BASEFONT COLOR=#FFFFFF>{0}</BASEFONT></CENTER>", skill), false, false);
                AddHtml(25 + xOffset, 180 + yOffset, 170, 20, "<CENTER><BASEFONT COLOR=#FFFFFF>Cost: 5 MaxxiaScroll</BASEFONT></CENTER>", false, false);

                AddButton(155 + xOffset, 145 + yOffset, 4005, 4007, 100 + index, GumpButtonType.Reply, 0);
            }
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            switch (info.ButtonID)
            {
                case 1: // Previous page
                    from.SendGump(new PowerscrollMVendorGump(m_Owner, m_Page - 1));
                    break;
                case 2: // Next page
                    from.SendGump(new PowerscrollMVendorGump(m_Owner, m_Page + 1));
                    break;
                default:
                    if (info.ButtonID >= 100)
                    {
                        int index = info.ButtonID - 100;
                        if (index >= 0 && index < AllSkills.Count)
                        {
                            SkillName skill = AllSkills[index];
                            if (HasEnoughMaxxiaScrolls(from))
                            {
                                ConsumeMaxxiaScrolls(from);
                                GivePowerscroll(from, skill);
                                from.SendMessage("You have purchased a Powerscroll 90 for {0}.", skill);
                            }
                            else
                            {
                                from.SendMessage("You don't have enough MaxxiaScrolls. You need 5 to purchase a Powerscroll 90.");
                            }
                        }
                        from.SendGump(new PowerscrollMVendorGump(m_Owner, m_Page));
                    }
                    break;
            }
        }

        private bool HasEnoughMaxxiaScrolls(Mobile from)
        {
            int count = from.Backpack.GetAmount(typeof(MaxxiaScroll), true);
            return count >= 5;
        }

        private void ConsumeMaxxiaScrolls(Mobile from)
        {
            from.Backpack.ConsumeTotal(typeof(MaxxiaScroll), 5);
        }

        private void GivePowerscroll(Mobile from, SkillName skill)
        {
            PowerScroll ps = new PowerScroll(skill, 90.0);
            from.AddToBackpack(ps);
        }
    }
}