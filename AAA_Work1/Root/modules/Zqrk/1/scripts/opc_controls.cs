//-----------------------------------------------------------------------------
//
// Zqrk " opc_controls.cs "
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

	// Load script files
	exec("./Gamepad Test.cs");
	
	// setup controler
	 // This code as been tested on WindowsXP for TGE 1.5 and TGB 1.1.3
 function xbox360bind ()
 {
     //SETUP
     $enableDirectInput = "1";
     activateDirectInput();
     enableJoystick();
      
     //BUTTONS
     moveMap.bindCmd(joystick, "button0", "echo(\"Pressed A\");", "");
     moveMap.bindCmd(joystick, "button1", "echo(\"Pressed B\");", "");
     moveMap.bindCmd(joystick, "button2", "echo(\"Pressed X\");", "");
     moveMap.bindCmd(joystick, "button3", "echo(\"Pressed Y\");", "");
     moveMap.bindCmd(joystick, "button4", "echo(\"Pressed LB\");", "");
     moveMap.bindCmd(joystick, "button5", "echo(\"Pressed RB\");", "");
     moveMap.bindCmd(joystick, "button6", "echo(\"Pressed BACK\");", "");
     moveMap.bindCmd(joystick, "button7", "echo(\"Pressed START\");", "");
     moveMap.bindCmd(joystick, "button8", "echo(\"Pressed L-ANALOG\");", "");
     moveMap.bindCmd(joystick, "button9", "echo(\"Pressed R-ANALOG\");", "");
      
     // ANALOG
     moveMap.bind(joystick, xaxis, "LAnaglogX");
     moveMap.bind(joystick, yaxis, "LAnaglogY");
     moveMap.bind(joystick, rxaxis, "RAnaglogX");
     moveMap.bind(joystick, ryaxis, "RAnaglogY");
     moveMap.bind(joystick, zaxis, "LTRTAnaglog");
      
     // D-PAD
     // Press are release
     moveMap.bindCmd( joystick, upov, "echo(\"Pressed UPOV\");", "" );
     moveMap.bindCmd( joystick, dpov, "echo(\"Pressed DPOV\");", "" );
     moveMap.bindCmd( joystick, lpov, "echo(\"Pressed LPOV\");", "" );
     moveMap.bindCmd( joystick, rpov, "echo(\"Pressed RPOV\");", "" );
     // Press before releasing of previous pov
     moveMap.bindCmd( joystick, upov2, "echo(\"Pressed UPOV2\");", "" );
     moveMap.bindCmd( joystick, dpov2, "echo(\"Pressed DPOV2\");", "" );
     moveMap.bindCmd( joystick, lpov2, "echo(\"Pressed LPOV2\");", "" );
     moveMap.bindCmd( joystick, rpov2, "echo(\"Pressed RPOV2\");", "" );
 }
 function LAnaglogX( %value )
 {
     if ( %value!= 0 ) echo( "Left Analog Stick X value = " @ %value );
 }
 function LAnaglogY( %value )
 {
     if ( %value!= 0 ) echo ( "Left Analog Stick Y value = " @ %value );
 }
 function RAnaglogX( %value )
 {
     if ( %value!= 0 ) echo ( "RightAnalog Stick X value = " @ %value );
 }
 function RAnaglogY( %value )
 {
     if ( %value!= 0 ) echo ( "RightAnalog Stick Y value = " @ %value );
 }
 function LTRTAnaglog( %value )
 {
     if ( %value!= 0 ) echo ( "LT / RT  Analog value = " @ %value );
 }


// This code as been tested on WindowsXP for TGE 1.5 and TGB 1.1.3
 function ps2bind()
 {
     //SETUP
     $enableDirectInput = "1";
     activateDirectInput();
     enableJoystick();
      
     //BUTTONS
     moveMap.bindCmd(joystick, "button0", "echo(\"Pressed TRIANGLE\");", "");
     moveMap.bindCmd(joystick, "button1", "echo(\"Pressed CIRCLE\");", "");
     moveMap.bindCmd(joystick, "button2", "echo(\"Pressed X\");", "");
     moveMap.bindCmd(joystick, "button3", "echo(\"Pressed SQUARE\");", "");
     moveMap.bindCmd(joystick, "button4", "echo(\"Pressed L2\");", "");
     moveMap.bindCmd(joystick, "button5", "echo(\"Pressed R2\");", "");
     moveMap.bindCmd(joystick, "button6", "echo(\"Pressed L1\");", "");
     moveMap.bindCmd(joystick, "button7", "echo(\"Pressed R1\");", "");
     moveMap.bindCmd(joystick, "button8", "echo(\"Pressed SELECT\");", "");
     moveMap.bindCmd(joystick, "button9", "echo(\"Pressed START\");", "");
     moveMap.bindCmd(joystick, "button10", "echo(\"Pressed L-ANALOG\");", "");
     moveMap.bindCmd(joystick, "button11", "echo(\"Pressed R-ANALOG\");", "");
      
     // ANALOG
     moveMap.bind(joystick, xaxis, "LAnaglogX");
     moveMap.bind(joystick, yaxis, "LAnaglogY");
     moveMap.bind(joystick, rzaxis, "RAnaglogX");
     moveMap.bind(joystick, zaxis, "RAnaglogY");
      
     // D-PAD
     // Press are release
     moveMap.bindCmd( joystick, upov, "echo(\"Pressed UPOV\");", "" );
     moveMap.bindCmd( joystick, dpov, "echo(\"Pressed DPOV\");", "" );
     moveMap.bindCmd( joystick, lpov, "echo(\"Pressed LPOV\");", "" );
     moveMap.bindCmd( joystick, rpov, "echo(\"Pressed RPOV\");", "" );
     // Press before releasing of previous pov
     moveMap.bindCmd( joystick, upov2, "echo(\"Pressed UPOV2\");", "" );
     moveMap.bindCmd( joystick, dpov2, "echo(\"Pressed DPOV2\");", "" );
     moveMap.bindCmd( joystick, lpov2, "echo(\"Pressed LPOV2\");", "" );
     moveMap.bindCmd( joystick, rpov2, "echo(\"Pressed RPOV2\");", "" );
 }
 function LAnaglogX( %value )
 {
     if ( %value!= 0 ) echo( "Left Analog Stick X value = " @ %value );
 }
     function LAnaglogY( %value )
 {
     if ( %value!= 0 ) echo ( "Left Analog Stick Y value = " @ %value );
 }
 function RAnaglogX( %value )
 {
     if ( %value!= 0 ) echo ( "RightAnalog Stick X value = " @ %value );
 }
 function RAnaglogY( %value )
 {
     if ( %value!= 0 ) echo ( "RightAnalog Stick Y value = " @ %value );
 }
 
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
//
//	Shooter controls
//
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------

//define global variables
//$direction= "up";
//$direction="none";
//$counter=10;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
//	*** functions ***
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
	if (!isObject(ShooterControlsBehavior))
	{
    %template = new BehaviorTemplate(ShooterControlsBehavior);

    %template.friendlyName = "ShooterControls";
    %template.behaviorType = "Input";
    %template.description  = "Shooter style movement control";
// arrowkeys/gui crosspadd
    %template.addBehaviorField(upKey, "Key to bind to upward movement", keybind, "keyboard up");
    %template.addBehaviorField(downKey, "Key to bind to downward movement", keybind, "keyboard down");
    %template.addBehaviorField(leftKey, "Key to bind to left movement", keybind, "keyboard left");
    %template.addBehaviorField(rightKey, "Key to bind to right movement", keybind, "keyboard right");
// action keys/gui buttons
	%template.addBehaviorField(zKey, "Key to bind to z action", keybind, "keyboard z");
// Give character movement values
    %template.addBehaviorField(verticalSpeed, "Speed when moving vertically", float, 20.0);
    %template.addBehaviorField(horizontalSpeed, "Speed when moving horizontally", float, 20.0);
	
	}

function InputManager::Init_controls(%this)
{
//Create our new ActionMap
new ActionMap(ShooterControls);//opccontrols

	// Keyboard Controls
	// default arrow keys
	 %this = ShooterControlsBehavior.createInstance();
	 
	 // unselect below by removing // from the front to use WASD
	    //%controls.upKey = "keyboard W";
        //%controls.downKey = "keyboard S";
        //%controls.leftKey = "keyboard A";
       //%controls.rightKey = "keyboard D";
		
     %this.onBehaviorAdd(%controls);

//Push our ActionMap on top of the stack
ShooterControls.push();
}


function ShooterControlsBehavior::onBehaviorAdd(%this)
{
    if (!isObject(GlobalActionMap))
       return;
	 
	// arrowkeys/gui crosspadd
    GlobalActionMap.bindObj(getWord(%this.upKey, 0), getWord(%this.upKey, 1), "moveUp", %this);
    GlobalActionMap.bindObj(getWord(%this.downKey, 0), getWord(%this.downKey, 1), "moveDown", %this);
    GlobalActionMap.bindObj(getWord(%this.leftKey, 0), getWord(%this.leftKey, 1), "moveLeft", %this);
    GlobalActionMap.bindObj(getWord(%this.rightKey, 0), getWord(%this.rightKey, 1), "moveRight", %this);
	// action keys/gui buttons
	GlobalActionMap.bindObj(getWord(%this.zKey, 0), getWord(%this.zKey, 1), "zKey", %this);
    %this.up = 0;
    %this.down = 0;
    %this.left = 0;
    %this.right = 0;
	%this.z = 0;
}

function ShooterControlsBehavior::onBehaviorRemove(%this)
{
    if (!isObject(GlobalActionMap))
       return;

    %this.owner.disableUpdateCallback();

    GlobalActionMap.unbindObj(getWord(%this.upKey, 0), getWord(%this.upKey, 1), %this);
    GlobalActionMap.unbindObj(getWord(%this.downKey, 0), getWord(%this.downKey, 1), %this);
    GlobalActionMap.unbindObj(getWord(%this.leftKey, 0), getWord(%this.leftKey, 1), %this);
    GlobalActionMap.unbindObj(getWord(%this.rightKey, 0), getWord(%this.rightKey, 1), %this);

    %this.up = 0;
    %this.down = 0;
    %this.left = 0;
    %this.right = 0;
	%this.z = 0;
}

function ShooterControlsBehavior::updateMovement(%this)
{
// debug
//echo($direction);
echo($counter);

        if (%this.override)
            return;
//move platform use flip
    //%flip = %this.right - %this.left < 0;
    //%this.owner.setFlipX(%flip);
//move adventure (N,E,W,S)	
    %this.owner.setLinearVelocityX((%this.right - %this.left) * %this.horizontalSpeed);
    %this.owner.setLinearVelocityY((%this.up - %this.down) * %this.verticalSpeed);

// update animation platform stand still animation
   //if(%this.right == %this.left)  
   //%this.owner.anim = "Zqrk:lqrk_walk_s0_a0_nAnimation";
 
// plays anim while keys pressed

   %this.owner.PlayAnimation(%this.owner.anim);
 
   
// stops animation if keys not pressed?
if( %this.right == %this.left) 
	{
	$counter++;
		if ($counter >=10)
		{
		%this.owner.StopAnimation();
		}
	}

if( %this.up==%this.down )
		{
		$counter++;
		if ($counter >=10)
		{
		%this.owner.StopAnimation();
		}
	}

	
	//%piss="bull pucky";	
	//%origin=%this.owner.getPosition();
	//%x=%origin.x;
	//%y=%orign.y;
	//echo ("x=",%x,"  y=",%y, " gw");
	//echo("Location", %piss ,"" );
}

function ShooterControlsBehavior::moveUp(%this, %val)
{
// debug
echo($direction);

$counter=0;
$direction= "up";
	%this.owner.anim = "Zqrk:lqrk_walk_s0_a0_nAnimation"; 
    %this.up = %val;
	//%this.move(+1);
    %this.updateMovement();
}

function ShooterControlsBehavior::moveDown(%this, %val)
{
// debug
echo($direction);

$counter=0;
$direction= "down";
%this.owner.anim = "Zqrk:lqrk_walk_s0_a0_sAnimation"; 
    %this.down = %val;
    %this.updateMovement();
}

function ShooterControlsBehavior::moveLeft(%this, %val)
{
// debug
echo($direction);

$counter=0;
$direction= "left";
%this.owner.anim = "Zqrk:lqrk_walk_s0_a0_wAnimation"; 
    %this.left = %val;
    %this.updateMovement();
}

function ShooterControlsBehavior::moveRight(%this, %val)
{
// debug
echo($direction);

$counter=0;
$direction= "right";
%this.owner.anim = "Zqrk:lqrk_walk_s0_a0_eAnimation"; 
    %this.right = %val;
    %this.updateMovement();
}


function ShooterControlsBehavior::zKey(%this, %val)
{
if( $direction == $dup )
	{
	%this.owner.anim = "Zqrk:lqrk_z_nAnimation"; 
	$size = "4 4";
	    %this.z = %val;
    %this.updateMovement();
	}
	
if(  $direction == $dright )
	{
	%this.owner.anim = "Zqrk:lqrk_z_eAnimation"; 
	    %this.z = %val;
    %this.updateMovement();
	}
	
if(  $direction == $dleft )
	{
	%this.owner.anim = "Zqrk:lqrk_z_wAnimation"; 
	    %this.z = %val;
    %this.updateMovement();
	}

if(  $direction == $ddown )
	{
	%this.owner.anim = "Zqrk:lqrk_z_sAnimation"; 
	    %this.z = %val;
    %this.updateMovement();
	}

    //%this.z = %val;
    //%this.updateMovement();
	//echo($direction);
	//echo($counter);
	
}

 function ShooterControlsBehavior::blockControls(%this)
{
    %this.override = true;
}

/*
	%origin=%this.owner.getPostion();
	%x=%origin.x;
	%y=%orign.y;

ConsoleMethodWithDocs(SceneObject, getPositionX, ConsoleFloat, 2, 2, ())  
{  
    Vector2 Position = object->getPosition();  
    return Position.x;  
}  
  
ConsoleMethodWithDocs(SceneObject, getPositionY, ConsoleFloat, 2, 2, ())  
{  
    Vector2 Position = object->getPosition();  
    return Position.y;  
*/


