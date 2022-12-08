using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject loadText;
    public AudioSource buttonClick;
    public AudioSource Ambient;
    public GameObject NewGame;
    public GameObject LoadGame;
    public GameObject Setting;
    public GameObject Quit;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject returnButton;

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    public void LoadGameButton()
    {
        NewGame.SetActive(false);
        LoadGame.SetActive(false);
        //Setting.SetActive(false);
        Quit.SetActive(false);
        Scene1.SetActive(true);
        Scene2.SetActive(true);
        Scene3.SetActive(true);
        returnButton.SetActive(true);
    }

    public void returnButtons()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
        returnButton.SetActive(false);
        NewGame.SetActive(true);
        LoadGame.SetActive(true);
        //Setting.SetActive(true);
        Quit.SetActive(true);
    }

    public void scene1Button()
    {
        StartCoroutine(Scene1Start());
    }

    public void scene2Button()
    {
        StartCoroutine(Scene2Start());
    }

    public void scene3Button()
    {
        StartCoroutine(Scene3Start());
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        loadText.SetActive(true);
        Ambient.Stop();
        GlobalHealth.currentHealth = 20;
        SceneManager.LoadScene(2);
    }

    IEnumerator Scene1Start()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        loadText.SetActive(true);
        Ambient.Stop();
        GlobalHealth.currentHealth = 20;
        SceneManager.LoadScene(2);
    }

    IEnumerator Scene2Start()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        loadText.SetActive(true);
        Ambient.Stop();
        GlobalHealth.currentHealth = 20;
        SceneManager.LoadScene(3);
    }

    IEnumerator Scene3Start()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        loadText.SetActive(true);
        Ambient.Stop();
        GlobalHealth.currentHealth = 20;
        SceneManager.LoadScene(4);
    }
}
