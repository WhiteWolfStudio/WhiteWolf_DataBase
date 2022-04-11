using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

namespace WhiteWolf {
    
    [System.Serializable]
    public class DBDatas {

        public string data;

        [Space]

        public bool _int;
        public bool _float;
        public bool _string;

    }
    
    public class WW_ShowDB : WW_Database {

        public string filePath;

        [ResizableTextArea]
        public string text;

        [Space]

        public DBDatas[] datas;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Awake() => filePath = Application.persistentDataPath;

        private void Update(){
            
            text = "";

            foreach ( var t in datas ){
                if ( t._int ) text += $"{ t.data }: { LoadDataInt( t.data ).ToString()}\n";
                else if ( t._float ) text += $"{ t.data }: { LoadDataFloat(t.data ).ToString() }\n";
                else if ( t._string ) text += $"{ t.data }: { LoadDataString(t.data )}\n";
            }
        }

    }

}
