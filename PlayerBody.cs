using Godot;
using System;

public class PlayerBody : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	public float speed = 1f;

	public float acceleration = 1f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//		Vector2 velocity = new Vector2();
//
//		if (Input.IsActionPressed("Right"))
//			velocity.x += speed;
//		if (Input.IsActionPressed("Left"))
//			velocity.x -= speed;
//		if (Input.IsActionPressed("Down"))
//			velocity.y += speed;
//		if (Input.IsActionPressed("Up"))
//			velocity.y -= speed;
//
//		velocity = velocity.Normalized() * speed;
//		MoveAndSlide(velocity);
//	}
}
