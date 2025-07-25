using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoolControler : MonoBehaviour
{
    [Header("Pooling")]
    public PoolAmount[] Pool;

    public void Awake()
    {
        for (int i = 0; i < Pool.Length; i++)
        {
            SimplePool.Preload(Pool[i].prefab, Pool[i].amount, Pool[i].root, Pool[i].collect, Pool[i].clamp);
        }

    }

}


