using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PasswordHidden : MonoBehaviour
{
    public TMP_Text hiddenpassword;
    public TMP_Text shownpassword;
    public bool Hidden = true;
    public string password ="";
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeHidden()
    {
        Hidden = !Hidden;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Hidden)
        {
            shownpassword.text = hiddenpassword.text;
        } else
        {
            password ="";
            for(int i=1; i< hiddenpassword.text.Length;i++)
            {
                password +="*";
            }
            shownpassword.text = password;
        }
    }
}
