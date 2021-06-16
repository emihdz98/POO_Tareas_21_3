using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemies : MonoBehaviour
{
        public ConstructorEnemies[] newEnemy;
    void Awake()
    {
        newEnemy= new ConstructorEnemies[3];

        newEnemy[0]= new ConstructorEnemies(1,"SmallEnemy",100,15,15);
        newEnemy[1]= new ConstructorEnemies(2,"BigEnemy",300,5,30);
        newEnemy[2]= new ConstructorEnemies(3,"FastEnemy",50,35,10);
    }

}
