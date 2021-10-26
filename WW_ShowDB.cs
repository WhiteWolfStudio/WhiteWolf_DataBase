using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

        [TextArea]
        public string text;

        [Space]

        public DBDatas[] datas;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Awake() => filePath = Application.persistentDataPath;

        void Update() {

            text = "";

            for ( int i = 0; i<datas.Length; i++ ){

                if ( datas[ i ]._int ) text += $"{ datas[i].data }: { LoadDataInt( datas[i].data ).ToString()}\n";
                else if ( datas[ i ]._float ) text += $"{ datas[i].data }: { LoadDataFloat(datas[i].data ).ToString() }\n";
                else if ( datas[ i ]._string ) text += $"{ datas[i].data }: { LoadDataString(datas[i].data )}\n";

            }

        }

    }

}
