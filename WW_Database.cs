using UnityEngine;
using System.IO;

namespace WhiteWolf {

    public class WW_Database : MonoBehaviour {

        // Load FLOAT
        public float LoadDataFloat(string name) {
            if (PlayerPrefs.HasKey(name)) return PlayerPrefs.GetFloat(name);
            return -0.0f;
        }

        // Load INT
        public int LoadDataInt(string name) {
            if (PlayerPrefs.HasKey(name)) return PlayerPrefs.GetInt(name);
            return -0;
        }

        // Load STRING
        public string LoadDataString(string name) {
            if (PlayerPrefs.HasKey(name)) return PlayerPrefs.GetString(name);
            return null;
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Save FLOAT
        public void SaveDataFloat(string name, float value) {
            PlayerPrefs.SetFloat(name, value);
            PlayerPrefs.Save();
        }

        // Save INT
        public void SaveDataInt(string name, int value) {
            PlayerPrefs.SetInt(name, value);
            PlayerPrefs.Save();
        }

        // Save STRING
        public void SaveDataString(string name, string value) {
            PlayerPrefs.SetString(name, value);
            PlayerPrefs.Save();
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Check FLOAT
        public bool CheakFloat(string name) {
            if (LoadDataFloat(name) == -0f) return false;
            else return true;
        }

        // Check INT
        public bool CheakInt(string name) {
            if (LoadDataInt(name) == -0f) return false;
            else return true;
        }

        // Check STRING
        public bool CheakString(string name) {
            if (LoadDataString(name) == null) return false;
            else return true;
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void PlusFloat(string name, float n) => SaveDataFloat(name, LoadDataFloat(name) + n);
        public void PlusInt(string name, int n) => SaveDataInt(name, LoadDataInt(name) + n);

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void MinusFloat(string name, float n) => SaveDataFloat(name, LoadDataFloat(name) - n);
        public void MinusInt(string name, int n) => SaveDataInt(name, LoadDataInt(name) - n);

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Reset INT / FLOAT / STRING
        public void ResetData() { PlayerPrefs.DeleteAll(); Debug.Log("All data deleted!"); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void SaveFile( string fileName, string data ){

            string path = $"{Application.persistentDataPath}/{fileName}";

            StreamWriter sw = File.AppendText( path );
            sw.WriteLine( $"{data}" );

        }

        public string GetFilePath( string file ){ return $"{Application.persistentDataPath}/{file}"; }

        public string FilePath(){ return Application.persistentDataPath; }

        public void File_Path() => Debug.Log( Application.persistentDataPath );
        
        public bool CheckFile( string file ){

            string path = $"{Application.persistentDataPath}/{file}";

            if ( File.Exists( path ) ){ return true; }
            return false;

        }

    }

}
