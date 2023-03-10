using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Template.AudioData;
using UnityEditor;
using UnityEngine;

namespace TemplateEditor.Tools
{
	/// <summary>
	/// オーディオデータのニックネームを定数で管理する構造体を作成するエディター拡張
	/// </summary>
	public static class AudioNickNameCreator
	{
        #region Member Variables

        // 音楽用ファイル名
        readonly private static string FILENAME_BGM =
			Path.GetFileNameWithoutExtension(EXPORT_PATH_BGM);

		// 効果音用ファイル名
		readonly private static string FILENAME_SFX =
			Path.GetFileNameWithoutExtension(EXPORT_PATH_SFX);

        #endregion

        #region Constants

        // コマンド名
        private const string COMMAND_NAME = "Tools/CreateConstants/Audio NickName";

		//作成したスクリプトを保存するパス(BGM)
		private const string EXPORT_PATH_BGM = "Assets/Scripts/Constants/BGMName.cs";
		//作成したスクリプトを保存するパス(SFX)
		private const string EXPORT_PATH_SFX = "Assets/Scripts/Constants/SFXName.cs";

		#endregion

		#region Private Methods

		/// <summary>
		/// オーディオデータのニックネームを定数で管理する構造体を作成します
		/// </summary>
		[MenuItem(COMMAND_NAME + " &a")]
		private static void Create()
		{
			if (!CanCreate()) return;
			CreateScriptBGM();
			CreateScriptSFX();
			Debug.Log("AudioNameを作成完了");
		}

		/// <summary>
		/// オーディオデータのニックネームを定数で管理する構造体を作成できるかどうかを取得します
		/// </summary>
		[MenuItem(COMMAND_NAME, true)]
		private static bool CanCreate()
		{
			var isPlayingEditor = !EditorApplication.isPlaying;
			var isPlaying = !Application.isPlaying;
			var isCompiling = !EditorApplication.isCompiling;
			return isPlayingEditor && isPlaying && isCompiling;
		}

		/// <summary>
		/// BGM用スクリプトを作成する関数
		/// </summary>
		private static void CreateScriptBGM()
		{
			var bGMList = new List<BGMData>();
			
			foreach (var guid in AssetDatabase.FindAssets("t:BGMData"))
			{
				var path = AssetDatabase.GUIDToAssetPath(guid);
				var asset = AssetDatabase.LoadMainAssetAtPath(path);
				var data = asset as BGMData;
				bGMList.Add(data);
			}

			var builder = new StringBuilder();

			//Script
			{
				//NameSpace
				builder.AppendLine("namespace Template.Constant");
				builder.AppendLine("{");

				//Struct
				{
					builder.Append("\t").AppendLine("/// <summary>");
					builder.Append("\t").AppendLine("/// オーディオデータのニックネームを定数で管理する構造体");
					builder.Append("\t").AppendLine("/// </summary>");
					builder.Append("\t").AppendFormat("public struct {0}", FILENAME_BGM).AppendLine();
					builder.Append("\t").AppendLine("{");

					//Constants
					{
						builder.Append("\t").Append("\t").AppendLine("#region Constants");
						builder.AppendLine("\t");

						foreach (var bgm in bGMList)
						{
							builder
								.Append("\t")
								.Append("\t")
								.AppendFormat
									(@"  public const string {0} = ""{1}"";",
										bgm.Name.Replace(" ", "_").ToUpper(),
										bgm.Name)
								.AppendLine();
						}

						builder.AppendLine("\t");
						builder.Append("\t").Append("\t").AppendLine("#endregion");
					}

					builder.Append("\t").AppendLine("}");
				}

				builder.AppendLine("}");
			}

			var directoryName = Path.GetDirectoryName(EXPORT_PATH_BGM);

			if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);

			File.WriteAllText(EXPORT_PATH_BGM, builder.ToString(), Encoding.UTF8);
			AssetDatabase.Refresh(ImportAssetOptions.ImportRecursive);
		}

		/// <summary>
		/// SFX用スクリプトを作成する関数
		/// </summary>
		private static void CreateScriptSFX()
		{
			var sFXList = new List<SFXData>();

			//エディター
			foreach (var guid in AssetDatabase.FindAssets("t:SFXData"))
			{
				var path = AssetDatabase.GUIDToAssetPath(guid);
				var asset = AssetDatabase.LoadMainAssetAtPath(path);
				var data = asset as SFXData;
				sFXList.Add(data);
			}

			var builder = new StringBuilder();

			//Script
			{
				//NameSpace
				builder.AppendLine("namespace Template.Constant");
				builder.AppendLine("{");

				//Struct
				{
					builder.Append("\t").AppendLine("/// <summary>");
					builder.Append("\t").AppendLine("/// 効果音名を定数で管理するクラス");
					builder.Append("\t").AppendLine("/// </summary>");
					builder.Append("\t").AppendFormat("public struct {0}", FILENAME_SFX).AppendLine();
					builder.Append("\t").AppendLine("{");

					//Constants
					{
						builder.Append("\t").Append("\t").AppendLine("#region Constants");
						builder.AppendLine("\t");

						foreach (var sfx in sFXList)
						{
							builder
								.Append("\t")
								.Append("\t")
								.AppendFormat
									(@"  public const string {0} = ""{1}"";",
										sfx.Name.Replace(" ", "_").ToUpper(),
										sfx.Name)
								.AppendLine();
						}

						builder.AppendLine("\t");
						builder.Append("\t").Append("\t").AppendLine("#endregion");
					}

					builder.Append("\t").AppendLine("}");
				}
				builder.AppendLine("}");
			}

			var directoryName = Path.GetDirectoryName(EXPORT_PATH_SFX);

			if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);

			File.WriteAllText(EXPORT_PATH_SFX, builder.ToString(), Encoding.UTF8);
			AssetDatabase.Refresh(ImportAssetOptions.ImportRecursive);
		}


        #endregion
    }
}