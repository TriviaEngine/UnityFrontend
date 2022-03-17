using UnityEngine;

public class SquareBehaviour : MonoBehaviour
{
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        var movement = new Vector2(x, y);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}