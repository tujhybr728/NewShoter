using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Caracter : Caracter
{
    private static float vertical, horizontal;
    Rigidbody rb_player;
    Vector3 move_vector;
    // Start is called before the first frame update

    void Start()
    {
        rb_player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
       
        transform.Translate(Vector3.forward * vertical * Time.deltaTime*movespeed, Space.Self);
        transform.Rotate(Vector3.up, horizontal*tonglspeed*Time.deltaTime);
    }
}
