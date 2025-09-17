using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int maxCount = 0;
    // Start is called before the first frame update
    void Start()
    {
      string str1 = "happy";
      string str2 = "birth day";
      string message;

      message = str1 + str2;
      Debug.Log (message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
