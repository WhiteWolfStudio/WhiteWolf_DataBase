using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

namespace WhiteWolf {

    public class WW_EditDB : WW_Database {

        [HorizontalLine]

        [Dropdown("types")]
        public string type;

        [HorizontalLine]

        public string _name;
        public string data;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private List<string> types { get { return new List<string>() { "int", "float", "string" }; } }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        [Button]
        void Edit(){

            if ( type == "int" ){ SaveDataInt( _name, int.Parse( data ) ); print( $"{_name}: {LoadDataInt( _name )}" ); }
            if ( type == "float" ){ SaveDataFloat( _name, float.Parse( data ) ); print( $"{_name}: {LoadDataFloat( _name )}" ); }
            if ( type == "string" ){ SaveDataString( _name, data ); print( $"{_name}: {LoadDataString( _name )}" ); }

        }

    }

}