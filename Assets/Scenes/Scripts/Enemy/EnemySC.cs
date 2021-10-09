using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySC : RefGM
{

    public Rigidbody rgdEn;
    public Transform trsEn;
    public Transform trsP1;

    public bool IsAlive;

    // Start is called before the first frame update
    void Start()
    {
        IsAlive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (IsAlive == false)
        {
            EnDie();
        }
    }

    public void EnDie()
    {
        Debug.Log("あぁ＾〜");
        Destroy(this.gameObject);
    }


}
