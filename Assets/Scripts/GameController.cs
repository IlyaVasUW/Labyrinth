using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int [] tiles;
    int boardDimensionX;
    int boardDimensionY;
    [SerializeField] GameObject tilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameBoardSpawn()
    {
        for(int x = 0; x < boardDimensionX; x++)
        {
            for(int y = 0; y < boardDimensionY; y++)
            {
                Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}
