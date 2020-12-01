using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Touchtry2D : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;

    [Header("This field is for display only")]
    [SerializeField] private int touchingColliders = 0;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("ground");
        }
        Debug.Log("Entering collision with " + collision.gameObject.name + " in layer " + collision.gameObject.layer + ". layerMask.value=" + layerMask.value);
        if ((layerMask.value & (1 << collision.gameObject.layer)) > 0)
            touchingColliders++;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
       // Debug.Log("Exiting collision with " + collision.gameObject.name + " in layer " + collision.gameObject.layer + ". layerMask.value=" + layerMask.value);
        if ((layerMask.value & (1 << collision.gameObject.layer)) > 0)
            touchingColliders--;
    }

    public bool IsTouching()
    {
        return touchingColliders > 0;
    }
}
