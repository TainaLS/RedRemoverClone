using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

    // Private
	private Rigidbody2D rb;

	// Public
	public enum Direction {Top, Down, Left, Right};
	public enum BoxColor {Red, RedLight, RedWhite, Green, GreenWhite, Purple, PurpleWhite};

	public Direction direction = Direction.Top;
	public BoxColor color = BoxColor.Red;
	public float forceApplied = 100f;
	public bool isStatic = true;
    public bool startMove = true;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();

		SetColor(color);

        if (isStatic) {
            rb.isKinematic = true;
        }

		if (startMove) {
			StartMove(direction);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	void SetColor (BoxColor color) {

		Color colorToBeApplied = Color.white;

		switch(color) {
		case BoxColor.Red:
			colorToBeApplied = Color.red;
			break;
		case BoxColor.Green:
			colorToBeApplied = Color.green;
			break;
		case BoxColor.Purple:
			colorToBeApplied = Color.blue;
			break;
		}

		gameObject.GetComponent<Renderer>().material.color = colorToBeApplied;

	}

	void StartMove (Direction dir) {
		switch(dir) {
		case Direction.Top:
			//top
			rb.AddForce (new Vector2(0, forceApplied));
			break;
		case Direction.Down:
			//down
			rb.AddForce (new Vector2(0, -forceApplied));
			break;
		case Direction.Left:
			//left
			rb.AddForce (new Vector2(-forceApplied, 0));
			break;
		case Direction.Right:
			//right
			rb.AddForce (new Vector2(forceApplied, 0));
			break;
		}
	}
}
