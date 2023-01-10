using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
