using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    private int score;

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        
        Vector3 move = transform.position;
        move.x = Mathf.Clamp(move.x, -7.4f, 7.4f);
        transform.position = move;
        
        //controller.Move(move * speed * Time.deltaTime);
    }
}
