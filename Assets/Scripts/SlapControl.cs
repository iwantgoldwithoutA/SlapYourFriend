using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Legs;
    public bool AttackReady = true;
    public float AttackCoolDown = 1.0f;
    public Animator Anim;

    public CapsuleCollider col;

 

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Anim.SetBool("IsFire", true);
        }
        else 
        {
            Anim.SetBool("IsFire", false);
        }
    }

    public void EnableCol()
    {
        col.enabled = true;  
    }

    public void DisableCol()
    {
        col.enabled = false;
    }
}
