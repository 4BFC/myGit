using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//SerializeField가 private을 inspector에 보이게 한다.
public class btn_Mgr : MonoBehaviour
{
    public Button selectBtn, set_btn;
    public GameObject[] skin_btn;

    // Start is called before the first frame update
    void Start()
    {
        selectBtn.onClick.AddListener(sceneChange);
        
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
    
    void skin_Btn()
    {

    }
}
