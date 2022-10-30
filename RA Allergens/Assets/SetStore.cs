using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStore : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SettingStore()
    {
        PlayerPrefs.SetString("Store", gameObject.name);
        Debug.Log(PlayerPrefs.GetString("Store"));
        GameObject.Find("GameManager").GetComponent<Allergy>().GoToScene("Review Page");
    }
}
