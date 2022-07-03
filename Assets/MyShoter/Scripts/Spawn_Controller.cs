using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{
    public GameObject[] _listSpawnEnemy;
    private List<GameObject> _listEnemy = new List<GameObject>();
    [SerializeField] public GameObject _enemy;
    private Vector3 point = new Vector3(-100,-100,-100);
    [SerializeField] GameObject _spawnControlTime;
    [SerializeField] GameObject _boss;
    public int count, healt_max;
    public bool flag = false;
    //private bool flagBoss = false;
    
    private void Awake()
    {
        _listSpawnEnemy = GameObject.FindGameObjectsWithTag("Spawn_point");
        for (int i = 0; i<_listSpawnEnemy.Length;i++)
        {
           _listEnemy.Add(Instantiate(_enemy,point,Quaternion.identity));
           _listEnemy[i].SetActive(false);
        }
        healt_max = _listEnemy[0].GetComponent<Caracter>().healt;
    }
    // Start is called before the first frame update
    void Start()
    {
        RelodeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true && count>=0) RelodeSpawn();
        if (count <= 0)
        {
            Instantiate(_boss);
            gameObject.SetActive(false);
        }
    }

    public void RelodeSpawn()
    {
        //foreach (GameObject obj in _listEnemy) // срабатывает только 1 раз, спавнит только одного из списка
        //{
        //    if (obj.activeSelf == false)
        //    {
        //        obj.transform.position = _listSpawnEnemy[Random.Range(0, _listSpawnEnemy.Length)].transform.position;
        //        obj.SetActive(true);
        //    }
        //}

        for (int i = 0; i < _listEnemy.Count; i++)
        {
            if (_listEnemy[i].activeSelf == false && count>= 0)
            {
                _listEnemy[i].transform.position = _listSpawnEnemy[Random.Range(0, _listSpawnEnemy.Length)].transform.position;
                _listEnemy[i].GetComponent<Caracter>().healt = healt_max;
                //_listEnemy[i].transform.position = _listSpawnEnemy[i].transform.position;
                _listEnemy[i].SetActive(true);
                count--;
            }
        }
        flag = false;
        Instantiate(_spawnControlTime, gameObject.transform);
    }


}
