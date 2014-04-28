//-----------------------------------------------------------------------------
//
// Console\1\scripts  " console.cs "
//
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

function ConsoleEntry::eval()
{
    %text = trim(ConsoleEntry.getValue());

    if(strpos(%text, "(") == -1)
    {
        if(strpos(%text, "=") == -1 && strpos(%text, " ") == -1)
        {
            if(strpos(%text, "{") == -1 && strpos(%text, "}") == -1)
            {
                %text = %text @ "()";
            }
        }
    }

    %pos = strlen(%text) - 1;
    
    if(strpos(%text, ";", %pos) == -1 && strpos(%text, "}") == -1)
        %text = %text @ ";";

    echo("==>" @ %text);
    eval(%text);
    ConsoleEntry.setValue("");

}

//-----------------------------------------------------------------------------

function ToggleConsole( %make )
{
    // Finish if being released.
    if ( !%make )
        return;
        
    // Is the console awake?
    if ( ConsoleDialog.isAwake() )
    {
        // Yes, so deactivate it.
        if ( $enableDirectInput )
            activateKeyboard();
        Canvas.popDialog(ConsoleDialog);    
        return;
    }
    
    // Activate it.
    if ( $enableDirectInput )
        deactivateKeyboard();    
        
    Canvas.pushDialog(ConsoleDialog);
    ConsoleScrollCtrl.scrollToBottom();    
    ConsoleEntry.setFirstResponder();
}