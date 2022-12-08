using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorChangeScene : MonoBehaviour
{
    public float TheDistance;
    //public GameObject TheDoor;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public AudioSource CreakSound;
    public GameObject ExtraCross;
    public GameObject fadeOut;

    void Update()
    {
        TheDistance = RayCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Open Door";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                CreakSound.Play();
                fadeOut.SetActive(true);
                StartCoroutine(FadeToExit());
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);

    }

    IEnumerator FadeToExit()
    {
        yield return new WaitForSeconds(3.1f);
        SceneManager.LoadScene(3);
    }
}
