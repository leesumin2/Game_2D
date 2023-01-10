using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRunGenerator : MonoBehaviour
{
    public GameObject CatRunPrefab;
    GameObject player;

    float span = 1.5f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(CatRunPrefab) as GameObject;
            int px = Random.Range(-9, 8);
            go.transform.position = new Vector3(-14, px, 0);

        }

    }
}
