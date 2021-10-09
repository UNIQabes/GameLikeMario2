using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootSC : RefGM
{
    private PlayerSC playerSC;
    private GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
       Player= transform.parent.gameObject;
       playerSC = Player.GetComponent<PlayerSC>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Ground"|other.gameObject.name=="EnemyHead")
        {
            playerSC.IsGrounding = true;
            
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground" | other.gameObject.name == "EnemyHead")
        {
            playerSC.IsGrounding = false;

        }

    }
}
