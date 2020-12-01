﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWings : MonoBehaviour
{
    [Tooltip("The points between which the platform moves")] [SerializeField] Transform startPoint = null, endPoint = null;
    [SerializeField] float speed = 1f;

    bool moveFromStartToEnd = true;

    void FixedUpdate()
    {
        float deltaX = speed * Time.fixedDeltaTime;
        if (moveFromStartToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, deltaX);
        }
        else
        {  // move from end to start
            transform.position = Vector3.MoveTowards(transform.position, startPoint.position, deltaX);
        }

        if (transform.position == startPoint.position)
        {
            moveFromStartToEnd = true;
        }
        else if (transform.position == endPoint.position)
        {
            moveFromStartToEnd = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<KeyBoard2D>())
        {
            other.transform.parent = this.transform;
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
