using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRunController : MonoBehaviour
{
    GameObject player;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + new Vector3(0.05f, 0,0);
        transform.Translate(0.05f, 0, 0);
        if (transform.position.x > 15.0f)
        {

            Destroy(gameObject);
        }

    }
}
