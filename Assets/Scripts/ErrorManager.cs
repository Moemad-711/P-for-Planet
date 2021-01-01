using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorManager : MonoBehaviour
{
    public Text errorText;

    private void Start()
    {
        errorText.gameObject.SetActive(false);
    }

    public void ShowErrorText()
    {
        
        errorText.gameObject.SetActive(true);
    }
}
