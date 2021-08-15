using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public int BallSpeed=0,jumpSpeed=0;
    private bool istouching=true;
    Rigidbody ball;
    
    // Start is called before the first frame update
    void Start()
    {
        ball= GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float HMove=Input.GetAxis("Horizontal");
        float VMove=Input.GetAxis("Vertical");

        Vector3 movement=new Vector3 (VMove ,0.0F ,-HMove);
        ball.AddForce(movement*BallSpeed);
        
        if((Input.GetKey(KeyCode.Space)) && istouching==true){
            Vector3 jumpBall=new Vector3(0.0f,5.0f,0.0f);
            ball.AddForce(jumpBall*jumpSpeed);
        }
        istouching=false;
    }

    private void OnCollisionStay(){
        istouching=true;
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("coinstag")){
            other.gameObject.SetActive(false);
        }
    }



}
