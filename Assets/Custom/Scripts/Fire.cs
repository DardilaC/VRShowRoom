using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class Fire : MonoBehaviour
{
    public Transform firePoint;
    public string bulletPrefab;
    public float firePower = 1000f;

    [System.Obsolete]
    public void FireBullet()
    {
        GameObject bullet = Realtime.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(firePoint.forward * firePower);
    }
}
