# basic-gameplay-unity3d
https://learn.unity.com/tutorial/lab-4-basic-gameplay?uv=2019.4&amp;pathwayId=5f7e17e1edbc2a5ec21a20af&amp;missionId=5f7648a4edbc2a5578eb67df&amp;projectId=5cf96846edbc2a2bcde6d0fc

## transform.translate vs. AddForce
### transform.translate
With this method you basically teletransport the GameObject, not taking in account physics nor colliders. This one is pretty expensive if you have a RigidBody attached.

### AddForce
With this one you are adding force to the RigidBody of the GameObject, so all the movement will be taking physics and colliders into account. If you need to move a RigidBody (like a Player) I recommend using [MovePosition](https://docs.unity3d.com/ScriptReference/Rigidbody.MovePosition.html). It's more precise than AddForce and uses the physics motor.

### Screenshots
<img title="screenshot-1" alt="screenshot-1" src="/images/screenshot-1.png">