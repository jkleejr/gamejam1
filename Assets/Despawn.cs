using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Despawner"))
        {
            Destroy(gameObject);
        }
    }
}
