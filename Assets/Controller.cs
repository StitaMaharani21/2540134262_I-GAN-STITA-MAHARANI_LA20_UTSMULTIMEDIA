using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public void Started()
    {
        SceneManager.LoadScene("PageMenu");
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene("HomePage");
    }
    public void Return()
    {
        SceneManager.LoadScene("PageMenu");
    }
    
    public void Gajah()
    {
        SceneManager.LoadScene("ElephantAR");
    }
    public void Macan()
    {
        SceneManager.LoadScene("TigerAR");
    }
    public void Monyet()
    {
        SceneManager.LoadScene("MonkeyAR");
    }

}
