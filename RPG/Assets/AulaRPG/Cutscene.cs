using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;


public class Cutscene : MonoBehaviour
{
    public GameObject bau, camera;
    public AudioSource audio;

    private void Start()
    {
      audio = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {

        bau = other.gameObject;
        bau.GetComponent<PlayableDirector>().enabled = true;
        camera.SetActive(true);
        audio.Play();
    }


}
