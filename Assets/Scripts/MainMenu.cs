using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // A script to make sure we can load from one scene to another
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

}
