
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
	public class Garden_Shrubs_Large_L_ShapeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6025, -9, -5, 2}, {6025, -9, -6, 2}, {6019, -9, 5, 3}// 5	6	8	
			, {6025, -9, 4, 2}, {6025, -9, 3, 2}, {6025, -9, -2, 2}// 9	10	11	
			, {6025, -9, -3, 2}, {6025, -9, 6, 2}, {6013, -3, -3, 1}// 12	24	28	
			, {6021, -5, -1, 1}, {12278, -5, -6, 1}, {6019, -4, -1, 1}// 29	30	31	
			, {6013, -5, 5, 1}, {6013, -6, -6, 1}, {6013, -6, -8, 1}// 32	33	34	
			, {6013, -6, -7, 1}, {6014, -8, -4, 1}, {6013, -2, -6, 1}// 36	38	39	
			, {6014, -8, 1, 1}, {6013, -6, -4, 1}, {6013, -1, -5, 1}// 40	41	46	
			, {6013, -7, -3, 1}, {3142, -6, -4, 1}, {3142, -3, -4, 1}// 47	48	50	
			, {11539, -3, -6, 6}, {11539, -5, -6, 6}, {6013, -2, -8, 1}// 51	53	54	
			, {6019, -7, -4, 3}, {6013, -7, 3, 1}, {6013, -3, -8, 1}// 55	56	60	
			, {6013, -2, -4, 1}, {6013, -7, 1, 1}, {6019, -4, -2, 1}// 61	63	64	
			, {6014, -8, -6, 1}, {6013, -3, 2, 1}, {6020, -4, 0, 1}// 65	71	73	
			, {6019, -7, 5, 3}, {6019, -7, 4, 3}, {6022, -3, 4, 1}// 77	78	79	
			, {6019, -7, 3, 3}, {6019, -7, 2, 3}, {6019, -7, 1, 3}// 80	81	82	
			, {6019, -7, 0, 3}, {6019, -7, -1, 3}, {6019, -7, -2, 3}// 83	84	85	
			, {6019, -7, -3, 3}, {6019, -8, 4, 3}, {6013, -4, -4, 1}// 86	87	88	
			, {6019, -8, 3, 3}, {6019, -8, 2, 3}, {6019, -8, 1, 1}// 89	90	91	
			, {6019, -8, -1, 3}, {6019, -8, -2, 3}, {6019, -8, -3, 2}// 93	94	95	
			, {6025, -8, 5, 2}, {6021, -7, 0, 2}, {6025, -8, 2, 2}// 96	97	98	
			, {6025, -8, 1, 1}, {6025, -8, 0, 2}, {12278, -3, -6, 1}// 99	100	101	
			, {6025, -8, -1, 2}, {6025, -4, -1, 1}, {6021, -7, -2, 2}// 102	103	104	
			, {6021, -7, -1, 2}, {6021, -2, 4, 2}, {6018, -2, 4, 2}// 105	106	108	
			, {6018, 0, 5, 2}, {6013, -7, -5, 1}, {6021, 0, 5, 2}// 109	110	111	
			, {6020, 0, 5, 2}, {6013, -3, -6, 1}, {6013, -5, -6, 1}// 112	114	115	
			, {6020, -2, 5, 1}, {6020, 1, 5, 2}, {6022, 0, 4, 1}// 116	117	118	
			, {6023, 5, 4, 2}, {6013, -7, -4, 1}, {6023, 3, 3, 2}// 119	120	121	
			, {6024, -4, -3, 2}, {6013, -1, 0, 1}, {3144, 2, 2, 1}// 123	125	126	
			, {6024, -2, 3, 2}, {6022, 0, 4, 1}, {3272, 1, 2, 1}// 127	128	129	
			, {6013, 3, 2, 1}, {6020, 1, 3, 1}, {6013, 1, 1, 1}// 130	131	132	
			, {6013, 1, 2, 1}, {6020, -2, 3, 1}, {6018, 3, 4, 1}// 133	136	138	
			, {6013, 1, 3, 1}, {6013, 3, 0, 1}, {6013, 0, 0, 1}// 139	140	141	
			, {6013, 2, 2, 1}, {6013, 6, 1, 1}, {6013, 1, 4, 1}// 142	143	145	
			, {6013, 1, 5, 1}, {6014, -8, -5, 1}, {6013, -1, -8, 1}// 146	147	148	
			, {6025, 7, 4, 1}, {6013, 1, 3, 1}, {6025, -8, -4, 2}// 149	150	151	
			, {6013, 0, 4, 1}, {6013, 2, 5, 1}, {3142, -2, 2, 1}// 152	153	154	
			, {6018, 2, 4, 1}, {6020, 6, 3, 1}, {6013, 6, 0, 1}// 155	156	157	
			, {6018, 5, 4, 2}, {6019, 0, 4, 1}, {6013, 2, 0, 1}// 158	159	160	
			, {6013, 1, 0, 1}, {6018, 1, 4, 1}, {6013, 5, 5, 2}// 161	162	163	
			, {6020, -3, 3, 1}, {6013, -2, 2, 1}, {6024, -2, 3, 2}// 164	165	166	
			, {6013, 7, 1, 1}, {6013, -1, 5, 1}, {6013, 2, 1, 1}// 168	169	170	
			, {6018, -1, 4, 1}, {6013, 5, 0, 1}, {6013, 4, 2, 1}// 171	173	174	
			, {6020, 5, 3, 1}, {6013, 0, 3, 1}, {6024, 7, 3, 1}// 175	178	179	
			, {6022, -5, 5, 1}, {6018, -2, 4, 1}, {6018, 0, 4, 1}// 180	182	183	
			, {6013, 6, 5, 1}, {6020, 0, 3, 1}, {6013, 7, 2, 1}// 184	186	187	
			, {6013, -2, -5, 1}, {6019, 0, 3, 1}, {6013, 7, 5, 2}// 188	189	190	
			, {6022, 3, 4, 3}, {6020, -1, 3, 1}, {6018, 0, 5, 1}// 192	193	195	
			, {6018, 3, 4, 1}, {6013, -1, 1, 1}, {6018, 0, 4, 1}// 197	198	199	
			, {6013, 0, 1, 1}, {6013, 5, 4, 1}, {6020, 4, 3, 2}// 200	201	202	
			, {6020, 2, 3, 1}, {6013, 2, 4, 1}, {6013, -1, 2, 1}// 203	204	206	
			, {6022, 3, 4, 2}, {6013, 5, 1, 1}, {6021, -1, 3, 2}// 207	209	210	
			, {6018, 1, 4, 1}, {6013, 5, 2, 1}, {6018, -2, 4, 1}// 211	212	213	
			, {11535, 1, 4, 2}, {6018, 4, 4, 1}, {6014, -8, -8, 1}// 214	216	217	
			, {6020, 6, 3, 1}, {6013, 4, 5, 1}, {6019, -4, 1, 1}// 218	220	221	
			, {6019, -4, 0, 1}, {6013, -4, -7, 1}, {6013, 2, 3, 1}// 222	223	224	
			, {6021, -5, 3, 1}, {6013, -3, 0, 1}, {6022, -5, 5, 1}// 225	226	228	
			, {6024, -4, 2, 1}, {6019, -4, 1, 1}, {6018, -3, 4, 1}// 229	230	231	
			, {6013, 4, 4, 1}, {6013, -3, -2, 1}, {6014, -8, 4, 1}// 232	235	236	
			, {6013, 4, 1, 1}, {6013, 7, 5, 1}, {6013, 3, 1, 1}// 237	239	240	
			, {6013, 7, 0, 1}, {6013, -5, -8, 1}, {6013, 4, 0, 1}// 241	242	243	
			, {6025, -1, 4, 1}, {6013, 5, 5, 1}, {6019, -1, 4, 2}// 244	245	247	
			, {6013, -2, 1, 1}, {6013, 0, 2, 1}, {6013, -3, -6, 1}// 248	249	250	
			, {6023, -5, 0, 1}, {6019, -7, -6, 3}, {6024, -1, 3, 3}// 251	253	254	
			, {6020, 3, 3, 2}, {6013, 6, 2, 1}, {6022, -5, 3, 1}// 255	256	257	
			, {6013, 3, 5, 1}, {6019, -8, -5, 2}, {6013, -2, 0, 1}// 258	259	260	
			, {6021, 3, 3, 1}, {6013, -6, -2, 1}, {6013, -2, 0, 1}// 263	264	265	
			, {6019, -8, -4, 2}, {6018, 0, 4, 2}, {6018, 6, 4, 2}// 266	268	270	
			, {6013, -2, 5, 1}, {6018, -1, 4, 1}, {6025, -4, 3, 1}// 271	272	273	
			, {6025, -1, 4, 2}, {6024, 7, 3, 1}, {6018, 2, 4, 1}// 274	275	276	
			, {6013, -1, -7, 1}, {6013, -1, -1, 1}, {6013, -1, -3, 1}// 278	279	283	
			, {6014, -8, -2, 1}, {6013, -1, -2, 1}, {6013, 3, -1, 1}// 284	285	287	
			, {6013, -2, -3, 1}, {6013, -2, -1, 1}, {6013, -2, -2, 1}// 288	289	290	
			, {6023, -3, 5, 1}, {3310, -4, -5, 1}, {6021, -5, 2, 1}// 291	292	293	
			, {6014, -8, 3, 1}, {6021, -5, 2, 2}, {6023, -5, 4, 2}// 294	296	297	
			, {6021, -5, 4, 1}, {6013, -7, -1, 1}, {6021, -5, 4, 1}// 298	299	300	
			, {6013, -7, -7, 1}, {6013, -6, -5, 1}, {6013, -5, -4, 1}// 303	305	307	
			, {6013, -6, 4, 1}, {6013, -5, 5, 1}, {6014, -8, -3, 1}// 308	310	311	
			, {6013, -4, -5, 1}, {6014, -8, 5, 1}, {6014, -8, 0, 1}// 312	313	314	
			, {4676, -4, -6, 1}, {6013, -4, -8, 1}, {6014, -8, 2, 1}// 315	316	317	
			, {6018, -3, 5, 1}, {6025, -4, 1, 2}, {6013, -5, -5, 1}// 319	320	321	
			, {6013, -7, -6, 1}, {6013, -1, -6, 1}, {6019, -4, 2, 1}// 322	323	325	
			, {6013, -4, 4, 1}, {6023, -3, 3, 1}, {6013, -6, 5, 1}// 326	327	328	
			, {6013, -6, -1, 1}, {6021, -5, 0, 1}, {6013, -7, 0, 1}// 329	330	331	
			, {6013, -7, 4, 2}, {6013, -6, 0, 1}, {6019, -7, -5, 3}// 333	334	335	
			, {6013, -3, 1, 1}, {6013, -6, 1, 1}, {6013, -5, -7, 1}// 336	337	339	
			, {6013, -6, 2, 1}, {6013, -8, 1, 1}, {6019, -4, 2, 1}// 340	342	343	
			, {6013, -2, -7, 1}, {6013, -7, 4, 1}, {6013, -7, 5, 2}// 344	345	346	
			, {6020, -4, -3, 1}, {6024, -4, 4, 1}, {6013, -7, -8, 1}// 347	348	350	
			, {6013, -6, -3, 1}, {6013, -3, -5, 1}, {6013, -7, -2, 1}// 351	352	353	
			, {6014, -8, -7, 1}, {6013, -1, -4, 1}, {6019, -8, -6, 2}// 354	355	356	
			, {11536, -6, 2, 1}, {6025, -4, 5, 2}, {6024, -4, -3, 1}// 357	360	362	
			, {6018, -3, 4, 1}, {6013, -3, -1, 1}, {6021, -5, -2, 1}// 363	364	365	
			, {6023, -5, -3, 2}, {6023, -5, -3, 1}, {6013, -4, -6, 1}// 366	367	368	
			, {6013, -3, -7, 1}, {6013, -3, -4, 1}, {6014, -8, -1, 1}// 369	370	371	
			, {6013, -5, 7, 1}, {6013, -6, 8, 1}, {6013, -3, 7, 1}// 372	374	376	
			, {3272, 5, 6, 1}, {6019, -7, 7, 3}, {6019, -7, 6, 3}// 377	380	381	
			, {6019, -8, 7, 3}, {6019, -8, 6, 3}, {6020, 3, 7, 2}// 383	384	385	
			, {6020, 7, 8, 2}, {6021, -3, 8, 2}, {6020, -3, 8, 2}// 386	387	388	
			, {6019, -1, 8, 2}, {6019, -2, 7, 2}, {6018, 5, 7, 2}// 389	390	391	
			, {6020, 4, 7, 2}, {6020, -6, 7, 2}, {6020, -7, 7, 2}// 392	393	394	
			, {6025, -6, 7, 2}, {6022, -7, 7, 2}, {6024, 0, 7, 2}// 395	396	397	
			, {6022, -2, 7, 2}, {6022, 0, 7, 2}, {6022, 0, 7, 1}// 398	399	400	
			, {6022, 0, 7, 1}, {6025, 3, 7, 1}, {6025, 4, 7, 1}// 401	402	403	
			, {6023, 5, 7, 1}, {6022, 2, 7, 1}, {6013, 4, 8, 1}// 404	405	407	
			, {6013, 5, 8, 1}, {6013, 0, 6, 1}, {6013, 5, 6, 1}// 408	410	411	
			, {6013, -2, 8, 1}, {6013, 1, 6, 1}, {6013, 7, 6, 1}// 412	413	414	
			, {6013, 0, 8, 1}, {6013, -1, 7, 1}, {6013, 6, 6, 1}// 416	417	418	
			, {6013, 6, 8, 1}, {6013, 2, 6, 1}, {6013, 1, 7, 1}// 421	423	424	
			, {6013, 3, 6, 1}, {6013, -2, 6, 1}, {6013, 6, 7, 1}// 425	426	427	
			, {6013, 4, 6, 1}, {6013, 3, 8, 1}, {6013, 7, 7, 1}// 428	430	433	
			, {3150, -1, 6, 1}, {6013, 2, 8, 1}, {6014, -8, 6, 1}// 435	436	438	
			, {6014, -8, 7, 1}, {6013, -7, 8, 1}, {6013, -7, 6, 2}// 439	440	442	
			, {6013, -6, 6, 1}, {6025, -4, 6, 1}, {6013, -4, 8, 1}// 443	444	445	
			, {6014, -8, 8, 1}, {6013, -4, 7, 1}, {6013, -3, 6, 1}// 447	448	450	
			, {6013, -5, 6, 1}, {6013, 8, 5, 1}, {6013, 8, 1, 1}// 451	455	456	
			, {6013, 9, 2, 1}, {6013, 9, 5, 1}, {6013, 9, 4, 1}// 457	459	460	
			, {6013, 9, 3, 1}, {6013, 9, 0, 1}, {6013, 9, 1, 1}// 461	462	467	
			, {6013, 8, 4, 1}, {6013, 8, 3, 1}, {6013, 8, 0, 1}// 468	472	473	
			, {6013, 8, 2, 1}, {6020, 8, 8, 2}, {6013, 8, 6, 1}// 474	476	478	
			, {6013, 8, 7, 1}, {6013, 9, 6, 1}, {6013, 9, 7, 1}// 479	482	483	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Garden_Shrubs_Large_L_ShapeAddonDeed();
			}
		}

		[ Constructable ]
		public Garden_Shrubs_Large_L_ShapeAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3216, -9, 1, 2, 2210, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3216, -9, -8, 1, 2211, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3216, -9, 2, 2, 2211, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3216, -9, 4, 2, 2208, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3216, -9, -6, 2, 2210, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3216, -9, 3, 2, 2209, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3216, -9, -7, 2, 2210, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3217, -9, -2, 2, 2209, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 3216, -9, -4, 2, 2210, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 3217, -9, -9, 1, 2208, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3217, -9, 0, 1, 2212, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3216, -9, 5, 2, 2211, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3217, -9, -1, 1, 2212, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 3218, -9, -3, 4, 2211, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3216, -9, -5, 3, 2208, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 3216, -9, 6, 2, 2212, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 3217, -9, 8, 1, 2211, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 3217, -9, 7, 1, 2211, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3217, -9, 9, 1, 2208, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2920, -4, 5, 1, 966, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2915, -3, -2, 1, 966, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 3392, -2, -6, 1, 2212, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 3217, -8, 0, 1, 2212, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 3217, -8, 1, 0, 2212, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 3216, -1, -9, 1, 2212, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 3258, -8, -7, 1, 2211, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 7870, -4, -3, 1, 2212, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 3216, -2, -9, 1, 2211, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 3216, -1, -4, 2, 2212, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 3216, -1, -5, 1, 2211, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 3379, 0, 5, 1, 2208, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 3167, -6, -2, 2, 2208, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 3167, -6, 0, 2, 2208, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 3217, 0, 5, 3, 2208, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 3244, -8, 1, 1, 2212, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 3249, 0, 0, 3, 2209, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 3245, 6, 0, 3, 2209, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 3245, 4, 0, 3, 2209, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 3245, 3, 0, 3, 2209, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 3245, 0, 0, 3, 2209, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 3216, -4, -9, 1, 2210, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 3392, -6, -6, 1, 2212, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 3216, -3, -9, 1, 2210, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 3216, -7, -9, 1, 2212, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 3257, -2, 1, 2, 2211, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 3249, 0, 1, 2, 2212, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 3270, -3, 2, 1, 2212, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 2915, -6, -2, 1, 966, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 3217, 5, -1, 1, 2210, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 3217, 6, -1, 1, 2209, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 3246, 6, 1, 1, 2210, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 3217, 1, -1, 1, 2211, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 3217, 4, -1, 1, 2209, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 3249, 6, 3, 1, 2210, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 3258, 2, 4, 1, 2212, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 3216, 7, -1, 1, 2208, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 3380, 5, 4, 2, 2212, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 3249, 7, 5, 1, 2210, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 3249, -1, 1, 2, 2212, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 3245, 3, 1, 1, 2209, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 3216, -1, -7, 1, 2208, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 3513, 2, -1, 1, 2207, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 3217, -2, 0, 1, 2212, -1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 3216, -6, -9, 1, 2208, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 3249, -2, -7, 1, 2212, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 3378, 6, 4, 3, 2212, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 3512, 3, -1, 1, 2210, -1, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 3216, -1, 0, 1, 2212, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 3392, 4, 1, 1, 2212, -1, "", 1);// 261
			AddComplexComponent( (BaseAddon) this, 3216, -5, -9, 1, 2208, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 3216, 0, -1, 2, 2209, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 3216, 1, -1, 1, 2212, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 3218, -1, -2, 3, 2210, -1, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 3216, -1, -1, 2, 2208, -1, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 3218, -1, -1, 1, 2208, -1, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 3216, -1, -3, 1, 2211, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 3216, -1, -2, 1, 2209, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 3391, -8, -8, 7, 2212, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 3244, -3, 5, 2, 2211, -1, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 3244, -5, 4, 2, 2211, -1, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 3254, -4, 5, 1, 2211, -1, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 3258, -5, 1, 2, 2211, -1, "", 1);// 306
			AddComplexComponent( (BaseAddon) this, 3217, -1, -8, 1, 2208, -1, "", 1);// 309
			AddComplexComponent( (BaseAddon) this, 3216, -1, -6, 2, 2212, -1, "", 1);// 318
			AddComplexComponent( (BaseAddon) this, 2914, -6, 0, 1, 966, -1, "", 1);// 324
			AddComplexComponent( (BaseAddon) this, 2914, -3, 0, 1, 966, -1, "", 1);// 332
			AddComplexComponent( (BaseAddon) this, 3159, -4, -5, 1, 2212, -1, "", 1);// 338
			AddComplexComponent( (BaseAddon) this, 2921, -5, 5, 1, 966, -1, "", 1);// 341
			AddComplexComponent( (BaseAddon) this, 3216, -8, -9, 1, 2210, -1, "", 1);// 349
			AddComplexComponent( (BaseAddon) this, 2916, -3, -1, 1, 966, -1, "", 1);// 358
			AddComplexComponent( (BaseAddon) this, 2916, -6, -1, 1, 966, -1, "", 1);// 359
			AddComplexComponent( (BaseAddon) this, 3244, -8, -4, 2, 2212, -1, "", 1);// 361
			AddComplexComponent( (BaseAddon) this, 3216, -8, 9, 1, 2210, -1, "", 1);// 373
			AddComplexComponent( (BaseAddon) this, 3391, -8, 8, 3, 2212, -1, "", 1);// 375
			AddComplexComponent( (BaseAddon) this, 3218, 0, 8, 4, 2209, -1, "", 1);// 378
			AddComplexComponent( (BaseAddon) this, 3218, -1, 9, 3, 2209, -1, "", 1);// 379
			AddComplexComponent( (BaseAddon) this, 3216, -6, 9, 1, 2212, -1, "", 1);// 382
			AddComplexComponent( (BaseAddon) this, 3217, -7, 9, 1, 2211, -1, "", 1);// 406
			AddComplexComponent( (BaseAddon) this, 3216, 0, 9, 1, 2212, -1, "", 1);// 409
			AddComplexComponent( (BaseAddon) this, 3216, 7, 9, 1, 2208, -1, "", 1);// 415
			AddComplexComponent( (BaseAddon) this, 3216, 4, 9, 1, 2211, -1, "", 1);// 419
			AddComplexComponent( (BaseAddon) this, 3217, 2, 9, 1, 2208, -1, "", 1);// 420
			AddComplexComponent( (BaseAddon) this, 3216, 3, 9, 2, 2210, -1, "", 1);// 422
			AddComplexComponent( (BaseAddon) this, 3216, 6, 9, 2, 2211, -1, "", 1);// 429
			AddComplexComponent( (BaseAddon) this, 3216, -1, 9, 2, 2211, -1, "", 1);// 431
			AddComplexComponent( (BaseAddon) this, 3216, 1, 9, 2, 2211, -1, "", 1);// 432
			AddComplexComponent( (BaseAddon) this, 3216, -2, 9, 1, 2208, -1, "", 1);// 434
			AddComplexComponent( (BaseAddon) this, 3217, 5, 9, 1, 2212, -1, "", 1);// 437
			AddComplexComponent( (BaseAddon) this, 3216, -3, 9, 2, 2209, -1, "", 1);// 441
			AddComplexComponent( (BaseAddon) this, 3216, -5, 9, 2, 2210, -1, "", 1);// 446
			AddComplexComponent( (BaseAddon) this, 3217, -4, 9, 1, 2210, -1, "", 1);// 449
			AddComplexComponent( (BaseAddon) this, 3218, 9, 1, 3, 2209, -1, "", 1);// 452
			AddComplexComponent( (BaseAddon) this, 3513, 9, 0, 1, 2209, -1, "", 1);// 453
			AddComplexComponent( (BaseAddon) this, 3392, 9, 2, 8, 2212, -1, "", 1);// 454
			AddComplexComponent( (BaseAddon) this, 3216, 9, 5, 2, 2210, -1, "", 1);// 458
			AddComplexComponent( (BaseAddon) this, 3216, 9, 1, 1, 2211, -1, "", 1);// 463
			AddComplexComponent( (BaseAddon) this, 3216, 9, 4, 1, 2208, -1, "", 1);// 464
			AddComplexComponent( (BaseAddon) this, 3216, 9, -1, 1, 2212, -1, "", 1);// 465
			AddComplexComponent( (BaseAddon) this, 3216, 9, 2, 1, 2210, -1, "", 1);// 466
			AddComplexComponent( (BaseAddon) this, 3218, 9, 4, 2, 2208, -1, "", 1);// 469
			AddComplexComponent( (BaseAddon) this, 3216, 8, -1, 1, 2212, -1, "", 1);// 470
			AddComplexComponent( (BaseAddon) this, 3216, 9, 3, 2, 2209, -1, "", 1);// 471
			AddComplexComponent( (BaseAddon) this, 3216, 9, 9, 1, 2211, -1, "", 1);// 475
			AddComplexComponent( (BaseAddon) this, 3217, 9, 7, 1, 2211, -1, "", 1);// 477
			AddComplexComponent( (BaseAddon) this, 3216, 8, 9, 1, 2211, -1, "", 1);// 480
			AddComplexComponent( (BaseAddon) this, 3216, 9, 6, 1, 2211, -1, "", 1);// 481
			AddComplexComponent( (BaseAddon) this, 3392, 8, 8, 8, 2212, -1, "", 1);// 484

		}

		public Garden_Shrubs_Large_L_ShapeAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class Garden_Shrubs_Large_L_ShapeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Garden_Shrubs_Large_L_ShapeAddon();
			}
		}

		[Constructable]
		public Garden_Shrubs_Large_L_ShapeAddonDeed()
		{
			Name = "Garden_Shrubs_Large_L_Shape";
		}

		public Garden_Shrubs_Large_L_ShapeAddonDeed( Serial serial ) : base( serial )
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