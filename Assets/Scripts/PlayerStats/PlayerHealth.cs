using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    Player playerData;
    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //Esto sería para simular que la energía o "stamina" se reduce al ejecutar
        //un ataque especial y se recupera con ataques básicos.
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerData.stamina -= 50;
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            playerData.stamina += 5;
        }
    }

    public void heal(float hl)
    {
        playerData.health += hl;
    }
    public void damage(float dmg)
    {
        playerData.health -= dmg;
    }
}
