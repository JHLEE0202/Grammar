using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public int inch;
    private float cm;
    // Start is called before the first frame update
    void Start()
    {
      cm = inch*2.54f;
      Debug.Log(inch + "인치는" + cm + "입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
