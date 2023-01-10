using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatSleepController : MonoBehaviour
{
    GameObject player;
    float rotSpeed = 0;
    float scaleSpeed = 1.0f;

    void Start()
    {

        this.player = GameObject.Find("player");
    }


    void Update()
    {
        this.rotSpeed = 10;

        Destroy(gameObject, 4.0f);

        //충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;


        if (d < r1 + r2)
        {
            transform.localScale = new Vector3
                (transform.localScale.x - 1f * this.scaleSpeed * Time.deltaTime,
                transform.localScale.y - 1f * this.scaleSpeed * Time.deltaTime, 0);
            transform.Rotate(0, 0, this.rotSpeed);
        }

    }
}
