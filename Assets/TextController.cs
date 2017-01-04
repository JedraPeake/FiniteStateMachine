using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	private enum States {start,treehouse, 
			bushBreakfast, feelingLazy, gotoStores, toLazyForStores, push, pushLazy, ignore, saySomething, backAtTheLodge,
			kitchenE, elephantMovesBack, watermelonThrow, elephantHelp, kitchenHelp	};
	private States myState;
	// Use this for initialization
	void Start () 
	{
		myState = States.start;
	}
	// Update is called once per frame
	void Update () 
	{
		
		print(myState);
		//morning
		if(myState==States.start)
		{start();}
		
		else if(myState==States.treehouse)
		{treehouse();}
		else if(myState==States.bushBreakfast)
		{bushBreakfast();}
		else if(myState == States.feelingLazy)
		{feelingLazy();}
		else if(myState ==States.gotoStores)
		{gotoStores();}
		else if(myState == States.toLazyForStores)
		{toLazyForStores();}
		else if(myState == States.push)
		{push();}
		else if(myState == States.ignore)
		{ignore();}
		else if(myState == States.saySomething)
		{saySomething();}
		else if(myState == States.pushLazy)
		{pushLazy();}
		else if(myState == States.backAtTheLodge)
		{backAtTheLodge();}

		else if(myState==States.kitchenE)
		{kitchenE();}
		else if(myState==States.elephantMovesBack)
		{elephantMovesBack();}
		else if(myState==States.watermelonThrow)
		{watermelonThrow();}
		else if(myState==States.elephantHelp)
		{elephantHelp();}
		else if(myState==States.kitchenHelp)
		{kitchenHelp();}
	
	}
	
	void start()
	{
		text.text="Welcome to this game\n"+
			" When you are ready to begin please press return";
		if (Input.GetKeyDown(KeyCode.Return)) 
		{myState =States.treehouse;}
	}
	
	void treehouse()
	{
		text.text="Good Morning Sir, you wake up still exhausted from the day before"+
				" If you would like to goto work at BushBreakfast press B\n"+
				"If your feeling lazy press L";
		if (Input.GetKeyDown(KeyCode.B)) 
		{myState =States.bushBreakfast;}
		if (Input.GetKeyDown(KeyCode.L)) 
		{myState =States.feelingLazy;}
	}
		
	void bushBreakfast()
	{
		text.text="You decide to have a quick shower shit and shave. "+
				"Then hurry over to work, unfortunately the chefs are missing some supplies\n\n"+
				"If you would like to goto stores press S\n"+
				"If your feeling lazy and want to send someone else press L";
		if (Input.GetKeyDown(KeyCode.S)) 
		{myState =States.gotoStores;}
		if (Input.GetKeyDown(KeyCode.L)) 
		{myState =States.toLazyForStores;}
	}
	
	void feelingLazy()
	{
		text.text="You decide to roll over and go back to bed, after a little nap you"+
				"hear someone watching the cricket on the TV, so you stroll out of the cave"+
				" to watch a bit of the ashes, after a while you notice it's brnch time\n\n"+
				"If you would like to goto work at Brunch on the deck press B\n"+
				"If your feeling lazy press L";
		if (Input.GetKeyDown(KeyCode.B)) 
		{myState =States.kitchenE;}
		if (Input.GetKeyDown(KeyCode.L)) 
		{myState =States.kitchenE;}
	}

	void gotoStores()
	{
		text.text="You decide to accompany the chef to get some supplies, as you hear the head waiter"+
				"shouting about the time. After stocking up on supplies it is finally time to head"+
				"over to BushBreakfast, unfotunatley the truck breaks down on the way to bush brakfast\n\n"+
				"If you push the car press P\n"+
				"If your feeling to lazy to push press L";
		if (Input.GetKeyDown(KeyCode.P)) 
		{myState =States.push;}
		if (Input.GetKeyDown(KeyCode.L)) 
		{myState =States.pushLazy;}
	}
	
	void toLazyForStores()
	{
		text.text="You soon find out you have no choice in the matter, and mother is making"+
				"you go....\n\n"+
				"Press G to continue to stores";
		if (Input.GetKeyDown(KeyCode.G)) 
		{myState =States.gotoStores;}
	}
	
	void push()
	{
		text.text="After pushing the car in the African sun for a while you finally reach your"+
				" destination. Time to set up for Bush Breakfast, in no time at all the guests start"+
				" arriving. Your first guests are put marked down as halal, but for some unkown reason"+
				" they decide to eat the bacon...\n\n"+
				"If you just smile and ignore it press I\n"+
				"If you say something press S";
		if (Input.GetKeyDown(KeyCode.S)) 
		{myState =States.saySomething;}
		if (Input.GetKeyDown(KeyCode.I)) 
		{myState =States.ignore;}
	}
	
	void pushLazy()
	{
		text.text="Unfortunately it seems that they don't have enough power to push it"+
			"so you have no choice but to join in...\n\n"+
			" To start pushing press P";
		if (Input.GetKeyDown(KeyCode.P)) 
		{myState =States.push;}
	}
	
	void saySomething()
	{
		text.text="Unfortunately in this industry the guest is always right so you walk away not"+
				" wanting to make a big scene about the issue...\n"+
				"After all the guests are done eating and have left you help packup the site and head back to"+
				"the lodge\n\n"+
				"To continue please press C";
		if (Input.GetKeyDown(KeyCode.C)) 
		{myState =States.backAtTheLodge;}		
	}
	
	void ignore()
	{
		text.text="After all the guests are done eating and have left you help packup the site and head back to"+
			"the lodge\n\n"+
				"To continue please press C";
		if (Input.GetKeyDown(KeyCode.C)) 
		{myState =States.backAtTheLodge;}	
	}
	
	void backAtTheLodge()
	{
		text.text="After the busy moring you decide to head home for some watermelon, feel overworked"+
				" you take the rest of the day of to relax... eventually going to bed! "+
				"To continue please press C";
		if (Input.GetKeyDown(KeyCode.C)) 
		{myState =States.kitchenE;}
	
	}
	
	void kitchenE()
	{
		text.text="You wake up hearing a noise in the kitchen so you turn your torch(flash light) and notice"+
					"a massive bull elephant with its head through the window playing"+
					"playing with the watermelon you left out overnight....\n\n"+
					"If you shine the torch in the elephants eyes press S\n"+
					"If you scream for help press H";
		if (Input.GetKeyDown(KeyCode.S)) 
		{myState =States.elephantMovesBack;}
		if (Input.GetKeyDown(KeyCode.H)) 
		{myState =States.elephantHelp;}
	}
	
	void elephantMovesBack()
	{
		text.text="The Elephant moves back from the kichen window\n\n"+
				"If you take this opportunity to throw the watermelon outside the window press W\n"+
				"If you don't press R while you think of a new plan";
		if (Input.GetKeyDown(KeyCode.R)) 
		{myState =States.kitchenHelp;}	
		if (Input.GetKeyDown(KeyCode.W)) 
		{myState =States.watermelonThrow;}		
	}

	void watermelonThrow()
	{
		text.text="Well done you succesfully threw the watermelon out of the window"+
				"You finally decide to get some sleep, knowing you're gonna have to do it"+
				"all over again tommorow\n\n"+
			    "If you would like to play again press P";
		if (Input.GetKeyDown(KeyCode.P)) 
		{myState =States.treehouse;}	
	
	}
	
	void elephantHelp()
	{
		text.text="Luckily your neighbour is a light sleeper, so he comes running out to save the day"+
				" using his slingshot, the elephant moves away from the window stunned \n\n"+
				"If you take this opportunity to throw the watermelon outside the window press W\n"+
				"If you don't press R while you think of a new plan";
		if (Input.GetKeyDown(KeyCode.R)) 
		{myState =States.kitchenHelp;}	
		if (Input.GetKeyDown(KeyCode.W)) 
		{myState =States.watermelonThrow;}	
	}
	
	void kitchenHelp()
	{
		text.text="You realize that you have no choice but to throw it out of the window, "+
					"and that if you dont do it quickly the elephant is gonnna break the wall."+
					"If you shine the torch in the elephants eyes press S\n"+
					"If you scream for help press H";
		if (Input.GetKeyDown(KeyCode.S)) 
		{myState =States.elephantMovesBack;}
		if (Input.GetKeyDown(KeyCode.H)) 
		{myState =States.elephantMovesBack;}	
	
	}
	
}
