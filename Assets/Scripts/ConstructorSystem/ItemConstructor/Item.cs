using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour 
{
   public string type;
   public int itemId;
   
   public float heal;

  BaseItems bItem;

private void Start() {
      
      bItem=GameObject.FindObjectOfType<BaseItems>();
    CargarDatos(itemId);
 }

void CargarDatos(int id)
{
    for (int i = 0; i < bItem.newItem.Length; i++)
    {
        if (bItem.newItem[i].itemId==id)
        {
            this.type=bItem.newItem[i].type;
            this.heal=bItem.newItem[i].heal;
        }
    }
}
private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().heal(heal);
        }
    }
}
