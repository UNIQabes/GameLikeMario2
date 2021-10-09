using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSC : RefGM
{
    public Rigidbody rgdP1;
    public GameObject Player;
    public bool IsGrounding;
    public bool IsGroundingL;
    public bool IsGroundingR;
    public bool IsWalking;
    public Animator playerAnim;
    public Transform plMdTrs;


    private float JumpSpeed=5;

    // Start is called before the first frame update
    void Start()
    {
        IsGrounding = true;
        IsWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        IsWalking = false;
        ReactInput();
    }

    public void ReactInput()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rgdP1.velocity = new Vector3(5, rgdP1.velocity.y, 0);
            IsWalking = true;
            plMdTrs.rotation = Quaternion.Euler(0,90,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgdP1.velocity = new Vector3(-5, rgdP1.velocity.y, 0);
            IsWalking = true;
            plMdTrs.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (IsGrounding)
            {
                rgdP1.velocity = new Vector3(0, JumpSpeed, 0);
                
                Debug.Log("A！");
            }
            else if(IsGroundingL)
            {
                rgdP1.velocity = new Vector3(5, JumpSpeed, 0);
                plMdTrs.rotation = Quaternion.Euler(0, 90, 0);
                Debug.Log("左！");
            }
            else if (IsGroundingR)
            {
                rgdP1.velocity = new Vector3(-5, JumpSpeed, 0);
                plMdTrs.rotation = Quaternion.Euler(0, -90, 0);
                Debug.Log("右！");
            }
        }

        SetAnimPara();
    }

    
    public void SetAnimPara()
    {
        //Animationを抜くときはこれをコメントアウトすればOK
        playerAnim.SetBool("IsWalking", IsWalking);
        playerAnim.SetBool("IsGrounding", IsGrounding);
        if (IsGroundingR)
        {
            playerAnim.SetBool("IsHanging", IsGroundingR);
        }
        else
        {
            playerAnim.SetBool("IsHanging", IsGroundingL);
        }
        playerAnim.SetFloat("VelocityY", rgdP1.velocity.y / JumpSpeed);


    }
   
}
