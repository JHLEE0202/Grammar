using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Player_Controler : MonoBehaviour
{
    public float speed = 10.0f; //속도의 값
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate (Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) ==true)
        {
            transform.Translate (Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate (Vector3.up * speed * Time.deltaTime);
        }
    }
}
