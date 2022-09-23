using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall1 : MonoBehaviour
{
    private Vector3 direction;
    public float MoveSpeed;

     void Start()
    {
        direction = new Vector3(Random.Range(-1f, 0.5f), Random.Range(-1f, 0.5f));
        direction = direction.normalized;
    }
    void Update()
    {
        transform.Translate(direction * MoveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (MoveSpeed >= 30)
            {
                MoveSpeed += 1;
            }
       
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);

        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            if (MoveSpeed >= 30)
            {
                MoveSpeed += 1;
            }
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BorderLeft"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<Score>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("BorderRight"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<Score>().AddP1Score();
        }
    }
    private void ResetBall()
    {
        MoveSpeed = 10f;
        transform.position = new Vector3(0, 0, 0);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction = direction.normalized;
    }
}
