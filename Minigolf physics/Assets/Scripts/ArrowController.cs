using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
    private Transform aimLine;
    private bool prova = false;

    void Start()
    {
        aimLine=gameObject.transform.Find("AimLine");
        aimLine.gameObject.SetActive(false);
    }

    void Update()
    {
        if(ball.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            if (!prova)
            {
                aimLine.gameObject.SetActive(true);
                transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y - 90.0f, 0);
                prova = true;
            }
            if (Input.GetMouseButton(1))
            {
                transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y - 90.0f, 0);
            }
        }
        else
        {
            if (prova)
            {
                aimLine.gameObject.SetActive(false);
                prova = false;
            }            
        }

    }
}
