using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inBoard : MonoBehaviour
{
    public GameObject pieceBoard;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("Red")) & (Piece.isLaunched == true))
        {
            pieceBoard = collision.gameObject;
            //makes
            Destroy(pieceBoard, 5);
            //waits 5 seconds before deleting object
        }
        if ((collision.gameObject.CompareTag("Yellow")) & (Piece.isLaunched == true))
        {
            pieceBoard = collision.gameObject;
            Destroy(pieceBoard, 5);

        }
    }
  
}