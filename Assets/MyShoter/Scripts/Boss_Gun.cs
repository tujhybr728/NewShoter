using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Gun : MonoBehaviour
{
    [SerializeField] GameObject timer_atake;
    [SerializeField] GameObject timer_relod;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject _gunpoint_object;
    private GameObject _buletgameobject;
    private Transform _gunpoint;
    private int _damage;
    private GameObject _boss;
    public int _maxBullet;
    public int _countBullet;
    public bool flag_atake = true, flag_relod = false;
    private void Awake()
    {
        _damage = gameObject.GetComponentInParent<Boss_Caracter>().damage;
        _boss = GameObject.FindGameObjectWithTag("Boss");
        _gunpoint = _gunpoint_object.transform;
        _maxBullet = _countBullet;
        Instantiate(timer_atake, gameObject.transform);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (flag_atake == true) Atake();
        if (_countBullet == 0)
        { Relode(); _countBullet--; }
    }

    public void Atake()
    {
        if (_countBullet > 0 && flag_relod == false)
        {
            flag_atake = false;
            _buletgameobject = Instantiate(bullet, _gunpoint.transform.position, _boss.transform.rotation);
            _buletgameobject.GetComponent<Bullet_Script>()._damage = _damage;
            _countBullet--;
            Instantiate(timer_atake, gameObject.transform);
        }
    }

    public void Relode()
    {
        Instantiate(timer_relod, gameObject.transform);
    }
}
