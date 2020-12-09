using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_controller_02 : MonoBehaviour
{

    public GameObject[] frame_geo;

  public bool frame = true;

    public GameObject[] grid_geo;

    public bool grid = false;

    

    // Start is called before the first frame update
    void Start()
    {

        

        foreach (GameObject grid_geo_01 in grid_geo)
        {
            grid_geo_01.SetActive(false);
        }

        foreach (GameObject frame_geo_01 in frame_geo)
        {
            frame_geo_01.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void frame_toogle()
    {

        frame = !frame;

        if (frame)
        {
           // Debug.Log("frame_isOn");
            foreach (GameObject frame_geo_01 in frame_geo)
            {
                frame_geo_01.SetActive(true);
            }

           

        }

        else
        {
           // Debug.Log("frame_isOFF");
            foreach (GameObject frame_geo_01 in frame_geo)
            {
                frame_geo_01.SetActive(false);
            }

            
        }

    }

    public void grid_toogle()
    {

        grid = !grid;

        if (grid)
        {
           // Debug.Log("grid_isOn");
            foreach (GameObject grid_geo_01 in grid_geo)
            {
                grid_geo_01.SetActive(true);

            }
            
        }

        else
        {
            //Debug.Log("grid_is OnFF");
            foreach (GameObject grid_geo_01 in grid_geo)
            {
                grid_geo_01.SetActive(false);

            }
            

        }

    }
}
