using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;
    public int _damage;
    private GameObject _Caracter;

    private void Awake()
    {
        Destroy(gameObject, 3);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider enemy)
    {
        _Caracter = enemy.gameObject;
        if (_Caracter.GetComponent<Caracter>())
        {
            _Caracter.GetComponent<Caracter>().Damage(_damage);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*_bulletSpeed, Space.Self);
    }
}
