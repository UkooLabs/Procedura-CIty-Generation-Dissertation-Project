﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
	[Range(1,10)]
	public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody>().velocity = Vector2.up * jumpForce;
			
		}
    }
}
