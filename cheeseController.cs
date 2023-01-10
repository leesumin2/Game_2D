using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }


            // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);

        if (transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }

    }
}


