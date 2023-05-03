using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCut : MonoBehaviour
{
    //public TMPText txt;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "fruit") {
            Destroy(collision.gameObject);
        }
        
        
        
        /*GameObject victim = collision.collider.gameObject;
        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);
        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();
        Destroy(pieces[1], 1);*/
    }
}
