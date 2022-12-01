using UnityEngine;

public class PickupAmmo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Weapon weapon = collision.gameObject.GetComponentInChildren<Weapon>();
        if (weapon)
        {
            weapon.AddAmmo(weapon.maxAmmoSize);
            Destroy(gameObject);
        }
    }
}
