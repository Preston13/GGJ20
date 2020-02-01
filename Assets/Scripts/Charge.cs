using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Charge : MonoBehaviour
{
    public Player player;
    public Slider chargeSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.isCharging)
        {
            chargeSlider.value -= .001f;
        }
        else
        {
            chargeSlider.value += .005f;
        }
    }
}
