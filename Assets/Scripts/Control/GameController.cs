using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Player;
    public Transform playerStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    public void ResetGame()
    {
        Player.transform.position = playerStartPosition.position;
    }
}
