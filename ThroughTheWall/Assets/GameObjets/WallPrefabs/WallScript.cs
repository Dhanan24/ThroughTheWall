﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public int wallNo;
    public int wallDifficulty;
    public bool breakablePart;
    public float wallSpeed;
    private Rigidbody rb;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        wallSpeed = 0.1f;
        rb = this.GetComponent<Rigidbody>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // FixedUpdate is independent on frame rate and relies on time intervals
    void FixedUpdate()
    {// this should cause the wall to move only on the x axis
        transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - wallSpeed);

        // removes game object from scene once it goes out of bounds on x axis
        if (transform.position.z < -40.0f) {
            Destroy(this.gameObject);
        }
    }
}
