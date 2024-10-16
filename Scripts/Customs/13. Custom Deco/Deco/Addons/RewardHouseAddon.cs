
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
	public class RewardHouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6015, -8, -8, 0}, {6016, -8, -7, 0}, {6015, -8, -6, 0}// 1	2	3	
			, {6014, -8, -5, 0}, {6015, -8, -4, 0}, {6016, -7, -8, 0}// 4	5	6	
			, {1245, -7, -6, 0}, {1239, -7, -5, 0}, {1239, -7, -4, 0}// 7	8	9	
			, {6015, -6, -8, 0}, {1239, -6, -6, 0}, {1239, -6, -5, 0}// 10	11	12	
			, {1239, -6, -4, 0}, {6015, -5, -8, 0}, {1238, -5, -6, 0}// 13	14	15	
			, {1239, -5, -5, 0}, {1239, -5, -4, 0}, {1247, -7, -7, 20}// 16	17	18	
			, {1239, -7, -6, 20}, {1239, -6, -6, 20}, {1237, -6, -5, 20}// 19	20	21	
			, {1239, -6, -4, 20}, {1239, -5, -6, 20}, {1239, -5, -5, 20}// 22	23	24	
			, {1239, -5, -4, 20}, {1239, -7, -6, 40}, {1242, -6, -7, 40}// 25	26	27	
			, {1239, -6, -6, 40}, {1237, -6, -5, 40}, {1239, -6, -4, 40}// 28	29	30	
			, {1241, -5, -7, 40}, {1239, -5, -6, 40}, {1239, -5, -5, 40}// 31	32	33	
			, {1239, -5, -4, 40}, {298, -8, -8, 0}, {339, -8, -7, 0}// 34	35	36	
			, {339, -8, -6, 0}, {339, -8, -5, 0}, {341, -8, -4, 0}// 37	38	39	
			, {338, -7, -8, 0}, {338, -7, -5, 0}, {338, -6, -8, 0}// 40	41	42	
			, {1848, -6, -7, 0}, {338, -6, -5, 0}, {338, -5, -8, 0}// 43	44	45	
			, {1848, -5, -7, 0}, {338, -5, -5, 0}, {298, -8, -8, 20}// 46	47	48	
			, {339, -8, -7, 20}, {311, -8, -6, 20}, {311, -8, -5, 20}// 49	50	51	
			, {338, -7, -8, 20}, {1851, -7, -5, 20}, {1848, -7, -4, 20}// 53	54	55	
			, {310, -6, -8, 20}, {310, -5, -8, 20}, {2236, -5, -6, 20}// 56	57	58	
			, {298, -8, -8, 40}, {339, -8, -7, 40}, {311, -8, -5, 40}// 59	60	62	
			, {311, -8, -4, 40}, {338, -7, -8, 40}, {2234, -7, -6, 40}// 63	64	65	
			, {310, -6, -8, 40}, {2237, -6, -5, 40}, {2237, -6, -4, 40}// 66	67	68	
			, {11377, -5, -4, 66}, {11377, -5, -5, 66}, {11377, -5, -6, 66}// 70	71	72	
			, {11377, -5, -7, 66}, {11377, -5, -8, 66}, {11377, -6, -4, 63}// 73	74	75	
			, {11377, -6, -5, 63}, {11377, -6, -6, 63}, {11377, -6, -7, 63}// 76	77	78	
			, {11377, -6, -8, 63}, {11377, -7, -4, 60}, {11377, -7, -5, 60}// 79	80	81	
			, {11377, -7, -6, 60}, {11377, -7, -7, 60}, {11377, -7, -8, 60}// 82	83	84	
			, {11377, -8, -4, 57}, {11377, -8, -5, 57}, {11377, -8, -6, 57}// 85	86	87	
			, {11377, -8, -7, 57}, {11377, -8, -8, 57}, {1851, -7, -4, 25}// 88	89	90	
			, {1850, -6, -7, 15}, {1850, -5, -7, 10}, {1848, -6, -7, 10}// 91	92	93	
			, {1848, -5, -7, 5}, {1848, -6, -7, 5}, {1241, -7, -7, 40}// 94	95	96	
			, {1245, -7, -7, 0}, {6014, -8, -3, 0}, {6015, -8, -2, 0}// 97	98	99	
			, {6015, -8, -1, 0}, {6015, -8, 0, 0}, {6016, -8, 1, 0}// 100	101	102	
			, {6014, -8, 2, 0}, {6013, -8, 3, 0}, {6015, -8, 4, 0}// 103	104	105	
			, {6015, -8, 5, 0}, {6013, -8, 6, 0}, {6013, -8, 7, 0}// 106	107	108	
			, {6013, -8, 8, 0}, {1239, -7, -3, 0}, {1239, -7, -2, 0}// 109	110	111	
			, {1239, -7, -1, 0}, {1239, -7, 0, 0}, {1239, -7, 1, 0}// 112	113	114	
			, {1245, -7, 2, 0}, {1239, -7, 3, 0}, {1245, -7, 4, 0}// 115	116	117	
			, {1239, -7, 5, 0}, {1246, -7, 6, 0}, {6013, -7, 7, 0}// 118	119	120	
			, {6013, -7, 8, 0}, {1238, -6, -3, 0}, {1239, -6, -2, 0}// 121	122	123	
			, {1239, -6, -1, 0}, {1238, -6, 0, 0}, {1239, -6, 1, 0}// 124	125	126	
			, {1239, -6, 2, 0}, {1238, -6, 3, 0}, {1239, -6, 4, 0}// 127	128	129	
			, {1239, -6, 5, 0}, {1239, -6, 6, 0}, {1246, -6, 7, 0}// 130	131	132	
			, {6014, -6, 8, 0}, {1239, -5, -3, 0}, {1238, -5, -2, 0}// 133	134	135	
			, {1239, -5, -1, 0}, {1239, -5, 0, 0}, {1238, -5, 1, 0}// 136	137	138	
			, {1239, -5, 2, 0}, {1239, -5, 3, 0}, {1239, -5, 4, 0}// 139	140	141	
			, {1239, -5, 5, 0}, {1239, -5, 6, 0}, {1240, -5, 7, 0}// 142	143	144	
			, {13522, -5, 8, 0}, {1239, -7, -1, 20}, {1239, -7, 0, 20}// 145	146	147	
			, {1239, -7, 1, 20}, {1239, -7, 2, 20}, {1239, -7, 3, 20}// 148	149	150	
			, {1237, -7, 4, 20}, {1245, -7, 5, 20}, {1245, -7, 6, 20}// 151	152	153	
			, {1246, -7, 7, 20}, {1239, -6, -3, 20}, {1239, -6, -2, 20}// 154	155	156	
			, {1239, -6, -1, 20}, {1237, -6, 0, 20}, {1239, -6, 1, 20}// 157	158	159	
			, {1236, -6, 2, 20}, {1239, -6, 3, 20}, {1236, -6, 4, 20}// 160	161	162	
			, {1239, -6, 5, 20}, {1239, -6, 6, 20}, {1240, -6, 7, 20}// 163	164	165	
			, {1236, -5, -3, 20}, {1239, -5, -2, 20}, {1239, -5, -1, 20}// 166	167	168	
			, {1239, -5, 0, 20}, {1239, -5, 1, 20}, {1239, -5, 2, 20}// 169	170	171	
			, {1239, -5, 3, 20}, {1239, -5, 4, 20}, {1239, -5, 5, 20}// 172	173	174	
			, {1236, -5, 6, 20}, {1243, -5, 7, 20}, {1239, -7, -1, 40}// 175	176	177	
			, {1239, -7, 0, 40}, {1239, -7, 1, 40}, {1245, -7, 2, 40}// 178	179	180	
			, {1239, -7, 3, 40}, {1239, -7, 4, 40}, {1239, -7, 5, 40}// 181	182	183	
			, {1239, -7, 6, 40}, {1246, -7, 7, 40}, {1239, -6, -3, 40}// 184	185	186	
			, {1239, -6, -2, 40}, {1239, -6, -1, 40}, {1237, -6, 0, 40}// 187	188	189	
			, {1238, -6, 1, 40}, {1239, -6, 2, 40}, {1239, -6, 3, 40}// 190	191	192	
			, {1239, -6, 4, 40}, {1239, -6, 5, 40}, {1239, -6, 6, 40}// 193	194	195	
			, {1243, -6, 7, 40}, {1239, -5, -3, 40}, {1238, -5, -2, 40}// 196	197	198	
			, {1239, -5, -1, 40}, {1239, -5, 0, 40}, {1239, -5, 1, 40}// 199	200	201	
			, {1239, -5, 2, 40}, {1239, -5, 3, 40}, {1239, -5, 4, 40}// 202	203	204	
			, {1238, -5, 5, 40}, {1237, -5, 6, 40}, {1240, -5, 7, 40}// 205	206	207	
			, {341, -8, -3, 0}, {339, -8, -2, 0}, {339, -8, -1, 0}// 208	209	210	
			, {339, -8, 0, 0}, {341, -8, 1, 0}, {341, -8, 2, 0}// 211	212	213	
			, {339, -8, 3, 0}, {339, -8, 4, 0}, {341, -8, 5, 0}// 214	215	216	
			, {341, -8, 6, 0}, {338, -7, 6, 0}, {339, -7, 7, 0}// 217	218	219	
			, {338, -6, 7, 0}, {67, -6, 8, 0}, {340, -5, 7, 0}// 220	221	222	
			, {66, -5, 8, 0}, {311, -8, -3, 20}, {311, -8, -2, 20}// 223	224	225	
			, {311, -8, -1, 20}, {311, -8, 0, 20}, {311, -8, 1, 20}// 226	227	228	
			, {305, -8, 3, 20}, {311, -8, 4, 20}, {308, -8, 6, 20}// 230	231	233	
			, {339, -8, 7, 20}, {1848, -7, -3, 20}, {1848, -7, -2, 20}// 234	235	236	
			, {310, -7, -1, 20}, {338, -7, 7, 20}, {298, -6, -3, 20}// 237	238	239	
			, {311, -6, -2, 20}, {309, -6, -1, 20}, {304, -6, 7, 20}// 240	241	242	
			, {310, -5, -3, 20}, {311, -8, -3, 40}, {311, -8, -1, 40}// 243	245	247	
			, {311, -8, 0, 40}, {311, -8, 1, 40}, {311, -8, 3, 40}// 248	249	251	
			, {311, -8, 4, 40}, {308, -8, 6, 40}, {339, -8, 7, 40}// 252	254	255	
			, {312, -7, 0, 40}, {338, -7, 7, 40}, {2237, -6, -3, 40}// 256	257	258	
			, {2239, -6, -2, 40}, {307, -6, 0, 40}, {310, -6, 7, 40}// 259	260	261	
			, {554, -6, 7, 60}, {554, -5, 7, 60}, {11377, -5, 8, 66}// 263	264	265	
			, {11377, -5, 7, 66}, {11377, -5, 6, 66}, {11377, -5, 5, 66}// 266	267	268	
			, {11377, -5, 4, 66}, {11377, -5, 3, 66}, {11377, -5, 2, 66}// 269	270	271	
			, {11377, -5, 1, 66}, {11377, -5, 0, 66}, {11377, -5, -1, 66}// 272	273	274	
			, {11377, -5, -2, 66}, {11377, -5, -3, 66}, {11377, -6, 8, 63}// 275	276	277	
			, {11377, -6, 7, 63}, {11377, -6, 6, 63}, {11377, -6, 5, 63}// 278	279	280	
			, {11377, -6, 4, 63}, {11377, -6, 3, 63}, {11377, -6, 2, 63}// 281	282	283	
			, {11377, -6, 1, 63}, {11377, -6, 0, 63}, {11377, -6, -1, 63}// 284	285	286	
			, {11377, -6, -2, 63}, {11377, -6, -3, 63}, {11377, -7, 8, 60}// 287	288	289	
			, {11377, -7, 7, 60}, {11377, -7, 6, 60}, {11377, -7, 5, 60}// 290	291	292	
			, {11377, -7, 4, 60}, {11377, -7, 3, 60}, {11377, -7, 2, 60}// 293	294	295	
			, {11377, -7, 1, 60}, {11377, -7, 0, 60}, {11377, -7, -1, 60}// 296	297	298	
			, {11377, -7, -2, 60}, {11377, -7, -3, 60}, {11377, -8, 8, 57}// 299	300	301	
			, {11377, -8, 7, 57}, {11377, -8, 6, 57}, {11377, -8, 5, 57}// 302	303	304	
			, {11377, -8, 4, 57}, {11377, -8, 3, 57}, {11377, -8, 2, 57}// 305	306	307	
			, {11377, -8, 1, 57}, {11377, -8, 0, 57}, {11377, -8, -1, 57}// 308	309	310	
			, {11377, -8, -2, 57}, {11377, -8, -3, 57}, {1851, -7, -2, 35}// 311	312	313	
			, {1848, -7, -2, 30}, {1851, -7, -3, 30}, {1848, -7, -2, 25}// 314	315	316	
			, {1848, -7, -3, 25}, {6015, -4, -8, 0}, {1239, -4, -6, 0}// 317	318	319	
			, {1239, -4, -5, 0}, {1239, -4, -4, 0}, {6015, -3, -8, 0}// 320	321	322	
			, {1239, -3, -6, 0}, {1238, -3, -5, 0}, {1239, -3, -4, 0}// 323	324	325	
			, {6016, -2, -8, 0}, {1241, -2, -7, 0}, {1239, -2, -6, 0}// 326	327	328	
			, {1238, -2, -5, 0}, {1239, -2, -4, 0}, {6013, -1, -8, 0}// 329	330	331	
			, {1241, -1, -7, 0}, {1244, -1, -6, 0}, {1244, -1, -5, 0}// 332	333	334	
			, {1244, -1, -4, 0}, {6015, 0, -8, 0}, {1273, 0, -7, 0}// 335	336	337	
			, {1271, 0, -6, 0}, {1271, 0, -5, 0}, {1271, 0, -4, 0}// 338	339	340	
			, {6013, 1, -8, 0}, {1268, 1, -7, 0}, {1267, 1, -6, 0}// 341	342	343	
			, {1267, 1, -5, 0}, {1267, 1, -4, 0}, {6015, 2, -8, 0}// 344	345	346	
			, {1268, 2, -7, 0}, {1267, 2, -6, 0}, {1267, 2, -5, 0}// 347	348	349	
			, {1267, 2, -4, 0}, {6013, 3, -8, 0}, {1268, 3, -7, 0}// 350	351	352	
			, {1267, 3, -6, 0}, {1267, 3, -5, 0}, {1267, 3, -4, 0}// 353	354	355	
			, {6015, 4, -8, 0}, {1268, 4, -7, 0}, {1267, 4, -6, 0}// 356	357	358	
			, {1267, 4, -5, 0}, {1267, 4, -4, 0}, {6014, 5, -8, 0}// 359	360	361	
			, {1268, 5, -7, 0}, {1267, 5, -6, 0}, {1267, 5, -5, 0}// 362	363	364	
			, {1267, 5, -4, 0}, {6016, 6, -8, 0}, {1268, 6, -7, 0}// 365	366	367	
			, {1267, 6, -6, 0}, {1267, 6, -5, 0}, {1267, 6, -4, 0}// 368	369	370	
			, {6015, 7, -8, 0}, {1269, 7, -7, 0}, {1269, 7, -6, 0}// 371	372	373	
			, {1269, 7, -5, 0}, {1269, 7, -4, 0}, {6016, 8, -8, 0}// 374	375	376	
			, {6014, 8, -7, 0}, {6016, 8, -6, 0}, {13522, 8, -5, 0}// 377	378	379	
			, {13522, 8, -4, 0}, {1239, -4, -6, 20}, {1237, -4, -5, 20}// 380	381	382	
			, {1239, -4, -4, 20}, {1239, -3, -6, 20}, {1239, -3, -5, 20}// 383	384	385	
			, {1239, -3, -4, 20}, {1242, -2, -7, 20}, {1239, -2, -6, 20}// 386	387	388	
			, {1236, -2, -5, 20}, {1239, -2, -4, 20}, {1242, -1, -7, 20}// 389	390	391	
			, {1239, -1, -6, 20}, {1239, -1, -5, 20}, {1239, -1, -4, 20}// 392	393	394	
			, {1242, 0, -7, 20}, {1239, 0, -6, 20}, {1239, 0, -5, 20}// 395	396	397	
			, {1239, 0, -4, 20}, {1242, 1, -7, 20}, {1239, 1, -6, 20}// 398	399	400	
			, {1239, 1, -5, 20}, {1239, 1, -4, 20}, {1242, 2, -7, 20}// 401	402	403	
			, {1239, 2, -6, 20}, {1239, 2, -5, 20}, {1236, 2, -4, 20}// 404	405	406	
			, {1242, 3, -7, 20}, {1239, 3, -6, 20}, {1236, 3, -5, 20}// 407	408	409	
			, {1239, 3, -4, 20}, {1242, 4, -7, 20}, {1239, 4, -6, 20}// 410	411	412	
			, {1239, 4, -5, 20}, {1239, 4, -4, 20}, {1242, 5, -7, 20}// 413	414	415	
			, {1239, 5, -6, 20}, {1239, 5, -5, 20}, {1236, 5, -4, 20}// 416	417	418	
			, {1242, 6, -7, 20}, {1239, 6, -6, 20}, {1239, 6, -5, 20}// 419	420	421	
			, {1239, 6, -4, 20}, {1249, 7, -7, 20}, {1244, 7, -6, 20}// 422	423	424	
			, {1244, 7, -5, 20}, {1244, 7, -4, 20}, {1242, -4, -7, 40}// 425	426	427	
			, {1239, -4, -6, 40}, {1238, -4, -5, 40}, {1239, -4, -4, 40}// 428	429	430	
			, {1242, -3, -7, 40}, {1239, -3, -6, 40}, {1238, -3, -5, 40}// 431	432	433	
			, {1239, -3, -4, 40}, {1242, -2, -7, 40}, {9262, -2, -6, 40}// 434	435	436	
			, {9257, -2, -5, 40}, {9257, -2, -4, 40}, {1242, -1, -7, 40}// 437	438	439	
			, {9259, -1, -6, 40}, {9269, -1, -5, 40}, {9269, -1, -4, 40}// 440	441	442	
			, {1241, 0, -7, 40}, {9259, 0, -6, 40}, {9269, 0, -5, 40}// 443	444	445	
			, {9269, 0, -4, 40}, {1241, 1, -7, 40}, {9259, 1, -6, 40}// 446	447	448	
			, {9269, 1, -5, 40}, {9269, 1, -4, 40}, {1242, 2, -7, 40}// 449	450	451	
			, {9259, 2, -6, 40}, {9269, 2, -5, 40}, {9269, 2, -4, 40}// 452	453	454	
			, {1241, 3, -7, 40}, {9259, 3, -6, 40}, {9269, 3, -5, 40}// 455	456	457	
			, {9269, 3, -4, 40}, {1242, 4, -7, 40}, {9263, 4, -6, 40}// 458	459	460	
			, {9260, 4, -5, 40}, {9260, 4, -4, 40}, {1242, 5, -7, 40}// 461	462	463	
			, {1239, 5, -6, 40}, {1239, 5, -5, 40}, {1239, 5, -4, 40}// 464	465	466	
			, {1241, 6, -7, 40}, {1241, 6, -6, 40}, {1239, 6, -5, 40}// 467	468	469	
			, {1238, 6, -4, 40}, {1249, 7, -7, 40}, {1216, 7, -6, 40}// 470	471	472	
			, {1209, 7, -5, 40}, {1209, 7, -4, 40}, {1215, 8, -6, 40}// 473	474	475	
			, {1211, 8, -5, 40}, {1211, 8, -4, 40}, {340, -4, -8, 0}// 476	477	478	
			, {1848, -4, -7, 0}, {338, -4, -5, 0}, {338, -3, -8, 0}// 479	480	481	
			, {1850, -3, -7, 0}, {338, -2, -8, 0}, {298, -2, -5, 0}// 482	483	484	
			, {338, -1, -8, 0}, {339, -1, -7, 0}, {339, -1, -6, 0}// 485	486	487	
			, {335, -1, -5, 0}, {339, -1, -4, 0}, {340, 0, -8, 0}// 488	489	490	
			, {338, 1, -8, 0} // 494	495	496	
			, {338, 2, -8, 0}, {338, 3, -8, 0}// 497	498	499	
			, {338, 4, -8, 0}, {340, 5, -8, 0}, {6427, 5, -7, 0}// 500	501	502	
			, {338, 6, -8, 0}, {338, 7, -8, 0}// 503	504	505	
			, {339, 7, -7, 0}, {334, 7, -6, 0}, {341, 7, -5, 0}// 506	507	508	
			, {343, 7, -4, 0}, {66, 8, -6, 0}, {67, 8, -5, 0}// 509	510	511	
			, {67, 8, -4, 0}, {2236, -4, -6, 20}, {310, -3, -8, 20}// 512	514	515	
			, {2236, -3, -6, 20}, {310, -2, -8, 20}, {2237, -2, -7, 20}// 516	517	518	
			, {310, -1, -8, 20}, {311, -1, -7, 20}, {311, -1, -6, 20}// 519	520	521	
			, {311, -1, -4, 20}, {310, 1, -8, 20}, {310, 2, -8, 20}// 522	524	525	
			, {310, 3, -8, 20}, {310, 4, -8, 20}, {307, 6, -8, 20}// 526	527	529	
			, {338, 7, -8, 20}, {339, 7, -7, 20}, {311, 7, -6, 20}// 530	531	532	
			, {303, 7, -4, 20}, {470, 8, -6, 20}, {310, -4, -8, 40}// 534	535	536	
			, {311, -4, -7, 40}, {311, -4, -6, 40}, {308, -4, -5, 40}// 537	538	539	
			, {310, -3, -8, 40}, {310, -2, -8, 40}, {310, 0, -8, 40}// 540	541	543	
			, {310, 1, -8, 40}, {310, 2, -8, 40}, {310, 3, -8, 40}// 544	545	546	
			, {310, 5, -8, 40}, {307, 6, -8, 40}, {298, 6, -7, 40}// 548	549	550	
			, {338, 7, -8, 40}, {335, 7, -7, 40}, {2234, 8, -7, 40}// 552	553	554	
			, {2232, 8, -6, 40}, {2232, 8, -5, 40}, {2232, 8, -4, 40}// 555	556	557	
			, {11387, 8, -4, 69}, {11387, 7, -4, 69}, {11387, 6, -4, 69}// 558	559	560	
			, {11387, 5, -4, 69}, {11384, 4, -4, 69}, {11387, 3, -4, 69}// 561	562	563	
			, {11387, 2, -4, 69}, {11387, 1, -4, 69}, {11387, 0, -4, 69}// 564	565	566	
			, {11387, -1, -4, 69}, {11387, -2, -4, 69}, {11387, -3, -4, 69}// 567	568	569	
			, {11386, -4, -4, 69}, {11375, -4, -5, 69}, {11375, -4, -6, 69}// 570	571	572	
			, {11375, -4, -7, 69}, {11375, -4, -8, 69}, {11389, 8, -5, 66}// 573	574	575	
			, {11389, 7, -5, 66}, {11389, 6, -5, 66}, {11389, 5, -5, 66}// 576	577	578	
			, {11389, 4, -5, 66}, {11389, 3, -5, 66}, {11389, 2, -5, 66}// 579	580	581	
			, {11389, 1, -5, 66}, {11389, 0, -5, 66}, {11389, -1, -5, 66}// 582	583	584	
			, {11389, -2, -5, 66}, {11379, -3, -5, 66}, {11376, -3, -6, 66}// 585	586	587	
			, {11376, -3, -7, 66}, {11376, -3, -8, 66}, {11389, 8, -6, 63}// 588	589	590	
			, {11389, 7, -6, 63}, {11389, 6, -6, 63}, {11389, 5, -6, 63}// 591	592	593	
			, {11389, 4, -6, 63}, {11389, 3, -6, 63}, {11389, 2, -6, 63}// 594	595	596	
			, {11389, 1, -6, 63}, {11389, 0, -6, 63}, {11389, -1, -6, 63}// 597	598	599	
			, {11379, -2, -6, 63}, {11376, -2, -7, 63}, {11376, -2, -8, 63}// 600	601	602	
			, {11389, 8, -7, 60}, {11389, 7, -7, 60}, {11389, 6, -7, 60}// 603	604	605	
			, {11389, 5, -7, 60}, {11389, 4, -7, 60}, {11389, 3, -7, 60}// 606	607	608	
			, {11389, 2, -7, 60}, {11389, 1, -7, 60}, {11389, 0, -7, 60}// 609	610	611	
			, {11379, -1, -7, 60}, {11376, -1, -8, 60}, {11389, 8, -8, 57}// 612	613	614	
			, {11389, 7, -8, 57}, {11389, 6, -8, 57}, {11389, 5, -8, 57}// 615	616	617	
			, {11389, 4, -8, 57}, {11389, 3, -8, 57}, {11389, 2, -8, 57}// 618	619	620	
			, {11389, 1, -8, 57}, {11379, 0, -8, 57}, {1850, -4, -7, 5}// 621	622	623	
			, {1239, -4, -3, 0}, {1239, -4, -2, 0}, {1239, -4, -1, 0}// 624	625	626	
			, {1239, -4, 0, 0}, {1239, -4, 1, 0}, {1239, -4, 2, 0}// 627	628	629	
			, {1238, -4, 3, 0}, {1239, -4, 4, 0}, {1238, -4, 5, 0}// 630	631	632	
			, {1239, -4, 6, 0}, {1240, -4, 7, 0}, {13522, -4, 8, 0}// 633	634	635	
			, {1239, -3, -3, 0}, {1239, -3, -2, 0}, {1239, -3, -1, 0}// 636	637	638	
			, {1238, -3, 0, 0}, {1239, -3, 1, 0}, {1239, -3, 2, 0}// 639	640	641	
			, {1239, -3, 3, 0}, {1238, -3, 4, 0}, {1239, -3, 5, 0}// 642	643	644	
			, {1239, -3, 6, 0}, {1240, -3, 7, 0}, {13522, -3, 8, 0}// 645	646	647	
			, {1238, -2, -3, 0}, {1239, -2, -2, 0}, {1239, -2, -1, 0}// 648	649	650	
			, {1239, -2, 0, 0}, {1239, -2, 1, 0}, {1238, -2, 2, 0}// 651	652	653	
			, {1239, -2, 3, 0}, {1239, -2, 4, 0}, {1238, -2, 5, 0}// 654	655	656	
			, {1188, -2, 6, 0}, {1248, -2, 7, 0}, {6014, -2, 8, 0}// 657	658	659	
			, {1244, -1, -3, 0}, {1244, -1, -2, 0}, {1244, -1, -1, 0}// 660	661	662	
			, {1244, -1, 0, 0}, {1244, -1, 1, 0}, {1239, -1, 2, 0}// 663	664	665	
			, {1238, -1, 3, 0}, {1244, -1, 4, 0}, {1244, -1, 5, 0}// 666	667	668	
			, {1248, -1, 6, 0}, {1045, -1, 7, 0}, {1302, -1, 8, 0}// 669	670	671	
			, {1271, 0, -3, 0}, {1271, 0, -2, 0}, {1272, 0, -1, 0}// 672	673	674	
			, {1039, 0, 0, 0}, {1036, 0, 1, 0}, {1036, 0, 2, 0}// 675	676	677	
			, {1036, 0, 3, 0}, {1036, 0, 4, 0}, {1036, 0, 5, 0}// 678	679	680	
			, {1041, 0, 6, 0}, {1038, 0, 7, 0}, {1303, 0, 8, 0}// 681	682	683	
			, {1267, 1, -3, 0}, {1267, 1, -2, 0}, {1270, 1, -1, 0}// 684	685	686	
			, {1038, 1, 0, 0}, {12792, 1, 1, 0}, {12790, 1, 2, 0}// 687	688	689	
			, {12794, 1, 3, 0}, {12795, 1, 4, 0}, {12790, 1, 5, 0}// 690	691	692	
			, {1035, 1, 6, 0}, {1038, 1, 7, 0}, {1302, 1, 8, 0}// 693	694	695	
			, {1267, 2, -3, 0}, {1267, 2, -2, 0}, {1270, 2, -1, 0}// 696	697	698	
			, {1042, 2, 0, 0}, {1037, 2, 1, 0}, {1037, 2, 2, 0}// 699	700	701	
			, {1037, 2, 3, 0}, {1037, 2, 4, 0}, {1037, 2, 5, 0}// 702	703	704	
			, {1040, 2, 6, 0}, {1038, 2, 7, 0}, {1303, 2, 8, 0}// 705	706	707	
			, {1267, 3, -3, 0}, {1267, 3, -2, 0}, {1270, 3, -1, 0}// 708	709	710	
			, {1036, 3, 0, 0}, {1036, 3, 1, 0}, {1036, 3, 2, 0}// 711	712	713	
			, {1036, 3, 3, 0}, {1036, 3, 4, 0}, {1036, 3, 5, 0}// 714	715	716	
			, {1036, 3, 6, 0}, {1043, 3, 7, 0}, {1304, 3, 8, 0}// 717	718	719	
			, {1267, 4, -3, 0}, {1267, 4, -2, 0}, {1270, 4, -1, 0}// 720	721	722	
			, {1302, 4, 0, 0}, {1303, 4, 1, 0}, {1303, 4, 2, 0}// 723	724	725	
			, {1303, 4, 3, 0}, {1303, 4, 4, 0}, {1302, 4, 5, 0}// 726	727	728	
			, {1304, 4, 6, 0}, {1303, 4, 7, 0}, {1303, 4, 8, 0}// 729	730	731	
			, {1267, 5, -3, 0}, {1267, 5, -2, 0}, {1270, 5, -1, 0}// 732	733	734	
			, {1303, 5, 0, 0}, {1302, 5, 1, 0}, {1304, 5, 2, 0}// 735	736	737	
			, {1303, 5, 3, 0}, {1303, 5, 4, 0}, {1303, 5, 5, 0}// 738	739	740	
			, {1303, 5, 6, 0}, {1303, 5, 7, 0}, {1304, 5, 8, 0}// 741	742	743	
			, {1267, 6, -3, 0}, {1267, 6, -2, 0}, {1270, 6, -1, 0}// 744	745	746	
			, {1302, 6, 0, 0}, {1303, 6, 1, 0}, {1302, 6, 2, 0}// 747	748	749	
			, {1302, 6, 3, 0}, {1304, 6, 4, 0}, {1303, 6, 5, 0}// 750	751	752	
			, {1302, 6, 6, 0}, {1303, 6, 7, 0}, {1303, 6, 8, 0}// 753	754	755	
			, {1269, 7, -3, 0}, {1269, 7, -2, 0}, {1275, 7, -1, 0}// 756	757	758	
			, {6017, 7, 0, 0}, {6014, 7, 1, 0}, {6014, 7, 2, 0}// 759	760	761	
			, {6017, 7, 3, 0}, {6014, 7, 4, 0}, {6017, 7, 5, 0}// 762	763	764	
			, {6017, 7, 6, 0}, {6017, 7, 7, 0}, {6014, 7, 8, 0}// 765	766	767	
			, {13522, 8, -3, 0}, {6017, 8, -2, 0}, {6014, 8, -1, 0}// 768	769	770	
			, {6013, 8, 0, 0}, {6014, 8, 1, 0}, {6017, 8, 2, 0}// 771	772	773	
			, {6014, 8, 3, 0}, {6017, 8, 4, 0}, {6013, 8, 5, 0}// 774	775	776	
			, {6014, 8, 6, 0}, {6014, 8, 7, 0}, {6014, 8, 8, 0}// 777	778	779	
			, {1239, -4, -3, 20}, {1236, -4, -2, 20}, {1236, -4, -1, 20}// 780	781	782	
			, {1239, -4, 0, 20}, {1239, -4, 1, 20}, {1236, -4, 2, 20}// 783	784	785	
			, {1239, -4, 3, 20}, {1236, -4, 4, 20}, {1239, -4, 5, 20}// 786	787	788	
			, {1239, -4, 6, 20}, {1240, -4, 7, 20}, {1239, -3, -3, 20}// 789	790	791	
			, {1239, -3, -2, 20}, {1239, -3, -1, 20}, {1239, -3, 0, 20}// 792	793	794	
			, {1239, -3, 1, 20}, {1239, -3, 2, 20}, {1239, -3, 3, 20}// 795	796	797	
			, {1239, -3, 4, 20}, {1239, -3, 5, 20}, {1239, -3, 6, 20}// 798	799	800	
			, {1243, -3, 7, 20}, {1238, -2, -3, 20}, {1239, -2, -2, 20}// 801	802	803	
			, {1239, -2, -1, 20}, {1239, -2, 0, 20}, {1239, -2, 1, 20}// 804	805	806	
			, {1236, -2, 2, 20}, {1239, -2, 3, 20}, {1239, -2, 4, 20}// 807	808	809	
			, {1239, -2, 5, 20}, {1188, -2, 6, 20}, {1240, -2, 7, 20}// 810	811	812	
			, {1239, -1, -3, 20}, {1239, -1, -2, 20}, {1188, -1, -1, 20}// 813	814	815	
			, {1239, -1, 0, 20}, {1244, -1, 1, 20}, {1239, -1, 2, 20}// 816	817	818	
			, {1239, -1, 3, 20}, {1244, -1, 4, 20}, {1239, -1, 5, 20}// 819	820	821	
			, {1244, -1, 6, 20}, {1248, -1, 7, 20}, {1236, 0, -3, 20}// 822	823	824	
			, {1239, 0, -2, 20}, {1243, 0, -1, 20}, {1237, 1, -3, 20}// 825	826	827	
			, {1239, 1, -2, 20}, {1240, 1, -1, 20}, {1239, 2, -3, 20}// 828	829	830	
			, {1239, 2, -2, 20}, {1240, 2, -1, 20}, {1239, 3, -3, 20}// 831	832	833	
			, {1239, 3, -2, 20}, {1243, 3, -1, 20}, {1239, 4, -3, 20}// 834	835	836	
			, {1236, 4, -2, 20}, {1240, 4, -1, 20}, {1239, 5, -3, 20}// 837	838	839	
			, {1239, 5, -2, 20}, {1240, 5, -1, 20}, {1239, 6, -3, 20}// 840	841	842	
			, {1239, 6, -2, 20}, {1243, 6, -1, 20}, {1239, 7, -3, 20}// 843	844	845	
			, {1244, 7, -2, 20}, {1248, 7, -1, 20}, {1237, -4, -3, 40}// 846	847	848	
			, {1238, -4, -2, 40}, {1239, -4, -1, 40}, {1239, -4, 0, 40}// 849	850	851	
			, {1237, -4, 1, 40}, {1239, -4, 2, 40}, {1239, -4, 3, 40}// 852	853	854	
			, {1239, -4, 4, 40}, {1239, -4, 5, 40}, {1239, -4, 6, 40}// 855	856	857	
			, {1240, -4, 7, 40}, {1239, -3, -3, 40}, {1239, -3, -2, 40}// 858	859	860	
			, {1238, -3, -1, 40}, {1239, -3, 0, 40}, {1239, -3, 1, 40}// 861	862	863	
			, {1239, -3, 2, 40}, {1238, -3, 3, 40}, {1238, -3, 4, 40}// 864	865	866	
			, {1239, -3, 5, 40}, {1239, -3, 6, 40}, {1243, -3, 7, 40}// 867	868	869	
			, {9261, -2, -3, 40}, {1239, -2, -2, 40}, {1239, -2, -1, 40}// 870	871	872	
			, {1239, -2, 0, 40}, {1238, -2, 1, 40}, {1239, -2, 2, 40}// 873	874	875	
			, {1239, -2, 3, 40}, {1239, -2, 4, 40}, {1238, -2, 5, 40}// 876	877	878	
			, {1239, -2, 6, 40}, {1240, -2, 7, 40}, {9258, -1, -3, 40}// 879	880	881	
			, {1238, -1, -2, 40}, {1188, -1, -1, 40}, {1239, -1, 0, 40}// 882	883	884	
			, {1239, -1, 1, 40}, {1239, -1, 2, 40}, {1239, -1, 3, 40}// 885	886	887	
			, {1239, -1, 4, 40}, {1239, -1, 5, 40}, {1239, -1, 6, 40}// 888	889	890	
			, {1248, -1, 7, 40}, {9258, 0, -3, 40}, {1239, 0, -2, 40}// 891	892	893	
			, {1240, 0, -1, 40}, {9258, 1, -3, 40}, {1239, 1, -2, 40}// 894	895	896	
			, {1240, 1, -1, 40}, {9258, 2, -3, 40}, {1239, 2, -2, 40}// 897	898	899	
			, {1240, 2, -1, 40}, {9258, 3, -3, 40}, {1239, 3, -2, 40}// 900	901	902	
			, {1243, 3, -1, 40}, {9264, 4, -3, 40}, {1239, 4, -2, 40}// 903	904	905	
			, {1240, 4, -1, 40}, {1239, 5, -3, 40}, {1237, 5, -2, 40}// 906	907	908	
			, {1243, 5, -1, 40}, {1239, 6, -3, 40}, {1239, 6, -2, 40}// 909	910	911	
			, {1240, 6, -1, 40}, {1209, 7, -3, 40}, {1214, 7, -2, 40}// 912	913	914	
			, {1248, 7, -1, 40}, {1211, 8, -3, 40}, {1213, 8, -2, 40}// 915	916	917	
			, {340, -4, 7, 0}, {66, -4, 8, 0}, {340, -3, 7, 0}// 918	919	920	
			, {65, -3, 8, 0}, {298, -2, 6, 0}, {335, -2, 7, 0}// 921	922	923	
			, {298, -1, -2, 0}, {339, -1, -1, 0}, {339, -1, 0, 0}// 924	925	926	
			, {339, -1, 1, 0}, {339, -1, 2, 0}, {339, -1, 3, 0}// 927	928	929	
			, {339, -1, 4, 0}, {339, -1, 5, 0}, {335, -1, 6, 0}// 930	931	932	
			, {338, 0, -1, 0}, {28, 0, 6, 0}, {338, 1, -1, 0}// 933	934	935	
			, {338, 2, -1, 0}, {32, 2, 1, 0}, {31, 2, 4, 0}// 937	939	940	
			, {26, 2, 6, 0}, {340, 3, -1, 0}, {340, 6, -1, 0}// 942	943	944	
			, {341, 7, -3, 0}, {334, 7, -2, 0}, {335, 7, -1, 0}// 945	946	947	
			, {65, 8, -3, 0}, {310, -4, -3, 20}, {310, -4, 7, 20}// 948	949	950	
			, {310, -2, -3, 20}, {296, -2, 7, 20}, {309, -1, -3, 20}// 952	953	954	
			, {311, -1, -2, 20}, {308, -1, -1, 20}, {339, -1, 0, 20}// 955	956	957	
			, {311, -1, 1, 20}, {303, -1, 3, 20}, {311, -1, 4, 20}// 958	960	961	
			, {308, -1, 6, 20}, {335, -1, 7, 20}, {338, 0, -1, 20}// 963	964	965	
			, {310, 1, -1, 20}, {310, 3, -1, 20}, {310, 4, -1, 20}// 966	968	969	
			, {307, 6, -1, 20}, {308, 7, -2, 20}, {335, 7, -1, 20}// 971	973	974	
			, {470, 8, -2, 20}, {311, -4, -3, 40}, {311, -4, -2, 40}// 975	976	977	
			, {308, -4, -1, 40}, {306, -4, 0, 40}, {310, -4, 7, 40}// 978	979	980	
			, {310, -3, -1, 40}, {310, -2, -1, 40}, {307, -2, 7, 40}// 981	983	984	
			, {310, -1, -1, 40}, {339, -1, 0, 40}, {311, -1, 1, 40}// 985	986	987	
			, {311, -1, 3, 40}, {311, -1, 4, 40}, {308, -1, 6, 40}// 989	990	992	
			, {335, -1, 7, 40}, {338, 0, -1, 40}, {310, 1, -1, 40}// 993	994	995	
			, {310, 3, -1, 40}, {310, 4, -1, 40}, {308, 6, -2, 40}// 997	998	1001	
			, {307, 6, -1, 40}, {307, 7, -2, 40}, {335, 7, -1, 40}// 1002	1003	1004	
			, {2232, 8, -3, 40}, {2230, 8, -2, 40}, {554, -4, 7, 60}// 1005	1006	1007	
			, {554, 2, -1, 60}, {554, 3, -1, 60}, {554, 4, -1, 60}// 1008	1009	1010	
			, {11375, -4, 8, 69}, {11375, -4, 7, 69}, {11375, -4, 6, 69}// 1011	1012	1013	
			, {11375, -4, 5, 69}, {11375, -4, 4, 69}, {11375, -4, 3, 69}// 1014	1015	1016	
			, {11375, -4, 2, 69}, {11375, -4, 1, 69}, {11375, 4, 0, 69}// 1017	1018	1019	
			, {11375, -4, 0, 69}, {11375, 4, -1, 69}, {11375, -4, -1, 69}// 1020	1021	1022	
			, {11375, 4, -2, 69}, {11375, -4, -2, 69}, {11375, 4, -3, 69}// 1023	1024	1025	
			, {11375, -4, -3, 69}, {11376, -3, 8, 66}, {11376, -3, 7, 66}// 1026	1027	1028	
			, {11376, -3, 6, 66}, {11376, -3, 5, 66}, {11376, -3, 4, 66}// 1029	1030	1031	
			, {11376, -3, 3, 66}, {11376, -3, 2, 66}, {11376, -3, 1, 66}// 1032	1033	1034	
			, {11376, 5, 0, 66}, {11377, 3, 0, 66}, {11376, -3, 0, 66}// 1035	1036	1037	
			, {11376, 5, -1, 66}, {11377, 3, -1, 66}, {11376, -3, -1, 66}// 1038	1039	1040	
			, {11376, 5, -2, 66}, {11377, 3, -2, 66}, {11376, -3, -2, 66}// 1041	1042	1043	
			, {11388, 8, -3, 66}, {11388, 7, -3, 66}, {11388, 6, -3, 66}// 1044	1045	1046	
			, {11381, 5, -3, 66}, {11378, 3, -3, 66}, {11388, 2, -3, 66}// 1047	1048	1049	
			, {11388, 1, -3, 66}, {11388, 0, -3, 66}, {11388, -1, -3, 66}// 1050	1051	1052	
			, {11388, -2, -3, 66}, {11381, -3, -3, 66}, {11376, -2, 8, 63}// 1053	1054	1055	
			, {11376, -2, 7, 63}, {11376, -2, 6, 63}, {11376, -2, 5, 63}// 1056	1057	1058	
			, {11376, -2, 4, 63}, {11376, -2, 3, 63}, {11376, -2, 2, 63}// 1059	1060	1061	
			, {11376, -2, 1, 63}, {11376, 6, 0, 63}, {11377, 2, 0, 63}// 1062	1063	1064	
			, {11376, -2, 0, 63}, {11376, 6, -1, 63}, {11377, 2, -1, 63}// 1065	1066	1067	
			, {11376, -2, -1, 63}, {11388, 8, -2, 63}, {11388, 7, -2, 63}// 1068	1069	1070	
			, {11381, 6, -2, 63}, {11378, 2, -2, 63}, {11388, 1, -2, 63}// 1071	1072	1073	
			, {11388, 0, -2, 63}, {11388, -1, -2, 63}, {11381, -2, -2, 63}// 1074	1075	1076	
			, {11376, -1, 8, 60}, {11376, -1, 7, 60}, {11376, -1, 6, 60}// 1077	1078	1079	
			, {11376, -1, 5, 60}, {11376, -1, 4, 60}, {11376, -1, 3, 60}// 1080	1081	1082	
			, {11376, -1, 2, 60}, {11376, -1, 1, 60}, {11376, 7, 0, 60}// 1083	1084	1085	
			, {11377, 1, 0, 60}, {11376, -1, 0, 60}, {11388, 8, -1, 60}// 1086	1087	1088	
			, {11381, 7, -1, 60}, {11378, 1, -1, 60}, {11388, 0, -1, 60}// 1089	1090	1091	
			, {11381, -1, -1, 60}, {11376, 0, 8, 57}, {11376, 0, 7, 57}// 1092	1093	1094	
			, {11376, 0, 6, 57}, {11376, 0, 5, 57}, {11376, 0, 4, 57}// 1095	1096	1097	
			, {11376, 0, 3, 57}, {11376, 0, 2, 57}, {11376, 0, 1, 57}// 1098	1099	1100	
			, {11381, 8, 0, 57}, {11381, 0, 0, 57}, {11375, 1, 7, 23}// 1101	1102	1103	
			, {11375, 1, 6, 23}, {11375, 1, 5, 23}, {11375, 1, 4, 23}// 1104	1105	1106	
			, {11375, 1, 3, 23}, {11375, 1, 2, 23}, {11375, 1, 1, 23}// 1107	1108	1109	
			, {11375, 1, 0, 23}, {11376, 2, 7, 20}, {11377, 0, 7, 20}// 1110	1111	1112	
			, {11376, 2, 6, 20}, {11377, 0, 6, 20}, {11376, 2, 5, 20}// 1113	1114	1115	
			, {11377, 0, 5, 20}, {11376, 2, 4, 20}, {11377, 0, 4, 20}// 1116	1117	1118	
			, {11376, 2, 3, 20}, {11377, 0, 3, 20}, {11376, 2, 2, 20}// 1119	1120	1121	
			, {11377, 0, 2, 20}, {11376, 2, 1, 20}, {11377, 0, 1, 20}// 1122	1123	1124	
			, {11376, 2, 0, 20}, {11377, 0, 0, 20}, {11376, 3, 7, 17}// 1125	1126	1127	
			, {11376, 3, 6, 17}, {11376, 3, 5, 17}, {11376, 3, 4, 17}// 1128	1129	1130	
			, {11376, 3, 3, 17}, {11376, 3, 2, 17}, {11376, 3, 1, 17}// 1131	1132	1133	
			, {11376, 3, 0, 17}// 1134	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RewardHouseAddonDeed();
			}
		}

		[ Constructable ]
		public RewardHouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 315, -8, -4, 20, 0, 0, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 315, -8, -6, 40, 0, 0, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 314, -5, -8, 40, 0, 0, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 315, -8, 2, 20, 0, 0, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 315, -8, 5, 20, 0, 0, "", 1);// 232
			AddComplexComponent( (BaseAddon) this, 314, -5, 7, 20, 0, 0, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 315, -8, -2, 40, 0, 0, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 315, -8, 2, 40, 0, 0, "", 1);// 250
			AddComplexComponent( (BaseAddon) this, 315, -8, 5, 40, 0, 0, "", 1);// 253
			AddComplexComponent( (BaseAddon) this, 314, -5, 7, 40, 0, 0, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 314, -4, -8, 20, 0, 0, "", 1);// 513
			AddComplexComponent( (BaseAddon) this, 314, 0, -8, 20, 0, 0, "", 1);// 523
			AddComplexComponent( (BaseAddon) this, 314, 5, -8, 20, 0, 0, "", 1);// 528
			AddComplexComponent( (BaseAddon) this, 315, 7, -5, 20, 0, 0, "", 1);// 533
			AddComplexComponent( (BaseAddon) this, 314, -1, -8, 40, 0, 0, "", 1);// 542
			AddComplexComponent( (BaseAddon) this, 314, 4, -8, 40, 0, 0, "", 1);// 547
			AddComplexComponent( (BaseAddon) this, 315, 6, -6, 40, 0, 0, "", 1);// 551
			AddComplexComponent( (BaseAddon) this, 10669, 1, 6, 0, 0, 0, "", 1);// 936
			AddComplexComponent( (BaseAddon) this, 10674, 2, 0, 0, 0, 0, "", 1);// 938
			AddComplexComponent( (BaseAddon) this, 10674, 2, 5, 0, 0, 0, "", 1);// 941
			AddComplexComponent( (BaseAddon) this, 314, -3, 7, 20, 0, 0, "", 1);// 951
			AddComplexComponent( (BaseAddon) this, 315, -1, 2, 20, 0, 0, "", 1);// 959
			AddComplexComponent( (BaseAddon) this, 315, -1, 5, 20, 0, 0, "", 1);// 962
			AddComplexComponent( (BaseAddon) this, 314, 2, -1, 20, 0, 0, "", 1);// 967
			AddComplexComponent( (BaseAddon) this, 314, 5, -1, 20, 0, 0, "", 1);// 970
			AddComplexComponent( (BaseAddon) this, 315, 7, -3, 20, 0, 0, "", 1);// 972
			AddComplexComponent( (BaseAddon) this, 314, -3, 7, 40, 0, 0, "", 1);// 982
			AddComplexComponent( (BaseAddon) this, 315, -1, 2, 40, 0, 0, "", 1);// 988
			AddComplexComponent( (BaseAddon) this, 315, -1, 5, 40, 0, 0, "", 1);// 991
			AddComplexComponent( (BaseAddon) this, 314, 2, -1, 40, 0, 0, "", 1);// 996
			AddComplexComponent( (BaseAddon) this, 314, 5, -1, 40, 0, 0, "", 1);// 999
			AddComplexComponent( (BaseAddon) this, 315, 6, -3, 40, 0, 0, "", 1);// 1000

		}

		public RewardHouseAddon( Serial serial ) : base( serial )
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

	public class RewardHouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RewardHouseAddon();
			}
		}

		[Constructable]
		public RewardHouseAddonDeed()
		{
			Name = "RewardHouse";
		}

		public RewardHouseAddonDeed( Serial serial ) : base( serial )
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