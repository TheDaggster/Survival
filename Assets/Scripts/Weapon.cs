using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    // This is used to find the bulletPrefab I intend to use some sort of pooling later if given time to help make the
    // game less buggy. 
    public Transform firePoint;
    // This is a public object that is a hidden object and is completely invisible in game and only viewable in scene
    // this is used to indicate where the bullet should be coming out from and works as like the barrel to a gun. 


    private void Update()
    // I then make a constant update where it will check if the player decides to press a button. 
    {
        if (Input.GetButtonDown("Fire1"))
            // If the user decides to press "Fire1" (Left mouse button) they will play another void called "Fire"
        {
            Fire(); // "Fire" is then triggered upon pressing "Fire1"
        }
    }

    private void Fire()
    {
       Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       // This then spawn the bulletPrefab which is connected to the bullet script where the script entails how fast 
       // the bullet is shot its direction, the fire-point is used to indicate in what position and also rotation but 
       // since this is a 2D Side scroller the rotation will be stuck at a 90 to 180 Angle and position is moved around
       // depending on where the fire-point is placed near the player. 
    }
}