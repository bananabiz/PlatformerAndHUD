using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    public int damage = 10;
    public Text clockText;
    public Text healthText;
    public Image healthBar;

    private float time;
    private float timeSecond;
    private float timeMinute;

    void Start()
    {
        health = maxHealth;
    }
    
	void Update()
    {
        time += Time.deltaTime;
        timeSecond = Mathf.Round(time);
        if (timeSecond > 59)
        {
            timeMinute++;
            timeSecond = 0;
            time = 0;
        }
        clockText.text = string.Format("{0:0}:{1:00}", timeMinute, timeSecond);

        healthBar.fillAmount = health / maxHealth;

        Debug.Log(healthBar.fillAmount);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" && health > 0)
        {
            health -= damage;
            Debug.Log(health);
            healthText.text = health.ToString();
        }

    }
}
