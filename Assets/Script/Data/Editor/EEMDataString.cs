using UnityEditor;
using UnityEngine;
using System.Collections;
using ComLib;

[CustomEditor(typeof(EMDataString))]

public class EEMDataString : Editor
{
	string path = "Assets/Data/SystemData/_Text/String_data_kr.txt";
	EMDataString 	script ;
	
	public override void OnInspectorGUI () 
	{
		if ( GUILayout.Button("Load CSV") )
		{
			int firstDataIndex = 0;
			string comma = ",";

			script.prefabData.Clear();

			string[] metaLineData = ComCSVReader.ReadFile(path);

			string[] firstLine = ComCSVReader.SplitMetaData(metaLineData[firstDataIndex], comma);

			if(firstLine == null)
			{
				Debug.LogError("error! data is invalided.");
				return;
			}

			int length = 0;
			if(int.TryParse(firstLine[0], out length) == false)
			{
				Debug.LogError("error! length is invalided.");
				return;
			}

			for(int i = 1; i < length + 1; i++)
			{
				EMDataStringStruct data = SetData (i, ComCSVReader.SplitMetaData(metaLineData[i], comma));
				script.prefabData.Add(data);
			}
		}
		
		base.OnInspectorGUI() ;
	}
	
	void OnEnable() 
	{		
		script = (EMDataString) target;
	}

	private EMDataStringStruct SetData (int row, params string[] metaData)
	{
		int i = 0;		
		EMDataStringStruct data = new EMDataStringStruct();
		if (!int.TryParse (metaData [i++], out data.ID))	{
			Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return null; }
		data.Text = metaData[i++] ;
		
		if (!int.TryParse (metaData [i++], out data.Size))	{
			Debug.LogError (string.Format("[Error] row : {0}, Size", row)); return null; }
		return data;
	}
	
}