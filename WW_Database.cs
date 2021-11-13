using UnityEngine;
using System.IO;

namespace WhiteWolf {

    public class WW_Database : MonoBehaviour {

        // Load FLOAT
        public static float LoadDataFloat(string name) {
            if (PlayerPrefs.HasKey(name)) return PlayerPrefs.GetFloat(name);
            return -0.0f;
        }

        // Load INT
        public static int LoadDataInt(string name) {
            if (PlayerPrefs.HasKey(name)) return PlayerPrefs.GetInt(name);
            return -0;
        }

        // Load STRING
        public static string LoadDataString(string name) {
            if (PlayerPrefs.HasKey(name)) return PlayerPrefs.GetString(name);
            return null;
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Save FLOAT
        public static void SaveDataFloat(string name, float value) {
            PlayerPrefs.SetFloat(name, value);
            PlayerPrefs.Save();
        }

        // Save INT
        public static void SaveDataInt(string name, int value) {
            PlayerPrefs.SetInt(name, value);
            PlayerPrefs.Save();
        }

        // Save STRING
        public static void SaveDataString(string name, string value) {
            PlayerPrefs.SetString(name, value);
            PlayerPrefs.Save();
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Check FLOAT
        public static bool CheakFloat(string name) {
            if (LoadDataFloat(name) == -0f) return false;
            else return true;
        }

        // Check INT
        public static bool CheakInt(string name) {
            if (LoadDataInt(name) == -0f) return false;
            else return true;
        }

        // Check STRING
        public static bool CheakString(string name) {
            if (LoadDataString(name) == null) return false;
            else return true;
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void PlusFloat(string name, float n) => SaveDataFloat(name, LoadDataFloat(name) + n);
        public static void PlusInt(string name, int n) => SaveDataInt(name, LoadDataInt(name) + n);

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void MinusFloat(string name, float n) => SaveDataFloat(name, LoadDataFloat(name) - n);
        public static void MinusInt(string name, int n) => SaveDataInt(name, LoadDataInt(name) - n);

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Reset INT / FLOAT / STRING
        public static void ResetData() { PlayerPrefs.DeleteAll(); Debug.Log("All data deleted!"); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void SaveFile( string fileName, string data ){

            string path = $"{Application.persistentDataPath}/{fileName}";

            StreamWriter sw = File.CreateText( path );
            sw.Write( $"{data}" );
            sw.Close();

        }

        public static string GetFilePath( string file ){ return $"{Application.persistentDataPath}/{file}"; }

        public static string FilePath(){ return Application.persistentDataPath; }

        public static void printFilePath() => Debug.Log( Application.persistentDataPath );

        public static bool CheckFile( string file ){

            string path = $"{Application.persistentDataPath}/{file}";

            if ( File.Exists( path ) ){ return true; }
            return false;

        }

    }

}
