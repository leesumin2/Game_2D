using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatSleepGenerator : MonoBehaviour
{
    public GameObject CatSleepPrefab;
    float span = 4f;
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
            GameObject go = Instantiate(CatSleepPrefab) as GameObject;
            int randomX = Random.Range(-10, 10);
            int randomY = Random.Range(-7, 7);
            go.transform.position = new Vector3(randomX, randomY, 0);

        }

    }
    }

