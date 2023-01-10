using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoController : MonoBehaviour
{
    public GameObject myVideo;
    public VideoPlayer videoClip;

    public void OnPlayVideo() //영상재생
    {
        myVideo.SetActive(true);
        videoClip.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
