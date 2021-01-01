using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
    public Toggle[] answers;
    public GameObject lastBody;
    public GameObject resultBody;
    public Text resultText;
    public GameObject feedback1;
    public GameObject feedback2;
    public GameObject feedback3;
    public GameObject finishButton;


    private int score;


    private void Start()
    {
        score = 0;
        resultBody.SetActive(false);
        lastBody.SetActive(false);
        resultText.gameObject.SetActive(false);
        feedback1.SetActive(false);
        feedback2.SetActive(false);
        feedback3.SetActive(false);
        finishButton.SetActive(false);

    }

    public void ShowFinishButton()
    {
        if (gameObject.GetComponent<PageManager>().count == gameObject.GetComponent<PageManager>().totalPageNaumber - 1)
            finishButton.SetActive(true);
    }

    public void CalculateScore()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i].isOn == true)
            { score = score + 1; }
            
        }
        resultText.text = "Your Score is " + score + "/" + answers.Length;
        resultText.gameObject.SetActive(true);
        if (score > 13)
            feedback1.SetActive(true);

        else if (score < 13 && score > 9)
            feedback2.SetActive(true);
        else if (score < 9)
            feedback3.SetActive(true);
        lastBody.SetActive(false);
        finishButton.SetActive(false);
        gameObject.GetComponent<PageManager>().previousButton.SetActive(false);
        gameObject.GetComponent<PageManager>().pageNumberText.gameObject.SetActive(false);
        gameObject.GetComponent<HeaderTextManager>().headerText.text = " You Finished!";
        resultBody.SetActive(true);

    }

}
