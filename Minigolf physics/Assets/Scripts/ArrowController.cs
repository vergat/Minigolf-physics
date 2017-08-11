using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
    private Transform aimLine;
    private bool check = false;
    public Vector3 ballPosition;
    void Start()
    {
        Cursor.visible = false;
        aimLine=gameObject.transform.Find("AimLine");
        ballPosition = ball.transform.position;
        aimLine.gameObject.SetActive(false);
    }

    void Update()
    {
        if(ball.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            if (!check)
            {
                aimLine.gameObject.SetActive(true);
                transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y - 90.0f, 0);
                ballPosition = ball.transform.position;
                check = true;
            }
            if (Input.GetMouseButton(1))
            {
                transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y - 90.0f, 0);
            }
        }
        else
        {
            if (check)
            {
                aimLine.gameObject.SetActive(false);
                check = false;
            }            
        }

    }
}
