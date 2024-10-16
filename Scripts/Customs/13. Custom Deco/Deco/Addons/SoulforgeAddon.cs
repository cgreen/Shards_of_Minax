////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SoulforgeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {17015, -1, -1, 1}, {17016, 0, -1, 1}, {17017, 1, -1, 1}// 1	2	3	
			, {17018, 2, -1, 1}, {17019, -1, 0, 1}, {17020, 0, 0, 1}// 4	5	6	
			, {17021, 1, 0, 1}, {17022, 2, 0, 1}, {17023, -1, 1, 1}// 7	8	9	
			, {17024, 0, 1, 1}, {17025, 1, 1, 1}, {17026, 2, 1, 1}// 10	11	12	
			, {17027, -1, 2, 1}, {17028, 0, 2, 1}, {17029, 1, 2, 1}// 13	14	15	
			, {17030, 2, 2, 1}, {4015, 0, 1, 0}, {4017, 1, 1, 0}// 16	17	18	
			, {4015, 1, 0, 0}// 19	
		};

		public override BaseAddonDeed Deed
		{
			get
			{
				return new SoulforgeAddonDeed();
			}
		}

		[ Constructable ]
		public SoulforgeAddon()
		{
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );
		}

		public SoulforgeAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SoulforgeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SoulforgeAddon();
			}
		}

		[Constructable]
		public SoulforgeAddonDeed()
		{
			Name = "Soulforge";
		}

		public SoulforgeAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}