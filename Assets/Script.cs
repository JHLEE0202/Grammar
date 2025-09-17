using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int hp = 180;
       if (hp <= 50)
       {
        Debug.Log("도망");
       }
      
       else if (hp >= 200)
       {
        Debug.Log("공격");
       }
        else
       {
        Debug.Log("방어");
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
