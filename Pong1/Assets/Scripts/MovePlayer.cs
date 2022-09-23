
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float MoveSpeed;
    public int playerNumber = 1;
    public Rigidbody2D rb;
    

    void Update()
   
    {
        
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * MoveSpeed * Time.deltaTime, 0));
            if (rb.position.y < -3.6f)
            {
                transform.Translate(Vector2.up * 0.1f);
            }
            if (rb.position.y > 3.6f)
            {
                transform.Translate(Vector2.down * 0.1f);
            }
        }
        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * MoveSpeed * Time.deltaTime, 0));
            if (rb.position.y < -3.6f)
            {
                transform.Translate(Vector2.up * 0.1f);
            }
            if (rb.position.y > 3.6f)
            {
                transform.Translate(Vector2.down * 0.1f);
            }
        }

    }
}
