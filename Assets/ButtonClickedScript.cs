using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickedScript : MonoBehaviour
{


    public void ActionButtonPressed(){
        Debug.Log("YAY!!!!!!!! Button got pressed!!!");
        SceneManager.LoadScene("SampleScene");
    }
}
