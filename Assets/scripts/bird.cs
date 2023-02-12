using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public Vector3 initialposotion;
    public int bird_speed = 60;
    public string scene_name;
    private bool bird_enable_time = true;
    private float bird_wait_time;


    void awake()
    {
        initialposotion = transform.position;
    }
    public void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    public void OnMouseUp()
    {
        Vector2 springforce = initialposotion - transform.position;
        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<Rigidbody2D>().gravityScale = 1;
        GetComponent<Rigidbody2D>().AddForce(bird_speed * springforce);
        bird_enable_time = true;
        

    }
    public void OnMouseDrag()
    {
        Vector3 dragposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(dragposition.x, dragposition.y);

    }

    void Update()
    {
        if (bird_enable_time && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.5)
        {
            bird_wait_time += Time.deltaTime;

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="ground")
        {
            Destroy(gameObject);
        }
    }

    /* IEnumerator player_died()
     {


         yield return new WaitForSeconds(0.3f);
     }
     */


}

