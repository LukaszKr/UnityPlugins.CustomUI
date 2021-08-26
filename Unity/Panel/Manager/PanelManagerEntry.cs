﻿namespace ProceduralLevel.UnityPlugins.UI.Unity
{
	internal class PanelManagerEntry
	{
		public readonly AUIPanel Panel;
		public readonly UICanvas Canvas;

		public PanelManagerEntry(AUIPanel panel, UICanvas canvas)
		{
			Panel = panel;
			Canvas = canvas;
		}
	}
}