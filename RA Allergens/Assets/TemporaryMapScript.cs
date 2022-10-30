using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemporaryMapScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SetAllergicItems SAI;
    public Sprite[] maps;
    void Start()
    {
        SAI = GameObject.Find("Allergic Items_List").GetComponent<SetAllergicItems>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Image>().sprite = maps[SAI.index];
    }
}
