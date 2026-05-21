using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class CacherVideo : MonoBehaviour
{
  VideoPlayer videoPlayer;
    RawImage rawImage;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        rawImage = GetComponent<RawImage>();
        rawImage.raycastTarget = false;

        
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "sequence.mp4");
        
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFini;
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        vp.Play();
    }

    void OnVideoFini(VideoPlayer vp)
    {
        this.gameObject.SetActive(false);
    }
}