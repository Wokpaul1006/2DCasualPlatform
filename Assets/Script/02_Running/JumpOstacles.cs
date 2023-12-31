using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpOstacles : MonoBehaviour
{

    void Update() => OnMoveForward();

    private void OnMoveForward() => transform.position += Vector3.left * Time.deltaTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Goal") 
        {
            Destroy(gameObject);
        }
    }
}
