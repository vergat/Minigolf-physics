﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceController : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject mace;
    private Vector3 position;
    private bool check=false;

    void Start()
    {
        position = mace.transform.localPosition;
    }

    void Update () {
        if (Input.GetMouseButton(0)&&ball.GetComponent<Rigidbody>().velocity==Vector3.zero)
        {

             if (!check)
             {
                mace.transform.localPosition = position;
                mace.transform.localRotation = Quaternion.Euler(Vector3.zero);
                mace.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                mace.gameObject.SetActive(true);
                check = true;
             }
            mace.gameObject.GetComponent<Rigidbody>().velocity=transform.right * 5.0f * Input.GetAxis("Mouse Y");      
        }
        else
        {
            mace.gameObject.SetActive(false);
            check = false;
        }
	}

}
