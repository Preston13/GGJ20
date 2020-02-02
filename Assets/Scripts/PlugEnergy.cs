using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlugEnergy : MonoBehaviour
{
    private Slider energy;
    public Player player;
    public Charge charge;
    private Light chargeLight;
    private bool isNearPlayer;

    // Start is called before the first frame update
    void Start()
    {
        energy = GetComponentInChildren<Slider>();
        chargeLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isCharging && isNearPlayer)
        {
            chargeLight.enabled = true;
            energy.value -= .0005f;

        }
        else
        {
            this.chargeLight.enabled = false;
        }

        if(energy.value == 0)
        {
            player.StopCharging();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isNearPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !player.isCharging)
        {
            isNearPlayer = false;
        }
    }
}
