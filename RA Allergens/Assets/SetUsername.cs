using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetUsername : MonoBehaviour
{
    private TMP_Text Username;
    // Start is called before the first frame update
    void Start()
    {
        Username = gameObject.GetComponent<TMP_Text>();
        Username.text = PlayerPrefs.GetString("Username");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
