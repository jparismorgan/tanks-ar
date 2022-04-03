using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
     [SerializeField]
    public GameObject bulletPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.rotation = Quaternion.identity;
        // transform.rotation = Quaternion.Euler(transform.eulerAngles.x,0, transform.eulerAngles.z);
        gameObject.transform.rotation = Quaternion.Euler(0,transform.eulerAngles.y,0);
        // Shoot(hand.shootFromHere.transform.position, wrist.Rotation)
    }

    public void ShootBullet() {
        Debug.Log("Shoot!");
        Debug.Log(gameObject.transform.position);
        Shoot(gameObject.transform.position, gameObject.transform.rotation, Color.red);
    }
    private void Shoot(Vector3 origin, Quaternion rotation, Color? color = null) {
        Debug.Log($"Shoot - origin: {origin} rotation: {rotation}");
        GameObject bullet = Instantiate(bulletPrefab, origin, rotation);
        if (color != null) {
            bullet.gameObject.GetComponent<Renderer>().material.SetColor("_Color", color.Value);
        }
        Debug.Log(bullet.transform.position);
        // audioSource.PlayOneShot(gunSound, 0.2f);
    }
}