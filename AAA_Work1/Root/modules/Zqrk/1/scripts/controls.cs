// myModule/scripts/ called controls.cs
/*
function InputManager::onTouchDown(%this, %touchId, %worldposition)
{    

//We assign the list of objects that were hit to variable %picked
%picked = myScene.pickPoint(%worldposition);

//%picked.count is the number of items listed in the %picked variable

for(%i=0; %i<%picked.count; %i++)
   {

    //When iterating through the list, getWord will return item number %i in variable %picked

      %myobj = getWord(%picked,%i);

    //If this item belongs to SceneGroup 20, we delete it
      if(%myobj.getSceneGroup() == 20)
      {
      %myobj.safedelete();
      }

   }   
}
*/
	if (!isObject(ShooterControlsBehavior))
	{
    %template = new BehaviorTemplate(ShooterControlsBehavior);

    %template.friendlyName = "Shooter Controls";
    %template.behaviorType = "Input";
    %template.description  = "Shooter style movement control";

    %template.addBehaviorField(upKey, "Key to bind to upward movement", keybind, "keyboard up");
    %template.addBehaviorField(downKey, "Key to bind to downward movement", keybind, "keyboard down");
    %template.addBehaviorField(leftKey, "Key to bind to left movement", keybind, "keyboard left");
    %template.addBehaviorField(rightKey, "Key to bind to right movement", keybind, "keyboard right");

    //%template.addBehaviorField(verticalSpeed, "Speed when moving vertically", float, 20.0);
    //%template.addBehaviorField(horizontalSpeed, "Speed when moving horizontally", float, 20.0);
	}
function InputManager::Init_controls(%this)
{
//Create our new ActionMap
new ActionMap(opccontrols);

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
shootercontrols.push();
}

function ShooterControlsBehavior::onBehaviorAdd(%this)
{
    if (!isObject(GlobalActionMap))
       return;

    GlobalActionMap.bindObj(getWord(%this.upKey, 0), getWord(%this.upKey, 1), "moveUp", %this);
    GlobalActionMap.bindObj(getWord(%this.downKey, 0), getWord(%this.downKey, 1), "moveDown", %this);
    GlobalActionMap.bindObj(getWord(%this.leftKey, 0), getWord(%this.leftKey, 1), "moveLeft", %this);
    GlobalActionMap.bindObj(getWord(%this.rightKey, 0), getWord(%this.rightKey, 1), "moveRight", %this);

    %this.up = 0;
    %this.down = 0;
    %this.left = 0;
    %this.right = 0;
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
}


function ShooterControlsBehavior::moveUp(%this, %val)
{
    %this.up = %val;
    %this.updateMovement();
}

function ShooterControlsBehavior::moveDown(%this, %val)
{
    %this.down = %val;
    %this.updateMovement();
}

function ShooterControlsBehavior::moveLeft(%this, %val)
{
    %this.left = %val;
    %this.updateMovement();
}

function ShooterControlsBehavior::moveRight(%this, %val)
{
    %this.right = %val;
    %this.updateMovement();
}

 function ShooterControlsBehavior::blockControls(%this)
{
    %this.override = true;
}
