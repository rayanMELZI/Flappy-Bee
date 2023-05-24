using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject player;

    public static bool gameIsRuning = true;
    

    void Start() {
        StartCoroutine(spawnObstacle());
    }

    IEnumerator spawnObstacle(){
        while (gameIsRuning == true)
        {
            Instantiate(prefab);
            yield return new WaitForSeconds(2f);
        }
    }
    
    void Update() {
        if (player == null && gameIsRuning == true)
        {
            Debug.Log("Game Over");
            gameIsRuning = false; //Game Over
        }
    }

}
