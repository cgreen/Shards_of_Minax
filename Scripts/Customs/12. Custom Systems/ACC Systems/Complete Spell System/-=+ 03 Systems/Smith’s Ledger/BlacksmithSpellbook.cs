using System;
using Server.Items;
using Server.Spells;

namespace Server.ACC.CSS.Systems.BlacksmithMagic
{
	public class BlacksmithSpellbook : CSpellbook
	{
		public override School School{ get{ return School.SmithsLedger; } }

		[Constructable]
		public BlacksmithSpellbook() : this( (ulong)0, CSSettings.FullSpellbooks )
		{
		}

		[Constructable]
		public BlacksmithSpellbook( bool full ) : this( (ulong)0, full )
		{
		}

		[Constructable]
		public BlacksmithSpellbook( ulong content, bool full ) : base( content, 0xEFA, full )
		{
			Hue = 1290;
			Name = "Smiths Ledger";
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( from.AccessLevel == AccessLevel.Player )
			{
				//Container pack = from.Backpack;
				//if( !(Parent == from || (pack != null && Parent == pack)) )
				//{
					//from.SendMessage( "The spellbook must be in your backpack [and not in a container within] to open." );
					//return;
				//}
				//else
				if( SpellRestrictions.UseRestrictions && !SpellRestrictions.CheckRestrictions( from, this.School ) )
				{
					return;
				}
			}

			from.CloseGump( typeof( BlacksmithSpellbookGump ) );
			from.SendGump( new BlacksmithSpellbookGump( this ) );
		}

		public BlacksmithSpellbook( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}