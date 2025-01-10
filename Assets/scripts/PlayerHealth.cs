using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    GameObject[] hjärtan;
    int maxHealth = 3;
    int health;
    int hurtAmount = 1;
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
    void OnCollisionEnter2D(Collision2D collision)
    {
        // if (transform.position.y < -5.6f) // if the ball is outside this position then
        {
            maxHealth--; //lives = lives -1;
            hjärtan[maxHealth].GetComponent<Image>().enabled = false;
            transform.position = new Vector2(0, -2); //makes the player respawn
            if (maxHealth == 0)
            {
                //change to game over scene
                SceneManager.LoadScene("gameover");
            }
        }
    }
    void Update()
    {
    }
}
