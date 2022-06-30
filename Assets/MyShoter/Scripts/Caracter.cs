using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracter : MonoBehaviour
{
    [SerializeField] public float movespeed;
    [SerializeField] public float tonglspeed;
    [SerializeField] public int healt;
    [SerializeField] public int damage;
    [SerializeField] GameObject Unit;

    public void Damage(int _damage)
    {
        healt -= _damage;
        if (healt <= 0) Die();
    }
    public void Die()
    {
        Unit.SetActive(false);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Damage(damage);
    }

}
