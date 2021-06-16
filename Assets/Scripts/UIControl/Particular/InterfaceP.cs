using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceP : MonoBehaviour
{
    [Header("Interfaces básicas")]
    public Text nameTXT;
    public Text healthTXT;
    public Text staminaTXT;

    [Header("Interfaces TMP")]
    public TMP_Text nameTMP;
    public TMP_Text healthTMP;
    public TMP_Text staminaTMP;

    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>(); 
        StartCoroutine(AsignarDatos(0.1f));
    }

    void Update() 
    {
        if(nameTXT != null)
            {
                nameTXT.text=playerData.nme;
            }
            
        if(healthTXT != null)
            {
                healthTXT.text=playerData.health.ToString();
            }
        if(staminaTXT != null)
            {
                staminaTXT.text=playerData.stamina.ToString();
            }

        if(nameTMP != null)
            {
                nameTMP.text=playerData.nme;
            }
            
        if(healthTMP != null)
            {
                healthTMP.text=playerData.health.ToString();
            }
        if(staminaTMP != null)
            {
                staminaTMP.text=playerData.stamina.ToString();
            }
    }
    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
                if(nameTXT != null)
            {
                nameTXT.text=playerData.nme;
            }
            
        if(healthTXT != null)
            {
                healthTXT.text=playerData.health.ToString();
            }
        if(staminaTXT != null)
            {
                staminaTXT.text=playerData.health.ToString();
            }

        if(nameTMP != null)
            {
                nameTMP.text=playerData.nme;
            }
            
        if(healthTMP != null)
            {
                healthTMP.text=playerData.health.ToString();
            }
        if(staminaTMP != null)
            {
                staminaTMP.text=playerData.health.ToString();
            }
            
    }
}
