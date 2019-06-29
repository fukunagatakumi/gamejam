using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroyansMusic : MonoBehaviour
{
    public AudioSource sound01;
    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        sound01.PlayOneShot(sound01.clip);
    }

}
