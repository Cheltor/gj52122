using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(0);
    }
}
