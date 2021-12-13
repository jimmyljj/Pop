using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : MonoBehaviour
{

    public int health;
    Animator anim;

    public Collider myCollider;

    public Transform target;
    public float speed = 0f;
    public GameObject dropItem;
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }

    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
            Death();
    }

     private void Death()
     {
        myCollider.enabled = false;
        anim.SetBool("isDead", true);
        Destroy(gameObject, 1.5f);
        Vector3 position = transform.position;
        GameObject Potion = Instantiate(dropItem, transform.position, dropItem.transform.rotation);
        Potion.SetActive(true);
        Destroy(Potion, 5f);
    }
}
