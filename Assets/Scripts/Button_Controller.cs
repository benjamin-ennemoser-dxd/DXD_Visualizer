using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Button_Controller : MonoBehaviour
{
    public GameObject[] Scheme;
    public GameObject shell_building;
   
    //public VideoClip[] videos;
    public Slider alpha_slider;

    public Material mat01;
    public Material mat02;
    public Material mat03;
    public Material mat04;
    public Material mat05;

    public Material shell_start;

   

    

    public Dropdown screen_menu;

    float initial_glas;


    private VideoPlayer _videoPlayer;
    float alpha_value;

   public int count=0;

    public int count02 = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        initial_glas = mat05.color.a;

        Scheme[0].SetActive(true);
        Scheme[1].SetActive(false);
        Scheme[2].SetActive(false);
        Scheme[3].SetActive(false);
        Scheme[4].SetActive(false);
        Scheme[5].SetActive(false);
        Scheme[6].SetActive(false);

       
       

       

       


        // _videoPlayer = Video_Canvas.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
       alpha_value = alpha_slider.value;

        mat01.color = new Color(mat01.color.r, mat01.color.g, mat01.color.b, alpha_value);
        mat02.color = new Color(mat02.color.r, mat02.color.g, mat02.color.b, alpha_value);
        mat03.color = new Color(mat03.color.r, mat03.color.g, mat03.color.b, alpha_value);
        mat04.color = new Color(mat04.color.r, mat04.color.g, mat04.color.b, alpha_value);
        mat05.color = new Color(mat05.color.r, mat05.color.g, mat05.color.b, (initial_glas * alpha_value));

        if(alpha_slider.value < 0.95f)
        {
            shell_building.GetComponent<Renderer>().material = mat04;
        }

        else
        {
            shell_building.GetComponent<Renderer>().material = shell_start;
        }

        
    }

   public void Scheme_Button()
    {
        count = screen_menu.value;

       // if (count > (Scheme.Length - 1))
       // {

          //  count = 0;
       // }


        if (count == 0)
        {
            Scheme[0].SetActive(true);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

            

        }

        if (count == 1)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(true);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

            
        }

        if (count == 2)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(true);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

           

        }

        if (count == 3)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(true);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

           
        }


        if (count == 4)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(true);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

            

        }


        if (count == 5)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(true);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

            
        }


        if (count == 6)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(true);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

            
        }

        if (count == 7)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(true);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(false);

           
        }

        if (count == 8)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(true);
            Scheme[9].SetActive(false);

            
        }
        if (count == 9)
        {
            Scheme[0].SetActive(false);
            Scheme[1].SetActive(false);
            Scheme[2].SetActive(false);
            Scheme[3].SetActive(false);
            Scheme[4].SetActive(false);
            Scheme[5].SetActive(false);
            Scheme[6].SetActive(false);
            Scheme[7].SetActive(false);
            Scheme[8].SetActive(false);
            Scheme[9].SetActive(true);

            
        }



        //_videoPlayer.clip = videos[count];



    }

    

    
}
