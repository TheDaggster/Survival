using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    public void Fire()
    {
       Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}