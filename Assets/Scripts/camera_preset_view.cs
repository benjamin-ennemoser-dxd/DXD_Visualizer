using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera_preset_view : MonoBehaviour
{
   // public GameObject cam;
    //public GameObject target;

    //public Transform cam_pos01;
   // public Transform target_pos01;

   // public Transform cam_pos02;
    //public Transform target_pos02;

    public int count = 0;
    
    public GameObject traget;

    public GameObject cam_01;
    public GameObject cam_02;
    public GameObject cam_03;
    public GameObject cam_04;
    public GameObject cam_05;
    public GameObject cam_06;
    public GameObject cam_07;
    public GameObject cam_08;
    public GameObject cam_09;

    public GameObject target_01;
    public GameObject target_02;
    public GameObject target_03;
    public GameObject target_04;
    public GameObject target_05;
    public GameObject target_06;
    public GameObject target_07;
    public GameObject target_08;
    public GameObject target_09;

    public Button camButton_01;
    public Button camButton_02;
    public Button camButton_03;
    public Button camButton_04;
    public Button camButton_05;
    public Button camButton_06;
    public Button camButton_07;
    public Button camButton_08;
    public Button camButton_09;
    


    // Start is called before the first frame update
    void Start()
    {
        //cam.transform.position = cam_pos01.position;
        // cam.transform.rotation = cam_pos01.rotation;

        // target.transform.position = target_pos01.transform.position;
        //target.transform.rotation = target_pos01.transform.rotation;

        camButton_01.interactable = false;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;

        traget.transform.position = target_01.transform.position;

        cam_01.SetActive(true);
        cam_01.GetComponent<CameraMovement>().enabled = true;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cam_01_click()
    {

        camButton_01.interactable = false;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;

        cam_01.SetActive(true);
        cam_01.GetComponent<CameraMovement>().enabled = true;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;


        traget.transform.position = target_01.transform.position;

    }


    public void cam_02_click()
    {
        camButton_01.interactable = true;
        camButton_02.interactable = false;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;

        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(true);
        cam_02.GetComponent<CameraMovement>().enabled = true;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_02.transform.position;

    }

    public void cam_03_click()
    {
        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = false;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;

        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(true);
        cam_03.GetComponent<CameraMovement>().enabled = true;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_03.transform.position;

    }

    public void cam_04_click()
    {
        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = false;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;

        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(true);
        cam_04.GetComponent<CameraMovement>().enabled = true;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_04.transform.position;

    }

    public void cam_05_click()

    {
        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = false;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;

        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(true);
        cam_05.GetComponent<CameraMovement>().enabled = true;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_05.transform.position;




    }


    public void cam_06_click()
    {

        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = false;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = true;


        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(true);
        cam_06.GetComponent<CameraMovement>().enabled = true;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_06.transform.position;

    }

    public void cam_07_click()
    {

        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = false;
        camButton_08.interactable = true;
        camButton_09.interactable = true;


        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(true);
        cam_07.GetComponent<CameraMovement>().enabled = true;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_07.transform.position;

    }

    public void cam_08_click()
    {

        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = false;
        camButton_09.interactable = true;


        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(true);
        cam_08.GetComponent<CameraMovement>().enabled = true;

        cam_09.SetActive(false);
        cam_09.GetComponent<CameraMovement>().enabled = false;

        traget.transform.position = target_08.transform.position;
    }

    public void cam_09_click()

    {

        camButton_01.interactable = true;
        camButton_02.interactable = true;
        camButton_03.interactable = true;
        camButton_04.interactable = true;
        camButton_05.interactable = true;
        camButton_06.interactable = true;
        camButton_07.interactable = true;
        camButton_08.interactable = true;
        camButton_09.interactable = false;


        cam_01.SetActive(false);
        cam_01.GetComponent<CameraMovement>().enabled = false;

        cam_02.SetActive(false);
        cam_02.GetComponent<CameraMovement>().enabled = false;

        cam_03.SetActive(false);
        cam_03.GetComponent<CameraMovement>().enabled = false;

        cam_04.SetActive(false);
        cam_04.GetComponent<CameraMovement>().enabled = false;

        cam_05.SetActive(false);
        cam_05.GetComponent<CameraMovement>().enabled = false;

        cam_06.SetActive(false);
        cam_06.GetComponent<CameraMovement>().enabled = false;

        cam_07.SetActive(false);
        cam_07.GetComponent<CameraMovement>().enabled = false;

        cam_08.SetActive(false);
        cam_08.GetComponent<CameraMovement>().enabled = false;

        cam_09.SetActive(true);
        cam_09.GetComponent<CameraMovement>().enabled = true;

        traget.transform.position = target_09.transform.position;

    }

    
}
