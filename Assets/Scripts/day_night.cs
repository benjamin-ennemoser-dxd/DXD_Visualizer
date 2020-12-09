using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day_night : MonoBehaviour
{

    public Slider Slider_day_night;
    public Light sun;

    public GameObject glass_lerp;

    public Material mat01;
    public Material mat02;

    public Material mat_night;

    float alpha_value;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = glass_lerp.GetComponent<Renderer>();
        sun.intensity = Slider_day_night.value;
        rend.material = mat01;
    }

    // Update is called once per frame
    void Update()
    {
        sun.intensity = Slider_day_night.value;
        sun.transform.eulerAngles = new Vector3(120 * Slider_day_night.value, 90 * Slider_day_night.value, 0);
        rend.material.Lerp(mat01, mat02, Slider_day_night.value);

        alpha_value = Slider_day_night.value;

        mat_night.color = new Color(mat_night.color.r, mat_night.color.g, mat_night.color.b,1- alpha_value);
        // RenderSettings.skybox.Lerp(SkyboxNight, SkyboxDay, Slider_day_night.value);
    }
}
