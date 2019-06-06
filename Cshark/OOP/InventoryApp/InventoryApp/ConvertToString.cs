using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    public class ConvertToString
    {
        public string WoodToString(Wood W) {
            switch (W){

                case Wood.INDIAN_ROSEWOOD :
                    return "Indian Rosewood";

                case Wood.BRAZILIAN_ROSEWOOD :
                    return "Brazilian Rosewood";

                case Wood.ADIRONDACK :
                    return "Adirondack";

                case Wood.ALDER :
                    return "Alder";

                case Wood.CEDAR:
                    return "Cedar";
                case Wood.COCOBOLO:
                    return "Cocobolo";
                case Wood.MAHOGANY:
                    return "Mahogany";
                case Wood.MAPLE:
                    return "Maple";
                case Wood.SITKA:
                    return "Sitka";
                 default:
                    return "wrong choice"; 
            }
                                
            }

        public string TypeToString(Type T) {
            switch(T){
                case Type.ACOUSTIC:
                    return "Acoustic";
                case Type.ELECTRIC:
                    return "Electic";
                default:
                    return "Wrong value";
            }
            
        }

        public string BuilderToString(Builder B)
        {
            switch (B)
            {
                case Builder.COLLINGS:
                    return "Collings";
                case Builder.FENDER:
                    return "Fender";
                case Builder.GIBSON:
                    return "Gibson";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.OLSON:
                    return "Olson";
                case Builder.PRS:
                    return "prs";
                case Builder.RYAN:
                    return "Ryan";
                case Builder.ANY:
                    return "Any";
                default:
                    return "Wrong Value";
            }
        }
            }
    }

