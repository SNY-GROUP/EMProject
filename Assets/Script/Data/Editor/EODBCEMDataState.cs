using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic ;
using System.Data;
using System.Data.Odbc;
using ComLib;

[CustomEditor(typeof(EMDataState))]
public class EODBCEMDataState : ODBCEditControlBase
{
	EMDataState script;
	override public void OnSetScript() {
		script = (EMDataState) target; }
	override public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) {
		fileFullName = string.Format("{0}/Data/SystemData/_Excel/State Table.xls", Application.dataPath) ;
		tableName = "Data"; }
	override public bool OnFetchData(DataTable dataTable,int rowCount) {
		script.prefabData.Clear ();
		for(int i = 0; i < dataTable.Rows.Count; i++) {
			List<string> rowString = new List<string>();
			for(int j = 0; j < dataTable.Columns.Count; j++) {
				rowString.Add(dataTable.Rows[i][dataTable.Columns[j].ColumnName].ToString()); }
			EMDataStateStruct data = SetData(i, rowString.ToArray());
			script.prefabData.Add(data); }
		return true;
	}
	override public void OnAddFieldInfo (ODBCDataSave saveData) {}
	override public void OnAddSaveData (ODBCDataSave saveData) {}

	private EMDataStateStruct SetData (int row, params string[] metaData)
	{
		int i = 0;		EMDataStateStruct data = new EMDataStateStruct();
		if (!int.TryParse (metaData [i++], out data.HP))	{
		Debug.LogError (string.Format("[Error] row : {0}, HP", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Patience))	{
		Debug.LogError (string.Format("[Error] row : {0}, Patience", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Math))	{
		Debug.LogError (string.Format("[Error] row : {0}, Math", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Glanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, Glanguage", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Language))	{
		Debug.LogError (string.Format("[Error] row : {0}, Language", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Common))	{
		Debug.LogError (string.Format("[Error] row : {0}, Common", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Jop))	{
		Debug.LogError (string.Format("[Error] row : {0}, Jop", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Private))	{
		Debug.LogError (string.Format("[Error] row : {0}, Private", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Rest))	{
		Debug.LogError (string.Format("[Error] row : {0}, Rest", row)); return null; }
		if (!long.TryParse (metaData [i++], out data.Gold))	{
		Debug.LogError (string.Format("[Error] row : {0}, Gold", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Luck))	{
		Debug.LogError (string.Format("[Error] row : {0}, Luck", row)); return null; }
		return data;
	}
}