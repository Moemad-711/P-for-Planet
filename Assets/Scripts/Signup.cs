using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signup : MonoBehaviour
{
    public TMPro.TMP_InputField UsernameInput;
    public TMPro.TMP_InputField PasswordInput;
    public TMPro.TMP_InputField ConfrimPasswordInput;
    public GameObject errorText;


    public void SignUp()
    {

        if (PasswordInput.text == ConfrimPasswordInput.text)
            StartCoroutine(MainScript.Instance.Web.Register(UsernameInput.text, PasswordInput.text));
        else
        {
            errorText.GetComponent<Text>().text = "Password Doesn't Match"; 
            errorText.SetActive(true);

        }
        
        
    }
}
