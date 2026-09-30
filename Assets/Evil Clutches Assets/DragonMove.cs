using UnityEngine;

public class DragonMove : MonoBehaviour
{
    public float speed = 5;
    private bool goingUp = true;

    //rat/fireball timers
    private float ratWait = 1, fireballwait = 2;
    private float ratTimer = 0, fireballTimer = 0;

    private float HeartWait = 4, HeartTimer = 0;

    public GameObject rat;
    public GameObject fireball;

    public GameObject Heart;
   
   
    void Update()
    {
        //spawning 
        ratTimer += Time.deltaTime;
        fireballTimer += Time.deltaTime;
        HeartTimer += Time.deltaTime;

        if (ratTimer > ratWait)
        {
            Instantiate(rat, transform.position, Quaternion.identity);
            ratTimer = 0;
            ratWait = Random.Range(1f, 2f);
        }

        if (fireballTimer > fireballwait)
        {
                Instantiate(fireball, transform.position, Quaternion.identity);
                fireballTimer = 0;
                fireballwait = Random.Range(2f, 3f);



        }

        if (HeartTimer > HeartWait)
        {
            Instantiate(Heart, transform.position, Quaternion.identity);
            HeartTimer = 0;
            HeartWait = Random.Range(4f, 5f);
        }

        transform.Translate(transform.up * speed * Time.deltaTime);
        if (transform.position.y > 4 && goingUp == true)
        {
            goingUp = false;
            speed *= -1;
        }
        if (transform.position.y < -4 && goingUp == false)
        {
            goingUp = true;
            speed *= -1;
        }
    }

}