using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PageManager : MonoBehaviour
{
    //public GameObject firstPage;
    //public GameObject SecondPage;
    //public GameObject ThirdPage;
    //public GameObject FourthPage;
    public GameObject[] pages;
    public Text pageNumberText;
    public GameObject nextButton;
    public GameObject previousButton;
    public int pageNumber;
    public int count;
    public int totalPageNaumber;

    private void Start()
    {
        previousButton.SetActive(false);
        nextButton.SetActive(true);
        count = 0 ;
        totalPageNaumber = pages.Length;
        pageNumber = 1;
        pageNumberText.text = pageNumber + "/" + totalPageNaumber;
        for(int i=0;i<pages.Length;i++)
        {
            if (i == 0)
                pages[i].SetActive(true);
            else
                pages[i].SetActive(false);
        }

    }
    public void NextPage()
    {
        if (count < totalPageNaumber-1)
        {
            pages[count].SetActive(false);
            count++;
            pageNumber++;
            pages[count].SetActive(true);
            pageNumberText.text = pageNumber + "/" + totalPageNaumber;
            previousButton.SetActive(true);
        }
        if(count == totalPageNaumber-1)
            nextButton.SetActive(false);
        
    }
    public void PreviousPage()
    {
        if (count > 0)
        {
            
            pages[count].SetActive(false);
            count--;
            pages[count].SetActive(true);
            pageNumber--;
            pageNumberText.text = pageNumber + "/" + totalPageNaumber;
            if (count < totalPageNaumber - 1)
                nextButton.SetActive(true);
            
        }
        if (count == 0)
            previousButton.SetActive(false);
    }


}
