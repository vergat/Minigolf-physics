using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private Canvas canvas;
    private bool control=false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            canvas.gameObject.SetActive(true);
            control = true;
        }
    }

    void Update()
    {
        if (control)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/MainScene");
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            SceneManager.LoadScene("Scenes/Menu");
        }
    }
}
