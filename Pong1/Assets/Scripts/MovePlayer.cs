
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float MoveSpeed;


    public void Start ()
    {
        MoveSpeed = 15;
    }
    public int playerNumber = 1;

    void Update()
    {
        
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * MoveSpeed * Time.deltaTime, 0));
        }
        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * MoveSpeed * Time.deltaTime, 0));
        }
    }
}
