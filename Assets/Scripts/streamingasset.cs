using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class streamingasset : MonoBehaviour
{
    VideoPlayer videoPlayer;
    public string[] videos;
    string url;

    public Button video_button_01;
    public Button video_button_02;
    public Button video_button_03;



    // Start is called before the first frame update
    void Start()
    {

        video_button_01.interactable = false;
        video_button_02.interactable = true;
        video_button_03.interactable = true;

        videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();


        {
            url = System.IO.Path.Combine(Application.streamingAssetsPath, videos[0]);
           // Debug.Log("video+loaded");

            videoPlayer.url = url;
        }

        videoPlayer.Play();
       // text_UI.text = text_movie[0];

       // videoPlayer.url = videos[0];
       //videoPlayer.SetTargetAudioSource(0, audioSource);

    }

    // Update is called once per frame
    void Update()
    {
        //if (string.IsNullOrEmpty(url))
        videoPlayer.Play();

    }

    public void Video_Click01()

    {
        video_button_01.interactable = false;
        video_button_02.interactable = true;
        video_button_03.interactable = true;
        // url = (videos[count]);
        //Debug.Log("video+loaded");

        url = System.IO.Path.Combine(Application.streamingAssetsPath, videos[0]);
        videoPlayer.url = url;
        videoPlayer.Play();
        // text_UI.text = text_movie[count];

        //Debug.Log("current video" + videos[count]);
    }

    public void Video_Click02()

    {
        video_button_01.interactable = true;
        video_button_02.interactable = false;
        video_button_03.interactable = true;
        // url = (videos[count]);
        //Debug.Log("video+loaded");

        url = System.IO.Path.Combine(Application.streamingAssetsPath, videos[1]);
        videoPlayer.url = url;
        videoPlayer.Play();
        // text_UI.text = text_movie[count];

        //Debug.Log("current video" + videos[count]);
    }
    public void Video_Click03()

    {
        video_button_01.interactable = true;
        video_button_02.interactable = true;
        video_button_03.interactable = false;
        // url = (videos[count]);
        //Debug.Log("video+loaded");

        url = System.IO.Path.Combine(Application.streamingAssetsPath, videos[2]);
        videoPlayer.url = url;
        videoPlayer.Play();
        // text_UI.text = text_movie[count];

        //Debug.Log("current video" + videos[count]);
    }
}
