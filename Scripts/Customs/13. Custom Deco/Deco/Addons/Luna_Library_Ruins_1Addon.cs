
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
	public class Luna_Library_Ruins_1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1283, -1, -5, 40}, {1283, -1, -6, 40}, {1283, -2, -2, 40}// 1	2	3	
			, {3743, -1, -6, 20}, {1283, -2, -3, 40}, {954, -5, -2, 60}// 4	5	6	
			, {954, -5, -7, 60}, {954, -6, -2, 60}, {1283, -2, -4, 40}// 7	8	9	
			, {954, -6, -7, 60}, {953, -7, -2, 60}, {953, -7, -3, 60}// 10	11	12	
			, {1283, -2, -5, 40}, {1283, -2, -6, 40}, {953, -7, -4, 60}// 13	14	15	
			, {953, -7, -5, 60}, {953, -7, -6, 60}, {956, -7, -7, 60}// 16	17	18	
			, {517, -6, -2, 40}, {517, -6, -7, 40}, {513, -7, -2, 40}// 19	20	21	
			, {518, -7, -6, 40}, {514, -7, -7, 40}, {517, -6, -2, 20}// 22	23	24	
			, {983, -6, -7, 20}, {1283, -3, -2, 40}, {518, -7, -6, 20}// 25	27	28	
			, {513, -7, -2, 20}, {514, -7, -7, 20}, {993, -5, -7, 0}// 30	31	32	
			, {1283, -3, -3, 40}, {517, -6, -2, 0}, {983, -6, -7, 0}// 33	34	35	
			, {4032, -4, -5, 26}, {1283, -3, -4, 40}, {1283, -2, -5, 40}// 36	37	38	
			, {1334, -5, -2, 20}, {513, -7, -2, 0}, {516, -7, -3, 0}// 39	40	42	
			, {4167, -6, -4, 20}, {1334, -5, -3, 20}, {1283, -3, -6, 40}// 43	44	45	
			, {1283, -4, -2, 40}, {1283, -4, -3, 40}, {1283, -4, -4, 40}// 46	47	48	
			, {518, -7, -6, 0}, {514, -7, -7, 0}, {1329, -5, -2, 60}// 49	50	51	
			, {1329, -5, -3, 60}, {1329, -5, -4, 60}, {1283, -4, -5, 40}// 52	53	54	
			, {2900, -3, -4, 20}, {1283, -4, -6, 40}, {1329, -5, -5, 60}// 55	56	57	
			, {1329, -5, -6, 60}, {2711, 0, -6, 20}, {1329, -6, -2, 60}// 58	59	60	
			, {2715, 1, -6, 20}, {3749, -7, -6, 20}, {1334, -5, -5, 20}// 62	66	70	
			, {1283, -6, -5, 40}, {1283, -6, -6, 40}, {1334, -5, -5, 0}// 71	72	73	
			, {1334, -5, -4, 0}, {1334, -6, -6, 0}, {1283, -6, -4, 40}// 74	75	76	
			, {1334, -6, -5, 20}, {1334, -6, -4, 20}, {1334, -6, -6, 20}// 77	78	79	
			, {1334, -5, -4, 20}, {1334, -5, -6, 20}, {1334, -5, -6, 0}// 80	81	82	
			, {1334, 2, 0, 20}, {1334, 2, -1, 20}, {1334, 2, -2, 20}// 83	84	85	
			, {1334, 2, -3, 20}, {1334, 2, -4, 20}, {1334, 2, -5, 20}// 86	87	88	
			, {1334, 2, -6, 20}, {1334, 1, 0, 20}, {1334, 1, -1, 20}// 89	90	91	
			, {1334, 1, -2, 20}, {1334, 1, -3, 20}, {1334, 1, -4, 20}// 92	93	94	
			, {1334, 1, -5, 20}, {1334, 1, -6, 20}, {1334, 0, 0, 20}// 95	96	97	
			, {1334, -5, -2, 0}, {1334, 0, -1, 20}, {1334, 0, -2, 20}// 98	99	100	
			, {1334, 0, -3, 20}, {1334, 0, -4, 20}, {1334, 0, -5, 20}// 101	102	103	
			, {1334, 0, -6, 20}, {1334, -1, -2, 20}, {1283, 2, 0, 40}// 104	105	106	
			, {1283, 2, -1, 40}, {1334, -1, -3, 20}, {1334, -1, -4, 20}// 107	108	109	
			, {1283, 2, -2, 40}, {1283, 2, -3, 40}, {1283, 2, -4, 40}// 110	111	112	
			, {1283, 2, -5, 40}, {1334, -1, -5, 20}, {1334, -1, -6, 20}// 113	114	115	
			, {1283, 2, -6, 40}, {954, 2, 0, 60}, {954, 2, -7, 60}// 116	117	118	
			, {954, 1, 0, 60}, {954, 1, -7, 60}, {1283, 1, 0, 40}// 119	120	121	
			, {1334, -2, -2, 20}, {1283, 1, -1, 40}, {954, 0, 0, 60}// 122	123	124	
			, {1283, -6, -3, 40}, {954, 0, -7, 60}, {1334, -5, -3, 0}// 125	126	127	
			, {1334, -2, -3, 20}, {1334, -2, -4, 20}, {1283, 1, -2, 40}// 128	129	130	
			, {1334, -2, -5, 20}, {1334, -2, -6, 20}, {953, -1, 0, 60}// 131	132	133	
			, {953, -1, -1, 60}, {954, -1, -2, 60}, {954, -1, -7, 60}// 134	135	136	
			, {954, -2, -2, 60}, {954, -2, -7, 60}, {954, -3, -2, 60}// 137	138	139	
			, {954, -3, -7, 60}, {954, -4, -2, 60}, {954, -4, -7, 60}// 140	141	142	
			, {1283, 1, -3, 40}, {1283, 1, -4, 40}, {1334, -3, -2, 20}// 143	144	145	
			, {1283, 1, -5, 40}, {993, 2, -7, 40}, {517, 0, 0, 40}// 146	147	148	
			, {513, -1, 0, 40}, {517, -1, -2, 40}, {983, -1, -7, 40}// 149	150	151	
			, {1334, -3, -3, 20}, {1334, -3, -4, 20}, {1334, -3, -5, 20}// 152	153	154	
			, {1334, -3, -6, 20}, {512, -2, -7, 40}, {1283, 1, -6, 40}// 155	156	157	
			, {1334, -4, -2, 20}, {1334, -4, -3, 20}, {1334, -4, -4, 20}// 167	168	169	
			, {1283, 0, 0, 40}, {983, 2, -7, 20}, {1334, -4, -5, 20}// 170	171	172	
			, {517, 0, 0, 20}, {1334, -4, -6, 20}, {513, -1, 0, 20}// 173	174	175	
			, {1283, 0, -1, 40}, {515, -1, -2, 20}, {1283, 0, -2, 40}// 176	177	182	
			, {993, -2, -7, 20}, {1283, 0, -3, 40}, {1283, 0, -4, 40}// 186	189	190	
			, {517, 1, -4, 0}, {993, 2, -7, 0}, {980, 1, -7, 0}// 193	194	195	
			, {952, -1, -1, 0}, {953, -1, -2, 0}, {954, -1, -3, 0}// 212	213	214	
			, {512, -1, -4, 0}, {954, -2, -3, 0}, {517, -2, -4, 0}// 215	216	217	
			, {980, -2, -7, 0}, {953, -3, -2, 0}, {956, -3, -3, 0}// 218	219	220	
			, {511, -3, -4, 0}, {972, -3, -7, 0}, {511, -4, -2, 0}// 221	222	223	
			, {514, -4, -4, 0}, {1283, 0, -5, 40}, {1283, -1, -2, 40}// 224	225	227	
			, {1283, -1, -3, 40}, {1283, -1, -4, 40}, {1329, 2, 0, 60}// 228	229	230	
			, {1329, 2, -1, 60}, {1329, 2, -2, 60}, {1329, 2, -3, 60}// 231	232	233	
			, {1329, 2, -4, 60}, {1329, 2, -5, 60}, {1329, 2, -6, 60}// 234	235	236	
			, {1329, 1, 0, 60}, {1329, 1, -1, 60}, {1329, 1, -2, 60}// 237	238	239	
			, {1329, 1, -3, 60}, {1329, 1, -4, 60}, {1329, 1, -5, 60}// 240	241	242	
			, {1329, 1, -6, 60}, {1329, 0, 0, 60}, {1329, 0, -1, 60}// 243	244	245	
			, {1329, 0, -2, 60}, {1329, 0, -3, 60}, {1329, 0, -4, 60}// 246	247	248	
			, {1329, 0, -5, 60}, {1329, 0, -6, 60}, {1329, -1, -2, 60}// 249	250	251	
			, {1329, -1, -3, 60}, {1329, -1, -4, 60}, {1329, -1, -5, 60}// 252	253	254	
			, {1329, -1, -6, 60}, {1329, -2, -2, 60}, {1329, -2, -3, 60}// 255	256	257	
			, {1329, -2, -4, 60}, {1329, -2, -5, 60}, {1329, -2, -6, 60}// 258	259	260	
			, {1329, -3, -2, 60}, {1329, -3, -3, 60}, {1329, -3, -4, 60}// 261	262	263	
			, {1329, -3, -5, 60}, {1329, -3, -6, 60}, {1329, -4, -2, 60}// 264	265	266	
			, {1329, -4, -3, 60}, {1329, -4, -4, 60}, {1329, -4, -5, 60}// 267	268	269	
			, {1329, -4, -6, 60}, {1334, 2, -4, 0}, {1334, 2, -5, 0}// 270	271	272	
			, {1334, 2, -6, 0}, {515, -5, -2, 20}, {515, -2, -2, 20}// 273	274	275	
			, {1334, 1, -4, 0}, {1334, 1, -5, 0}, {1334, 1, -6, 0}// 276	277	278	
			, {1334, 0, -4, 0}, {1334, 0, -5, 0}, {1334, 0, -6, 0}// 279	280	281	
			, {13471, -1, -1, 0}, {13471, -1, -2, 0}, {1334, -1, -4, 0}// 282	283	284	
			, {1334, -1, -5, 0}, {1334, -1, -6, 0}, {13471, -2, -2, 0}// 285	286	287	
			, {1334, -2, -4, 0}, {1334, -2, -5, 0}, {1334, -2, -6, 0}// 288	289	290	
			, {1334, -3, -4, 0}, {1334, -3, -5, 0}, {1334, -3, -6, 0}// 291	292	293	
			, {1334, -6, -2, 0}, {1283, -5, -4, 40}, {1283, -5, -5, 40}// 294	295	296	
			, {1334, -6, -4, 0}, {1283, -5, -2, 40}, {1334, -6, -2, 20}// 297	298	299	
			, {1334, -6, -3, 20}, {1283, -5, -6, 40}, {1283, -6, -2, 40}// 300	301	302	
			, {1283, -5, -3, 40}, {1334, -4, -4, 0}, {1334, -4, -5, 0}// 303	304	305	
			, {1329, -6, -4, 60}, {1334, -4, -3, 0}, {1334, -4, -2, 0}// 306	307	308	
			, {1329, -6, -5, 60}, {1329, -6, -3, 60}, {1329, -6, -6, 60}// 309	310	311	
			, {1334, -6, -3, 0}, {1334, -6, -5, 0}, {953, -3, -1, 0}// 312	313	314	
			, {1334, -4, -6, 0}, {13471, -2, -1, 0}, {515, -2, -2, 40}// 315	317	321	
			, {516, -1, -3, 40}, {4554, -5, -6, 40}, {1283, -3, -5, 40}// 325	326	328	
			, {516, -1, -2, 40}, {4555, -1, -6, 40}, {513, 2, 0, 0}// 330	332	333	
			, {518, 2, -3, 0}, {512, 2, -4, 0}, {1036, 2, 7, 0}// 336	337	338	
			, {953, 2, 4, 60}, {953, 2, 3, 60}, {956, 2, 2, 60}// 339	340	341	
			, {514, 2, 2, 40}, {514, 2, 2, 20}, {518, 2, 3, 0}// 346	350	354	
			, {298, 2, 2, 0}, {953, 2, 8, 60}, {953, 2, 7, 60}// 355	356	357	
			, {966, 2, 6, 60}, {964, 2, 5, 60}, {513, 2, 8, 40}// 358	359	360	
			, {516, 2, 5, 40}, {513, 2, 8, 20}, {516, 2, 5, 20}// 361	362	363	
			, {513, 2, 8, 0}, {1329, 6, -1, 60}, {4610, 3, -4, 20}// 364	366	367	
			, {1283, 5, 0, 40}, {1283, 5, -1, 40}, {1283, 5, -2, 40}// 368	369	370	
			, {2817, 4, -6, 20}, {2813, 5, -6, 23}, {1334, 8, 0, 20}// 372	373	374	
			, {1334, 8, -1, 20}, {2814, 4, -6, 23}, {2818, 3, -6, 20}// 376	378	379	
			, {3129, 7, -6, 20}, {2815, 3, -6, 23}, {2816, 5, -6, 20}// 380	381	382	
			, {1334, 8, -2, 20}, {1334, 8, -3, 20}, {1334, 8, -4, 20}// 383	384	385	
			, {1334, 8, -5, 20}, {1334, 8, -6, 20}, {1334, 7, 0, 20}// 386	387	388	
			, {1334, 7, -1, 20}, {1334, 7, -2, 20}, {1334, 7, -3, 20}// 389	390	391	
			, {1334, 7, -4, 20}, {1334, 7, -5, 20}, {1334, 7, -6, 20}// 392	393	394	
			, {1283, 5, -3, 40}, {1283, 5, -4, 40}, {1334, 6, 0, 20}// 395	396	397	
			, {1334, 6, -1, 20}, {1334, 6, -2, 20}, {1334, 6, -3, 20}// 398	399	400	
			, {1334, 6, -4, 20}, {1334, 6, -5, 20}, {1334, 6, -6, 20}// 401	402	403	
			, {1283, 5, -5, 40}, {1334, 5, 0, 20}, {1283, 5, -6, 40}// 404	405	406	
			, {1334, 5, -1, 20}, {1334, 5, -2, 20}, {1334, 5, -3, 20}// 407	408	409	
			, {1334, 5, -4, 20}, {1334, 5, -5, 20}, {1334, 5, -6, 20}// 410	411	412	
			, {1283, 4, 0, 40}, {1283, 4, -1, 40}, {1283, 4, -2, 40}// 413	414	415	
			, {1334, 4, 0, 20}, {1334, 4, -1, 20}, {1283, 4, -3, 40}// 416	417	418	
			, {1334, 4, -2, 20}, {1334, 4, -3, 20}, {1334, 4, -4, 20}// 419	420	421	
			, {1283, 4, -4, 40}, {1334, 4, -5, 20}, {1334, 4, -6, 20}// 422	423	424	
			, {1334, 3, 0, 20}, {1334, 3, -1, 20}, {1334, 3, -2, 20}// 425	426	427	
			, {1334, 3, -3, 20}, {1334, 3, -4, 20}, {1334, 3, -5, 20}// 428	429	430	
			, {1334, 3, -6, 20}, {1283, 4, -5, 40}, {1283, 4, -6, 40}// 431	432	433	
			, {1283, 3, 0, 40}, {1283, 3, -1, 40}, {952, 8, 0, 60}// 434	435	436	
			, {1283, 3, -2, 40}, {953, 8, -1, 60}, {953, 8, -2, 60}// 437	438	439	
			, {953, 8, -3, 60}, {953, 8, -4, 60}, {953, 8, -5, 60}// 440	441	442	
			, {953, 8, -6, 60}, {954, 8, -7, 60}, {1283, 3, -3, 40}// 443	444	445	
			, {954, 7, 0, 60}, {954, 7, -7, 60}, {1283, 3, -4, 40}// 446	447	448	
			, {1283, 3, -5, 40}, {1283, 3, -6, 40}, {954, 6, 0, 60}// 449	450	451	
			, {954, 6, -7, 60}, {954, 5, 0, 60}, {954, 5, -7, 60}// 452	453	454	
			, {954, 4, 0, 60}, {954, 4, -7, 60}, {954, 3, 0, 60}// 455	456	457	
			, {954, 3, -7, 60}, {992, 8, 0, 40}, {984, 8, -2, 40}// 458	459	460	
			, {994, 8, -4, 40}, {994, 8, -6, 40}, {983, 8, -7, 40}// 461	462	463	
			, {514, 7, 0, 40}, {983, 5, -7, 40}, {515, 3, 0, 40}// 464	465	466	
			, {992, 8, 0, 20}, {984, 8, -1, 20}, {994, 8, -5, 20}// 470	471	472	
			, {984, 8, -6, 20}, {993, 8, -7, 20}, {514, 7, 0, 20}// 474	476	477	
			, {993, 7, -7, 20}, {983, 6, -7, 20}, {517, 4, 0, 20}// 481	482	483	
			, {512, 3, 0, 20}, {6017, 8, 0, 0}, {1334, 8, -1, 0}// 485	491	492	
			, {1334, 8, -2, 0}, {1334, 8, -3, 0}, {1334, 8, -4, 0}// 495	497	499	
			, {992, 8, 0, 0}, {1334, 8, -5, 0}, {1334, 8, -6, 0}// 501	502	503	
			, {984, 8, -3, 0}, {984, 8, -6, 0}, {512, 8, -7, 0}// 504	506	507	
			, {972, 6, -7, 0}, {983, 5, -7, 0}, {517, 3, 0, 0}// 509	510	512	
			, {6017, 7, 0, 0}, {1334, 7, -1, 0}, {1334, 7, -2, 0}// 515	516	517	
			, {1334, 7, -3, 0}, {1334, 7, -4, 0}, {1334, 7, -5, 0}// 518	519	520	
			, {1334, 7, -6, 0}, {1329, 8, 0, 60}, {1329, 8, -1, 60}// 521	522	523	
			, {1329, 8, -2, 60}, {1329, 8, -3, 60}, {1329, 8, -4, 60}// 524	525	526	
			, {1329, 8, -5, 60}, {1329, 8, -6, 60}, {1329, 7, 0, 60}// 527	528	529	
			, {6017, 6, 0, 0}, {1329, 7, -2, 60}, {1329, 7, -3, 60}// 530	531	532	
			, {1329, 7, -4, 60}, {1329, 7, -5, 60}, {1329, 6, -1, 60}// 533	534	535	
			, {1329, 6, -2, 60}, {1329, 6, -3, 60}, {1329, 6, -4, 60}// 536	537	538	
			, {1334, 6, -1, 0}, {1329, 6, -5, 60}, {1329, 6, -6, 60}// 539	540	541	
			, {1329, 5, -1, 60}, {1329, 5, -2, 60}, {1329, 5, -3, 60}// 542	543	544	
			, {1329, 5, -4, 60}, {1329, 5, -5, 60}, {1329, 5, -6, 60}// 545	546	547	
			, {1329, 4, 0, 60}, {1329, 4, -1, 60}, {1329, 4, -2, 60}// 548	549	550	
			, {1329, 4, -3, 60}, {1329, 4, -4, 60}, {1329, 4, -5, 60}// 551	552	553	
			, {1329, 4, -6, 60}, {1334, 6, -2, 0}, {1329, 3, 0, 60}// 554	555	556	
			, {1329, 3, -1, 60}, {1334, 6, -3, 0}, {1329, 3, -2, 60}// 557	558	559	
			, {1334, 6, -4, 0}, {1334, 6, -5, 0}, {1329, 3, -3, 60}// 560	561	562	
			, {1329, 3, -4, 60}, {1329, 3, -5, 60}, {1329, 3, -6, 60}// 563	564	565	
			, {1334, 6, -6, 0}, {6017, 5, 0, 0}, {1334, 5, -1, 0}// 566	567	568	
			, {1334, 5, -2, 0}, {1334, 5, -3, 0}, {1334, 5, -4, 0}// 569	570	571	
			, {1334, 5, -5, 0}, {1334, 5, -6, 0}, {6017, 4, 0, 0}// 572	573	574	
			, {1334, 4, -1, 0}, {1334, 4, -2, 0}, {1334, 4, -3, 0}// 575	576	577	
			, {1334, 4, -4, 0}, {1334, 4, -5, 0}, {1334, 4, -6, 0}// 578	579	580	
			, {1334, 3, -1, 0}, {1334, 3, -2, 0}, {1334, 3, -3, 0}// 581	582	583	
			, {1334, 3, -4, 0}, {1334, 3, -5, 0}, {1283, 8, 0, 40}// 584	585	586	
			, {1283, 8, -1, 40}, {1283, 8, -2, 40}, {1283, 8, -3, 40}// 587	588	589	
			, {1283, 8, -4, 40}, {1283, 8, -5, 40}, {1283, 8, -6, 40}// 590	591	592	
			, {1334, 3, -6, 0}, {1283, 7, 0, 40}, {1283, 7, -1, 40}// 593	594	595	
			, {1283, 7, -2, 40}, {1283, 7, -3, 40}, {1283, 7, -4, 40}// 596	597	598	
			, {1283, 7, -5, 40}, {1283, 7, -6, 40}, {1283, 6, 0, 40}// 599	600	601	
			, {1283, 6, -1, 40}, {1283, 6, -2, 40}, {1283, 6, -3, 40}// 602	603	604	
			, {1283, 6, -4, 40}, {1283, 6, -5, 40}, {1283, 6, -6, 39}// 605	606	607	
			, {4609, 3, -2, 20}, {4611, 3, -3, 20}, {1329, 7, -6, 60}// 608	609	611	
			, {4554, 3, -6, 40}, {1329, 6, -1, 60}, {1329, 6, -1, 60}// 612	614	616	
			, {1403, 8, 7, 40}, {1403, 8, 6, 40}, {1403, 8, 5, 40}// 618	619	620	
			, {1403, 7, 8, 40}, {1403, 6, 8, 40}, {1403, 5, 3, 40}// 621	622	623	
			, {1403, 6, 7, 40}, {1403, 6, 6, 40}, {1403, 6, 5, 40}// 624	625	626	
			, {1403, 5, 8, 40}, {1403, 5, 7, 40}, {1403, 5, 6, 40}// 627	628	629	
			, {1403, 5, 5, 40}, {1403, 4, 8, 40}, {1403, 4, 7, 40}// 630	631	632	
			, {1403, 4, 6, 40}, {1403, 4, 5, 40}, {1403, 3, 8, 40}// 633	634	635	
			, {1403, 3, 7, 40}, {1334, 5, 2, 40}, {1334, 5, 1, 40}// 636	637	638	
			, {1374, 8, 8, 20}, {1374, 8, 7, 20}, {1374, 8, 6, 20}// 639	640	641	
			, {1374, 8, 5, 20}, {1374, 7, 8, 20}, {1374, 6, 8, 20}// 642	643	644	
			, {1374, 6, 7, 20}, {1374, 6, 6, 20}, {1374, 6, 5, 20}// 645	646	647	
			, {1374, 5, 8, 20}, {1374, 5, 7, 20}, {1374, 5, 6, 20}// 648	649	650	
			, {1374, 5, 5, 20}, {1374, 4, 8, 20}, {1374, 4, 7, 20}// 651	652	653	
			, {1374, 4, 6, 20}, {1374, 4, 5, 20}, {1374, 3, 8, 20}// 654	655	656	
			, {1374, 3, 7, 20}, {1374, 8, 4, 20}, {1374, 8, 3, 20}// 657	658	659	
			, {1374, 7, 3, 20}, {1374, 7, 2, 20}, {1374, 7, 1, 20}// 660	661	662	
			, {1374, 6, 4, 20}, {1279, 8, 8, 0}, {1279, 8, 7, 0}// 663	664	665	
			, {1374, 6, 3, 20}, {1279, 8, 6, 0}, {1374, 6, 2, 20}// 666	667	668	
			, {1374, 6, 1, 20}, {1279, 8, 5, 0}, {1279, 7, 8, 0}// 669	670	671	
			, {1279, 6, 8, 0}, {1374, 5, 4, 20}, {1374, 5, 3, 20}// 672	673	674	
			, {1374, 5, 2, 20}, {1279, 6, 7, 0}, {1374, 5, 1, 20}// 675	676	677	
			, {1279, 6, 6, 0}, {1403, 4, 4, 40}, {1279, 6, 5, 0}// 678	679	680	
			, {1279, 5, 8, 0}, {1403, 4, 3, 40}, {1279, 5, 7, 0}// 681	682	683	
			, {1279, 5, 6, 0}, {1279, 5, 5, 0}, {1279, 4, 8, 0}// 684	685	686	
			, {1279, 4, 7, 0}, {1279, 4, 6, 0}, {1374, 4, 4, 20}// 687	688	689	
			, {1279, 4, 5, 0}, {1374, 4, 3, 20}, {1279, 3, 8, 0}// 690	691	692	
			, {1279, 3, 7, 0}, {1279, 3, 6, 0}, {1279, 3, 5, 0}// 693	694	695	
			, {1006, 3, 3, 25}, {1006, 3, 4, 25}, {1006, 3, 3, 30}// 696	697	698	
			, {1007, 3, 4, 30}, {1007, 3, 3, 35}, {953, 8, 4, 60}// 699	700	701	
			, {952, 8, 3, 60}, {954, 8, 2, 60}, {957, 7, 3, 60}// 702	703	704	
			, {954, 7, 2, 60}, {953, 6, 4, 60}, {956, 6, 3, 60}// 705	706	707	
			, {965, 6, 2, 60}, {963, 5, 2, 60}, {954, 4, 2, 60}// 708	709	710	
			, {954, 3, 2, 60}, {516, 8, 4, 40}, {518, 8, 3, 40}// 711	712	713	
			, {512, 8, 2, 40}, {1009, 7, 4, 40}, {992, 7, 2, 40}// 714	715	716	
			, {511, 4, 2, 40}, {517, 3, 2, 40}, {516, 8, 4, 20}// 717	718	728	
			, {518, 8, 3, 20}, {512, 8, 2, 20}, {511, 7, 2, 20}// 730	731	733	
			, {518, 4, 3, 20}, {511, 4, 2, 20}, {1006, 3, 4, 20}// 734	735	736	
			, {1006, 3, 3, 20}, {517, 3, 2, 20}, {1279, 8, 4, 0}// 737	738	742	
			, {1279, 8, 3, 0}, {516, 8, 4, 0}, {518, 8, 3, 0}// 743	744	745	
			, {512, 8, 2, 0}, {1279, 7, 3, 0}, {1009, 7, 4, 0}// 746	747	748	
			, {514, 6, 4, 0}, {1279, 6, 4, 0}, {1279, 6, 3, 0}// 749	750	751	
			, {1009, 7, 5, 5}, {1006, 7, 6, 5}, {1006, 7, 7, 5}// 752	753	754	
			, {1009, 7, 6, 10}, {1006, 7, 7, 10}, {1009, 7, 7, 15}// 755	756	757	
			, {1007, 3, 5, 25}, {1009, 7, 5, 45}, {1006, 7, 6, 45}// 758	759	760	
			, {1006, 7, 7, 45}, {1009, 7, 6, 50}, {1006, 7, 7, 50}// 761	762	763	
			, {1009, 7, 7, 55}, {959, 8, 8, 60}, {953, 8, 7, 60}// 764	765	766	
			, {966, 8, 6, 60}, {964, 8, 5, 60}, {954, 7, 8, 60}// 767	768	769	
			, {965, 6, 8, 60}, {953, 6, 6, 60}, {953, 6, 5, 60}// 770	771	772	
			, {963, 5, 8, 60}, {954, 4, 8, 60}, {954, 3, 8, 60}// 773	774	775	
			, {967, 8, 8, 40}, {984, 8, 7, 40}, {513, 8, 6, 40}// 776	777	778	
			, {1199, 8, 4, 60}, {993, 7, 8, 40}, {1006, 7, 7, 40}// 779	780	781	
			, {1006, 7, 6, 40}, {1203, 8, 3, 60}, {1006, 7, 5, 40}// 782	783	784	
			, {983, 6, 8, 40}, {511, 5, 8, 40}, {1200, 7, 3, 60}// 785	786	787	
			, {514, 5, 5, 40}, {515, 4, 8, 40}, {517, 3, 8, 40}// 788	789	790	
			, {1329, 7, 1, 60}, {971, 8, 8, 20}, {984, 8, 7, 20}// 791	792	793	
			, {513, 8, 6, 20}, {983, 7, 8, 20}, {512, 6, 8, 20}// 794	795	796	
			, {515, 4, 8, 20}, {513, 4, 5, 20}, {517, 3, 8, 20}// 797	798	799	
			, {1007, 3, 6, 20}, {1006, 3, 5, 20}, {992, 8, 8, 0}// 800	801	802	
			, {984, 8, 7, 0}, {513, 8, 6, 0}, {983, 7, 8, 0}// 803	804	805	
			, {1006, 7, 7, 0}, {1189, 6, 4, 60}, {1200, 6, 3, 60}// 806	807	808	
			, {1329, 6, 1, 60}, {1006, 7, 6, 0}, {1189, 5, 4, 60}// 809	810	811	
			, {1006, 7, 5, 0}, {1200, 5, 3, 60}, {511, 6, 8, 0}// 812	813	814	
			, {1329, 5, 1, 60}, {516, 6, 7, 0}, {1189, 4, 4, 60}// 815	816	817	
			, {515, 4, 8, 0}, {1200, 4, 3, 60}, {1197, 3, 4, 60}// 818	819	820	
			, {517, 3, 8, 0}, {1201, 8, 8, 60}, {1199, 8, 7, 60}// 821	822	823	
			, {1199, 8, 6, 60}, {1199, 8, 5, 60}, {1198, 7, 8, 60}// 824	825	826	
			, {1198, 6, 8, 60}, {1279, 5, 4, 0}, {1189, 6, 7, 60}// 827	828	829	
			, {1189, 6, 6, 60}, {1189, 6, 5, 60}, {1198, 5, 8, 60}// 830	831	832	
			, {1189, 5, 7, 60}, {1189, 5, 6, 60}, {1189, 5, 5, 60}// 833	834	835	
			, {1198, 4, 8, 60}, {1189, 4, 7, 60}, {1189, 4, 6, 60}// 836	837	838	
			, {1189, 4, 5, 60}, {1202, 3, 8, 60}, {1197, 3, 7, 60}// 839	840	841	
			, {1197, 3, 6, 60}, {1197, 3, 5, 60}, {1403, 8, 8, 40}// 842	843	844	
			, {1279, 5, 3, 0}, {1279, 4, 4, 0}, {1279, 4, 3, 0}// 845	846	847	
			, {6017, 4, 1, 0}, {1279, 3, 4, 0}, {1279, 3, 3, 0}// 848	849	850	
			, {1403, 8, 4, 40}, {1403, 8, 3, 40}, {1403, 7, 3, 40}// 851	852	853	
			, {1334, 7, 2, 40}, {1334, 7, 1, 40}, {1403, 6, 4, 40}// 854	855	856	
			, {1403, 6, 3, 40}, {1334, 6, 2, 40}, {1334, 6, 1, 40}// 857	858	859	
			, {1403, 5, 4, 40}, {1204, 3, 3, 60}, {515, 7, 2, 0}// 860	861	862	
			, {515, 4, 2, 0}, {517, 3, 2, 0}// 865	866	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Luna_Library_Ruins_1AddonDeed();
			}
		}

		[ Constructable ]
		public Luna_Library_Ruins_1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 11539, -2, -6, 40, 0, -1, "Zagros - Developer", 1);// 26
			AddComplexComponent( (BaseAddon) this, 7712, -2, -5, 26, 0, -1, "Collected Works by William Raistspear", 1);// 29
			AddComplexComponent( (BaseAddon) this, 7620, -2, -5, 20, 871, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 9411, -6, -3, 20, 0, 1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 9409, -2, -6, 20, 0, 1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 7622, -3, -5, 20, 871, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 4632, -3, -6, 20, 871, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 10704, -3, -5, 26, 871, -1, "Desk Blotter", 1);// 67
			AddComplexComponent( (BaseAddon) this, 7621, -4, -5, 20, 871, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2455, -4, -5, 26, 0, -1, "Coffee", 1);// 69
			AddComplexComponent( (BaseAddon) this, 521, 2, 0, 40, 0, 0, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 519, 1, 0, 40, 0, 0, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 990, 1, -7, 40, 0, 0, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 990, 0, -7, 40, 0, 0, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 522, -1, -1, 40, 0, 0, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 521, -3, -2, 40, 0, 0, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 519, -3, -7, 40, 0, 0, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 521, -4, -2, 40, 0, 0, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 519, -4, -7, 40, 0, 0, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 521, 2, 0, 20, 0, 0, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 521, 1, 0, 20, 0, 0, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 990, 1, -7, 20, 0, 0, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 990, 0, -7, 20, 0, 0, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 522, -1, -1, 20, 0, 0, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 990, -1, -7, 20, 0, 0, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 521, -3, -2, 20, 0, 0, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 990, -3, -7, 20, 0, 0, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 990, -4, -7, 20, 0, 0, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 990, 0, -7, 0, 0, 0, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 990, -1, -7, 0, 0, 0, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 991, -3, -6, 0, 0, 0, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 522, -4, -3, 0, 0, 0, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 990, -4, -7, 0, 0, 0, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 521, -5, -2, 40, 0, 0, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 521, -5, -7, 40, 0, 0, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 522, -7, -3, 40, 0, 0, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 522, -7, -4, 40, 0, 0, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 522, -7, -5, 40, 0, 0, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 521, -4, -2, 20, 0, 0, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 990, -5, -7, 20, 0, 0, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 522, -7, -3, 20, 0, 0, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 522, -7, -4, 20, 0, 0, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 522, -7, -5, 20, 0, 0, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 521, -5, -2, 0, 0, 0, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 522, -7, -4, 0, 0, 0, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 522, -7, -5, 0, 0, 0, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1283, 0, -6, 40, 0, -1, "flagstones", 1);// 226
			AddComplexComponent( (BaseAddon) this, 3633, -6, -6, 40, 0, 2, "", 1);// 316
			AddComplexComponent( (BaseAddon) this, 11539, -4, -6, 40, 0, -1, "Tixu - Gamesmaster", 1);// 318
			AddComplexComponent( (BaseAddon) this, 11539, 0, -6, 40, 0, -1, "Maximus - Gamesmaster", 1);// 319
			AddComplexComponent( (BaseAddon) this, 3633, 2, -6, 40, 0, 2, "", 1);// 320
			AddComplexComponent( (BaseAddon) this, 3633, -2, -6, 40, 0, 2, "", 1);// 322
			AddComplexComponent( (BaseAddon) this, 11538, 1, -3, 40, 0, -1, "Ivy - Gamesnaster", 1);// 323
			AddComplexComponent( (BaseAddon) this, 11538, 1, -1, 40, 0, -1, "Rose - Gamesmaster", 1);// 324
			AddComplexComponent( (BaseAddon) this, 3633, -4, -6, 40, 0, 2, "", 1);// 327
			AddComplexComponent( (BaseAddon) this, 3633, 0, -6, 40, 0, 2, "", 1);// 329
			AddComplexComponent( (BaseAddon) this, 11539, -6, -6, 40, 0, -1, "Angellus - Developer", 1);// 331
			AddComplexComponent( (BaseAddon) this, 522, 2, -1, 0, 0, 0, "", 1);// 334
			AddComplexComponent( (BaseAddon) this, 522, 2, -2, 0, 0, 0, "", 1);// 335
			AddComplexComponent( (BaseAddon) this, 522, 2, 7, 40, 0, 0, "", 1);// 342
			AddComplexComponent( (BaseAddon) this, 522, 2, 6, 40, 0, 0, "", 1);// 343
			AddComplexComponent( (BaseAddon) this, 522, 2, 7, 20, 0, 0, "", 1);// 344
			AddComplexComponent( (BaseAddon) this, 522, 2, 6, 20, 0, 0, "", 1);// 345
			AddComplexComponent( (BaseAddon) this, 522, 2, 7, 0, 0, 0, "", 1);// 347
			AddComplexComponent( (BaseAddon) this, 522, 2, 4, 40, 0, 0, "", 1);// 348
			AddComplexComponent( (BaseAddon) this, 522, 2, 3, 40, 0, 0, "", 1);// 349
			AddComplexComponent( (BaseAddon) this, 522, 2, 4, 20, 0, 0, "", 1);// 351
			AddComplexComponent( (BaseAddon) this, 522, 2, 3, 20, 0, 0, "", 1);// 352
			AddComplexComponent( (BaseAddon) this, 522, 2, 4, 0, 0, 0, "", 1);// 353
			AddComplexComponent( (BaseAddon) this, 4080, 5, -6, 25, 0, -1, "Around the World in 80 Moongates-First Edition", 1);// 365
			AddComplexComponent( (BaseAddon) this, 9409, 6, -6, 20, 0, 1, "", 1);// 371
			AddComplexComponent( (BaseAddon) this, 4082, 4, -6, 26, 0, -1, "Mona Lisas and Mad Hatters-First Edition", 1);// 375
			AddComplexComponent( (BaseAddon) this, 4079, 3, -6, 26, 0, -1, "A Shard's Tale-First Edition", 1);// 377
			AddComplexComponent( (BaseAddon) this, 991, 8, -1, 40, 0, 0, "", 1);// 467
			AddComplexComponent( (BaseAddon) this, 991, 8, -3, 40, 0, 0, "", 1);// 468
			AddComplexComponent( (BaseAddon) this, 991, 8, -5, 40, 0, 0, "", 1);// 469
			AddComplexComponent( (BaseAddon) this, 990, 7, -7, 40, 0, 0, "", 1);// 473
			AddComplexComponent( (BaseAddon) this, 990, 6, -7, 40, 0, 0, "", 1);// 475
			AddComplexComponent( (BaseAddon) this, 519, 4, 0, 40, 0, 0, "", 1);// 478
			AddComplexComponent( (BaseAddon) this, 990, 4, -7, 40, 0, 0, "", 1);// 479
			AddComplexComponent( (BaseAddon) this, 990, 3, -7, 40, 0, 0, "", 1);// 480
			AddComplexComponent( (BaseAddon) this, 991, 8, -2, 20, 0, 0, "", 1);// 484
			AddComplexComponent( (BaseAddon) this, 991, 8, -3, 20, 0, 0, "", 1);// 486
			AddComplexComponent( (BaseAddon) this, 991, 8, -4, 20, 0, 0, "", 1);// 487
			AddComplexComponent( (BaseAddon) this, 990, 5, -7, 20, 0, 0, "", 1);// 488
			AddComplexComponent( (BaseAddon) this, 990, 4, -7, 20, 0, 0, "", 1);// 489
			AddComplexComponent( (BaseAddon) this, 990, 3, -7, 20, 0, 0, "", 1);// 490
			AddComplexComponent( (BaseAddon) this, 991, 8, -1, 0, 0, 0, "", 1);// 493
			AddComplexComponent( (BaseAddon) this, 991, 8, -2, 0, 0, 0, "", 1);// 494
			AddComplexComponent( (BaseAddon) this, 991, 8, -4, 0, 0, 0, "", 1);// 496
			AddComplexComponent( (BaseAddon) this, 991, 8, -5, 0, 0, 0, "", 1);// 498
			AddComplexComponent( (BaseAddon) this, 521, 7, 0, 0, 0, 0, "", 1);// 500
			AddComplexComponent( (BaseAddon) this, 990, 7, -7, 0, 0, 0, "", 1);// 505
			AddComplexComponent( (BaseAddon) this, 521, 6, 0, 0, 0, 0, "", 1);// 508
			AddComplexComponent( (BaseAddon) this, 521, 5, 0, 0, 0, 0, "", 1);// 511
			AddComplexComponent( (BaseAddon) this, 990, 4, -7, 0, 0, 0, "", 1);// 513
			AddComplexComponent( (BaseAddon) this, 990, 3, -7, 0, 0, 0, "", 1);// 514
			AddComplexComponent( (BaseAddon) this, 3633, 4, -6, 40, 0, 2, "", 1);// 610
			AddComplexComponent( (BaseAddon) this, 2855, 4, -3, 40, 0, 1, "", 1);// 613
			AddComplexComponent( (BaseAddon) this, 3633, 6, -6, 40, 0, 2, "", 1);// 615
			AddComplexComponent( (BaseAddon) this, 521, 4, 0, 0, 0, 0, "", 1);// 617
			AddComplexComponent( (BaseAddon) this, 522, 8, 5, 40, 0, 0, "", 1);// 719
			AddComplexComponent( (BaseAddon) this, 522, 5, 7, 40, 0, 0, "", 1);// 720
			AddComplexComponent( (BaseAddon) this, 522, 5, 6, 40, 0, 0, "", 1);// 721
			AddComplexComponent( (BaseAddon) this, 522, 8, 5, 20, 0, 0, "", 1);// 722
			AddComplexComponent( (BaseAddon) this, 521, 5, 8, 20, 0, 0, "", 1);// 723
			AddComplexComponent( (BaseAddon) this, 522, 8, 5, 0, 0, 0, "", 1);// 724
			AddComplexComponent( (BaseAddon) this, 522, 6, 6, 0, 0, 0, "", 1);// 725
			AddComplexComponent( (BaseAddon) this, 522, 6, 5, 0, 0, 0, "", 1);// 726
			AddComplexComponent( (BaseAddon) this, 521, 5, 8, 0, 0, 0, "", 1);// 727
			AddComplexComponent( (BaseAddon) this, 991, 7, 1, 40, 0, 0, "", 1);// 729
			AddComplexComponent( (BaseAddon) this, 522, 4, 1, 40, 0, 0, "", 1);// 732
			AddComplexComponent( (BaseAddon) this, 522, 7, 1, 20, 0, 0, "", 1);// 739
			AddComplexComponent( (BaseAddon) this, 522, 4, 4, 20, 0, 0, "", 1);// 740
			AddComplexComponent( (BaseAddon) this, 522, 4, 1, 20, 0, 0, "", 1);// 741
			AddComplexComponent( (BaseAddon) this, 521, 6, 2, 0, 0, 0, "", 1);// 863
			AddComplexComponent( (BaseAddon) this, 521, 5, 2, 0, 0, 0, "", 1);// 864

		}

		public Luna_Library_Ruins_1Addon( Serial serial ) : base( serial )
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

	public class Luna_Library_Ruins_1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Luna_Library_Ruins_1Addon();
			}
		}

		[Constructable]
		public Luna_Library_Ruins_1AddonDeed()
		{
			Name = "Luna_Library_Ruins_1";
		}

		public Luna_Library_Ruins_1AddonDeed( Serial serial ) : base( serial )
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