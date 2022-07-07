using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_controller : MonoBehaviour
{
    public int damage;
    private GameObject _Caracter;
    private Coroutine coroutine;
    private WaitForSeconds _waitTime = new WaitForSeconds(0.5f);
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<SphereCollider>().radius = 2.5f;      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Caracter>())
        {
            other.gameObject.GetComponent<Caracter>().Damage(damage);
        }
        Destroy(gameObject);
    }

    private void Start()
    {
        StartCoroutine(WaitBum());
    }

    private IEnumerator WaitBum ()
    {
        GetComponent<SphereCollider>().radius = 0f;
        yield return _waitTime;
        GetComponent<SphereCollider>().radius = 1.5f;
    }
}
