using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    int HP = 20;
    [SerializeField] float MoveSpeed = 3.00f;
    // Start is called before the first frame update
    void Start()
    {
        Consoler();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void Consoler()
    {
        //Debug.Log("More Now i got it so here you go lets go you look like you could use some more");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0.00f,zValue);
    }
}
