using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class WebScipt : MonoBehaviour
{
    public ErrorManager LoginError;
    public ErrorManager SignUpError;

    void Start()
    {

    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("login_user", username);
        form.AddField("login_password", password);

        using (UnityWebRequest www = UnityWebRequest.Post("https://p4planet.000webhostapp.com/planet/login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                LoginError.ShowErrorText();
            }

            else
            {



                Debug.Log(www.downloadHandler.text);
                SceneManager.LoadScene(3);

            }
        }
    }


    public IEnumerator Register(string username, string password)
    {

        WWWForm form = new WWWForm();
        form.AddField("login_user", username);
        form.AddField("login_password", password);

        using (UnityWebRequest www = UnityWebRequest.Post("https://p4planet.000webhostapp.com/planet/signup.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                Debug.Log("WWW Error");
                if(www.isNetworkError)
                {
                    SignUpError.errorText.text = "No Internet Connection";
                    SignUpError.ShowErrorText();
                }
                if (www.isHttpError)
                {
                    SignUpError.errorText.text = "Username is already taken";
                    SignUpError.ShowErrorText();
                }
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                Debug.Log("download handler error");
                SceneManager.LoadScene(0);
            }
        }
    }
    public IEnumerator Logout()
    {
        WWWForm form = new WWWForm();

        using (UnityWebRequest www = UnityWebRequest.Post("https://p4planet.000webhostapp.com/planet/logout.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                if (www.isNetworkError)
                {
                    LoginError.errorText.text = "No Internet Connection";
                    LoginError.ShowErrorText();
                }
                if (www.isHttpError)
                {
                    LoginError.errorText.text = "Invalid Username or Password";
                    LoginError.ShowErrorText();
                }
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                SceneManager.LoadScene(0);
            }
        }
    }
}

   
