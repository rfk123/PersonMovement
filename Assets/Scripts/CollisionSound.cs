using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioClip collisionClip; // Assign this in the inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (!audioSource)
        {
            // Log an error if no AudioSource is found
            Debug.LogError("No AudioSource component found on this GameObject.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a wall
        if (collision.gameObject.tag == "Enemy")
        {
            // Play the audio clip
            audioSource.clip = collisionClip;
            audioSource.Play();
        }
    }
}
