using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject bell;


    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.bell = GameObject.Find("bell");
    }

    public void CheeseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void CheeseSpinHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.5f;
    }

    public void CatCrushHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
    }

    public void time()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void redBell()
    {
        this.bell.GetComponent<Image>().fillAmount += 0.2f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

