using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    private Slider slider;
    private Image fill;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInParent<Slider>();
        fill = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < .5 && slider.value > .2)
        {
            fill.color = Color.yellow;
        }
        else if (slider.value < .2)
        {
            fill.color = Color.red;
        }
        else
        {
            fill.color = new Color(.1f, .8f, .1f);
        }
    }
}
