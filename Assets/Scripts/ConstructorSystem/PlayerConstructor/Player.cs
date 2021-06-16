using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
   public string nme;
   public int playerId;
   
   public float health;
   public float speed;
   public float stamina;

  BasePlayer bPlayer;

private void Start() {
      
      bPlayer=GameObject.FindObjectOfType<BasePlayer>();
    CargarDatos(playerId);
 }

void CargarDatos(int id){
    for (int i = 0; i < bPlayer.newPlayer.Length; i++)
    {
        if (bPlayer.newPlayer[i].playerId==id)
        {
            this.nme=bPlayer.newPlayer[i].name;
            this.health=bPlayer.newPlayer[i].health;
            this.speed=bPlayer.newPlayer[i].speed;
            this.stamina=bPlayer.newPlayer[i].stamina;
        }
    }
}
}
