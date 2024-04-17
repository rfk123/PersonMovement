using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDist : MonoBehaviour
{

    public Transform checkpoint; // Drag your checkpoint object here in the inspector
    private LineRenderer lineRenderer;

    void Start()
    {
        // Get the LineRenderer attached to the enemy
        lineRenderer = GetComponent<LineRenderer>();

        // Setup the LineRenderer
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = 2;

        // Optional: Add some color
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = Color.red;
    }

    void Update()
    {
        if (checkpoint != null)
        {
            // Update the positions of the line: start at enemy, end at checkpoint
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, checkpoint.position);
        }
    }
}
