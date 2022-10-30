using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;
public class Allergy : MonoBehaviour
{
    
    // Start is called before the first frame update

    public bool SignIn = true;
    public bool ShowPasswordBool = false;
    public TMP_Text[] SignInText;    
    public TMP_Text SignUpText;   
    public GameObject SignInPanel; 
    public GameObject MainScreenPanel; 
    public TMP_Text[] Password;
    public Scrollbar bar;
    public bool barb=false;
    public GameObject[] Scenes;
    private TMP_Text NameTitle;
    public string Username;
    public string StoreName;
    public TMP_Text[] TextUsernames;
    public string[][] names;
    public string[][] reviews;
    public string[] names_;
    public string[] reviews_;
    private SetAllergicItems SAI;

    public string[,] list = new string[4,4] {
    {"Vincent of Tampa, FL","I went to Applebee's for lunch 2 weeks ago. They had a new menu with a wide variety of items. Their 550 calorie and below selections are all quite good. My server was very friendly and efficient and she kept my drink filled at all times. The quality of the food was excellent and it was priced reasonably.","Jennifer of Mcconnellsburg, PA","We had Zoey. She was a very good waitress. Was very attentive, got our drinks every time we needed it, did not have to ask. Was very nice. Excellent job at everything."},
    {"Eli of Columbia, MO","My family and I went to McDonald’s on Business Loop the roundabout basically in Columbia and we ordered a McChicken, McDouble a couple of drinks. Fanta, Coke and a Dr. Pepper and a Chicken Nugget Happy Meal. Most of the meal was good but the fries, oh the fries they were absolutely disgusting and undercooked. I might go again but will not get fries.","Manikandan of Other, Other","I have been visited every weekend. And it's a nice place to eats without any disturbance. And make me relax. I love a spicy chicken and kebab wrap lover. Whenever I visit McDonalds I placed this order. And I love that McDonalds black forest as desserts."},
    {"Josh floranne D.","5 star for the person who helped me alone while his coworker watch him only even people are lining up waiting for their turn to order.","Dana L.","Outstanding service from the night crew. No wait, food was fresh, everyone was friendly! Will be back soon. Restaurant was clean."},
    {"Josh floranne D.","5 star for the person who helped me alone while his coworker watch him only even people are lining up waiting for their turn to order.","Dana L.","Outstanding service from the night crew. No wait, food was fresh, everyone was friendly! Will be back soon. Restaurant was clean."},
    };
    public int[,] list2 = new int[4,2] {
    {5,4},
    {2,4},
    {5,5},
    {5,5},
    };


    void Start()
    {
        Application.targetFrameRate = 300;
    Username = PlayerPrefs.GetString("Username");
    
    }
    
    public void DeclareUsername()
    {
        PlayerPrefs.SetString("Username",GameObject.Find("UsernameText").GetComponent<TMP_Text>().text);
        foreach (var item in TextUsernames)
        {
            item.text = PlayerPrefs.GetString("Username");
        }
    }
    public void GoToScene(string Scene)
    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            if(Scenes[i].name != Scene)
                Scenes[i].SetActive(false);
            else
                Scenes[i].SetActive(true);
        }
        if(Scene == "MainScreen")
        {
        NameTitle = GameObject.Find("NameTitle").GetComponent<TMP_Text>();
        NameTitle.text = PlayerPrefs.GetString("Username"); 
        }
        
            
    }
    public void Testing()
    {
        Debug.Log("TESTCOMPLETE");
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
        StoreName = PlayerPrefs.GetString("Store");
        string text = Password[0].text;
        string hiddenpassword = "";
        for (int i = 1; i < text.Length; i++)
        {
            hiddenpassword += "*";
        }
        Password[1].text = hiddenpassword;

        if(barb)
        {
        //bar = gameObject.GetComponent<Scrollbar>();
        if(bar.value < 1)
        {
            bar.value += 0.025f;
        } else
        {
            barb=!barb;
        }
        
        }
    }
    public void ShowPassword()
    {
        ShowPasswordBool = !ShowPasswordBool;
        if(ShowPasswordBool)
        {
            Password[1].color = new Color32(34, 34, 34, 0);
            Password[0].color = new Color32(34, 34, 34, 255);
        } else
        {
            Password[0].color = new Color32(34, 34, 34, 0);
            Password[1].color = new Color32 (34,34,34,255);;
        }
    }
    
 
    public void BackUp()
    {
        barb = true;

    }
    public void SetStore(string Store)
    {
        PlayerPrefs.SetString("Store", Store);
    }
}
