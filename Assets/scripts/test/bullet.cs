using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject skillbullet;
    public float maxshotdelay;
    public float curshotdelay;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{

        //    Instantiate(Bullet, FirePos.transform.position, 0);
        //    transform.Translate(Vector3.forward * 1f);
        //}
        Fire();
        reload();
    }
    void Fire()
    {
        if (!Input.GetButton("Fire1")) //버튼을 눌러야한다
            return;

        if (curshotdelay < maxshotdelay) //현재 딜레이가 맥스를 넘어야한다.
            return;

        GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation);
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        curshotdelay = 0;
    }

    void reload()
    {
        curshotdelay += Time.deltaTime;
    }
}
