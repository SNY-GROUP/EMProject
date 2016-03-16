using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic ;
using System.Data ;
using System.Data.Odbc ;

namespace ComLib
{
	[CustomEditor(typeof(DataFormulaGenerator))]
	public class EVDataFormulaGenerator : ODBCEditControlBase
	{
		CodeGenerator script ;
		
		override public void OnSetScript() 
		{
			script = (CodeGenerator) target;
		}
			
		/// file 위치 와 table 명을 기입 한다.
		override public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) 
		{
			fileFullName = string.Format("{0}/{1}", Application.dataPath, script.fullFilePath) ;
			tableName = "Struct";
		}

		override public bool OnFetchData(DataTable dataTable,int rowCount) 
		{
			string[] ColumnArray = new string[dataTable.Columns.Count];
			string fullPath = string.Format ("{0}/{1}/{2}.cs", Application.dataPath, script.targetPath, script.tableName);
			string data = string.Format ("using UnityEngine;\nusing System.Collections;\nusing System.Collections.Generic;\nusing System;\n\n[Serializable]\npublic class {0}Struct\n{1}", script.tableName, "{");

			for(int i = 0; i < dataTable.Columns.Count; i++)
			{
				if( string.IsNullOrEmpty(dataTable.Columns[i].ColumnName) )
					continue;
				
				data = string.Format("{0}\n\tpublic {1}\t{2}\t;", 
				                     data, 
				                     dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString(), 
				                     dataTable.Columns[i].ColumnName);

				ColumnArray[i] = dataTable.Columns[i].ColumnName;
			}

			// creator1
			data = string.Format ("{0}\n\n\tpublic {1}Struct ()\n\t{2}\n", data, script.tableName, "{}");

			// creator2
			data = string.Format ("{0}\n\n\tpublic {1}Struct ({1}Struct orgData)\n\t{2}\n", data, script.tableName, "{");
			
			data = string.Format ("{0}\t\tCopy(orgData) ;\n", data);
			
			data = string.Format ("{0}\t{1}", data, "}");

			// copy
			data = string.Format ("{0}\n\n\tpublic void Copy ({1}Struct orgData)\n\t{2}\n", data, script.tableName, "{");

			for(int i = 0; i < ColumnArray.Length; i++)
			{
				data = string.Format ("{0}\t\t{1} = orgData.{1} ;\n", data, ColumnArray[i]);
			}

			data = string.Format ("{0}\t{1}", data, "}");

			// end
			data = string.Format ("{0}\n{1}", data, "}");

			// data list
			data = string.Format ("{0}\n\npublic class {1} : MonoBehaviour\n{2}", data, script.tableName, "{");

			data = string.Format ("{0}\n\tpublic List<{1}Struct> prefabData = new List<{1}Struct>();", data, script.tableName);	

			// end
			data = string.Format ("{0}\n{1}", data, "}");

			ComSystemIO.Create (fullPath, data);

			// editor
			fullPath = string.Format ("{0}/{1}/Editor/EODBC{2}.cs", Application.dataPath, script.targetPath, script.tableName);

			MakeEditorScript (fullPath, dataTable, ColumnArray);
			
			return true ;
		}

		public override void OnAddFieldInfo (ODBCDataSave saveData)
		{
		}

		public override void OnAddSaveData (ODBCDataSave saveData)
		{
		}

		private void MakeEditorScript ( string fullPath, DataTable dataTable, string[] ColumnArray )
		{
			string data = string.Format ("using UnityEngine;\n" +
			                             "using UnityEditor;\n" +
			                             "using System.Collections;\n" +
			                             "using System.Collections.Generic ;\n" +
			                             "using System.Data;\n" +
			                             "using System.Data.Odbc;\n" +
			                             "using ComLib;\n\n" +
			                             "[CustomEditor(typeof({0}))]\n" +
			                             "public class EODBC{0} : ODBCEditControlBase\n{1}", script.tableName, "{");

			data = string.Format ("{0}\n\t{1} script;", data, script.tableName);

			data = string.Format ("{0}\n\toverride public void OnSetScript() {1}", data, "{");

			data = string.Format ("{0}\n\t\tscript = ({1}) target; {2}", data, script.tableName, "}");

			data = string.Format ("{0}\n\toverride public void OnSetConnectionInfo(ref string fileFullName,ref string tableName) {1}", data, "{");

			data = string.Format ("{0}\n\t\tfileFullName = string.Format(\"{1}/{2}\", Application.dataPath) ;", data, "{0}", script.fullFilePath);
			data = string.Format ("{0}\n\t\ttableName = \"Data\"; {1}", data, "}");

			data = string.Format ("{0}\n\toverride public bool OnFetchData(DataTable dataTable,int rowCount) {1}", data, "{");

			data = string.Format ("{0}\n\t\tscript.prefabData.Clear ();", data);
			data = string.Format ("{0}\n\t\tfor(int i = 0; i < rowCount; i++) {1}", data, "{");
			data = string.Format ("{0}\n\t\t\tList<string> rowString = new List<string>();", data);
			data = string.Format ("{0}\n\t\t\tfor(int j = 0; j < dataTable.Columns.Count; j++) {1}", data, "{");
			data = string.Format ("{0}\n\t\t\t\trowString.Add(dataTable.Rows[i][dataTable.Columns[j].ColumnName].ToString()); {1}", data, "}");
			data = string.Format ("{0}\n\t\t\t{1}Struct data = SetData(i, rowString.ToArray());", data, script.tableName);	
			data = string.Format ("{0}\n\t\t\tscript.prefabData.Add(data); {1}", data, "}");
					
			data = string.Format ("{0}\n\t\treturn true;\n\t{1}", data, "}");

			data = string.Format ("{0}\n\toverride public void OnAddFieldInfo (ODBCDataSave saveData) {1}", data, "{}");
			data = string.Format ("{0}\n\toverride public void OnAddSaveData (ODBCDataSave saveData) {1}", data, "{}");

			// setdata
			data = string.Format ("{0}\n\n\tprivate {1}Struct SetData (int row, params string[] metaData)\n\t{2}\n", data, script.tableName, "{");
			data = string.Format ("{0}\t\tint i = 0;", data);
			data = string.Format ("{0}\t\t{1}Struct data = new {1}Struct();", data, script.tableName);
			
			for(int i = 0; i < ColumnArray.Length; i++)
			{
				if(dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString().Equals("string"))
				{
					data = string.Format ("{0}\n\t\tdata.{1} = metaData[i++] ;\n", data, ColumnArray[i]);
				}
				else if(dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString().Equals("int"))
				{
					data = string.Format ("{0}\n\t\tif (!int.TryParse (metaData [i++], out data.{1}))\t{2}\n", data, ColumnArray[i], "{");
					data = string.Format ("{0}\t\tDebug.LogError (string.Format(\"[Error] row : {1}, {2}\", row)); return null; {3}", data, "{0}", ColumnArray[i], "}");
				}
				else if(dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString().Equals("long"))
				{
					data = string.Format ("{0}\n\t\tif (!long.TryParse (metaData [i++], out data.{1}))\t{2}\n", data, ColumnArray[i], "{");
					data = string.Format ("{0}\t\tDebug.LogError (string.Format(\"[Error] row : {1}, {2}\", row)); return null; {3}", data, "{0}", ColumnArray[i], "}");
				}
			}

			data = string.Format ("{0}\n\t\treturn data;", data);
			
			data = string.Format ("{0}\n\t{1}", data, "}");

			data = string.Format ("{0}\n{1}", data, "}");
					
			ComSystemIO.Create (fullPath, data);
		}
	}
}
