﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    //[Header ("Stats")]
    public float speed;
    public float stoppingDistance;
    public float nearDistance;

    private Transform player;
    // Use this for initialization
    public GameObject Object1;
    public GameObject UICamera;
    public GameObject ObjectCamera;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera").transform;
        //Object1.GetComponent<MoveObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       // transform.LookAt(player);
       
        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, player.position) <= stoppingDistance)
        {
            Debug.Log("ok");
            Object1.GetComponent<MoveObject>().enabled = false;
            ObjectCamera.SetActive(false);
            UICamera.SetActive(true);
        }
        else if (Vector3.Distance(transform.position, player.position) < stoppingDistance && Vector3.Distance(transform.position, player.position) > nearDistance)
        {
            transform.position = this.transform.position;
        }
      
    }

}
