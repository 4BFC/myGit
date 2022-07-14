using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeBullet : MonoBehaviour
{
    private int Max = 300;
    private int count = 1;
    private void Update()
    {
        count += 1;
        count_Destroy(count, Max);
    }

    private void count_Destroy(int count, int Max)
    {
        if(count > Max)
        {
            count = 0;
            Destroy(this.gameObject);
        }
        //Debug.Log(count);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bullet")
        {
            Destroy(collision.gameObject);
        }
    }
}
