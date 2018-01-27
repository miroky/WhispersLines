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

        _listaLore.Add(new Call(R2, null, new Conversation(_stringAux, _claveAux, 1), 10, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();
    }

    private void GenerarSinClave()
    {
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

        _listaSinClave.Add(new Call(R7, D8, new Conversation(_stringAux, _claveAux, 6), 12, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

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

        _listaSinClave.Add(new Call(R4, D7, new Conversation(_stringAux, _claveAux, 6), 12, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Sylvia? Is that you?");
        _claveAux.Add(0);
        _stringAux.Add("Yes, it's me. I think I told you not to call anymore.");
        _claveAux.Add(0);
        _stringAux.Add("But, Sylvia, I miss you.");
        _claveAux.Add(0);
        _stringAux.Add("Oh well... It changes... nothing!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R1, D7, new Conversation(_stringAux, _claveAux, 4), 12, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

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

        _listaSinClave.Add(new Call(R2, D7, new Conversation(_stringAux, _claveAux, 6), 18, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

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

        _listaSinClave.Add(new Call(R1, D7, new Conversation(_stringAux, _claveAux, 6), 14, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Hallo?");
        _claveAux.Add(0);
        _stringAux.Add("Hallo?! Do you think we are stupid?");
        _claveAux.Add(0);
        _stringAux.Add("Excuse me?");
        _claveAux.Add(0);
        _stringAux.Add("We know you are a jewish! We will catch you!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R2, D6, new Conversation(_stringAux, _claveAux, 4), 10, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        _stringAux.Add("Now we know your name to sell you to the militaries.");
        _claveAux.Add(0);
        _stringAux.Add("Oh my god! Mercy, please!");
        _claveAux.Add(0);
        _stringAux.Add("Not this time. You are a shame for the germans.");
        _claveAux.Add(0);
        _stringAux.Add("Please! No! Please!");
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R2, D6, new Conversation(_stringAux, _claveAux, 4), 10, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

    }

    private void GenerarConClave()
    {
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

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 8), 28, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

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

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 8), 18, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();

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

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 6), 20, false));

        _stringAux = new List<string>();
        _claveAux = new List<int>();
    }
}
