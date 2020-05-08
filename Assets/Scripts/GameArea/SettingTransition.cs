using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingTransition : MonoBehaviour
{
    public Animator animation;
   
    public void Parent()
    {
        animation.SetTrigger("Parent");
    }

    public void Settings()
    {
        animation.SetTrigger("Settings");
    }

    public void Curriculum()
    {
        animation.SetTrigger("Curriculum");
    }

    public void Progress()
    {
        animation.SetTrigger("Progress");
    }

    public void LoadLevel(string scenename)
    {
        SceneManager.LoadScene("MainMenuGameplay");
    }
}
