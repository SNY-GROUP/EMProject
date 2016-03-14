using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic ;
using System.Data;
using System.Data.Odbc;
using ComLib;

[CustomEditor(typeof(EMDataEvent))]
public class EODBCEMDataEvent : ODBCEditControlBase
{
	EMDataEvent script;
	override public void OnSetScript() {
		script = (EMDataEvent) target; }
	override public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) {
		fileFullName = string.Format("{0}/Data/SystemData/_Excel/Event Table.xls", Application.dataPath) ;
		tableName = "Data"; }
	override public bool OnFetchData(DataTable dataTable,int rowCount) {
		script.prefabData.Clear ();
		for(int i = 0; i < dataTable.Rows.Count; i++) {
			List<string> rowString = new List<string>();
			for(int j = 0; j < dataTable.Columns.Count; j++) {
				rowString.Add(dataTable.Rows[i][dataTable.Columns[j].ColumnName].ToString()); }
			EMDataEventStruct data = SetData(i, rowString.ToArray());
			script.prefabData.Add(data); }
		return true;
	}
	override public void OnAddFieldInfo (ODBCDataSave saveData) {}
	override public void OnAddSaveData (ODBCDataSave saveData) {}

	private EMDataEventStruct SetData (int row, params string[] metaData)
	{
		int i = 0;		EMDataEventStruct data = new EMDataEventStruct();
		if (!int.TryParse (metaData [i++], out data.ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.EventType))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventType", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.LevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, LevelType", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.EvenTName))	{
		Debug.LogError (string.Format("[Error] row : {0}, EvenTName", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.EventInfo))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventInfo", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.EventBuyInfo))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventBuyInfo", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.SaleMin))	{
		Debug.LogError (string.Format("[Error] row : {0}, SaleMin", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.SaleMax))	{
		Debug.LogError (string.Format("[Error] row : {0}, SaleMax", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainGold))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainGold", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainHp))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainHp", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainPatience))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainPatience", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainMath))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainMath", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Gain_GLanguage))	{
		Debug.LogError (string.Format("[Error] row : {0}, Gain_GLanguage", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.Gain_Language))	{
		Debug.LogError (string.Format("[Error] row : {0}, Gain_Language", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainCommon))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainCommon", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainJop))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainJop", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainPrivate))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainPrivate", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainRest))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainRest", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.probabilityGroupID))	{
		Debug.LogError (string.Format("[Error] row : {0}, probabilityGroupID", row)); return null; }
		return data;
	}
}