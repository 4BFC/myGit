using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    public int curHealth;

    Rigidbody rigid;
    BoxCollider boxCollider;
    Material mat;

    private void Awake() //사용할 컴포넌트 적용
    {
        rigid = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        mat = GetComponent<MeshRenderer>().material;//Material은 MeshRenderer 컴포넌트로 접근
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet") //태그가 "bullet"인 대상자가 isTrigger로 되어 있는지 확인해야함
        {
            Debug.Log("attack");
            //Destroy(gameObject, 3);
            StartCoroutine(onDmage());
        }
        else
        {
            Debug.Log("Error : Check this Log!!");
            StartCoroutine(onDmage());
        }
    }

    //코루틴을 사용
    IEnumerator onDmage()
    {
        mat.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        mat.color = Color.white;
    }
}
