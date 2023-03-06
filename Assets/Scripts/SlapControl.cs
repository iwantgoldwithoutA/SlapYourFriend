using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Legs;
    public bool AttackReady = true;
    public float AttackCoolDown = 1.0f;
    Animator Anim;

    public void Yaheuy()
    {
        AttackReady = false;
        Anim = Legs.GetComponent<Animator>();
        Anim.SetBool("Isfire", true);
    }

    IEnumerator ResetAttackCoolDown()
    {
        yield return new WaitForSeconds(AttackCoolDown);
        Anim.SetBool("Isfire", false);
        AttackReady = true;
    }

    
}
