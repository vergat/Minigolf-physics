using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

    private Transform arrow;

    void Start()
    {
        arrow=transform.Find("Arrow");

    }
    void Update()
    {
            if (Input.GetMouseButton(1) && GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                arrow.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y - 90.0f, 0);
            }  
    }
}
