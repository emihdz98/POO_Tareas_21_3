using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItems : MonoBehaviour
{
        public ConstructorItems[] newItem;
    void Awake()
    {
        newItem= new ConstructorItems[3];

        newItem[0]= new ConstructorItems(1,"SmallHealthPotion",50);
        newItem[1]= new ConstructorItems(2,"MedHealthPotion",100);
        newItem[2]= new ConstructorItems(3,"BigHealthPotion",200);
    }

}
