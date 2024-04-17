using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f;

    private float changeInterval = 2.0f;
    private float changeTimer;
    private Vector3 movementDirection;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        changeTimer += Time.deltaTime;

        if (changeTimer > changeInterval){
            ChangeDirection();
            changeTimer = 0;
        }

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector3 move = movementDirection * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }

    void ChangeDirection()
    {
        float randomX = Random.Range(-1.0f, 1.0f);
        float randomZ = Random.Range(-1.0f, 1.0f);

        movementDirection = new Vector3(randomX, 0.0f, randomZ).normalized;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            ChangeDirection();
        }
    }
}
