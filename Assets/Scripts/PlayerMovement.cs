using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRigitBody;
    float forceMagnitude = 40f;
    private float score = 0; //Encapsalation yaptık
    public Canvas uiObject;
    float LeftRight;
    float upDown;
    bool onGround;
    // Start is called before the first frame update
    void Start()
    {
        playerRigitBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
            LeftRight = Input.GetAxis("Horizontal");
            upDown = Input.GetAxis("Vertical");
   

    }

    //FixedUpdate,Update göre daha yavaş çalışır
    private void FixedUpdate()
    {
        if (onGround)
        {
            //Top sol- Sağ tarafta
            //transform.position += Vector3.right * 10f; //pozisyonunu sağa doğru değiştirir
            Vector3 leftRightVector = Vector3.right * LeftRight * forceMagnitude;
            playerRigitBody.AddForce(leftRightVector);   //AddForce : Nesneye kuvvet uyguluyor. F=m.a vb.


            //Top Yukarı -aşağı tarafa
            Vector3 upDownVector = Vector3.up * upDown * forceMagnitude;
            playerRigitBody.AddForce(upDownVector);
        }
    }

    //Zemine değdiğinde
    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

    //Zemine değmediğinde
    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }

    public void SetScore(float anIncrement)
    {
        score += anIncrement;
        uiObject.GetComponent<UIController>().setScoreText("Score : "+score.ToString());
    }

}

