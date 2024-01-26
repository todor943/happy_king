using Godot;
using System;

public class WorldNode : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private Sprite sprite;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sprite = new Sprite();
		AddChild(sprite);

		// Set the sprite's texture (replace 'res://path/to/your/image.png' with your actual image path)
		var texture = (Texture)GD.Load("res://Sprites/banana_peel.png");
		sprite.Texture = texture;

		// Call a function to position the sprite randomly
		PlaceSpriteRandomly();
	}
	
	private void PlaceSpriteRandomly()
	{
		// Set the sprite's position to a random location within the screen boundaries
		sprite.Position = new Vector2(
			(float)GD.RandRange(0, GetViewportRect().Size.x),
			(float)GD.RandRange(0, GetViewportRect().Size.y)
		);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
