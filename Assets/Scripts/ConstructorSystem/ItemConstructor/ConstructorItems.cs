using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorItems
{
   //Atributos o propiedades
   public int itemId;
   public string type;
   
   public float heal;

   //Método constructor
   public ConstructorItems(int id, string t, float hl)
   {
      this.itemId=id;
      this.type=t;
      this.heal=hl;
   }
}
