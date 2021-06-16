using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour 
{
   public string type;
   public int enemyId;
   
   public float health;
   public float speed;
   public float damage;

  BaseEnemies bEnemy;

private void Start() {
      
      bEnemy=GameObject.FindObjectOfType<BaseEnemies>();
    CargarDatos(enemyId);
 }

void CargarDatos(int id)
{
    for (int i = 0; i < bEnemy.newEnemy.Length; i++)
    {
        if (bEnemy.newEnemy[i].enemyId==id)
        {
            this.type=bEnemy.newEnemy[i].type;
            this.health=bEnemy.newEnemy[i].health;
            this.speed=bEnemy.newEnemy[i].speed;
            this.damage=bEnemy.newEnemy[i].damage;
        }
    }
}
private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().damage(damage);
        }
    }
}
