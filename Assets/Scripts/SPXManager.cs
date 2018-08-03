using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPXManager : MonoBehaviour {

    public static SPXManager instance;

    public GameObject coinParticles;

    void Awake()
    {
        if (instance == instance == null)
        {
            instance = this;
        }
    }

    public void ShowCoinParticle(GameObject obj)
    {
        Instantiate(coinParticles, obj.transform.position, Quaternion.identity);
    }
}
