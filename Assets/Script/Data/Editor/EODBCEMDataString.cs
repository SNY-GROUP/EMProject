using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic ;
using System.Data;
using System.Data.Odbc;
using ComLib;

[CustomEditor(typeof(EMDataString))]
public class EODBCEMDataString : ODBCEditControlBase
{
	EMDataString script;
	override public void OnSetScript() {
		script = (EMDataString) target; }
	override public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) {
		fileFullName = string.Format("{0}/Data/SystemData/_Excel/String Table.xls", Application.dataPath) ;
		tableName = "Data"; }
	override public bool OnFetchData(DataTable dataTable,int rowCount) {
		script.prefabData.Clear ();
		for(int i = 0; i < dataTable.Rows.Count; i++) {
			List<string> rowString = new List<string>();
			for(int j = 0; j < dataTable.Columns.Count; j++) {
				rowString.Add(dataTable.Rows[i][dataTable.Columns[j].ColumnName].ToString()); }
			EMDataStringStruct data = SetData(i, rowString.ToArray());
			script.prefabData.Add(data); }
		return true;
	}
	override public void OnAddFieldInfo (ODBCDataSave saveData) {}
	override public void OnAddSaveData (ODBCDataSave saveData) {}

	private EMDataStringStruct SetData (int row, params string[] metaData)
	{
		int i = 0;		EMDataStringStruct data = new EMDataStringStruct();
		if (!int.TryParse (metaData [i++], out data.ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return null; }
		data.Text = metaData[i++] ;

		if (!int.TryParse (metaData [i++], out data.Size))	{
		Debug.LogError (string.Format("[Error] row : {0}, Size", row)); return null; }
		return data;
	}
}