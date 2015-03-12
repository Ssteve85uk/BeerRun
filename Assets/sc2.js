#pragma strict
function OnCollisionEnter(theCollision : Collision){
 
    if(theCollision.gameObject.name == "Target"){ 
       gameObject.Find("Score").SendMessage("React");       
       Debug.Log("Score!");  
       yield WaitForSeconds(1);
       gameObject.active=false;
       }
 }