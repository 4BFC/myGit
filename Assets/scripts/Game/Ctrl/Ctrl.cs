using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{
    float h;
    float v;
    
    int p = 10;    
    
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Vector3 cur = new Vector3(h,v,0) * p;
        rigid.velocity = cur;
        
        
    }
}
