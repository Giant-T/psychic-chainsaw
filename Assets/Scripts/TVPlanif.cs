using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

[RequireComponent(typeof(VideoPlayer))]
public class TVPlanif : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    [SerializeField] private VirtualButtonBehaviour virtualButtonBehaviour;

    // Start is called before the first frame update
    void Start()
    {
      videoPlayer = GetComponent<VideoPlayer>();
      virtualButtonBehaviour.RegisterOnButtonPressed(ToggleVideo);  
    }

    public void ToggleVideo(VirtualButtonBehaviour behaviour) {
        if (videoPlayer.isPlaying) {
            videoPlayer.Pause();
        } else {
            videoPlayer.Play();
        }
    }
}
