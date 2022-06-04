using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer video;


    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
    }
  
    public void PlayVideo()
    {
        video.Play();
    }

    public void PauseVideo()
    {
        video.Pause();
    }

    public void StopVideo()
    {
        video.Stop();
    }
}
