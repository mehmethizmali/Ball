using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Sahneyi tekar yükleme kütüphanesi

public class PlayerFinish : MonoBehaviour
{
    //içine Değdiğinde
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            //Sahnenin İndexini alıyoruz ve bir sonraki sahneye geçme işlemini yapıyoruz
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex + 1);
        }
    }
}
