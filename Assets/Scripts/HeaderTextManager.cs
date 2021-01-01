using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeaderTextManager : MonoBehaviour
{

    public Text headerText;
    private void Start()
    {
        headerText.text = "Quistion " + gameObject.GetComponent<PageManager>().pageNumber;
    }
    public void ChangeTestHeaderText()
    {
        headerText.text = "Quistion " + gameObject.GetComponent<PageManager>().pageNumber;
    }

}
