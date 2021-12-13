using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollisionController : MonoBehaviour
{
    public HealthbarController healthbar;
    public GameObject potDestroy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (healthbar)
            {
                healthbar.onTakeDamage(10);
            }    
        }

        if (collision.gameObject.tag == "Heal Potion")
        {
            if (healthbar)
            {
                healthbar.onGainLife(25);
            }
        }
    }
}
