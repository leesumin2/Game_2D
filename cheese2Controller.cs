using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese2Controller : MonoBehaviour
{
    GameObject player;
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.rotSpeed = 10;

        transform.Translate(0, -0.05f, 0, Space.World);
        transform.Rotate(0, 0, this.rotSpeed);

        if (transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }

    }
}
