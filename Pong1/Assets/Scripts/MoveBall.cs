using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * 600);
    }
}
