using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public CharacterController controller;
    public float speed = 12f;
    private int score;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        /*float x = Input.GetAxis("Horizontal");
        
        Vector3 move = transform.right * x;
        
        controller.Move(move * speed * Time.deltaTime);*/

        float horizontalMove = Input.GetAxis("Horizontal");

        float horizOffset = horizontalMove * speed * Time.deltaTime;

        float rawHorizPos = transform.position.x + horizOffset;
        float clampedHorizPos = Mathf.Clamp(rawHorizPos, screenBounds.x * -1, screenBounds.x);

        transform.position = new Vector3(clampedHorizPos, transform.position.y, transform.position.z);
    }
}
