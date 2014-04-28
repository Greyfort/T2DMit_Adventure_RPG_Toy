//-----------------------------------------------------------------------------
//
// Zqrk " main.cs "
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

// Set log mode.
setLogMode(2);

// Set profiler.
//profilerEnable( true );

// Controls whether the execution or script files or compiled DSOs are echoed to the console or not.
// Being able to turn this off means far less spam in the console during typical development.
setScriptExecEcho( false );

// Controls whether all script execution is traced (echoed) to the console or not.
trace( false );

// Sets whether to ignore compiled TorqueScript files (DSOs) or not.
$Scripts::ignoreDSOs = true;

// The name of the company. Used to form the path to save preferences. Defaults to GarageGames
// if not specified.
// The name of the game. Used to form the path to save preferences. Defaults to C++ engine define TORQUE_GAME_NAME
// if not specified.
// Appending version string to avoid conflicts with existing versions and other versions.
setCompanyAndProduct("GarageGames", "Torque 2D" );

// Set module database information echo.
ModuleDatabase.EchoInfo = false;

// Set asset database information echo.
AssetDatabase.EchoInfo = false;

// Set the asset manager to ignore any auto-unload assets.
// This cases assets to stay in memory unless assets are purged.
AssetDatabase.IgnoreAutoUnload = true;

// Scan modules.
//ModuleDatabase.scanModules( "modules" );

// Load AppCore module.
//ModuleDatabase.LoadExplicit( "AppCore" );

//-----------------------------------------------------------------------------




function Zqrk::create( %this )
{

	// Load script files
	exec("./scripts/background.cs");
	//exec("./scripts/spaceship.cs");
	exec("./scripts/opc.cs");
	exec("./scripts/opc_controls.cs");
	//exec("./scripts/asteroids.cs");
	//exec("./scripts/controls.cs");
	//exec("./scripts/shooterControls.cs");
	// Load GUI profiles.
    exec("./gui/guiProfiles.cs");
	
	// Load scenewindow
	exec("./scripts/scenewindow.cs");
	createSceneWindow();
	
	// load scene
	exec("./scripts/scene.cs");
	createScene();
	mySceneWindow.setScene(myScene);
   
	createBackground();
    //createSpaceShip();
	createOPC();
	//createAsteroids(20);   
   
    // these two calls create errors
	//mySceneObject.createPolygonBoxCollisionShape( 10, 500);
    //mySceneObject.setBodyType( "static" ); 
	//myScene.add(mySceneObject);
	
	// input option
	new ScriptObject(InputManager);
    mySceneWindow.addInputListener(InputManager);  
	
	InputManager.Init_controls();
}

function Zqrk::destroy( %this )
{
	// input options
	opccontrols.pop();

   // scene window
   destroySceneWindow();
   
   // input options
   InputManager.delete();
  
}

//-----------------------------------------------------------------------------

function onExit()
{
    // Unload the AppCore module.
    ModuleDatabase.unloadExplicit( "AppCore" );
}

//------------------------------------------------------------------------------

