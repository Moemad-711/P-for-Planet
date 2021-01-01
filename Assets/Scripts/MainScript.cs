using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainScript : MonoBehaviour
{
    public static MainScript Instance;
    public WebScipt Web;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Web = GetComponent<WebScipt>();
    }

}
