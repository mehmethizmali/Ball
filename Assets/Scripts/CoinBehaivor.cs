using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaivor : MonoBehaviour
{
   
    private float amount = 5f; //Skor artırma aralığı 5 er 5 er artacak skor.
    //Bir nesne içinde geçerse
    private void OnTriggerEnter(Collider other)
    {
        //Gelen nesne top ise.Topun tag'ı Player'dir
        if (other.tag == "Player")
        {
            // other.GetComponent<PlayerMovement>().score += amount; //Score artırma
            other.GetComponent<PlayerMovement>().SetScore(amount); //Her obje kendi Properties'ini kullanmalıdır
            Destroy(gameObject);
        }
       
    }
}

