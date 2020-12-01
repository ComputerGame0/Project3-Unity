using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]

public class WindVelocity : MonoBehaviour
{
    
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] string triggeringTag;
    [SerializeField] float v;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<KeyBoard2D>())
        {
            Debug.Log("player entered");
        }
           
           
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == triggeringTag)
        {
            Debug.Log("Object is in trigger");
            //rb.AddForce(-Vector2.right * Time.deltaTime);
            rb.velocity = rb.velocity * v;
        }

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<KeyBoard2D>())
        {
            other.transform.parent = null;
        }
    }

  

}
