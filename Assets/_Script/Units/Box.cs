using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    Rigidbody2D BoxRg;
    // Start is called before the first frame update
    void Start()
    {
        BoxRg = GetComponent<Rigidbody2D>();
        BoxRg.velocity = new Vector2(20f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(BoxRg.velocity.magnitude == 0 && GameManager.State == GameState.Simulation)
        {
            GameManager.Instance.UpdateGameState(GameState.Lose);
        }
    }
}
