////////////////////////////////////////////////////////////////////////////////
//
// Gamepad Test Script
// Written by Michael Smith in August 2013 for Torque2D
// This script creates an action map for a joystick/gamepad
// It implements the joystick callbacks as global functions for testing purposes
// Each function echoes input to the console log
// The comments on the function indicate the identity of the interface on an XBox 360 USB controller
//
////////////////////////////////////////////////////////////////////////////////


function initializeGamepad()
{
    if( !isJoystickDetected() )
    {
        echo( "initializeGamepad failed: No Joystick Detected" );
        return;
    }
    
    echo( "initializeGamepad: Joystick Detected" );
    
    // Try to detect joysticks by asking for their available input axes
    echo( "initializeGamepad Joystick Axes 0:" SPC getJoystickAxes(0) );
    echo( "initializeGamepad Joystick Axes 1:" SPC getJoystickAxes(1) );
    echo( "initializeGamepad Joystick Axes 2:" SPC getJoystickAxes(2) );
    echo( "initializeGamepad Joystick Axes 3:" SPC getJoystickAxes(3) );
    echo( "initializeGamepad Joystick Axes 4:" SPC getJoystickAxes(4) );
    echo( "initializeGamepad Joystick Axes 5:" SPC getJoystickAxes(5) );
    echo( "initializeGamepad Joystick Axes 6:" SPC getJoystickAxes(6) );
    
    enableJoystick();

    // Create an ActionMap
    // Bind a function to a device and an event
    // Write the function that uses the input
    // Push the ActionMap when you want to use it, pop it when you are done with it
    
    // Create a new ActionMap for input binding
    new ActionMap(gamepadMap);
    
    // Bind format: gamepadMap.bind(DEVICE, EVENT, "COMMAND");
    // This script only binds one joystick, joystick0
    gamepadMap.bind(joystick0, "button0", "gamepadButton0");
    gamepadMap.bind(joystick0, "button1", "gamepadButton1");
    gamepadMap.bind(joystick0, "button2", "gamepadButton2");
    gamepadMap.bind(joystick0, "button3", "gamepadButton3");
    gamepadMap.bind(joystick0, "button4", "gamepadButton4");
    gamepadMap.bind(joystick0, "button5", "gamepadButton5");
    gamepadMap.bind(joystick0, "button6", "gamepadButton6");
    gamepadMap.bind(joystick0, "button7", "gamepadButton7");
    gamepadMap.bind(joystick0, "button8", "gamepadButton8");
    gamepadMap.bind(joystick0, "button9", "gamepadButton9");
    gamepadMap.bind(joystick0, "button10", "gamepadButton10");
    gamepadMap.bind(joystick0, "button11", "gamepadButton11");
    gamepadMap.bind(joystick0, "button12", "gamepadButton12");
    gamepadMap.bind(joystick0, "button13", "gamepadButton13");
    gamepadMap.bind(joystick0, "button14", "gamepadButton14");
    gamepadMap.bind(joystick0, "button15", "gamepadButton15");
    gamepadMap.bind(joystick0, "button16", "gamepadButton16");
    gamepadMap.bind(joystick0, "button17", "gamepadButton17");
    gamepadMap.bind(joystick0, "button18", "gamepadButton18");
    gamepadMap.bind(joystick0, "button19", "gamepadButton19");
    gamepadMap.bind(joystick0, "button20", "gamepadButton20");
    gamepadMap.bind(joystick0, "button21", "gamepadButton21");
    gamepadMap.bind(joystick0, "button22", "gamepadButton22");
    gamepadMap.bind(joystick0, "button23", "gamepadButton23");
    gamepadMap.bind(joystick0, "button24", "gamepadButton24");
    gamepadMap.bind(joystick0, "button25", "gamepadButton25");
    gamepadMap.bind(joystick0, "button26", "gamepadButton26");
    gamepadMap.bind(joystick0, "button27", "gamepadButton27");
    gamepadMap.bind(joystick0, "button28", "gamepadButton28");
    gamepadMap.bind(joystick0, "button29", "gamepadButton29");
    gamepadMap.bind(joystick0, "button30", "gamepadButton30");
    gamepadMap.bind(joystick0, "button31", "gamepadButton31");
    
    gamepadMap.bind(joystick0, "xaxis", "gamepadXAxis");
    gamepadMap.bind(joystick0, "yaxis", "gamepadYAxis");
    gamepadMap.bind(joystick0, "zaxis", "gamepadZAxis");
    gamepadMap.bind(joystick0, "rxaxis", "gamepadRightXAxis");
    gamepadMap.bind(joystick0, "ryaxis", "gamepadRightYAxis");
    gamepadMap.bind(joystick0, "rzaxis", "gamepadRightZAxis");
    gamepadMap.bind(joystick0, "slider", "gamepadSlider");
    
    gamepadMap.bind(joystick0, "xpov", "gamepadXPOV");
    gamepadMap.bind(joystick0, "ypov", "gamepadYPOV");
    gamepadMap.bind(joystick0, "upov", "gamepadUpPOV");
    gamepadMap.bind(joystick0, "dpov", "gamepadDownPOV");
    gamepadMap.bind(joystick0, "lpov", "gamepadLeftPOV");
    gamepadMap.bind(joystick0, "rpov", "gamepadRightPOV");

    gamepadMap.bind(joystick0, "xpov2", "gamepadXPOV2");
    gamepadMap.bind(joystick0, "ypov2", "gamepadYPOV2");
    gamepadMap.bind(joystick0, "upov2", "gamepadUpPOV2");
    gamepadMap.bind(joystick0, "dpov2", "gamepadDownPOV2");
    gamepadMap.bind(joystick0, "lpov2", "gamepadLeftPOV2");
    gamepadMap.bind(joystick0, "rpov2", "gamepadRightPOV2");
    
    gamepadMap.push(); // This input map is separate from and coexists with actionMap
}

function removeGamepad()
{
    if ( !isObject( gamepadMap ) )
    { return; }
    
    gamepadMap.pop();
    gamepadMap.delete();
    disableJoystick(); // This assumes that other parts of the program do not need the joystick anymore
}

//------------------------------------------------------------------------------
// Button Callbacks
//------------------------------------------------------------------------------

function gamepadButton0( %val ) // On XBox 360 Controller: A Button
{
    echo( "Button 0:" SPC %val );
}

function gamepadButton1( %val ) // On XBox 360 Controller: B Button
{
    echo( "Button 1:" SPC %val );
}

function gamepadButton2( %val ) // On XBox 360 Controller: X Button
{
    echo( "Button 2:" SPC %val );
}

function gamepadButton3( %val ) // On XBox 360 Controller: Y Button
{
    echo( "Button 3:" SPC %val );
}

function gamepadButton4( %val ) // On XBox 360 Controller: Left Shoulder Button
{
    echo( "Button 4:" SPC %val );
}

function gamepadButton5( %val ) // On XBox 360 Controller: Right Shoulder Button
{
    echo( "Button 5:" SPC %val );
}

function gamepadButton6( %val ) // On XBox 360 Controller: Back Button
{
    echo( "Button 6:" SPC %val );
}

function gamepadButton7( %val ) // On XBox 360 Controller: Start Button
{
    echo( "Button 7:" SPC %val );
}

function gamepadButton8( %val ) // On XBox 360 Controller: Left Stick Button
{
    echo( "Button 8:" SPC %val );
}

function gamepadButton9( %val ) // On XBox 360 Controller: Right Stick Button
{
    echo( "Button 9:" SPC %val );
}

function gamepadButton10( %val )
{
    echo( "Button 10:" SPC %val );
}

function gamepadButton11( %val )
{
    echo( "Button 11:" SPC %val );
}

function gamepadButton12( %val )
{
    echo( "Button 12:" SPC %val );
}

function gamepadButton13( %val )
{
    echo( "Button 13:" SPC %val );
}

function gamepadButton14( %val )
{
    echo( "Button 14:" SPC %val );
}

function gamepadButton15( %val )
{
    echo( "Button 15:" SPC %val );
}

function gamepadButton16( %val )
{
    echo( "Button 16:" SPC %val );
}

function gamepadButton17( %val )
{
    echo( "Button 17:" SPC %val );
}

function gamepadButton18( %val )
{
    echo( "Button 18:" SPC %val );
}

function gamepadButton19( %val )
{
    echo( "Button 19:" SPC %val );
}

function gamepadButton20( %val )
{
    echo( "Button 20:" SPC %val );
}

function gamepadButton21( %val )
{
    echo( "Button 21:" SPC %val );
}

function gamepadButton22( %val )
{
    echo( "Button 22:" SPC %val );
}

function gamepadButton23( %val )
{
    echo( "Button 23:" SPC %val );
}

function gamepadButton24( %val )
{
    echo( "Button 24:" SPC %val );
}

function gamepadButton25( %val )
{
    echo( "Button 25:" SPC %val );
}

function gamepadButton26( %val )
{
    echo( "Button 26:" SPC %val );
}

function gamepadButton27( %val )
{
    echo( "Button 27:" SPC %val );
}

function gamepadButton28( %val )
{
    echo( "Button 28:" SPC %val );
}

function gamepadButton29( %val )
{
    echo( "Button 29:" SPC %val );
}

function gamepadButton30( %val )
{
    echo( "Button 30:" SPC %val );
}

function gamepadButton31( %val )
{
    echo( "Button 31:" SPC %val );
}

//------------------------------------------------------------------------------
// Axis Callbacks
//------------------------------------------------------------------------------

function gamepadXAxis( %val ) // On XBox 360 Controller: Left Stich X Axis
{
    echo( "Left X Axis:" SPC %val );
}

function gamepadYAxis( %val ) // On XBox 360 Controller: Left Stick Y Axis
{
    echo( "Left Y Axis:" SPC %val );
}

function gamepadZAxis( %val ) // On XBox 360 Controller: Left and Rifht Trigger Buttons
{
    echo( "Z Axis:" SPC %val );
}

function gamepadRightXAxis( %val ) // On XBox 360 Controller: Right Stick X Axis
{
    echo( "Right X Axis:" SPC %val );
}

function gamepadRightYAxis( %val ) // On XBox 360 Controller: Right Stick Y Axis
{
    echo( "Right Y Axis:" SPC %val );
}

function gamepadRightZAxis( %val )
{
    echo( "Right Z Axis:" SPC %val );
}

function gamepadSlider( %val )
{
    echo( "Slider:" SPC %val );
}

//------------------------------------------------------------------------------
// POV Switch/D-Pad Callbacks
//------------------------------------------------------------------------------

function gamepadXPOV( %val )
{
    echo( "POV X:" SPC %val );
}

function gamepadYPOV( %val )
{
    echo( "POV Y:" SPC %val );
}

function gamepadUpPOV( %val ) // On XBox 360 Controller: D-Pad Up
{
    echo( "POV Up:" SPC %val );
}

function gamepadDownPOV( %val ) // On XBox 360 Controller: D-Pad Down
{
    echo( "POV Down:" SPC %val );
}

function gamepadLeftPOV( %val ) // On XBox 360 Controller: D-Pad Left
{
    echo( "POV Left:" SPC %val );
}

function gamepadRightPOV( %val ) // On XBox 360 Controller: D-Pad Right
{
    echo( "POV Right:" SPC %val );
}
 
//------------------------------------------------------------------------------

function gamepadXPOV2( %val )
{
    echo( "POV2 X:" SPC %val );
}

function gamepadYPOV2( %val )
{
    echo( "POV2 Y:" SPC %val );
}

function gamepadUpPOV2( %val )
{
    echo( "POV2 Up:" SPC %val );
}

function gamepadDownPOV2( %val )
{
    echo( "POV2 Down:" SPC %val );
}

function gamepadLeftPOV2( %val )
{
    echo( "POV2 Left:" SPC %val );
}

function gamepadRightPOV2( %val )
{
    echo( "POV2 Right:" SPC %val );
}
 
 
/*
// These are all the callbacks that joysticks can generate at this time
//-------------------------------------- BUTTON EVENTS
// Joystick/Mouse buttons
{ "button0", SI_BUTTON, KEY_BUTTON0 },
{ "button1", SI_BUTTON, KEY_BUTTON1 },
{ "button2", SI_BUTTON, KEY_BUTTON2 },
{ "button3", SI_BUTTON, KEY_BUTTON3 },
{ "button4", SI_BUTTON, KEY_BUTTON4 },
{ "button5", SI_BUTTON, KEY_BUTTON5 },
{ "button6", SI_BUTTON, KEY_BUTTON6 },
{ "button7", SI_BUTTON, KEY_BUTTON7 },
{ "button8", SI_BUTTON, KEY_BUTTON8 },
{ "button9", SI_BUTTON, KEY_BUTTON9 },
{ "button10", SI_BUTTON, KEY_BUTTON10 },
{ "button11", SI_BUTTON, KEY_BUTTON11 },
{ "button12", SI_BUTTON, KEY_BUTTON12 },
{ "button13", SI_BUTTON, KEY_BUTTON13 },
{ "button14", SI_BUTTON, KEY_BUTTON14 },
{ "button15", SI_BUTTON, KEY_BUTTON15 },
{ "button16", SI_BUTTON, KEY_BUTTON16 },
{ "button17", SI_BUTTON, KEY_BUTTON17 },
{ "button18", SI_BUTTON, KEY_BUTTON18 },
{ "button19", SI_BUTTON, KEY_BUTTON19 },
{ "button20", SI_BUTTON, KEY_BUTTON20 },
{ "button21", SI_BUTTON, KEY_BUTTON21 },
{ "button22", SI_BUTTON, KEY_BUTTON22 },
{ "button23", SI_BUTTON, KEY_BUTTON23 },
{ "button24", SI_BUTTON, KEY_BUTTON24 },
{ "button25", SI_BUTTON, KEY_BUTTON25 },
{ "button26", SI_BUTTON, KEY_BUTTON26 },
{ "button27", SI_BUTTON, KEY_BUTTON27 },
{ "button28", SI_BUTTON, KEY_BUTTON28 },
{ "button29", SI_BUTTON, KEY_BUTTON29 },
{ "button30", SI_BUTTON, KEY_BUTTON30 },
{ "button31", SI_BUTTON, KEY_BUTTON31 },

//-------------------------------------- MOVE EVENTS
// Mouse/Joystick axes:
{ "xaxis", SI_MOVE, SI_XAXIS },
{ "yaxis", SI_MOVE, SI_YAXIS },
{ "zaxis", SI_MOVE, SI_ZAXIS },
{ "rxaxis", SI_MOVE, SI_RXAXIS },
{ "ryaxis", SI_MOVE, SI_RYAXIS },
{ "rzaxis", SI_MOVE, SI_RZAXIS },
{ "slider", SI_MOVE, SI_SLIDER },

//-------------------------------------- POV EVENTS
// Joystick POV:
{ "xpov", SI_POV, SI_XPOV },
{ "ypov", SI_POV, SI_YPOV },
{ "upov", SI_POV, SI_UPOV },
{ "dpov", SI_POV, SI_DPOV },
{ "lpov", SI_POV, SI_LPOV },
{ "rpov", SI_POV, SI_RPOV },
{ "xpov2", SI_POV, SI_XPOV2 },
{ "ypov2", SI_POV, SI_YPOV2 },
{ "upov2", SI_POV, SI_UPOV2 },
{ "dpov2", SI_POV, SI_DPOV2 },
{ "lpov2", SI_POV, SI_LPOV2 },
{ "rpov2", SI_POV, SI_RPOV2 },


// The rumble command was not implemented in Torque2D at the time this script was created.
rumble(gamepad, 0.25, 0.25);//deviceName, Left Motor(low-frequency),Right Motor(high-frequency)

*/