﻿using UnityEngine;

namespace ProceduralLevel.UnityPlugins.UI.Unity
{
	public class UILabelToggle : UIToggle
	{
		[SerializeField]
		private UIText m_Label = null;

		public UIText Label => m_Label;
	}
}