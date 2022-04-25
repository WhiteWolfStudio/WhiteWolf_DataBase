using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

namespace WhiteWolf {
    
    [System.Serializable]
    public class DBData {

        public string name;
        [Dropdown("StringValues")] public string type;

        private List<string> StringValues => new List<string>() { "int", "float", "string", "vector2", "vector3" };

    }
    
    public class WW_ShowDB : WW_Database {
        
        [HorizontalLine]

        public string filePath;

        [HorizontalLine]
        
        [ResizableTextArea]
        public string text;

        [Space]

        public DBData[] data;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Awake() => filePath = Application.persistentDataPath;

        private void Update() => ShowData();
        
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
        
        private void ShowData(){
            
            text = "";

            foreach ( var t in data ){

                switch ( t.type ){
                    
                    case "int":
                        text += $"{ t.name }: { LoadDataInt( t.name ).ToString()}\n";
                        break;
                    
                    case "float":
                        text += $"{ t.name }: { LoadDataFloat(t.name ).ToString() }\n";
                        break;
                    
                    case "string":
                        text += $"{ t.name }: { LoadDataString(t.name )}\n";
                        break;
                    
                    case "vector2":
                        text += $"{ t.name }: { LoadDataVector2(t.name )}\n";
                        break;
                    
                    case "vector3":
                        text += $"{ t.name }: { LoadDataVector3(t.name )}\n";
                        break;

                }

            }
            
        }

    }

}
