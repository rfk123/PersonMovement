using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{

    public AudioSource MyAudioSource;
  
    // Update is called once per frame
    void Update()
    {
        //Just want to test if my audio is playing since I can't actually hear it on my computer
        if (MyAudioSource.isPlaying)
        {
            Debug.Log("Audio is playing");
        }
        else
        {
            Debug.Log("Audio is not playing");
        }
    }
}
