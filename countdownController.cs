using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownController : MonoBehaviour
{
    [SerializeField] float setTime = 60.0f;
    [SerializeField] Text countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown.text = setTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
        {
            setTime -= Time.deltaTime;
        }
        else if (setTime <= 0)
        {
            Time.timeScale = 0.0f;
            SceneManager.LoadScene("FailScene");
        }
        countdown.text = Mathf.Round(setTime).ToString();
        
    }
}
