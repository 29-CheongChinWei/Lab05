using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinscript : MonoBehaviour

{
    public int score;
    public GameObject scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.GetComponent<Text>().text = "Score :" + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score += 10;
            Destroy(collision.gameObject);
        }
    }
}
