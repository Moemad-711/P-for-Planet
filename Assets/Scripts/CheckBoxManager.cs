using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBoxManager : MonoBehaviour
{
    public Toggle firstChoice;
    public Toggle secondChoice;
    public Toggle thirdChoice;

    // Start is called before the first frame update
    void Start()
    {
        firstChoice.isOn = false;
        secondChoice.isOn = false;
        thirdChoice.isOn = false;
    }

    public void SetFirstChoice()
    {
        if (firstChoice.isOn == true)
        {
            secondChoice.isOn = false;
            thirdChoice.isOn = false;
            print("first is true");
        }
    }

    public void SetSecondChoice()
    {
        if (secondChoice.isOn == true)
        {
            firstChoice.isOn = false;
            thirdChoice.isOn = false;
            print("second is true");
        }
    }

    public void SetThirdChoice()
    {
        if (thirdChoice.isOn == true)
        {
            firstChoice.isOn = false;
            secondChoice.isOn = false;
            print("third is true");
        }

    }

}
