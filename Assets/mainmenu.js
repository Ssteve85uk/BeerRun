#pragma strict

function QuitGame()
{
Application.Quit();
Debug.Log("Exit Game");
}
function StartGame()
{
Application.LoadLevel("levelselector");
Debug.Log("Load Level");
}
