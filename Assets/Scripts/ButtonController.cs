using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update

    public void ClickPlay()
    {
        SceneManager.LoadScene("abc");
    }
    public void ClickExit()
    {
        Application.Quit();
    }
}
