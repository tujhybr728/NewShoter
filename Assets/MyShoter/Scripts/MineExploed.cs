using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExploed : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Caracter>().Damage(GetComponentInParent<Mine_controller>().damage);
    }

}
