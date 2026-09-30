using System.Runtime.CompilerServices;
using UnityEngine;

using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    private int ScoreVal = 0;

    public TextMeshProUGUI scoreBox; 

    void Update()
    {
        //traveling up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        //traveling down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        // constrict movement
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
    }
        
       private void OnTriggerEnter2D(Collider2D collision)
       { 
           if (collision.gameObject.tag == "Projectile")
           {
            if(collision.GetComponent<ProjectrileMove>() !=null)
            {
                ScoreVal += collision.GetComponent<ProjectrileMove>().points;
                scoreBox.text = "Score: " + ScoreVal;
            }
            Destroy(collision.gameObject);
           }
         
       }
}

           