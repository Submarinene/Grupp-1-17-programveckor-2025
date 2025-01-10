using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 3;
    int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        phealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (phealth == null)
        {
            return;
        }

        phealth.Hurt(hurtAmount);
        Destroy(gameObject);
    }
}


