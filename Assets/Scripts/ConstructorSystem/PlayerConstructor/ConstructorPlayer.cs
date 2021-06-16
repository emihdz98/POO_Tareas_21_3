using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorPlayer
{
   //Atributos o propiedades
   public int playerId;
   public string name;
   
   public float health;
   public float speed;
   public float stamina;


   //Método constructor
   public ConstructorPlayer(int id, string n, float h, float sp, float st)
   {
      
      this.playerId=id;
      this.name=n;
      this.health=h;
      this.speed=sp;
      this.stamina=st;
   }
}
