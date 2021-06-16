using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorEnemies
{
   //Atributos o propiedades
   public int enemyId;
   public string type;
   
   public float health;
   public float speed;
   public float damage;


   //Método constructor
   public ConstructorEnemies(int id, string t, float h, float sp, float dmg)
   {
      
      this.enemyId=id;
      this.type=t;
      this.health=h;
      this.speed=sp;
      this.damage=dmg;
   }
}
