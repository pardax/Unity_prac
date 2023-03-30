using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cSound : MonoBehaviour
{
    AudioSource ads;

    public AudioClip cartoon;
    public AudioClip wood;
    public AudioClip retreat;

    // Start is called before the first frame update
    void Start()
    {
        ads = GetComponent<AudioSource>();
        Debug.Log("Control : Q / W / E / A / S / D / Z / X");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) 
        {
            ads.clip = retreat;
            ads.Play();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            ads.clip = cartoon;
            ads.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ads.clip = wood;
            ads.Play();
        }
        if(Input.GetKeyDown (KeyCode.A))
        {
            ads.Stop();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            ads.Pause();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ads.PlayOneShot(cartoon);
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            ads.volume -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ads.volume += 0.1f;
        }
    }
}
