using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginMenu : MonoBehaviour
{
   public void Close()
    {
        Application.Quit();
    }
    public void StressTest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
