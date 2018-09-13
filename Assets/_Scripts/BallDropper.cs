using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallDropper : MonoBehaviour
{
    
    
    public GameObject BallPrefab;
    
    public float speed = 5f;
    
    public float leftAndRightEdge = 20f;
    
    public float chanceToChangeDirections = 0.01f;
    
    public float secondsBetweenBallDrops = 5f;

    void Start()
    {
        Invoke("DropBall", 2f);
    }
    void DropBall()
    {
        GameObject Ball = Instantiate<GameObject>(BallPrefab);
        Ball.transform.position = transform.position;
        Invoke("DropBall", secondsBetweenBallDrops);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
        void FixedUpdate()
        {
            if (Random.value < chanceToChangeDirections)
            {
                speed *= -1;
            }
        }
}