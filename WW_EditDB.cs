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

        private List<string> StringValues => new List<string>() { "int", "float", "string" };

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        [Button]
        private void Edit(){

            switch ( type ){
                
                case "int":
                    SaveDataInt( _name, int.Parse( data ) ); print( $"{_name}: {LoadDataInt( _name, 0 )}" );
                    break;
                case "float":
                    SaveDataFloat( _name, float.Parse( data ) ); print( $"{_name}: {LoadDataFloat( _name, 0 )}" );
                    break;
                case "string":
                    SaveDataString( _name, data ); print( $"{_name}: {LoadDataString( _name, "null" )}" );
                    break;
                
            }
            
        }

        [Button]
        private void Reset() => ResetData();

    }

}
