using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Sahneyi tekar yükleme kütüphanesi

public class LeaveReloader : MonoBehaviour
{
    private Vector3 initialPosition;
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //Player'a,Topun Player tagini atadık
        initialPosition = player.transform.position; //Topun ilk pozisyonunu aldık

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // SceneManager.LoadScene(0); //Sıfırıncı sahneyi yüklüyoruz. Unity de build setting =>add open sceen diyerek sahneyi eklemeliyiz

            //Sahnenin İndexini alıyoruz ve bir sonraki sahneye geçme işlemini yapıyoruz
            //int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(sceneIndex + 1);

            player.GetComponent<Rigidbody>().velocity = Vector3.zero; //Topun rigitbody'daki hızını sıfırlıyoruz
            player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; //Topun dönmesini sıfırladık başa dönünce
            player.transform.position = initialPosition; //Topun pozisyonunu ilk pozisyonuna aldık

        }
    }
}
