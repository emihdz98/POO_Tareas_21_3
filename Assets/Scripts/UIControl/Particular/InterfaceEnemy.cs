using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceEnemy : MonoBehaviour
{
    [Header("Interfaces básicas")]
    public Text nameTXT;
    public Text healthTXT;

    [Header("Interfaces TMP")]
    public TMP_Text nameTMP;
    public TMP_Text healthTMP;

    enemy enemyData;

    // Start is called before the first frame update
    void Start()
    {
        enemyData=GetComponentInParent<enemy>(); 
        StartCoroutine(AsignarDatos(0.1f));
    }

    void Update() 
    {
        if(nameTXT != null)
            {
                nameTXT.text=enemyData.type;
            }
            
        if(healthTXT != null)
            {
                healthTXT.text=enemyData.health.ToString();
            }

        if(nameTMP != null)
            {
                nameTMP.text=enemyData.type;
            }
            
        if(healthTMP != null)
            {
                healthTMP.text=enemyData.health.ToString();
            }
    }
    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
        if(nameTXT != null)
            {
                nameTXT.text=enemyData.type;
            }
            
        if(healthTXT != null)
            {
                healthTXT.text=enemyData.health.ToString();
            }

        if(nameTMP != null)
            {
                nameTMP.text=enemyData.type;
            }
            
        if(healthTMP != null)
            {
                healthTMP.text=enemyData.health.ToString();
            }
            
    }
}
