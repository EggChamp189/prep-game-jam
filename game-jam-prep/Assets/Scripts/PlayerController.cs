using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class PlayerController : MonoBehaviour
{
    private Vector2 playerScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScale = new Vector2(gameObject.transform.localScale.x, gameObject.transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down);
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }

    }
}
