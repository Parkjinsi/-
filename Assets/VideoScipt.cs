using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoScipt : MonoBehaviour
{
    public GameObject target;
    public VideoPlayer video;
    // Start is called before the first frame update
    public void videoStart()
    {
        target.SetActive(true);
        video.Play();
        Destroy(target, 5);
    }
}
