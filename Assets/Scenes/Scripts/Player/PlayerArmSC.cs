using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmSC : RefGM
{
    public bool isLeft;
    public PlayerSC playerSC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            if (isLeft)
            {
                playerSC.IsGroundingL = true;
                Debug.Log("ワイが左腕や");
            }
            else
            {
                playerSC.IsGroundingR = true;
                Debug.Log("ワイが右腕や");
            }
            
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            if (isLeft)
            {
                playerSC.IsGroundingL = false;
            }
            else
            {
                playerSC.IsGroundingR = false;
            }

        }

    }
}
