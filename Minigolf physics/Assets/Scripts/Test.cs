using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject mace;
    private Vector3 position;
    private bool check=false;

    void Start()
    {
        position = mace.transform.localPosition;
        Debug.Log("aaa");
    }

    void Update () {
        if (Input.GetMouseButton(0)&&ball.GetComponent<Rigidbody>().velocity==Vector3.zero)
        {

             if (!check)
             {
                mace.transform.localPosition = position;
                mace.transform.localRotation = Quaternion.Euler(Vector3.zero);
                //meh.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                mace.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                mace.gameObject.SetActive(true);
                check = true;
             }
            
            //mace.transform.localRotation = position.localRotation;
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(800, 0, 0));
            mace.gameObject.GetComponent<Rigidbody>().velocity=transform.right * 5.0f * Input.GetAxis("Mouse Y");
            //transform.position += transform.right * Time.deltaTime * 10.0f*Input.GetAxis("Mouse Y");
            
        }
        else
        {
            mace.gameObject.SetActive(false);
            check = false;
        }
	}

}
