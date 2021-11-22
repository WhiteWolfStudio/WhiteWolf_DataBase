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

        [TextArea]
        public string text;

        [Space]

        public DBDatas[] datas;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        void Update() {

            text = "";

            for ( int i = 0; i<datas.Length; i++ ){

                if ( datas[ i ]._int ) text += $"{ datas[i].data }: { LoadDataInt( datas[i].data, 0 ).ToString()}\n";
                else if ( datas[ i ]._float ) text += $"{ datas[i].data }: { LoadDataFloat( datas[i].data, 0 ).ToString() }\n";
                else if ( datas[ i ]._string ) text += $"{ datas[i].data }: { LoadDataString( datas[i].data, "null" )}\n";

            }

        }

    }

}
