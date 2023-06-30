using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit_Points : MonoBehaviour
{
    public float add = 10;
    public float score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            score = add + score;
            Destroy(gameObject);
            
            scoreText.text = "Score: " + score.ToString();

        }
    }
}
