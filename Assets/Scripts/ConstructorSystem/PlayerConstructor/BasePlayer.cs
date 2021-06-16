using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
        public ConstructorPlayer[] newPlayer;
    void Awake()
    {
        newPlayer= new ConstructorPlayer[3];

        newPlayer[0]= new ConstructorPlayer(1,"Character1",200,10,300);
        newPlayer[1]= new ConstructorPlayer(2,"Character2",100,20,200);
        newPlayer[2]= new ConstructorPlayer(3,"Character3",200,15,200);
    }

}
