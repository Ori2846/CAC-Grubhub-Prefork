using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
public class Allergy : MonoBehaviour
{
    
    // Start is called before the first frame update

    public bool SignIn = true;
    public TMP_Text[] SignInText;    
    public TMP_Text SignUpText;   
    public GameObject SignInPanel; 
    public GameObject MainScreenPanel; 

    
    void Start()
    {
    
        
    }
    public void SignInSignUp()
    {
        SignUpText.text = "";
        SignIn = !SignIn;
        if(SignIn)
        {
            SignInText[0].text = "SIGN IN";
            SignInText[2].text = "Sign Up";
            SignInText[1].text = "SIGN IN";
            
        } else
        {
            SignInText[0].text = "SIGN UP";
            SignInText[2].text = "Sign In";
            SignInText[1].text = "SIGN UP";
        }
    }
    public void SignUp()
    {
        SignUpText.text = "Successful!";
        
    }
    public void SignInFunction()
    {
        if(SignInText[1].text == "SIGN IN")
        {
            Animator animator = SignInPanel.GetComponent<Animator>();
        animator.SetBool("open", true);
        Animator animator2 = MainScreenPanel.GetComponent<Animator>();
        animator2.SetBool("open", true);
            
            //Change Screen
        }else
        {
            SignUpText.text = "Successful!";
            SignUp();
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
