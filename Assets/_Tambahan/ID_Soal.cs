using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ID_Soal : MonoBehaviour
{
    public int ID;
  

    public void btn_()
    {
       
        GetComponent<Animation>().Play("button");
    }

    public void btn_pindah(string kemana)
    {
    
        UnityEngine.SceneManagement.SceneManager.LoadScene(kemana);
        Debug.Log("Pindah scene");
    }

    public void btn_ulang()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        Debug.Log("Pindah scene");
    }

}
