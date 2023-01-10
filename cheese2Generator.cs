using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese2Generator : MonoBehaviour
{
    public GameObject cheesePrefab;
    float span = 3.4f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(cheesePrefab) as GameObject;
            int px = Random.Range(-9, 9);
            go.transform.position = new Vector3(px, 8, 0);

        }
    }
}
