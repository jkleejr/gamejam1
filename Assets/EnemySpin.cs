using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpin : MonoBehaviour
{

    public float spinSpeed;
    private Rigidbody2D rb;
    void Start()

    {

        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = spinSpeed;

    }
}
