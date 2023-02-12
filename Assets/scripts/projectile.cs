using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    private SpringJoint2D spring;
    private Rigidbody2D rb;
    private bool ispressed;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spring = GetComponent<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ispressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);        
        }
    }
    private void OnMouseDown()
    {     rb.isKinematic = true;                                                                                                                                                   
        ispressed = true;
    }
    private void OnMouseUp()
    {
        rb.isKinematic = false;
        ispressed = false;
        StartCoroutine(release());
    }
    IEnumerator release()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<SpringJoint2D>().enabled = false;
    }
}
