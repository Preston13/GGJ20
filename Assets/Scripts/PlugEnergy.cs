using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlugEnergy : MonoBehaviour
{
    public Slider energy;
    public Player player;
    public Charge charge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isCharging)
        {
            energy.value -= .0005f;
        }
    }
}
