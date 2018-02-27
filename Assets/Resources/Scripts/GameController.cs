using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float currentTime;
    public Text timeDisplay;
    public int health;
    public Text healthDisplay;

	
	
	// Update is called once per frame
	void Update ()
    {
        currentTime += Time.deltaTime;

        timeDisplay.text = currentTime.ToString("0:00");

        healthDisplay.text = health.ToString();
	}

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("hazard"))
        {
            health--;
        }

    }

}
