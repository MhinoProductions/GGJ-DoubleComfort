﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    Transform playerTransform;

    void Awake()
    {
        playerTransform = player.transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(playerTransform);
    }
    */
}
