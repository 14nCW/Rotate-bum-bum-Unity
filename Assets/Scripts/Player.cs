using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public float turningSpeed;

    public int health;
    int score;
    public TMP_Text healthDisplay;
    public TMP_Text scoreDisplay;

	// Start is called before the first frame update
	void Start()
	{
        healthDisplay.text = "Health: " + health;
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(Vector3.forward * turningSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
	}

    public void takeDamage() {
        health--;
        healthDisplay.text = "Health: " + health;
        if (health <= 0) {
            SceneManager.LoadScene("Game");
        }
    }

    public void AddScore() {
        score++;
        scoreDisplay.text = "Score: " + score;
    }
}
