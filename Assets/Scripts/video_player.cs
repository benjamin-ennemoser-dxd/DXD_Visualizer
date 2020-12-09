using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video_player : MonoBehaviour
{

    VideoPlayer videoPlayer;
    public string[] videos;
    

    string url;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();


        {
            url = System.IO.Path.Combine(Application.streamingAssetsPath, videos[0]);
            Debug.Log("video+loaded");
        }

        videoPlayer.url = videos[0];
        //videoPlayer.SetTargetAudioSource(0, audioSource);

    }

    // Update is called once per frame
    void Update()
    {
    //if (string.IsNullOrEmpty(url))
    
}

    public void Video_Click()

    {
        count++;
        if (count > (videos.Length - 1))

        {

            count = 0;
        }
        url = (videos[count]);
        Debug.Log("video+loaded");
        //videoPlayer.url = url;


    }
}
