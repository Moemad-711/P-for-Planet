using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public TMPro.TMP_InputField UsernameInput;
    public TMPro.TMP_InputField PasswordInput;
    // Start is called before the first frame update
    
    public void Login()
    {
            StartCoroutine(MainScript.Instance.Web.Login(UsernameInput.text, PasswordInput.text));
    }
}
