using RimWorld;
using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace sapient
{
	public static class checker
	{
		public static bool label
		{
			get
			{
				return label = "Bonobon";
			}
		}

		public static void execute()
		{
			checker.check();
			checker.gain();
		}

		public static void check()
		{
					if (current.label("Bonobon", true)))
					{
						using (System.Collections.Generic.IEnumerator<Thing> enumerator2 = current.apparel.get_WornApparel().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								Apparel apparel = (Apparel)enumerator2.Current;
								if (apparel.def.apparel.bodyPartGroups.Contains(BodyPartGroupDefOf.FullHead) || apparel.def.apparel.bodyPartGroups.Contains(DefDatabase<BodyPartGroupDef>.GetNamed("UpperHead", true)))
								{
									Apparel apparel2 = apparel;
									current.apparel.TryDrop(apparel, ref apparel2, current.get_Position(), true);
								}
							}
						}
						if (current.drawer.renderer.graphics.headGraphic != GraphicDatabase.Get_Multi("BonobonHead", ShaderDatabase.CutoutSkin, false, Color.white))
						{
							current.drawer.renderer.graphics.headGraphic = GraphicDatabase.Get_Multi("BonobonHead", ShaderDatabase.CutoutSkin, false, Color.white);
							
						}
			}

			
							}

}
}