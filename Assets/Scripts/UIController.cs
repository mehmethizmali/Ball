using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject player; //Game object player oluşturup Ball içine attık ve erişmek istedğimiz PlayerMovement değerine eriştik.UIController Canvas'a verildi
   
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = "Score :" + player.GetComponent<PlayerMovement>().score;
    }

    public void setScoreText(string aScoreString)
    {
        scoreText.text = aScoreString; //Update yerine her objeyi kendi içinde verildi. Her obje kendi Properties'inde set edildi.
    }
}
