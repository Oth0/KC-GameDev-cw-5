using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnAnimatorIK(int layerIndex)
    {
        gameManager.instance.AddPoint();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
    
}
