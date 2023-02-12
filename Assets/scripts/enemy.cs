using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject brust;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<bird>())
        {
          //  Instantiate(brust, transform.position, Quaternion.identity);
            Destroy(gameObject);
         //  Destroy(this.gameObject);
        }
        else if(collision.contacts[0].normal.y<0.5)
        {
           // Instantiate(brust, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
