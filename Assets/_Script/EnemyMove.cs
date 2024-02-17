using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Transform castle; 

    void Start()
    {
        GameObject castleObject = GameObject.FindGameObjectWithTag("Castle");
        
        if (castleObject != null)
        {
            castle = castleObject.transform;
        }
        else
        {
            Debug.LogError("Castle bulunamadı!");
        }
    }

    void Update()
    {
        if (castle == null)
            return;

        Vector3 moveDirection = castle.position - transform.position;
        moveDirection.Normalize();

        // Hareket et
        transform.Translate(moveDirection * (moveSpeed * Time.deltaTime), Space.World);
    }
}
