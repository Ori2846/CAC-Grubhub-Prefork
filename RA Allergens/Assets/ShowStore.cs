using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowStore : MonoBehaviour
{
    public string Store;
    public TMP_Text PageTitle;
    public TMP_Text AllergyList;
    public string[] StoreLIST;
    public string[] StoreALLERGIES;
    // Start is called before the first frame update
    void Start()
    {
        Store = PlayerPrefs.GetString("Store");
        PageTitle.text = Store;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0;i<StoreLIST.Length;i++)
        {
            Debug.Log(StoreALLERGIES[i]);
        }
        
    }
}
