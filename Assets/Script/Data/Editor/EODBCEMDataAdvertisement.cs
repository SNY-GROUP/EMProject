using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic ;
using System.Data;
using System.Data.Odbc;
using ComLib;

[CustomEditor(typeof(EMDataAdvertisement))]
public class EODBCEMDataAdvertisement : ODBCEditControlBase
{
	EMDataAdvertisement script;
	override public void OnSetScript() {
		script = (EMDataAdvertisement) target; }
	override public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) {
		fileFullName = string.Format("{0}/Data/SystemData/_Excel/HomeShopping Table.xls", Application.dataPath) ;
		tableName = "Data"; }
	override public bool OnFetchData(DataTable dataTable,int rowCount) {
		script.prefabData.Clear ();
		for(int i = 0; i < rowCount; i++) {
			List<string> rowString = new List<string>();
			for(int j = 0; j < dataTable.Columns.Count; j++) {
				rowString.Add(dataTable.Rows[i][dataTable.Columns[j].ColumnName].ToString()); }
			EMDataAdvertisementStruct data = SetData(i, rowString.ToArray());
			script.prefabData.Add(data); }
		return true;
	}
	override public void OnAddFieldInfo (ODBCDataSave saveData) {}
	override public void OnAddSaveData (ODBCDataSave saveData) {}

	private EMDataAdvertisementStruct SetData (int row, params string[] metaData)
	{
		int i = 0;		EMDataAdvertisementStruct data = new EMDataAdvertisementStruct();
		if (!int.TryParse (metaData [i++], out data.ID))	{
		Debug.LogError (string.Format("[Error] row : {0}, ID", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.OpenLevelType))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenLevelType", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.NameID))	{
		Debug.LogError (string.Format("[Error] row : {0}, NameID", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.InfoID))	{
		Debug.LogError (string.Format("[Error] row : {0}, InfoID", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.CategoryType))	{
		Debug.LogError (string.Format("[Error] row : {0}, CategoryType", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.GainStress))	{
		Debug.LogError (string.Format("[Error] row : {0}, GainStress", row)); return null; }
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
		data.FileName = metaData[i++] ;

		if (!int.TryParse (metaData [i++], out data.Buy))	{
		Debug.LogError (string.Format("[Error] row : {0}, Buy", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.EventID))	{
		Debug.LogError (string.Format("[Error] row : {0}, EventID", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.OpenType))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenType", row)); return null; }
		if (!int.TryParse (metaData [i++], out data.OpenValue))	{
		Debug.LogError (string.Format("[Error] row : {0}, OpenValue", row)); return null; }
		return data;
	}
}