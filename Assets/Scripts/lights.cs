using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lights : MonoBehaviour
{

    public Light[] lights_list;
    public float[] brightness;

    int count = 0;
    public RenderTexture render_tex;
    Texture2D tex_to_light;
    public Slider light_intensity;
    public Slider day_night;
    Color light_color;

    public Dropdown screens;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




      tex_to_light = toTexture2D(render_tex);

        light_color = AverageColorFromTexture(tex_to_light);

        foreach (Light lights_array in lights_list)
        {
            lights_array.intensity= light_intensity.value *(1- day_night.value)*brightness[screens.value];
           // Debug.Log(lights_array.intensity);
            lights_array.color = light_color;
        }

        //lights_list.intensity = light_intensity.value;
        Resources.UnloadUnusedAssets();
    }

    Texture2D toTexture2D(RenderTexture rTex)
    {
        Texture2D tex = new Texture2D(512, 512, TextureFormat.RGB24, false);
        RenderTexture.active = rTex;
        tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
        tex.Apply();
        return tex;
    }

    Color32 AverageColorFromTexture(Texture2D tex)
    {

        Color32[] texColors = tex.GetPixels32();

        int total = texColors.Length;

        float r = 0;
        float g = 0;
        float b = 0;

        for (int i = 0; i < total; i++)
        {

            r += texColors[i].r;

            g += texColors[i].g;

            b += texColors[i].b;

        }

        return new Color32((byte)(r / total), (byte)(g / total), (byte)(b / total), 0);

    }

    public void Light_Click()
    {/*
        count++;

        if (count > (lights_list.Length - 1))

        {

            count = 0;
        }

        for(int i=0; i< lights_list.Length; i++)
        {
            if(i==count)
            {
                lights_list[i].SetActive(true);
            }

            else
            {
                lights_list[i].SetActive(false);
            }

        
        }*/

    }
}
