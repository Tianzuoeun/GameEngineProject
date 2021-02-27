using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosscamera : MonoBehaviour
{
    public Animator camAnim;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutscene), 3f);
        }
    }
    void StopCutscene()
    {
        camAnim.SetBool("cutscene1", false);
    }
}
