using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

    [SerializeField]
    private Vector3 offset=Vector3.zero;

    void Start()
    {
        
    }
    void Update()
    {

       // Camera.main.transform.position = gameObject.transform.position + offset;
    }
}
