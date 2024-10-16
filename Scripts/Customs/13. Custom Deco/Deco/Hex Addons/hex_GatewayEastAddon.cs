
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
	public class hex_GatewayEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {466, 0, -1, 0}, {478, 0, 0, 0}, {479, 0, 1, 0}// 1	2	3	
			, {481, 0, 1, 20}, {484, 0, 0, 20}, {474, 0, -1, 14}// 4	5	6	
			, {483, 1, 1, 0}, {483, 1, -1, 0}, {481, 0, 2, 0}// 7	8	9	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new hex_GatewayEastAddonDeed();
			}
		}

		[ Constructable ]
		public hex_GatewayEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public hex_GatewayEastAddon( Serial serial ) : base( serial )
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

	public class hex_GatewayEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new hex_GatewayEastAddon();
			}
		}

		[Constructable]
		public hex_GatewayEastAddonDeed()
		{
			Name = "Stone Archway East";
		}

		public hex_GatewayEastAddonDeed( Serial serial ) : base( serial )
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