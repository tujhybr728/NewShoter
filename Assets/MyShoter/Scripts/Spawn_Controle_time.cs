using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controle_time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnDestroy()
    {
        gameObject.transform.GetComponentInParent<Spawn_Controller>().flag = true;
    }
}
