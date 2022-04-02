using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
     [SerializeField]
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Shoot(hand.shootFromHere.transform.position, wrist.Rotation)
    }


    private void Shoot(Vector3 origin, Quaternion rotation, Color? color = null) {
        Debug.Log($"Shoot - origin: {origin} rotation: {rotation}");
        GameObject bullet = Instantiate(bulletPrefab, origin, rotation);
        if (color != null) {
            bullet.gameObject.GetComponent<Renderer>().material.SetColor("_Color", color.Value);
        }
        // audioSource.PlayOneShot(gunSound, 0.2f);
    }
}