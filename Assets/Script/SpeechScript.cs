using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechScript : MonoBehaviour
{
    public AudioSource ad;
    private GameObject textScreen;
    private MeshRenderer trigger;

    void Start()
    {
        if(this.gameObject.transform.parent.tag!="spacepanel"){
        textScreen = this.gameObject.transform.GetChild(0).gameObject;
        trigger = this.gameObject.transform.GetChild(1).GetComponent<MeshRenderer>();
        textScreen.SetActive(false);
        }
    }
   

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            trigger.enabled = false;
            textScreen.SetActive(true);
            ad.Play();
            Debug.Log(Other.gameObject.name);
           
        }
    }
    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            trigger.enabled = true;
            textScreen.SetActive(false);
            ad.Stop();
           

        }

    }
   /* public void playaudio()
    {
        ad.Play();
    }*/

}
