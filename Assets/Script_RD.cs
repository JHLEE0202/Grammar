using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_RD : MonoBehaviour
{
    public float speed = 10.0f; //속도의 값

    private Rigidbody playerRd;
    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //transform.Translate (Vector3.left * speed * Time.deltaTime);
            playerRd.AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) ==true)
        {
            playerRd.AddForce( speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
             playerRd.AddForce(0f, speed, 0f);
        }
    }

    //private void OnColllisionEnter(Collision Collision)
    //{
        //if (Collision.Collider.GameObject.ComponentTag("Cube"))

        //Debug.Log("this is cube");
    //}
}
