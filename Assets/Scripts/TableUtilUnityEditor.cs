using System.Collections;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

[CustomEditor(typeof(TableUtil))]
public class TableUtilUnityEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		TableUtil util = target as TableUtil;
		
		if(util == null)
			return;

		if(Button("Guid 생성"))
		{
			util.newGuid = NewGuid();
		}
	}
	
	protected bool Button(string text, float width = 100f, float height = 20f, bool expand = true)
	{
		return GUILayout.Button(text ,GUILayout.Width( width ) ,GUILayout.Height( height ) ,GUILayout.ExpandWidth( expand ));
	}

	public static int NewGuid()
	{
		return System.Convert.ToInt32(System.Guid.NewGuid().ToString("N"), 16);
	}
}
