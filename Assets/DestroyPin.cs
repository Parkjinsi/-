using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPin : MonoBehaviour
{
    [SerializeField]
    private GameObject Pin;
    // Start is called before the first frame update
    public void DestroyPinF()
    {
        Destroy(Pin);
    }
}
