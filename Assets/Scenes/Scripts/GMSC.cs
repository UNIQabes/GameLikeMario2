using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMSC : MonoBehaviour
{
    public bool EnIsAlive;

    public GameObject Player1;
    public PlayerSC plSCP1;
    public Rigidbody rgdP1;
    public Transform trsP1;
    public GameObject PlayerBody;
    public PlayerArmSC plLArmSC;
    public PlayerArmSC plRArmSC;
    public GameObject PlayerModel;
    public Animator playerAnim;
    public Transform plMdTrs;

    public GameObject Enemy;
    public EnemySC enSC;
    public Rigidbody rgdEn;
    public Transform trsEn;
    public GameObject EnemyHead;
    public EnemyHeadSC enHeadSC;

    // Start is called before the first frame update
    void Start()
    {
        EnIsAlive = true;
        GetSCandOB();
        SetValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void GetSCandOB()
    {
        Player1 = GameObject.Find("Player");
        plSCP1 = Player1.GetComponent<PlayerSC>();
        rgdP1 = Player1.GetComponent<Rigidbody>();
        trsP1 = Player1.GetComponent<Transform>();
        PlayerBody = Player1.transform.Find("PlayerBody").gameObject;
        plLArmSC = Player1.transform.Find("PlayerLArm").gameObject.GetComponent<PlayerArmSC>();
        plRArmSC = Player1.transform.Find("PlayerRArm").gameObject.GetComponent<PlayerArmSC>();
        //Animationを抜くときはこれをコメントアウトすればOK
        PlayerModel = Player1.transform.Find("PlayerModel").gameObject;
        playerAnim = PlayerModel.GetComponent<Animator>();
        plMdTrs = PlayerModel.GetComponent<Transform>();

        Enemy = GameObject.Find("Enemy");
        enSC = Enemy.GetComponent<EnemySC>();
        rgdEn = Enemy.GetComponent<Rigidbody>();
        trsEn = Enemy.GetComponent<Transform>();
        EnemyHead = Enemy.transform.Find("EnemyHead").gameObject;
        enHeadSC = EnemyHead.GetComponent<EnemyHeadSC>();
        enHeadSC.enemySC = enSC;

    }

    private void SetValue()
    {
        RefGM.gMSC = this;

        plSCP1.rgdP1 = rgdP1;
        plLArmSC.playerSC = plSCP1;
        plRArmSC.playerSC = plSCP1;
        plLArmSC.isLeft = true;
        plRArmSC.isLeft = false;
        //Animationを抜くときはこれをコメントアウトすればOK
        plSCP1.playerAnim = playerAnim;
        plSCP1.plMdTrs = plMdTrs;

        enSC.rgdEn = rgdEn;
        enSC.trsEn = trsEn;
        enSC.trsP1 = trsP1;
    }
}
