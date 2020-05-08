using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Transitions : MonoBehaviour
{
    public Animator animation;
    
    // Update is called once per frame
    public void ChildIcon()
    {
        animation.SetTrigger("Enter");
    }

    public void BackToMenu()
    {
        animation.SetTrigger("Exit");
    }

    public void LoadLevel(string scenename)
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadLevels(int sceneno)
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame(string scenename)
    {
        SceneManager.LoadScene("PlayArea");
    }

}
