using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//SerializeField가 private을 inspector에 보이게 한다.
public class btn_Mgr : MonoBehaviour
{
    public Button selectBtn, set_btn;
    public Button[] skin_btn;
    public bool[] check;
    // Start is called before the first frame update
    void Start()
    {
        selectBtn.onClick.AddListener(sceneChange);
        skin_btn[0].onClick.AddListener(skin_Btn0);
        skin_btn[1].onClick.AddListener(skin_Btn1);
        skin_btn[2].onClick.AddListener(skin_Btn2);

        //skin_Img = new GameObject[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sceneChange()
    {
        SceneManager.LoadScene("Game");
    }
    
    void skin_Btn0()//나중에 loadScene을 할 때 조건문으로 사용 할 것
    {
        if (skin_btn[0])
        {
            check[0] = true;
            check[1] = false;
            check[2] = false;
            Debug.Log(check[0]);
        }
    }
    void skin_Btn1()
    {
        if (skin_btn[1])
        {
            check[0] = false;
            check[1] = true; 
            check[2] = false;
            Debug.Log(check[1]);
        }
    }
    void skin_Btn2()
    {
        if (skin_btn[2])
        {
            check[0] = false;
            check[1] = false; 
            check[2] = true;
            Debug.Log(check[2]);
        }
    }
}
