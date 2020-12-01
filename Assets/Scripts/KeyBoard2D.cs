using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Touchtry2D))]
public class KeyBoard2D : MonoBehaviour
{
    
    [Tooltip("The horizontal force that the player's feet use for walking, in newtons.")]
    [SerializeField] float walkForce = 5f;

    [Tooltip("The vertical force that the player's feet use for jumping, in newtons.")]
    [SerializeField] float jumpImpulse = 5f;

    [Range(0, 1f)]
    [SerializeField] float slowDownAtJump = 0.5f;
    

    private Rigidbody2D rb;
    private Touchtry2D td;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        td = GetComponent<Touchtry2D>();
    }

    private ForceMode2D walkForceMode = ForceMode2D.Force;
    private ForceMode2D jumpForceMode = ForceMode2D.Impulse;
    private bool playerWantsToJump = false;

    private void Update()
    {
        // Keyboard events are tested each frame, so we should check them here.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space");
            playerWantsToJump = true;
        }
    }

    /*
     * Note that updates related to the physics engine should be done in FixedUpdate and not in Update!
     */
    private void FixedUpdate()
    {


        
        if (td.IsTouching())
        {
            Debug.Log("Touching");
            float horizontal = Input.GetAxis("Horizontal");
            rb.AddForce(new Vector3(horizontal * walkForce, 0, 0), walkForceMode);
            if (playerWantsToJump)
            {            // Since it is active only once per frame, and FixedUpdate may not run in that frame!
                Debug.Log("playerWantsToJump");
                //rb.velocity = new Vector3(rb.velocity.x * slowDownAtJump, rb.velocity.y, rb.velocity.z);
                rb.AddForce(new Vector3(0, jumpImpulse, 0), jumpForceMode);
                playerWantsToJump = false;
            }
        }
        
       
        
    }
}
