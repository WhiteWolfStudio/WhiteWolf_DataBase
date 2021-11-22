using UnityEngine;
using System.IO;

namespace WhiteWolf {

    public class WW_Database : MonoBehaviour {

        // Load FLOAT
        public static float LoadDataFloat( string name, float or ){

            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetFloat( name );
            else SaveDataFloat( name, or );

            return LoadDataFloat( name, or ); ;

        }

        // Load INT
        public static int LoadDataInt( string name, int or ){

            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetInt( name );
            else SaveDataInt( name, or );

            return LoadDataInt( name, or );

        }

        // Load STRING
        public static string LoadDataString( string name, string or ){

            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetString( name );
            else SaveDataString( name, or );

            return LoadDataString( name, or );

        }

        // Load BOOL
        public static bool LoadDataBool( string name, bool or ){

            if ( PlayerPrefs.HasKey( name ) ){ return ( PlayerPrefs.GetInt( name )  == 0 ? false : true ); }
            else SaveDataBool( name, or );

            return LoadDataBool( name, or );

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Save FLOAT
        public static void SaveDataFloat( string name, float value ){

            PlayerPrefs.SetFloat( name, value );
            PlayerPrefs.Save();

        }

        // Save INT
        public static void SaveDataInt( string name, int value ){

            PlayerPrefs.SetInt( name, value );
            PlayerPrefs.Save();

        }

        // Save STRING
        public static void SaveDataString( string name, string value ){

            PlayerPrefs.SetString( name, value );
            PlayerPrefs.Save();

        }

        // Save BOOL
        public static void SaveDataBool( string name, bool value ){

            if ( value == false ){ PlayerPrefs.SetInt( name, 0 ); }
            else { PlayerPrefs.SetInt( name, 1 ); }

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void PlusFloat( string name, float n ) => SaveDataFloat( name, LoadDataFloat( name, 0 ) + n );
        public static void PlusInt( string name, int n ) => SaveDataInt( name, LoadDataInt( name, 0 ) + n );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void MinusFloat( string name, float n ) => SaveDataFloat( name, LoadDataFloat( name, 0 ) - n);
        public static void MinusInt( string name, int n ) => SaveDataInt( name, LoadDataInt( name, 0 ) - n );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Reset INT / FLOAT / STRING
        public static void ResetData(){ PlayerPrefs.DeleteAll(); print( "All data deleted!" ); }

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
