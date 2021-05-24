using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float DropSpeed = 0.00f;
    [SerializeField] int TimeToDrop = 0;
    MeshRenderer MR;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
        RB = GetComponent<Rigidbody>();
        MR.enabled=false;
        RB.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if(Time.time > TimeToDrop)
        {
                MR.enabled=true;
                RB.useGravity=true;
        }
    }
}
