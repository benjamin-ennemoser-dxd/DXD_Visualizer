using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class alembic_animation_toggle : MonoBehaviour
{

    // public PlayableDirector director;
    public GameObject Animation_object_01;
    Animator m_Animator;

    public Text animation_text;

    bool play_alembic = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = Animation_object_01.GetComponent<Animator>();
        m_Animator.speed = 1;
        animation_text.text = "ON";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play_animation()
    {

        if (play_alembic)
        {
            // director.Play();
            // director.Resume();

            m_Animator.speed = 1;
            animation_text.text = "ON";
        }
        else
        {
            //director.Pause();

            m_Animator.speed = 0;
            animation_text.text = "OFF";
        }

        play_alembic = !play_alembic;
    }
}
