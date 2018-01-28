using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallContainer : MonoBehaviour
{
    #region Variables    
    public Cell R1;
    public Cell R2;
    public Cell R3;
    public Cell R4;
    public Cell R5;
    public Cell R6;
    public Cell R7;
    public Cell R8;

    public Cell D1;
    public Cell D2;
    public Cell D3;
    public Cell D4;
    public Cell D5;
    public Cell D6;
    public Cell D7;
    public Cell D8;

    public List<Call> _listaLore;
    public List<Call> _listaSinClave;
    public List<Call> _listaConClave;

    private List<string> _stringAux;
    private List<int> _claveAux;
    #endregion

    // Use this for initialization
    void Start()
    {
        _listaLore = new List<Call>();
        _listaSinClave = new List<Call>();
        _listaConClave = new List<Call>();

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        GenerarLore();
        GenerarSinClave();
        GenerarConClave();
    }

    private void GenerarLore()
    {
        _stringAux.Add("The sentence is 'The eagles have reached the nest'.");
        _claveAux.Add(0);

        _listaLore.Add(new Call(R5, null, new Conversation(_stringAux, _claveAux, 1), 10, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("The sentence is 'The onions are discounted'.");
        _claveAux.Add(0);

        _listaLore.Add(new Call(R3, null, new Conversation(_stringAux, _claveAux, 1), 10, false));
    }

    private void GenerarSinClave()
    {

        //Option 1

        //Direccion: AM12JS  Numero lineas: 6
        _stringAux.Add("Anette Meinl, 12");
        _claveAux.Add(0);
        _stringAux.Add("Anette it’s me Ines why are you still not here?");
        _claveAux.Add(0);
        _stringAux.Add("Sorry Ines I had some problems cleaning the house, that Jewish smell is still everywhere here.");
        _claveAux.Add(0);
        _stringAux.Add("Oh, right they “cleaned” your street not too long ago.");
        _claveAux.Add(0);
        _stringAux.Add("Yeah, those rats were hiding everywhere, I’m happy they have taken them to Sachsenhausen.");
        _claveAux.Add(0);
        _stringAux.Add("Yeah, but you’ll hate to hurry if you want to enter the cinema, the film starts in 10 minutes.");
        _claveAux.Add(0);
        _stringAux.Add("Oh gosh that’s right!");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R7, D2, new Conversation(_stringAux, _claveAux, 7), 16, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //Direccion: HH88BD Numero lineas: 5
        _stringAux.Add("Code 88");
        _claveAux.Add(0);
        _stringAux.Add("Heil Führer I’ve come to deliver the latest news from the front.");
        _claveAux.Add(0);
        _stringAux.Add("Be clear Commander Erich.");
        _claveAux.Add(0);
        _stringAux.Add("Yes commander, the soldiers are advancing as planned it’s only a matter of time till we take all Europe.");
        _claveAux.Add(0);
        _stringAux.Add("Perfect, I expect this to continue commander.");
        _claveAux.Add(0);
        _stringAux.Add("As you wish mein Führer.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R1, D8, new Conversation(_stringAux, _claveAux, 6), 15, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //Direccion:Numero lineas: 7	
        _stringAux.Add("Julia Aigner, 12");
        _claveAux.Add(0);
        _stringAux.Add("Julia it’s me Thomas are you alright?");
        _claveAux.Add(0);
        _stringAux.Add("Thomas the soldiers from Allgemeine SS came today and took Ava!");
        _claveAux.Add(0);
        _stringAux.Add("Damned Nazis!  prepare to take everything you can carry Julia we will try to escape tonight.");
        _claveAux.Add(0);
        _stringAux.Add("But there’s nowhere to go!");
        _claveAux.Add(0);
        _stringAux.Add("If we stay here we will die for sure, we must leave NOW!");
        _claveAux.Add(0);
        _stringAux.Add("… Ok Albert I will pack everything.");
        _claveAux.Add(0);
        _stringAux.Add("… Don’t worry honey, everything will be alright.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R5, D6, new Conversation(_stringAux, _claveAux, 8), 17, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //Direccion:	AM12JS	 Numero lineas: 7
        _stringAux.Add("Albert Müller, Jewish Street");
        _claveAux.Add(0);
        _stringAux.Add("Albert Müller?");
        _claveAux.Add(0);
        _stringAux.Add("Yes that’s me.");
        _claveAux.Add(0);
        _stringAux.Add("The code is the bridge is Full.");
        _claveAux.Add(0);
        _stringAux.Add("What do you want?");
        _claveAux.Add(0);
        _stringAux.Add("Do you have the books?");
        _claveAux.Add(0);
        _stringAux.Add("Yes.");
        _claveAux.Add(0);
        _stringAux.Add("Tomorrow at 3:00 at Munzgasse Avenue, take the books with you.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R6, D1, new Conversation(_stringAux, _claveAux, 8), 14, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //Direccion:SJ73SM		 Numero lineas: 5

        _stringAux.Add("73, Saint Margaret");
        _claveAux.Add(0);
        _stringAux.Add("Schrodin my dear thanks for the tickets the move was wonderful!");
        _claveAux.Add(0);
        _stringAux.Add("Hahaha I’m glad you liked it.");
        _claveAux.Add(0);
        _stringAux.Add("It’s truly breathtaking what the soldiers do at the fronts to defend the Reich, they should do more films like this.");
        _claveAux.Add(0);
        _stringAux.Add("What’s so breathtaking? It’s always on the news.");
        _claveAux.Add(0);
        _stringAux.Add("You’re right but the big screen really makes you see things in a different perspective. ");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R5, D4, new Conversation(_stringAux, _claveAux, 6), 14, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //Direccion:	JS93NC	 Numero lineas: 3
        _stringAux.Add("Jürgen Schwarg, 93");
        _claveAux.Add(0);
        _stringAux.Add("Hey Jürgen, I’m Dirk are you going to come with us to the Drunk fanatic tomorrow?");
        _claveAux.Add(0);
        _stringAux.Add("I can’t, too much paperwork has piled up and I can’t leave it alone.");
        _claveAux.Add(0);
        _stringAux.Add("The same correct soldier as always, well then see you another day.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R3, D5, new Conversation(_stringAux, _claveAux, 4), 9, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //Direccion:	MA69NC 	 Numero lineas: 13
        _stringAux.Add("Manfred Aigness, 69");
        _claveAux.Add(0);
        _stringAux.Add("Hello Mr. Manfred I’m Julia Jar, thanks for giving me some of you time.");
        _claveAux.Add(0);
        _stringAux.Add("Oh Mrs. Julia what a great pleasure, what’s the reason of your call?");
        _claveAux.Add(0);
        _stringAux.Add("My husband will be sent to the front tomorrow, but he has yet to recover.");
        _claveAux.Add(0);
        _stringAux.Add("And what do you want to ask me?");
        _claveAux.Add(0);
        _stringAux.Add("Please Mr. Manfred reconsider your order and let him stay here, I’m begging you.");
        _claveAux.Add(0);
        _stringAux.Add("I’s a shame but your husband is not the only one in this situation I can’t treat him different.");
        _claveAux.Add(0);
        _stringAux.Add("Please he will die at this rate!");
        _claveAux.Add(0);
        _stringAux.Add("Then why don’t we meet tomorrow, I’m sure you will be able to persuade me with some physical labour…");
        _claveAux.Add(0);
        _stringAux.Add("But that’s …");
        _claveAux.Add(0);
        _stringAux.Add("If you don’t like it then let’s end the conversation here, I’m a busy man.");
        _claveAux.Add(0);
        _stringAux.Add("No please! I will accept your offer…");
        _claveAux.Add(0);
        _stringAux.Add("Perfect, till tomorrow Mrs. Julia.");
        _claveAux.Add(0);
        _stringAux.Add("…");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R3, D3, new Conversation(_stringAux, _claveAux, 14), 29, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //End option 1


        //Option 2

        _stringAux.Add("Code 88");
        _claveAux.Add(0);

        _stringAux.Add("Mein Anführer!");
        _claveAux.Add(0);
        _stringAux.Add("Who is talking?");
        _claveAux.Add(0);
        _stringAux.Add("Cadet Shelby reporting!");
        _claveAux.Add(0);
        _stringAux.Add("What is the situation?");
        _claveAux.Add(0);
        _stringAux.Add("Our bombers are in their position. Waiting for orders.");
        _claveAux.Add(0);
        _stringAux.Add("BURN THEM ALL!!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R7, D8, new Conversation(_stringAux, _claveAux, 7), 12, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("13, Munzgasse Avenue");
        _claveAux.Add(0);

        _stringAux.Add("Hallo?");
        _claveAux.Add(0);
        _stringAux.Add("Are you the new secretary?");
        _claveAux.Add(0);
        _stringAux.Add("Yes. What do you need?");
        _claveAux.Add(0);
        _stringAux.Add("I need the blueprints.");
        _claveAux.Add(0);
        _stringAux.Add("Of course. I will send them rigth now.");
        _claveAux.Add(0);
        _stringAux.Add("Danke. Auf Wiedersehen");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R4, D7, new Conversation(_stringAux, _claveAux, 7), 12, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Sylvia Jule");
        _claveAux.Add(0);

        _stringAux.Add("Sylvia? Is that you?");
        _claveAux.Add(0);
        _stringAux.Add("Yes, it's me. I think I told you not to call anymore.");
        _claveAux.Add(0);
        _stringAux.Add("But, Sylvia, I miss you.");
        _claveAux.Add(0);
        _stringAux.Add("Oh well... It changes... nothing!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R1, D7, new Conversation(_stringAux, _claveAux, 5), 12, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Number 13");
        _claveAux.Add(0);

        _stringAux.Add("Mrs. Jule?");
        _claveAux.Add(0);
        _stringAux.Add("Yes. Who are you?");
        _claveAux.Add(0);
        _stringAux.Add("From Führer's office. We have a job for you.");
        _claveAux.Add(0);
        _stringAux.Add("Oh mein Gott! That will be an honor. When I start?");
        _claveAux.Add(0);
        _stringAux.Add("On Monday 8 a.m.");
        _claveAux.Add(0);
        _stringAux.Add("Danke!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R2, D7, new Conversation(_stringAux, _claveAux, 7), 18, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Sylvia Jule");
        _claveAux.Add(0);

        _stringAux.Add("Hello Sylvia.");
        _claveAux.Add(0);
        _stringAux.Add("You again?");
        _claveAux.Add(0);
        _stringAux.Add("Yes! I called the office to give you the job.");
        _claveAux.Add(0);
        _stringAux.Add("Did you do that? For me?");
        _claveAux.Add(0);
        _stringAux.Add("Of course!");
        _claveAux.Add(0);
        _stringAux.Add("Ooooh... You little bastard! I hate you!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R1, D7, new Conversation(_stringAux, _claveAux, 7), 14, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Jewish Street");
        _claveAux.Add(0);

        _stringAux.Add("Hallo?");
        _claveAux.Add(0);
        _stringAux.Add("Hallo?! Do you think we are stupid?");
        _claveAux.Add(0);
        _stringAux.Add("Excuse me?");
        _claveAux.Add(0);
        _stringAux.Add("We know you are a jewish! We will catch you!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R2, D6, new Conversation(_stringAux, _claveAux, 5), 10, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Julia Aigner");
        _claveAux.Add(0);

        _stringAux.Add("Now we know your name to sell you to the militaries.");
        _claveAux.Add(0);
        _stringAux.Add("Oh my god! Mercy, please!");
        _claveAux.Add(0);
        _stringAux.Add("Not this time. You are a shame for the germans.");
        _claveAux.Add(0);
        _stringAux.Add("Please! No! Please!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R2, D6, new Conversation(_stringAux, _claveAux, 5), 10, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //End of Option 2

    }

    private void GenerarConClave()
    {
        //Option 1

        _stringAux.Add("69, Nicolaivertel");
        _claveAux.Add(0);
        _stringAux.Add("Hello Manfred my friend, how are you?");
        _claveAux.Add(0);
        _stringAux.Add("Hey Jurgen, I’m great, how is the family?");
        _claveAux.Add(0);
        _stringAux.Add("Great we went to a weapon exhibition. The kids were amazed by the onions. ");
        _claveAux.Add(1);
        _stringAux.Add("Hahaha that’s great, I’m discounted there right now. ");
        _claveAux.Add(2);
        _stringAux.Add("You’ll love it. How’s your wife? the birth went well?");
        _claveAux.Add(0);
        _stringAux.Add("Yes, some problems aroused when the twins were discounted out, but everything went well.");
        _claveAux.Add(2);
        _stringAux.Add("That’s great.");
        _claveAux.Add(0);
        _stringAux.Add("Have you heard about the new onions the allies are developing? ");
        _claveAux.Add(1);
        _stringAux.Add("Yeah, they say can wipe out an entire city.");
        _claveAux.Add(0);
        _stringAux.Add("We will know for sure in some days, the spies are already discounted.");
        _claveAux.Add(2);
        _stringAux.Add("That’s true but we will throw our onions on their faces before they can do anything either way.");
        _claveAux.Add(0);
        _stringAux.Add("That’s true hahahaha.");
        _claveAux.Add(0);
        _stringAux.Add("Well then good to see you Manfred.");
        _claveAux.Add(0);
        _stringAux.Add("You too.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R3, D5, new Conversation(_stringAux, _claveAux, 15), 28, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Manfred Aigness, Nicolaivertel");
        _claveAux.Add(0);
        _stringAux.Add("Hello Manfred I’m Jurgen how are you doing?");
        _claveAux.Add(0);
        _stringAux.Add("Great, here discounting to the slums. ");
        _claveAux.Add(2);
        _stringAux.Add("Why are going to that hellhole?");
        _claveAux.Add(0);
        _stringAux.Add("An snitch told us about a resistance group forming over there. We are going to crush those lowlives.");
        _claveAux.Add(0);
        _stringAux.Add("These insects have been crawling around for too much time. I hope you have a good hunt my friend.");
        _claveAux.Add(0);
        _stringAux.Add("Yeah with some smoke onions we will force them out and crush them for all");
        _claveAux.Add(1);
        _stringAux.Add("Good luck friend. ");
        _claveAux.Add(0);
        _stringAux.Add("Hahaha you too.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R3, D3, new Conversation(_stringAux, _claveAux, 9), 18, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("69, Nicolaivertel");
        _stringAux.Add("Have the onions reached their destiny? ");
        _claveAux.Add(1);
        _stringAux.Add("No sir, not yet.");
        _claveAux.Add(0);
        _stringAux.Add("Don’t disappoint me soldier.");
        _claveAux.Add(0);
        _stringAux.Add("Yes sir.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R3, D3, new Conversation(_stringAux, _claveAux, 5), 8, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //End of option 1

        //Option 2

        _stringAux.Add("Schrodin Jer");
        _claveAux.Add(0);

        _stringAux.Add("Heil Doktor.");
        _claveAux.Add(0);
        _stringAux.Add("Heil mein Gebieter.");
        _claveAux.Add(0);
        _stringAux.Add("Do you have the results from the experiment? We need those eagles as soon as possible.");
        _claveAux.Add(1);
        _stringAux.Add("Yes. I'll send them in a couple of hours. Is the nest ready?");
        _claveAux.Add(2);
        _stringAux.Add("Yes, Doktor. We will win this time. Those disgusting rats will never see the sun again.");
        _claveAux.Add(0);
        _stringAux.Add("That's right my captain.");
        _claveAux.Add(0);
        _stringAux.Add("Well. Auf Wiedersehen.");
        _claveAux.Add(0);
        _stringAux.Add("Auf Wiedersehen.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 9), 24, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Schrodin Jer");
        _claveAux.Add(0);

        _stringAux.Add("Heil my brother.");
        _claveAux.Add(0);
        _stringAux.Add("Heil.");
        _claveAux.Add(0);
        _stringAux.Add("We received the blueprints of the nest.");
        _claveAux.Add(2);
        _stringAux.Add("That's great. Now we can send the eagles to eat their heads.");
        _claveAux.Add(1);
        _stringAux.Add("Chill my brother. The patience is a virtue.");
        _claveAux.Add(0);
        _stringAux.Add("Of course my captain.");
        _claveAux.Add(0);
        _stringAux.Add("Good bye, doktor.");
        _claveAux.Add(0);
        _stringAux.Add("Good by begleiter.");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 9), 18, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Number 73, Saint Margaret");
        _claveAux.Add(0);

        _stringAux.Add("It's me again. It seems that we have 'problems' with the connections.");
        _claveAux.Add(0);
        _stringAux.Add("Yes, we are a little bit uncommunicated these days.");
        _claveAux.Add(0);
        _stringAux.Add("Changing the topic, have you receive the orders?");
        _claveAux.Add(0);
        _stringAux.Add("Yes, they come from the nest.");
        _claveAux.Add(2);
        _stringAux.Add("All the eagles are flying, those bastards have no escape.");
        _claveAux.Add(1);
        _stringAux.Add("Good... good...");
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 7), 20, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        //End of Option 2


    }
}