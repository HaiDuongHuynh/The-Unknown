using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorJump : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreakSound;
    public GameObject ExtraCross;
    public AudioSource JumpMusic;
    public GameObject TheZombie;
    public AudioSource AmbMusic;
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
                TheDoor.GetComponent<Animation>().Play("FirstDoorAni");
                CreakSound.Play();
                TheZombie.SetActive(true);
                StartCoroutine(PlayJumpMusic());
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);

    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(1.0f);
        AmbMusic.Stop();
        JumpMusic.Play();
    }
}
