using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEfire : MonoBehaviour
{
    public float speed = 40;
    public GameObject obj;
    public GameObject cube;
    public GameObject pin;
    public Transform firePosition;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Fire()
    {
        if(!pin)
        {
            GameObject spawnedObj = Instantiate(obj, firePosition.position, firePosition.rotation);
            GameObject spawnedObj2 = Instantiate(cube, firePosition.position, firePosition.rotation);
            spawnedObj2.GetComponent<Rigidbody>().velocity = speed * firePosition.forward;
            spawnedObj.transform.position = firePosition.transform.position;
            spawnedObj.transform.forward = firePosition.forward;
            audioSource.PlayOneShot(audioClip);
            Destroy(spawnedObj, 2);
            Destroy(spawnedObj2, 2);
        }
        
    }
}
