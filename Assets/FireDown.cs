using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDown : MonoBehaviour
{
    ParticleSystem ps;
    public int fireHP = 10;
    public int FireHP
    {
        get {
            return fireHP;
        }
        set {
            fireHP -= value;
        }
    }
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }
    public void Emission()
    {
        var em = ps.emission;
        em.rateOverTime = FireHP/2;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer == LayerMask.NameToLayer("Smoke"))
        {
            FireHP = 1;
            if(FireHP == 5)
            {
                Emission();
            }           
            else if(FireHP == 2)
            {
                Emission();
            }
            else if(FireHP == 0)
            {
                ps.Stop();
            }   
        }     
    }
}
