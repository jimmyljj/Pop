using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 firingPoint;

    public int damage = 2;

    [SerializeField]
    float projectileSpeed;

    [SerializeField]
    private float maxProjectileDistance;

    public Rigidbody rig;

    void Start()
    {
        firingPoint = transform.position;

        rig.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
    }

    void Update()
    {
        MoveProjectile();
    }

    void MoveProjectile()
    {
        if (Vector3.Distance(firingPoint, transform.position) > maxProjectileDistance)
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnemySlime enemySlime;

        if (collision.transform.tag == "Enemy")
        {
            enemySlime = collision.transform.GetComponent<EnemySlime>();
            enemySlime.TakeDamage(damage);
            Destroy(this.gameObject);
        }

        if (collision.transform.tag == "Obstacles")
        {
            Destroy(this.gameObject);
        }
    }


}
