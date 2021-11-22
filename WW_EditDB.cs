using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

namespace WhiteWolf {

    public class WW_EditDB : WW_Database {

        [HorizontalLine]

        [Dropdown("StringValues")]
        public string type;

        [HorizontalLine]

        public string _name;
        public string data;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private List<string> StringValues { get { return new List<string>() { "int", "float", "string" }; } }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        [Button]
        void Edit(){

            if ( type == "int" ){ SaveDataInt( _name, int.Parse( data ) ); print( $"{_name}: {LoadDataInt( _name, 0 )}" ); }
            if ( type == "float" ){ SaveDataFloat( _name, float.Parse( data ) ); print( $"{_name}: {LoadDataFloat( _name, 0 )}" ); }
            if ( type == "string" ){ SaveDataString( _name, data ); print( $"{_name}: {LoadDataString( _name, "null" )}" ); }

        }

        [Button]
        void Reset() => ResetData();

    }

}
