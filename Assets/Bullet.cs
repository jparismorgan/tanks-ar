using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
        private const float speed = 0.1f;

        // public GameObject explosionPrefab;
        private int lives = 3;

        void Start() {
            Destroy(this.gameObject, 20.0f);
        }

        void Update() {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        void OnCollisionEnter(Collision collision) {
            lives -= 1;
            if (lives <= 0 && collision.gameObject.tag != "FlareGun" && collision.gameObject.tag != "UI") {
                ContactPoint contact = collision.contacts[0];
                Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
                Vector3 position = contact.point;

                // GameObject explosionObject = Instantiate(explosionPrefab, position, rotation) as GameObject;
                // Destroy(explosionObject, 4.0f);

                Destroy(this.gameObject);
            }
        }
    }