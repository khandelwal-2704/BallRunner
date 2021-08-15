using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 turnCoin;

    // Update is called once per frame
    void Update()
    {
        turnCoin=new Vector3(45,0,0);

        transform.Rotate(turnCoin* Time.deltaTime);

        
    }
}
