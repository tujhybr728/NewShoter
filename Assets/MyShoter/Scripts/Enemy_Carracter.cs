using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Carracter : Caracter
{
    public GameObject _player;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.GetComponent<Caracter>())
        {
            player.GetComponent<Caracter>().Damage(damage);
            Die();
        }
    }

    private void LateUpdate()
    {
        agent.destination = _player.transform.position;
    }
}
