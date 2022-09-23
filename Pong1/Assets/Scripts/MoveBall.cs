using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float ForceBall = 600f;


    public Rigidbody2D rb;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * 600);
        rb.AddForce(Vector2.up * 200);
    }
}

