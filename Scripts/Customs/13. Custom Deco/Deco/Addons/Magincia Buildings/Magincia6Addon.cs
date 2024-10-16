
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
	public class Magincia6Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {352, -7, -12, 0}, {352, -3, -12, 0}, {352, -5, -12, 0}// 1	2	3	
			, {352, -1, -12, 0}, {353, -8, -12, 0}, {1327, -5, -4, 0}// 4	5	10	
			, {1327, -4, -8, 0}, {1327, -5, -1, 0}, {1327, -4, -10, 0}// 11	12	13	
			, {1327, -4, -9, 0}, {1327, -4, -6, 0}, {1327, -5, -3, 0}// 14	15	16	
			, {1327, -4, -4, 0}, {1327, -4, -7, 0}, {1327, -5, -2, 0}// 17	18	19	
			, {1327, -2, 4, 0}, {1327, -2, 3, 0}, {1327, -2, 2, 0}// 20	21	22	
			, {1327, -3, 1, 0}, {1327, -2, 1, 0}, {1327, -3, 2, 0}// 23	24	25	
			, {1327, -3, 3, 0}, {1327, -6, -4, 0}, {1327, -6, -10, 0}// 26	27	28	
			, {1327, -3, 4, 0}, {1327, -4, -5, 0}, {1327, -2, -11, 0}// 29	30	31	
			, {1327, -6, -3, 0}, {1327, -2, -10, 0}, {1327, -2, -9, 0}// 32	33	34	
			, {1327, -2, -8, 0}, {1327, -2, -7, 0}, {1327, -2, -6, 0}// 35	36	37	
			, {1327, -2, -5, 0}, {1327, -2, -4, 0}, {1327, -2, -3, 0}// 38	39	40	
			, {1327, -2, -2, 0}, {1327, -6, -2, 0}, {1327, -2, -1, 0}// 41	42	43	
			, {1327, -2, 0, 0}, {1327, -3, -3, 0}, {1327, -3, -2, 0}// 44	45	46	
			, {1327, -3, -1, 0}, {1327, -5, -5, 0}, {1327, -6, 4, 0}// 47	48	49	
			, {1327, -5, 3, 0}, {1327, -5, 1, 0}, {2798, -2, -2, 1}// 50	51	52	
			, {2799, -1, -9, 1}, {2799, -5, 1, 1}, {2799, -5, -7, 1}// 53	54	55	
			, {2800, -5, -2, 1}, {2800, -1, -6, 1}, {2801, -2, -7, 1}// 56	57	58	
			, {2801, -2, 1, 1}, {2802, -1, -7, 1}, {2802, -5, -3, 1}// 59	60	61	
			, {2802, -5, 2, 1}, {2802, -5, 3, 1}, {2802, -1, -8, 1}// 62	63	64	
			, {2802, -5, -6, 1}, {2802, -5, 4, 1}, {2802, -5, -5, 1}// 65	66	67	
			, {2802, -5, -4, 1}, {2803, -3, -7, 1}, {2803, -3, 1, 1}// 68	69	70	
			, {2803, -4, -7, 1}, {2803, 0, -9, 1}, {2803, -4, 1, 1}// 71	72	73	
			, {2804, -2, -5, 1}, {2804, -2, -4, 1}, {2804, -2, -3, 1}// 74	75	76	
			, {2804, -2, 4, 1}, {2804, -2, 2, 1}, {2804, -2, -6, 1}// 77	78	79	
			, {2804, -2, 3, 1}, {2805, -3, -2, 1}, {2805, 0, -6, 1}// 80	81	82	
			, {2805, -4, -2, 1}, {2810, -4, 4, 1}, {2810, -3, -4, 1}// 83	84	85	
			, {2810, -3, -5, 1}, {2810, -3, -3, 1}, {2810, 0, -8, 1}// 86	87	88	
			, {2810, -3, -6, 1}, {2810, -3, 3, 1}, {2810, -3, 4, 1}// 89	90	91	
			, {2810, 0, -7, 1}, {2810, -4, -5, 1}, {2810, -4, 3, 1}// 92	93	94	
			, {2810, -4, 2, 1}, {2810, -3, 2, 1}, {2810, -4, -4, 1}// 95	96	97	
			, {2810, -4, -3, 1}, {2810, -4, -6, 1}, {2825, -7, -6, 0}// 98	99	100	
			, {2825, -7, 1, 0}, {2825, -7, 4, 0}, {2825, -7, -3, 0}// 101	102	103	
			, {2826, -3, -11, 0}, {4229, -3, -11, 3}, {4231, -7, -6, 8}// 104	105	106	
			, {4232, -7, -3, 7}, {4233, -7, 1, 4}, {4235, -7, 4, 5}// 107	108	109	
			, {351, -8, -11, 0}, {351, -8, -2, 0}, {351, 0, -3, 0}// 110	111	112	
			, {351, -8, 0, 0}, {351, 0, -2, 0}, {351, -8, 1, 0}// 113	114	115	
			, {351, -8, 3, 0}, {351, -8, 4, 0}, {351, -8, -3, 0}// 116	117	118	
			, {351, 0, 4, 0}, {351, -8, -5, 0}, {351, -8, -6, 0}// 119	120	121	
			, {351, -8, -8, 0}, {351, -8, -9, 0}, {351, 0, 3, 0}// 122	123	124	
			, {353, 0, -4, 0}, {359, 0, 1, 0}, {359, 0, 1, 20}// 125	131	132	
			, {359, 0, -1, 10}, {359, 0, -1, 20}, {359, 0, -1, 0}// 133	134	135	
			, {359, 0, 1, 10}, {366, 0, 2, 0}, {367, 0, -1, 0}// 136	137	138	
			, {1370, 0, 3, 20}, {1387, 0, 0, 20}, {1387, 0, -1, 20}// 139	140	141	
			, {1387, 0, 2, 20}, {1387, 0, 1, 20}, {1387, 0, -2, 20}// 142	143	144	
			, {1392, -7, 4, 20}, {1392, -7, -10, 20}, {1392, -7, -6, 20}// 145	146	147	
			, {1392, -7, -5, 20}, {1392, -7, 3, 20}, {1392, -7, -3, 20}// 148	149	150	
			, {1392, -7, 0, 20}, {1392, -7, -1, 20}, {1392, -7, -2, 20}// 151	152	153	
			, {1392, -7, -4, 20}, {1392, -7, 2, 20}, {1392, -7, 1, 20}// 154	155	156	
			, {1392, -7, -8, 20}, {1392, -7, -9, 20}, {1392, -7, -7, 20}// 157	158	159	
			, {1393, -5, -11, 20}, {1393, 0, -11, 20}, {1393, -2, -11, 20}// 160	161	162	
			, {1393, -6, -11, 20}, {1393, -3, -11, 20}, {1393, -4, -11, 20}// 163	164	165	
			, {1393, -1, -11, 20}, {1394, -7, -11, 20}, {1395, 0, -9, 20}// 166	167	168	
			, {1395, 0, -4, 20}, {1395, -3, -8, 20}, {1395, -4, 4, 20}// 169	170	171	
			, {1395, 0, -8, 20}, {1395, -3, 3, 20}, {1395, -3, 0, 20}// 172	173	174	
			, {1395, -3, -1, 20}, {1395, -3, 4, 20}, {1395, -2, 2, 20}// 175	176	177	
			, {1395, -5, -3, 20}, {1395, -5, -7, 20}, {1395, -5, -9, 20}// 178	179	180	
			, {1395, -5, 0, 20}, {1395, -6, -4, 20}, {1395, -6, -6, 20}// 181	182	183	
			, {1395, -6, 0, 20}, {1395, -6, 3, 20}, {1395, -1, 3, 20}// 184	185	186	
			, {1395, -1, -3, 20}, {1395, -1, 0, 20}, {1395, -1, -4, 20}// 187	188	189	
			, {1396, -1, 1, 20}, {1396, -3, -5, 20}, {1396, -5, -1, 20}// 190	191	192	
			, {1396, -1, -2, 20}, {1396, -6, -8, 20}, {1396, -4, -1, 20}// 193	194	195	
			, {1396, -3, 1, 20}, {1396, -4, 3, 20}, {1396, -6, 2, 20}// 196	197	198	
			, {1396, -2, -4, 20}, {1396, -1, -7, 20}, {1396, -2, -9, 20}// 199	200	201	
			, {1397, -1, 2, 20}, {1397, 0, -6, 20}, {1397, -5, -5, 20}// 202	203	204	
			, {1397, -3, -6, 20}, {1397, -5, -4, 20}, {1397, -6, -10, 20}// 205	206	207	
			, {1397, -6, -7, 20}, {1397, 0, -3, 20}, {1397, -4, -2, 20}// 208	209	210	
			, {1397, -4, 0, 20}, {1397, -2, 0, 20}, {1397, -4, 1, 20}// 211	212	213	
			, {1397, -2, -10, 20}, {1397, -4, 2, 20}, {1397, -2, -1, 20}// 214	215	216	
			, {1397, -2, 3, 20}, {1397, -2, 4, 20}, {1397, -4, -6, 20}// 217	218	219	
			, {1397, -1, -1, 20}, {1397, -5, 2, 20}, {1397, -5, 3, 20}// 220	221	222	
			, {1398, -6, -5, 20}, {1398, -6, -9, 20}, {1398, -5, -6, 20}// 223	224	225	
			, {1398, -1, 4, 20}, {1398, 0, -10, 20}, {1398, -1, -10, 20}// 226	227	228	
			, {1398, -3, -7, 20}, {1398, -3, -2, 20}, {1398, -4, -7, 20}// 229	230	231	
			, {1398, -4, -9, 20}, {1398, -2, -8, 20}, {1398, -2, -6, 20}// 232	233	234	
			, {1398, -3, -9, 20}, {1399, -2, -5, 20}, {1399, -2, -3, 20}// 235	236	237	
			, {1399, -1, -5, 20}, {1399, 0, 4, 20}, {1399, 0, -5, 20}// 238	239	240	
			, {1399, -3, -4, 20}, {1399, -5, -10, 20}, {1399, -6, -3, 20}// 241	242	243	
			, {1399, -6, -1, 20}, {1399, -6, 1, 20}, {1399, -5, -2, 20}// 244	245	246	
			, {1399, -4, -4, 20}, {1399, -4, -8, 20}, {1399, -4, -10, 20}// 247	248	249	
			, {1399, -4, -3, 20}, {1400, -5, -8, 20}, {1400, -2, -2, 20}// 250	251	252	
			, {1400, -2, 1, 20}, {1400, -2, -7, 20}, {1400, -3, 2, 20}// 253	254	255	
			, {1400, -4, -5, 20}, {1400, -5, 4, 20}, {1400, -1, -8, 20}// 256	257	258	
			, {1400, -3, -3, 20}, {1400, -5, 1, 20}, {1400, -3, -10, 20}// 259	260	261	
			, {1400, -1, -6, 20}, {1400, -1, -9, 20}, {1400, -6, 4, 20}// 262	263	264	
			, {1400, -6, -2, 20}, {1400, 0, -7, 20}, {1582, 0, -3, 20}// 265	266	267	
			, {1327, -5, 0, 0}, {1327, -5, 4, 0}, {1327, -4, -11, 0}// 268	269	270	
			, {1327, -5, 2, 0}, {1327, -5, -9, 0}, {1327, -5, -6, 0}// 271	272	273	
			, {1327, -6, 2, 0}, {1327, -5, -8, 0}, {1327, -5, -7, 0}// 274	275	276	
			, {1327, -4, 0, 0}, {1327, -6, -5, 0}, {1327, -6, -6, 0}// 277	278	279	
			, {1327, -6, -7, 0}, {1327, -6, -8, 0}, {1327, -4, 2, 0}// 280	281	282	
			, {1327, -5, -10, 0}, {1327, -4, 1, 0}, {1327, -6, -1, 0}// 283	284	285	
			, {1327, -6, 1, 0}, {1327, -4, -3, 0}, {1327, -4, -1, 0}// 286	287	288	
			, {1327, -4, -2, 0}, {1327, -4, 4, 0}, {1327, -4, 3, 0}// 289	290	291	
			, {1327, -6, -9, 0}, {1327, -6, 0, 0}, {1327, -3, -8, 0}// 292	293	294	
			, {1327, -3, -9, 0}, {1327, -3, -10, 0}, {1327, -3, -11, 0}// 295	296	297	
			, {1327, -3, -4, 0}, {1327, -3, 0, 0}, {1327, -3, -7, 0}// 298	299	300	
			, {1327, -3, -6, 0}, {1327, -3, -5, 0}, {1327, -6, 3, 0}// 301	302	303	
			, {1327, -5, -11, 0}, {1327, -6, -11, 0}, {1327, -7, 3, 0}// 304	305	306	
			, {1327, -7, 4, 0}, {1327, -7, -2, 0}, {1327, -7, -1, 0}// 307	308	309	
			, {1327, -7, 0, 0}, {1327, -7, 1, 0}, {1327, -7, 2, 0}// 310	311	312	
			, {1327, -7, -8, 0}, {1327, -7, -7, 0}, {1327, -7, -6, 0}// 313	314	315	
			, {1327, -7, -5, 0}, {1327, -7, -4, 0}, {1327, -7, -3, 0}// 316	317	318	
			, {1327, -7, -11, 0}, {1327, -7, -10, 0}, {1327, -7, -9, 0}// 319	320	321	
			, {1327, -1, -11, 0}, {1327, -1, -10, 0}, {1327, -1, -9, 0}// 322	323	324	
			, {1327, -1, -8, 0}, {1327, -1, -7, 0}, {1327, -1, -6, 0}// 325	326	327	
			, {1327, -1, -5, 0}, {1327, -1, -4, 0}, {1327, -1, -3, 0}// 328	329	330	
			, {1327, -1, -2, 0}, {1327, -1, -1, 0}, {1327, -1, 0, 0}// 331	332	333	
			, {1327, -1, 1, 0}, {1327, -1, 2, 0}, {1327, -1, 3, 0}// 334	335	336	
			, {1327, -1, 4, 0}, {1327, 0, -9, 0}, {1327, 0, -10, 0}// 337	338	339	
			, {1327, 0, -11, 0}, {1327, 0, -8, 0}, {1327, 0, -7, 0}// 340	341	342	
			, {1327, 0, -6, 0}, {1327, 0, -5, 0}, {1327, 0, -4, 0}// 343	344	345	
			, {1327, 0, -3, 0}, {1327, 0, -2, 0}, {1327, 0, -1, 0}// 346	347	348	
			, {1327, 0, 0, 0}, {1327, 0, 1, 0}, {1327, 0, 2, 0}// 349	350	351	
			, {1327, 0, 3, 0}, {1327, 0, 4, 0}, {1327, -5, 7, 0}// 352	353	354	
			, {1327, -5, 9, 0}, {1327, -5, 11, 0}, {1327, -5, 6, 0}// 355	356	357	
			, {1327, -5, 10, 0}, {1327, -5, 5, 0}, {1327, -5, 8, 0}// 358	359	360	
			, {1327, -3, 7, 0}, {1327, -2, 5, 0}, {1327, -3, 5, 0}// 361	362	363	
			, {1327, -3, 6, 0}, {1327, -3, 8, 0}, {1327, -3, 9, 0}// 364	365	366	
			, {1327, -3, 10, 0}, {1327, -3, 11, 0}, {1327, -6, 5, 0}// 367	368	369	
			, {2798, -2, 6, 1}, {2799, -1, 7, 1}, {2800, -1, 10, 1}// 370	371	372	
			, {2800, -5, 6, 1}, {2802, -1, 9, 1}, {2802, -1, 8, 1}// 373	374	375	
			, {2802, -5, 5, 1}, {2803, 0, 7, 1}, {2804, -2, 5, 1}// 376	377	378	
			, {2805, -3, 6, 1}, {2805, -4, 6, 1}, {2805, 0, 10, 1}// 379	380	381	
			, {2810, 0, 9, 1}, {2810, 0, 8, 1}, {2810, -4, 5, 1}// 382	383	384	
			, {2810, -3, 5, 1}, {2825, -7, 10, 0}, {2923, -7, 7, 0}// 385	386	387	
			, {2924, -7, 6, 0}, {4232, -7, 10, 7}, {4031, -7, 6, 4}// 388	389	390	
			, {4029, -7, 7, 4}, {351, -8, 7, 0}, {351, -8, 6, 0}// 391	392	393	
			, {351, -8, 9, 0}, {351, -8, 12, 0}, {351, -8, 10, 0}// 394	395	396	
			, {352, -3, 12, 0}, {352, -5, 12, 0}, {352, -7, 12, 0}// 397	398	399	
			, {352, -1, 12, 0}, {1389, -2, 12, 20}, {1389, -3, 12, 20}// 400	408	409	
			, {1389, 0, 12, 20}, {1389, -1, 12, 20}, {1389, -4, 12, 20}// 410	411	412	
			, {1389, -6, 12, 20}, {1389, -5, 12, 20}, {1390, -7, 12, 20}// 413	414	415	
			, {1392, -7, 6, 20}, {1392, -7, 5, 20}, {1392, -7, 7, 20}// 416	417	418	
			, {1392, -7, 9, 20}, {1392, -7, 8, 20}, {1392, -7, 10, 20}// 419	420	421	
			, {1392, -7, 11, 20}, {1395, -3, 5, 20}, {1395, -4, 6, 20}// 422	423	424	
			, {1395, 0, 6, 20}, {1395, -3, 6, 20}, {1395, -2, 8, 20}// 425	426	427	
			, {1395, -2, 7, 20}, {1395, -5, 9, 20}, {1395, -6, 8, 20}// 428	429	430	
			, {1395, -1, 7, 20}, {1396, -4, 8, 20}, {1396, -6, 11, 20}// 431	432	433	
			, {1396, -5, 11, 20}, {1396, -6, 7, 20}, {1396, -6, 6, 20}// 434	435	436	
			, {1396, -1, 6, 20}, {1397, -6, 5, 20}, {1397, -6, 9, 20}// 437	438	439	
			, {1397, -6, 10, 20}, {1397, -3, 11, 20}, {1397, -2, 10, 20}// 440	441	442	
			, {1397, -4, 9, 20}, {1397, -4, 11, 20}, {1397, -1, 9, 20}// 443	444	445	
			, {1397, -4, 5, 20}, {1397, -3, 7, 20}, {1398, 0, 7, 20}// 446	447	448	
			, {1398, 0, 5, 20}, {1398, 0, 9, 20}, {1398, -5, 10, 20}// 449	450	451	
			, {1398, -5, 7, 20}, {1398, -1, 8, 20}, {1398, -3, 10, 20}// 452	453	454	
			, {1398, -3, 8, 20}, {1398, -1, 11, 20}, {1398, -2, 11, 20}// 455	456	457	
			, {1399, -2, 6, 20}, {1399, -2, 9, 20}, {1399, -2, 5, 20}// 458	459	460	
			, {1399, 0, 11, 20}, {1399, -5, 5, 20}, {1399, -4, 10, 20}// 461	462	463	
			, {1400, -5, 6, 20}, {1400, -4, 7, 20}, {1400, -5, 8, 20}// 464	465	466	
			, {1400, -1, 10, 20}, {1400, -1, 5, 20}, {1400, -3, 9, 20}// 467	468	469	
			, {1400, 0, 10, 20}, {1400, 0, 8, 20}, {1327, -4, 6, 0}// 470	471	472	
			, {1327, -4, 5, 0}, {1327, -4, 10, 0}, {1327, -4, 9, 0}// 473	474	475	
			, {1327, -4, 8, 0}, {1327, -4, 7, 0}, {1327, -4, 11, 0}// 476	477	478	
			, {1327, -6, 6, 0}, {1327, -6, 7, 0}, {1327, -6, 8, 0}// 479	480	481	
			, {1327, -6, 9, 0}, {1327, -6, 10, 0}, {1327, -6, 11, 0}// 482	483	484	
			, {1327, -7, 8, 0}, {1327, -7, 9, 0}, {1327, -7, 10, 0}// 485	486	487	
			, {1327, -7, 11, 0}, {1327, -7, 5, 0}, {1327, -7, 6, 0}// 488	489	490	
			, {1327, -7, 7, 0}, {1327, -2, 7, 0}, {1327, -2, 8, 0}// 491	492	493	
			, {1327, -2, 6, 0}, {1327, -2, 9, 0}, {1327, -2, 10, 0}// 494	495	496	
			, {1327, -2, 11, 0}, {1327, -1, 5, 0}, {1327, -1, 6, 0}// 497	498	499	
			, {1327, -1, 7, 0}, {1327, -1, 8, 0}, {1327, -1, 9, 0}// 500	501	502	
			, {1327, -1, 10, 0}, {1327, -1, 11, 0}, {1327, 0, 5, 0}// 503	504	505	
			, {1327, 0, 6, 0}, {1327, 0, 7, 0}, {1327, 0, 8, 0}// 506	507	508	
			, {1327, 0, 9, 0}, {1327, 0, 10, 0}, {1327, 0, 11, 0}// 509	510	511	
			, {1327, -7, 12, 0}, {1327, -6, 12, 0}, {1327, -5, 12, 0}// 512	513	514	
			, {1327, -4, 12, 0}, {1327, -3, 12, 0}, {1327, -2, 12, 0}// 515	516	517	
			, {1327, -1, 12, 0}, {1327, 0, 12, 0}, {352, 1, -12, 0}// 518	519	520	
			, {352, 5, -12, 0}, {352, 3, -12, 0}, {352, 7, -12, 0}// 521	522	523	
			, {352, 8, -12, 0}, {2798, 5, -6, 1}, {2801, 5, -9, 1}// 524	528	529	
			, {2803, 1, -9, 1}, {2803, 4, -9, 1}, {2803, 3, -9, 1}// 530	531	532	
			, {2803, 2, -9, 1}, {2804, 5, -8, 1}, {2804, 5, -7, 1}// 533	534	535	
			, {2805, 4, -6, 1}, {2805, 2, -6, 1}, {2805, 1, -6, 1}// 536	537	538	
			, {2805, 3, -6, 1}, {2810, 3, -8, 1}, {2810, 3, -7, 1}// 539	540	541	
			, {2810, 1, -7, 1}, {2810, 1, -8, 1}, {2810, 2, -8, 1}// 542	543	544	
			, {2810, 2, -7, 1}, {2810, 4, -7, 1}, {2810, 4, -8, 1}// 545	546	547	
			, {2826, 1, -11, 0}, {2826, 5, -11, 0}, {4230, 1, -11, 5}// 548	549	550	
			, {4234, 5, -11, 2}, {350, 8, -4, 0}, {351, 8, -7, 0}// 551	552	553	
			, {351, 8, -6, 0}, {351, 8, -10, 0}, {351, 8, -9, 0}// 554	555	556	
			, {352, 4, 4, 0}, {352, 4, -4, 0}, {352, 5, 4, 0}// 557	558	559	
			, {352, 5, -4, 0}, {352, 2, -4, 0}, {352, 2, 4, 0}// 560	561	562	
			, {352, 1, 4, 0}, {352, 1, -4, 0}, {352, 3, 4, 0}// 563	564	565	
			, {352, 3, -4, 0}, {352, 7, 4, 0}, {352, 7, -4, 0}// 566	567	568	
			, {352, 8, 4, 0}, {352, 6, 4, 0}, {352, 6, -4, 0}// 569	570	571	
			, {404, 3, -3, 0}, {404, 1, -3, 0}, {404, 8, -3, 0}// 575	576	577	
			, {404, 6, -3, 0}, {405, 3, 3, 0}, {405, 6, 3, 0}// 578	579	580	
			, {405, 8, 3, 0}, {405, 1, 3, 0}, {1387, 8, -5, 20}// 581	582	583	
			, {1387, 8, -10, 20}, {1387, 8, -4, 20}, {1387, 8, -8, 20}// 584	585	586	
			, {1387, 8, -6, 20}, {1387, 8, -7, 20}, {1387, 8, -9, 20}// 587	588	589	
			, {1387, 8, 4, 20}, {1388, 8, 3, 20}, {1388, 8, -11, 20}// 590	591	592	
			, {1389, 7, -3, 20}, {1389, 5, -3, 20}, {1389, 4, -3, 20}// 593	594	595	
			, {1389, 2, -3, 20}, {1389, 1, -3, 20}, {1389, 3, -3, 20}// 596	597	598	
			, {1389, 6, -3, 20}, {1391, 8, -3, 20}, {1393, 4, 3, 20}// 599	600	601	
			, {1393, 2, -11, 20}, {1393, 5, 3, 20}, {1393, 6, 3, 20}// 602	603	604	
			, {1393, 7, -11, 20}, {1393, 1, 3, 20}, {1393, 5, -11, 20}// 605	606	607	
			, {1393, 1, -11, 20}, {1393, 3, 3, 20}, {1393, 3, -11, 20}// 608	609	610	
			, {1393, 4, -11, 20}, {1393, 6, -11, 20}, {1393, 7, 3, 20}// 611	612	613	
			, {1393, 2, 3, 20}, {1395, 7, -8, 20}, {1395, 5, -4, 20}// 614	615	616	
			, {1395, 6, 4, 20}, {1395, 5, 4, 20}, {1395, 7, -9, 20}// 617	618	619	
			, {1395, 3, 4, 20}, {1395, 1, -6, 20}, {1395, 2, -8, 20}// 620	621	622	
			, {1395, 2, -10, 20}, {1396, 1, -7, 20}, {1396, 6, -9, 20}// 623	624	625	
			, {1396, 3, -4, 20}, {1396, 3, -8, 20}, {1396, 5, -9, 20}// 626	627	628	
			, {1396, 4, -9, 20}, {1397, 1, -5, 20}, {1397, 6, -8, 20}// 629	630	631	
			, {1397, 6, -10, 20}, {1397, 5, -8, 20}, {1397, 5, -10, 20}// 632	633	634	
			, {1397, 7, 4, 20}, {1397, 2, -4, 20}, {1397, 2, -9, 20}// 635	636	637	
			, {1397, 4, -4, 20}, {1397, 4, -6, 20}, {1397, 3, -7, 20}// 638	639	640	
			, {1397, 4, -10, 20}, {1398, 1, 4, 20}, {1398, 1, -9, 20}// 641	642	643	
			, {1398, 6, -5, 20}, {1398, 6, -6, 20}, {1398, 6, -7, 20}// 644	645	646	
			, {1398, 4, 4, 20}, {1398, 4, -7, 20}, {1398, 2, -5, 20}// 647	648	649	
			, {1398, 2, 4, 20}, {1398, 2, -7, 20}, {1398, 7, -7, 20}// 650	651	652	
			, {1398, 2, -6, 20}, {1399, 3, -6, 20}, {1399, 3, -10, 20}// 653	654	655	
			, {1399, 7, -6, 20}, {1399, 5, -6, 20}, {1399, 5, -7, 20}// 656	657	658	
			, {1399, 6, -4, 20}, {1399, 1, -8, 20}, {1399, 1, -10, 20}// 659	660	661	
			, {1399, 1, -4, 20}, {1400, 3, -5, 20}, {1400, 3, -9, 20}// 662	663	664	
			, {1400, 5, -5, 20}, {1400, 7, -5, 20}, {1400, 7, -4, 20}// 665	666	667	
			, {1400, 4, -8, 20}, {1400, 7, -10, 20}, {1400, 4, -5, 20}// 668	669	670	
			, {1327, 1, -11, 0}, {1327, 1, -10, 0}, {1327, 1, -9, 0}// 671	672	673	
			, {1327, 1, -8, 0}, {1327, 1, -7, 0}, {1327, 1, -6, 0}// 674	675	676	
			, {1327, 1, -5, 0}, {1327, 1, -4, 0}, {1327, 2, -11, 0}// 677	678	679	
			, {1327, 2, -10, 0}, {1327, 2, -9, 0}, {1327, 2, -8, 0}// 680	681	682	
			, {1327, 2, -7, 0}, {1327, 2, -6, 0}, {1327, 2, -5, 0}// 683	684	685	
			, {1327, 2, -4, 0}, {1327, 3, -11, 0}, {1327, 3, -10, 0}// 686	687	688	
			, {1327, 3, -9, 0}, {1327, 3, -8, 0}, {1327, 3, -7, 0}// 689	690	691	
			, {1327, 3, -6, 0}, {1327, 3, -5, 0}, {1327, 3, -4, 0}// 692	693	694	
			, {1327, 4, -11, 0}, {1327, 4, -10, 0}, {1327, 4, -9, 0}// 695	696	697	
			, {1327, 4, -8, 0}, {1327, 4, -7, 0}, {1327, 4, -6, 0}// 698	699	700	
			, {1327, 4, -5, 0}, {1327, 4, -4, 0}, {1327, 5, -11, 0}// 701	702	703	
			, {1327, 5, -10, 0}, {1327, 5, -9, 0}, {1327, 5, -8, 0}// 704	705	706	
			, {1327, 5, -7, 0}, {1327, 5, -6, 0}, {1327, 5, -5, 0}// 707	708	709	
			, {1327, 5, -4, 0}, {1327, 6, -11, 0}, {1327, 6, -10, 0}// 710	711	712	
			, {1327, 6, -9, 0}, {1327, 6, -8, 0}, {1327, 6, -7, 0}// 713	714	715	
			, {1327, 6, -6, 0}, {1327, 6, -5, 0}, {1327, 6, -4, 0}// 716	717	718	
			, {1327, 7, -11, 0}, {1327, 7, -10, 0}, {1327, 7, -9, 0}// 719	720	721	
			, {1327, 7, -8, 0}, {1327, 7, -7, 0}, {1327, 7, -6, 0}// 722	723	724	
			, {1327, 7, -5, 0}, {1327, 7, -4, 0}, {1327, 8, -11, 0}// 725	726	727	
			, {1327, 8, -10, 0}, {1327, 8, -9, 0}, {1327, 8, -8, 0}// 728	729	730	
			, {1327, 8, -7, 0}, {1327, 8, -6, 0}, {1327, 8, -5, 0}// 731	732	733	
			, {1327, 8, -4, 0}, {1327, 1, 4, 0}, {1327, 2, 4, 0}// 734	735	736	
			, {1327, 3, 4, 0}, {1327, 4, 4, 0}, {1327, 5, 4, 0}// 737	738	739	
			, {1327, 6, 4, 0}, {1327, 7, 4, 0}, {3009, 9, -3, 0}// 740	741	742	
			, {2798, 5, 10, 1}, {2801, 5, 7, 1}, {2803, 3, 7, 1}// 743	744	745	
			, {2803, 2, 7, 1}, {2803, 4, 7, 1}, {2803, 1, 7, 1}// 746	747	748	
			, {2804, 5, 8, 1}, {2804, 5, 9, 1}, {2805, 4, 10, 1}// 749	750	751	
			, {2805, 1, 10, 1}, {2805, 3, 10, 1}, {2805, 2, 10, 1}// 752	753	754	
			, {2810, 1, 9, 1}, {2810, 1, 8, 1}, {2810, 2, 8, 1}// 755	756	757	
			, {2810, 3, 8, 1}, {2810, 3, 9, 1}, {2810, 2, 9, 1}// 758	759	760	
			, {2810, 4, 8, 1}, {2810, 4, 9, 1}, {2826, 5, 5, 0}// 761	762	763	
			, {2826, 1, 5, 0}, {4229, 1, 5, 2}, {4231, 5, 5, 7}// 764	765	766	
			, {350, 8, 12, 0}, {351, 8, 7, 0}, {351, 8, 9, 0}// 767	768	769	
			, {351, 8, 10, 0}, {351, 8, 6, 0}, {352, 5, 12, 0}// 770	771	772	
			, {352, 1, 12, 0}, {352, 3, 12, 0}, {352, 7, 12, 0}// 773	774	775	
			, {1387, 8, 6, 20}, {1387, 8, 5, 20}, {1387, 8, 11, 20}// 782	783	784	
			, {1387, 8, 7, 20}, {1387, 8, 10, 20}, {1387, 8, 8, 20}// 785	786	787	
			, {1387, 8, 9, 20}, {1389, 7, 12, 20}, {1389, 5, 12, 20}// 788	789	790	
			, {1389, 6, 12, 20}, {1389, 4, 12, 20}, {1389, 2, 12, 20}// 791	792	793	
			, {1389, 1, 12, 20}, {1389, 3, 12, 20}, {1391, 8, 12, 20}// 794	795	796	
			, {1395, 3, 8, 20}, {1395, 3, 5, 20}, {1395, 3, 9, 20}// 797	798	799	
			, {1395, 1, 7, 20}, {1396, 1, 9, 20}, {1396, 1, 8, 20}// 800	801	802	
			, {1396, 1, 10, 20}, {1396, 1, 11, 20}, {1396, 5, 8, 20}// 803	804	805	
			, {1396, 5, 5, 20}, {1396, 5, 7, 20}, {1396, 6, 8, 20}// 806	807	808	
			, {1396, 2, 7, 20}, {1396, 2, 6, 20}, {1396, 2, 9, 20}// 809	810	811	
			, {1396, 2, 8, 20}, {1396, 4, 7, 20}, {1396, 7, 6, 20}// 812	813	814	
			, {1396, 7, 11, 20}, {1397, 6, 10, 20}, {1397, 6, 5, 20}// 815	816	817	
			, {1397, 5, 10, 20}, {1397, 5, 6, 20}, {1397, 7, 10, 20}// 818	819	820	
			, {1397, 6, 11, 20}, {1397, 7, 8, 20}, {1397, 2, 11, 20}// 821	822	823	
			, {1397, 4, 8, 20}, {1397, 3, 6, 20}, {1398, 1, 5, 20}// 824	825	826	
			, {1398, 3, 7, 20}, {1398, 4, 10, 20}, {1398, 4, 9, 20}// 827	828	829	
			, {1398, 4, 11, 20}, {1398, 5, 9, 20}, {1398, 2, 5, 20}// 830	831	832	
			, {1398, 6, 9, 20}, {1399, 3, 11, 20}, {1399, 7, 7, 20}// 833	834	835	
			, {1399, 7, 9, 20}, {1399, 5, 11, 20}, {1399, 6, 6, 20}// 836	837	838	
			, {1399, 1, 6, 20}, {1400, 2, 10, 20}, {1400, 3, 10, 20}// 839	840	841	
			, {1400, 7, 5, 20}, {1400, 6, 7, 20}, {1400, 4, 6, 20}// 842	843	844	
			, {1400, 4, 5, 20}, {1327, 1, 5, 0}, {1327, 1, 6, 0}// 845	846	847	
			, {1327, 1, 7, 0}, {1327, 1, 8, 0}, {1327, 1, 9, 0}// 848	849	850	
			, {1327, 1, 10, 0}, {1327, 1, 11, 0}, {1327, 1, 12, 0}// 851	852	853	
			, {1327, 2, 5, 0}, {1327, 2, 6, 0}, {1327, 2, 7, 0}// 854	855	856	
			, {1327, 2, 8, 0}, {1327, 2, 9, 0}, {1327, 2, 10, 0}// 857	858	859	
			, {1327, 2, 11, 0}, {1327, 2, 12, 0}, {1327, 3, 5, 0}// 860	861	862	
			, {1327, 3, 6, 0}, {1327, 3, 7, 0}, {1327, 3, 8, 0}// 863	864	865	
			, {1327, 3, 9, 0}, {1327, 3, 10, 0}, {1327, 3, 11, 0}// 866	867	868	
			, {1327, 3, 12, 0}, {1327, 4, 5, 0}, {1327, 4, 6, 0}// 869	870	871	
			, {1327, 4, 7, 0}, {1327, 4, 8, 0}, {1327, 4, 9, 0}// 872	873	874	
			, {1327, 4, 10, 0}, {1327, 4, 11, 0}, {1327, 4, 12, 0}// 875	876	877	
			, {1327, 5, 5, 0}, {1327, 5, 6, 0}, {1327, 5, 7, 0}// 878	879	880	
			, {1327, 5, 8, 0}, {1327, 5, 9, 0}, {1327, 5, 10, 0}// 881	882	883	
			, {1327, 5, 11, 0}, {1327, 5, 12, 0}, {1327, 6, 5, 0}// 884	885	886	
			, {1327, 6, 6, 0}, {1327, 6, 7, 0}, {1327, 6, 8, 0}// 887	888	889	
			, {1327, 6, 9, 0}, {1327, 6, 10, 0}, {1327, 6, 11, 0}// 890	891	892	
			, {1327, 6, 12, 0}, {1327, 7, 5, 0}, {1327, 7, 6, 0}// 893	894	895	
			, {1327, 7, 7, 0}, {1327, 7, 8, 0}, {1327, 7, 9, 0}// 896	897	898	
			, {1327, 7, 10, 0}, {1327, 7, 11, 0}, {1327, 7, 12, 0}// 899	900	901	
			, {1327, 8, 5, 0}, {1327, 8, 6, 0}, {1327, 8, 7, 0}// 902	903	904	
			, {1327, 8, 8, 0}, {1327, 8, 9, 0}, {1327, 8, 10, 0}// 905	906	907	
			, {1327, 8, 11, 0}, {1327, 8, 12, 0}, {1327, 1, 12, 0}// 908	909	910	
			, {1327, 2, 12, 0}, {1327, 3, 12, 0}, {1327, 4, 12, 0}// 911	912	913	
			, {1327, 5, 12, 0}, {1327, 6, 12, 0}, {1327, 7, 12, 0}// 914	915	916	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Magincia6AddonDeed();
			}
		}

		[ Constructable ]
		public Magincia6Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 355, 0, -12, 0, 0, 0, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 355, -2, -12, 0, 0, 0, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 355, -4, -12, 0, 0, 0, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 355, -6, -12, 0, 0, 0, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 354, -8, -4, 0, 0, 0, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 354, -8, -10, 0, 0, 0, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 354, -8, -7, 0, 0, 0, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 354, -8, -1, 0, 0, 0, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 354, -8, 2, 0, 0, 0, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 354, -8, 5, 0, 0, 0, "", 1);// 401
			AddComplexComponent( (BaseAddon) this, 354, -8, 11, 0, 0, 0, "", 1);// 402
			AddComplexComponent( (BaseAddon) this, 354, -8, 8, 0, 0, 0, "", 1);// 403
			AddComplexComponent( (BaseAddon) this, 355, -4, 12, 0, 0, 0, "", 1);// 404
			AddComplexComponent( (BaseAddon) this, 355, -2, 12, 0, 0, 0, "", 1);// 405
			AddComplexComponent( (BaseAddon) this, 355, 0, 12, 0, 0, 0, "", 1);// 406
			AddComplexComponent( (BaseAddon) this, 355, -6, 12, 0, 0, 0, "", 1);// 407
			AddComplexComponent( (BaseAddon) this, 355, 6, -12, 0, 0, 0, "", 1);// 525
			AddComplexComponent( (BaseAddon) this, 355, 2, -12, 0, 0, 0, "", 1);// 526
			AddComplexComponent( (BaseAddon) this, 355, 4, -12, 0, 0, 0, "", 1);// 527
			AddComplexComponent( (BaseAddon) this, 354, 8, -5, 0, 0, 0, "", 1);// 572
			AddComplexComponent( (BaseAddon) this, 354, 8, -11, 0, 0, 0, "", 1);// 573
			AddComplexComponent( (BaseAddon) this, 354, 8, -8, 0, 0, 0, "", 1);// 574
			AddComplexComponent( (BaseAddon) this, 354, 8, 8, 0, 0, 0, "", 1);// 776
			AddComplexComponent( (BaseAddon) this, 354, 8, 11, 0, 0, 0, "", 1);// 777
			AddComplexComponent( (BaseAddon) this, 354, 8, 5, 0, 0, 0, "", 1);// 778
			AddComplexComponent( (BaseAddon) this, 355, 4, 12, 0, 0, 0, "", 1);// 779
			AddComplexComponent( (BaseAddon) this, 355, 6, 12, 0, 0, 0, "", 1);// 780
			AddComplexComponent( (BaseAddon) this, 355, 2, 12, 0, 0, 0, "", 1);// 781

		}

		public Magincia6Addon( Serial serial ) : base( serial )
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

	public class Magincia6AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Magincia6Addon();
			}
		}

		[Constructable]
		public Magincia6AddonDeed()
		{
			Name = "Magincia6";
		}

		public Magincia6AddonDeed( Serial serial ) : base( serial )
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