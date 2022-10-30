using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllergyCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Check = false;
    public Image Checkmark;
    void Start()
    {
        Checkmark = gameObject.transform.Find("Checkmark (1)").Find("Checkmark (2)").Find("Checkmark").GetComponent<Image>();
        //Checkmark = gameObject.transform.Find("Checkmark").GetComponent<Image>();
        if(PlayerPrefs.GetString("Allergy_"+gameObject.name) == "True")
            Check=true;
        else
            Check = false;
    
    }
    public void ChangeCheck()
    {
        Check = !Check;
        PlayerPrefs.SetString("Allergy_"+gameObject.name, Check.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        Checkmark.enabled = Check;
        
    }
}
