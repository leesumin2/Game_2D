using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    //�÷��̾� ������
    Rigidbody2D rigid2D;
    float jumpForce = 780.0f;
    float walkForce = 40.0f;
    float maxWalkSpeed = 3.0f;

    float span = 10.0f;
    float delta = 0;

    GameObject success;
    GameObject hpGauge;

    public GameObject bangPrefab;


    int count = 0;

    //Audio 
    public AudioSource audioSource;
    public AudioClip audioJump;
    public AudioClip audioSuccess;
    public AudioClip audioCheeseTouch;
    public AudioClip audioCheese2Touch;
    public AudioClip audioCrash;

    //Audio
    public void JumpSound()
    {
        audioSource.PlayOneShot(audioJump);
    }
    public void succeseSound()
    {
        audioSource.PlayOneShot(audioSuccess);
    }
    public void touchCheeseSound()
    {
        audioSource.PlayOneShot(audioCheeseTouch);
    }

    public void touchCheese2Sound()
    {
        audioSource.PlayOneShot(audioCheese2Touch);
    }

    public void crashSound()
    {
        audioSource.PlayOneShot(audioCrash);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.success = GameObject.Find("success");
        this.hpGauge = GameObject.Find("hpGauge");



    }

    void OnTriggerEnter2D(Collider2D col)
    {


        // ���ڴ� ����� �����հ� �浹��
        if (col.gameObject.tag == "sleep")
        {
            this.count++;
            this.success.GetComponent<Text>().text = "���� Ƚ�� : " + this.count.ToString("D") + "ȸ";
            Debug.Log(count);
            succeseSound();
            Destroy(col.gameObject, 0.3f);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().redBell();

            if (this.count == 5)
            {
                SceneManager.LoadScene("ClearScene");
            }
        }

        //�޸��� ����������հ� �浹��
        if (col.gameObject.tag == "run")
        {
            crashSound();
            Instantiate(bangPrefab, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().CatCrushHp();
        }

        // �������� ġ��� �浹��
        if (col.gameObject.tag == "cheese")
        {
            touchCheeseSound();
            Destroy(col.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().CheeseHp();

        }

        // ȸ���ϸ� �������� ġ��� �浹��
        if (col.gameObject.tag == "cheese2")
        {
            touchCheese2Sound();
            Destroy(col.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().CheeseSpinHp();

        }


    }


    // Update is called once per frame
    void Update()
    {

        //����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            JumpSound();
        }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //�ð��� ���� hpGauge ����
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(hpGauge) as GameObject;
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        }
        if (this.hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            SceneManager.LoadScene("FailScene");
        }

    }
}
