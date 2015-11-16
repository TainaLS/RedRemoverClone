using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

    // Private
	private Rigidbody2D rb;

	// Public
	public enum Direction {Top, Down, Left, Right};
	public Direction direction = Direction.Top;
	
	public float forceApplied = 100f;
	public bool isStatic = true;
    public bool startMove = true;

	// Use this for initialization
	void Start () {

        // get rigid body 2d reference
		rb = GetComponent<Rigidbody2D>();
                
        if (isStatic) {
            rb.isKinematic = true;
        }
        		
	}

    void Update() {

        if (startMove) {
            Move(direction);
        }        

    }

	void Move (Direction dir) {
		switch(dir) {
		case Direction.Top:
			//top
			rb.velocity = new Vector2(0, forceApplied);
			break;
		case Direction.Down:
			//down
			rb.velocity = new Vector2(0, -forceApplied);
			break;
		case Direction.Left:
			//left
			rb.velocity = new Vector2(-forceApplied, 0);
			break;
		case Direction.Right:
			//right
			rb.velocity = new Vector2(forceApplied, 0);
			break;
		}
	}

    

}
