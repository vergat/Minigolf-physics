using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecollider : MonoBehaviour {
    [SerializeField]
    private GameObject meh;


    private void OnTriggerEnter(Collider other)
    {
       /* if (other.gameObject != meh)
        {
            meh.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
            meh.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            //meh.gameObject.SetActive(false);
            Debug.Log("beh");
        }*/
    }
}
