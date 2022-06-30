using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_boss_relod : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 6);
    }

    private void OnDestroy()
    {
        gameObject.GetComponentInParent<Boss_Gun>()._countBullet = gameObject.GetComponentInParent<Boss_Gun>()._maxBullet;
    }
}
