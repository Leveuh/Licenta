using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RegistrationScript : MonoBehaviour
{


    // Start is called before the first frame update
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {

        StartCoroutine(Register());
    }

    IEnumerator Register()
    {

        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);

        WWW www = new WWW("http://localhost/sqlconnect/register.php", form);
        yield return www;

        

        if (www.text == "0")
        {

            Debug.Log("User created.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User creation failed");

        }




    }



}

