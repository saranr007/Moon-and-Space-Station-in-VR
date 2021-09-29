using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voiceinss : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    
    void Start()
    {
        audioSource = this.gameObject.GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource.Play();
        }    
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            audioSource.Stop();
        }
        
    }
    
}
