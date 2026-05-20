using UnityEngine;
using UnityEngine.Video;

public class CacherVideo : MonoBehaviour
{
    VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoFini;
    }

    void OnVideoFini(VideoPlayer vp)
    {
        this.gameObject.SetActive(false); 
    }
}
