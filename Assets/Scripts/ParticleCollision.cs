using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem collisionEffect;  // Assign this in the Inspector

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")  // Make sure your wall has the "Wall" tag
        {
            PlayCollisionEffect(collision.contacts[0].point);  // Plays effect at collision point
        }
    }

    void PlayCollisionEffect(Vector3 position)
    {
        if (collisionEffect != null)
        {
            collisionEffect.transform.position = position;  // Move the particle system to the collision point
            collisionEffect.Play();  // Play the particle effect
        }
        else
        {
            Debug.LogError("No particle system assigned!");
        }
    }
}
