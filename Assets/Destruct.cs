using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class Destruct : MonoBehaviour
{
    public void Awake()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Realtime.Destroy(gameObject);
    }
}
