using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PATransition : MonoBehaviour
{
    public Animator animation;

    public void LoadMain(string scenename)
    {
        animation.SetTrigger("Back");
        SceneManager.LoadScene("MainMenuGameplay");
    }
}
