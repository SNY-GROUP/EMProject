using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic ;
using System.Data;
using System.Data.Odbc;
using ComLib;

[CustomEditor(typeof(EMDataUniversity))]
public class EODBCEMDataUniversity : ODBCEditControlBase
{
	EMDataUniversity script;
	override public void OnSetScript() {
		script = (EMDataUniversity) target; }
	override public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) {
		fileFullName = string.Format("{0}/Data/SystemData/_Excel/University Table.xls", Application.dataPath) ;
		tableName = "Data"; }
	override public bool OnFetchData(DataTable dataTable,int rowCount) {
		script.prefabData.Clear ();
		for(int i = 0; i < dataTable.Rows.Count; i++) {
			List<string> rowString = new List<string>();
			for(int j = 0; j < dataTable.Columns.Count; j++) {
				rowString.Add(dataTable.Rows[i][dataTable.Columns[j].ColumnName].ToString()); }
			EMDataUniversityStruct data = SetData(i, rowString.ToArray());
			script.prefabData.Add(data); }
		return true;
	}
	override public void OnAddFieldInfo (ODBCDataSave saveData) {}
	override public void OnAddSaveData (ODBCDataSave saveData) {}

	private EMDataUniversityStruct SetData (int row, params string[] metaData)
	{
		int i = 0;		EMDataUniversityStruct data = new EMDataUniversityStruct();
		if (!int.TryParse (metaData [i++], out data.Id))	{
		Debug.LogError (string.Format("[Error] row : {0}, Id", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.LevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelType", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GradeNameId))	{
		Debug.LogError (string.Format("[Error] row : {0}, GradeNameId", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.UniversityNameId))	{
		Debug.LogError (string.Format("[Error] row : {0}, UniversityNameId", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionGold))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionGold", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionHp))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionHp", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionPatience))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionPatience", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionMath))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionMath", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Condition_GLanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, Condition_GLanguage", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Condition_Language))	{
		Debug.LogError (string.Format("[Error] row : {0}, Condition_Language", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionCommon))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionCommon", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionJop))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionJop", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionPrivate))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionPrivate", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.ConditionRest))	{
		Debug.LogError (string.Format("[Error] row : {0}, ConditionRest", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.EndingType))	{
		Debug.LogError (string.Format("[Error] row : {0}, EndingType", row)); return null; }
		return data;
	}
}