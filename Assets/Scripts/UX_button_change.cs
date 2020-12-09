using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UX_button_change : MonoBehaviour
{

    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;    

    public bool toogle = false;

    

    // Start is called before the first frame update

    private void Start()
    {
       

      


    }
    public void ChangeImage()
    {


        if (but.image.sprite == OnSprite)

        {
            but.image.sprite = OffSprite;
            toogle = false;          

        }

        else

        {
            but.image.sprite = OnSprite;
            toogle = true;

        }
       
    }
}
