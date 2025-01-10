using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    int hurtAmount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyHealth ehealth = collision.gameObject.GetComponent<EnemyHealth>;
        if (ehealth == null)
        {
            return;
        }
        ehealth.Hurt(hurtAmount);
    }
}
