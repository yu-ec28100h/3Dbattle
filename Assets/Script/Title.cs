using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool firstPush = false;

    public void PressStart()
    {
        Debug.Log("Press Start");

        if(!firstPush)
        {
            Debug.Log("Go Stage");

            SceneManager.LoadScene("CharaSelectScene");

            firstPush = true;
        }
    }
}
