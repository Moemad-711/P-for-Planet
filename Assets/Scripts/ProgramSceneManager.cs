using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ProgramSceneManager : MonoBehaviour
{
    public Text firstText;
    public Text secondText;
    public Image image;
 
    public void LoadSignupScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLoginScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadWelcomeScene ()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadFirstLoginScene()
    {
        SceneManager.LoadScene(3);
    }

    public void FirstTimeSceneNextButton()
    {
        if (firstText.IsActive() == true && secondText.IsActive() == false)
        {
            firstText.gameObject.SetActive(false);
            image.gameObject.SetActive(false);
            secondText.gameObject.SetActive(true);
        }
        else
        {
            LoadChoiceScene();
        }
    }

    public void LoadChoiceScene()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadClimateCatalog()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadWeatherOrClimateScene()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadTheGreenhouseEffectScene()
    {
        SceneManager.LoadScene(7);
    }
    public void loadCloudsAndClimateScene()
    {
        SceneManager.LoadScene(8);
    }
    public void LoadAirPollutionScene()
    {
        SceneManager.LoadScene(9);
    }
    public void LoadMeasuringSeaLevelScene()
    {
        SceneManager.LoadScene(10);
    }
    public void LoadKeepInBalanceScene()
    {
        SceneManager.LoadScene(11);
    }
    public void LoadTakeTheTestScene()
    {
        SceneManager.LoadScene(12);
    }
}
