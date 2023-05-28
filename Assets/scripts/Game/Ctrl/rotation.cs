using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    //https://www.youtube.com/watch?v=egKsKhn9Kf0
    Rigidbody rigid;
    //Vector3 curr;
    Vector3 curr;

  
    float rw_f = 10;
    float rs_f = -10;
    float ra_f = 10;
    float rd_f = -10;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        curr = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(rw_f * Time.deltaTime, 0.0f, 0.0f);
                
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(rs_f * Time.deltaTime, 0.0f, 0.0f);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, 0.0f, ra_f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 0.0f, rd_f * Time.deltaTime);

        }
        
        //transform.position = curr;
        if (Input.GetKeyDown(KeyCode.Space)){
            transform.position = new Vector3(0,0,0);
            transform.Rotate(0.0f, 0.0f, 0.0f); //Quaternion
        }
    }
}
