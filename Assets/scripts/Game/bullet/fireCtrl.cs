using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        if (count > 50)
        {
            count = 0;
            Fire();
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Fire();
        //}
    }

    void Fire()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
    }


}
