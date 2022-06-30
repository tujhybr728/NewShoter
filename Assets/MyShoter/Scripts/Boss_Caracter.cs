using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Caracter : Caracter
{
    private GameObject _player;
    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        gameObject.transform.LookAt(_player.transform);
    }
}
