using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isMoving;
    public Player player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            this.transform.rotation = new Quaternion(.707f, .707f, 0f, 0f);
            this.transform.position += new Vector3(1f, 0f) * Time.deltaTime * moveSpeed;
            isMoving = true;

        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            this.transform.rotation = new Quaternion(-.707f, .707f, 0f, 0f);
            this.transform.position += new Vector3(-1f, 0f) * Time.deltaTime * moveSpeed;
            isMoving = true;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            this.transform.rotation = new Quaternion(-1f, 0f, 0f, 0f);
            this.transform.position += new Vector3(0f, -1f) * Time.deltaTime * moveSpeed;
            isMoving = true;

        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            this.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            this.transform.position += new Vector3(0f, 1f) * Time.deltaTime * moveSpeed;
            isMoving = true;

        }
        else
        {
            isMoving = false;
        }
    }
}
