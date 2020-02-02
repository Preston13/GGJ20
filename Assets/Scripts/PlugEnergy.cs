using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlugEnergy : MonoBehaviour
{
    public Slider energy;
    public Player player;
    public Charge charge;
    public Light chargeLight;

    // Start is called before the first frame update
    void Start()
    {
        chargeLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isCharging)
        {
            chargeLight.enabled = true;
            energy.value -= .0005f;
        }
        else
        {
            chargeLight.enabled = false;
        }
    }
}
