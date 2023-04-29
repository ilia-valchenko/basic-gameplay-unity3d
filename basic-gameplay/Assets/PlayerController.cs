using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 15.0f;
    private const float Strength = 150.0f;

    //private Rigidbody _playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //_playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * Speed);

        /* transform.translate vs. AddForce
         * transform.translate:
            With this method you basically teletransport the GameObject, not taking in account physics nor colliders.
            This one is pretty expensive if you have a RigidBody attached.

         * AddForce
            With this one you are adding force to the RigidBody of the GameObject,
            so all the movement will be taking physics and colliders into account.
            If you need to move a RigidBody (like a Player) I recommend using MovePosition.
            It's more precise than AddForce and use the physics motor.
            See: https://docs.unity3d.com/ScriptReference/Rigidbody.MovePosition.html
        */

        //_playerRigidBody.AddForce(Vector3.forward * verticalInput * Time.deltaTime * Strength);
        //_playerRigidBody.AddForce(Vector3.right * horizontalInput * Time.deltaTime * Strength);
    }
}
