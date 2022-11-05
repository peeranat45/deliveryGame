using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float minVelocity = 0;
    [SerializeField] private float maxVelocity = 100000f;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player")
        {
            return;
        }
        float currentVelocity = other.GetComponent<Rigidbody2D>().velocity.magnitude;
        if (currentVelocity > minVelocity || currentVelocity < maxVelocity)
        {
            Debug.Log(GameManager.Instance);
            GameManager.Instance.UpdateGameState(GameState.Victory);
        }
        else
        {
            GameManager.Instance.UpdateGameState(GameState.Lose);
        }
    }
}
