using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void ReturnToMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
