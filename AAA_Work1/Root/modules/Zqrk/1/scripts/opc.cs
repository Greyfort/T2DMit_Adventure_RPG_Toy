//-----------------------------------------------------------------------------
//
// Zqrk " opc.cs "
//
// name:			Adventures of  Zqrk
// Created:			April, 2014
// By:				Greyfort
//
// Version:			1.00
//-----------------------------------------------------------------------------
// Last Edited:	4.25.2014
//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------
function createOPC()
{
   // Create the sprite.
    %opc = new Sprite(PlayerShip);
    // We want our spaceship to move and be affected by gravity and various forces
    // so we set its BodyType to dynamic
    %opc.setBodyType( dynamic );
   // Set the position at the center of our Scene
    %opc.Position = "0 0";
   // Set the size.        
    %opc.Size = $size;
    // Set the layer closest to the camera (above the background)
    %opc.SceneLayer = 1;
	// set speeds
	%opc.minSped="5";
	%opc.maxSpeed="15";
    // Set the scroller to use an animation!
	//%anim = "TropicalAssets:lrqk_walk_s0_a0_sAnimation"; 
    %opc.Image = "Zqrk:lqrk_actn_green";
    // This creates a box which so that collisions with the screen edges register properly
    // Calling createPolygonBoxCollisionShape() without arguments sets the box to the size of the 
    // sceneobject automatically.
	
    %opc.createPolygonBoxCollisionShape();	
	//collision
	%opc.setCollisionCallback( true );	
    // Add the sprite to the scene.
    myScene.add( %opc );  
	//setFixedAngle prevents the spaceship's rotation from being influenced by Collisions and physics forces
	//The spaceship will still bounce when it collides with other objects.
	%opc.setFixedAngle(true);
	//create a new variable and set it to false.
	%opc.isThrusting = false;

	// Keyboard Controls
	// default arrow keys
	 %controls = ShooterControlsBehavior.createInstance();
	 
	 // unselect below by removing // from the front to use WASD
	    //%controls.upKey = "keyboard W";
        //%controls.downKey = "keyboard S";
        //%controls.leftKey = "keyboard A";
        //%controls.rightKey = "keyboard D";
		
     %opc.addBehavior(%controls);
	
}

function opc::move (%this, %amount)
{
	%position = %this.getPostion();
	//%newPosition = t2dVectorAdd(%postion,%amount);
	//%this.setPostion(%newPosition);
	//return % %newPosition;
}


// End of Script