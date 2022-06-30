using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Script : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject _gunpoint_player;
    private GameObject _buletgameobject = new GameObject();
    private Transform _gunpoint;
    private int _damage;
    private GameObject _player;
    private List<GameObject> _listBullet = new List<GameObject>();
    public int _countBullet,_countMine = 3;
    private int _maxBullet;
    // Start is called before the first frame update
    void Start()
    {
        _damage = gameObject.GetComponentInParent<Player_Caracter>().damage;
        _player = GameObject.FindGameObjectWithTag("Player");
        _gunpoint = _gunpoint_player.transform;
        _maxBullet = _countBullet;
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)==true && _countBullet!=0)
        {
            _buletgameobject = Instantiate(bullet, _gunpoint.transform.position, _player.transform.rotation);
            _buletgameobject.GetComponent<Bullet_Script>()._damage = _damage;
            _countBullet--;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _countBullet = _maxBullet;
        }
        if (Input.GetMouseButtonDown(1) == true && _countMine !=0)
        {
            Instantiate(mine, _player.transform.position, Quaternion.identity);
            _countMine--;
        }
    }


}
