using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isNearPlug = false;
    private Vector3 plugPos;

    public bool isCharging = false;
    public bool canMoveRight = true;
    public Charge charging;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearPlug)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                isCharging = true;
                plugPos = this.transform.position;
            }
        }

        if(isCharging)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                isCharging = false;
            }

            if(Vector3.Distance(this.transform.position, plugPos) >= 5f)
            {
                Vector3 dist = this.transform.position - plugPos;
                dist *= 5 / Vector3.Distance(this.transform.position, plugPos);
                this.transform.position = plugPos + dist;
            }
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plug")
        {
            isNearPlug = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plug")
        {
            isNearPlug = false;
        }
    }
}
