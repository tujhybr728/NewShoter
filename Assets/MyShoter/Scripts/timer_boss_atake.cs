using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_boss_atake : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 0.7f);
    }

    private void OnDestroy()
    {
        gameObject.GetComponentInParent<Boss_Gun>().flag_atake = true;
    }
}
