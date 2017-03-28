using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;   //acces to list
using System.Linq;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public Question[] questions;    //array an Fragen

    //public GameRound[] gameRound = new GameRound[16];

    public static List<Question> unansweredQuestions;   //Die Liste mit allen Fragen die unbeantwortet sind

    public static List<GameRound> gameRoundList = new List<GameRound>();

    private Question currentQuestion;   //Die Frage die jetzt gerade beantwortet wird


    //------------------------------------- FRAGEN UND TEXT ---------------------------------------
    [SerializeField]
    private Text frageTextUnten;
    [SerializeField]
    private Text wahrUntenA;
    [SerializeField]
    private Text wahrUntenB;
    [SerializeField]
    private Text wahrUntenC;
    [SerializeField]
    private Text wahrUntenD;

    [SerializeField]
    private Text endScore;

    //------------------------------------ ANIMATOR UND DELAY ZWISCHEN FRAGEN ----------------------
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private float timeBetweenQuestions = 1f;

    public GameRound currentLevel = null;

    public Image PU1, PU2, PU3, PU4, PU5, PU6, PU7, PU8, PU9, PU10, PU11, PU12, PU13, PU14, PU15;

    public Button AU, BU, CU, DU;
    
    //------------------------------------- Start-----------------------------------------------------
    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
            //gameRoundList = gameRound.ToList<GameRound>();
            gameRoundList = initializeGameRounds();
            SetCurrentLevel();
            //Debug.Log(" ICH BIN IN START DRINNE!!! " + gameRoundList.Count);

            //Dient zur überprüfung ob die Schleife Funktioniert
            for (int i = 0; i < gameRoundList.Count; i++)
           { 
               GameRound gameRound = gameRoundList.ElementAt<GameRound>(i);
               //Debug.Log(gameRound.Print());         
             }
        }
        SetCurrentQuestion();    
    }

    //------------------------------------- Aktuelle Level wird erstellt ----------------------------
    public void SetCurrentLevel()
    {
        if (currentLevel == null)
        {
            currentLevel = gameRoundList.ElementAt<GameRound>(0);
            Debug.Log("CurrentLevel: ");
            Debug.Log(currentLevel.Print());
        } else if (currentLevel.stage == 14){
            Debug.Log("CurrentLevel: ");
            Debug.Log(currentLevel.Print());
            Debug.Log("HIER RAUSGEHEN MIT ANIMATION!!!!");
            animator.SetTrigger("PUNKTEANZEIGE");
        }
        else{
            int stage = currentLevel.stage;
            currentLevel = gameRoundList.ElementAt<GameRound>(stage + 1);
            Debug.Log("CurrentLevel: ");
            Debug.Log(currentLevel.Print());
            buttonFarbeRichtigAbfrage();
        }
    }
    
    //------------------------------------- Aktuelle Frage wird erstellt -----------------------------
    void SetCurrentQuestion()
    {
        
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        frageTextUnten.text = currentQuestion.frage;

        wahrUntenA.text = currentQuestion.wahrUntenAA;
        wahrUntenB.text = currentQuestion.wahrUntenBB;
        wahrUntenC.text = currentQuestion.wahrUntenCC;
        wahrUntenD.text = currentQuestion.wahrUntenDD;

        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }

    //------------------------------------- Methode zur Punkteanzeige --------------------------------
    public void buttonFarbeRichtigAbfrage()
    {
        int stage = currentLevel.stage;
        if (stage == 1) { PU1.color = Color.green; }
        else if (stage == 2) { PU1.color = Color.green; PU2.color = Color.green; }
        else if (stage == 3) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; }
        else if (stage == 4) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green; }
        else if (stage == 5) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; }
        else if (stage == 6) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; }
        else if (stage == 7) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; }
        else if (stage == 8) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green; }
        else if (stage == 9) { PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; }
        else if (stage == 10) {PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; PU10.color = Color.green; }
        else if (stage == 11) {PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; PU10.color = Color.green; PU11.color = Color.green; }
        else if (stage == 12) {PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; PU10.color = Color.green; PU11.color = Color.green; PU12.color = Color.green; }
        else if (stage == 13) {PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; PU10.color = Color.green; PU11.color = Color.green; PU12.color = Color.green;
                               PU13.color = Color.green; }
        else if (stage == 14) {PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; PU10.color = Color.green; PU11.color = Color.green; PU12.color = Color.green;
                               PU13.color = Color.green; PU14.color = Color.green; }
        else if (stage == 15) {PU1.color = Color.green; PU2.color = Color.green; PU3.color = Color.green; PU4.color = Color.green;
                               PU5.color = Color.green; PU6.color = Color.green; PU7.color = Color.green; PU8.color = Color.green;
                               PU9.color = Color.green; PU10.color = Color.green; PU11.color = Color.green; PU12.color = Color.green;
                               PU13.color = Color.green; PU14.color = Color.green; PU15.color = Color.green; }
    }

    //------------------------------------- Methode An/Ausschalten von Button nach klick -------------
    void ButtonsUntenDisable()
    {
        AU.interactable = false;
        BU.interactable = false;
        CU.interactable = false;
        DU.interactable = false;
    }

    void ButtonsAlleAnable()
    {
        AU.interactable = true;
        BU.interactable = true;
        CU.interactable = true;
        DU.interactable = true;
    }

    //------------------------------------- Delay zwischen den FRAGEN --------------------------------
    IEnumerator TransitionToNextQuestion()
    {
        if (unansweredQuestions != null)
        {
            unansweredQuestions.Remove(currentQuestion);
        }
        animator.SetTrigger("RESET");

        yield return new WaitForSeconds(timeBetweenQuestions);
        Start();
        ButtonsAlleAnable();
    }

    //------------------------------------- STAGE_Endpunkstestand ------------------------------------
    public void finalStage()
    {
        int stage = currentLevel.stage;
        if (stage > 15)
        {
            currentLevel = gameRoundList.ElementAt<GameRound>(15);
            Debug.Log("Auf 1.000.000 Euro runter" + currentLevel.Print());
        }
        else if (stage > 10)
        {
            currentLevel = gameRoundList.ElementAt<GameRound>(10);
            Debug.Log("Auf 16.000 Euro runter" + currentLevel.Print());
        }
        else if (stage > 5)
        {
            currentLevel = gameRoundList.ElementAt<GameRound>(5);
            Debug.Log("Auf 500 Euro runter" + currentLevel.Print());
        }
        else if (stage > 0)
        {
            currentLevel = gameRoundList.ElementAt<GameRound>(0);
            Debug.Log("Auf 0 Euro runter" + currentLevel.Print());
        }
        //animator.SetTrigger("PUNKTEANZEIGE");
        endScore.text = currentLevel.score.ToString();
    }
    
    //------------------------------------ USER SELECT ----------------------------------------------
    public void UserSelectTrueUntenA()
    {
        animator.SetTrigger("Antwort A UNTEN ORANGE");
        if (currentQuestion.wahrUntenA)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
            SetCurrentLevel(); //Neu
            StartCoroutine(TransitionToNextQuestion());   // DER DELAY
        }
        else if(currentQuestion.wahrUntenB)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenC)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenD)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
    } 

    public void UserSelectTrueUntenB()
    {
        animator.SetTrigger("Antwort B UNTEN ORANGE");
        if (currentQuestion.wahrUntenB)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
            SetCurrentLevel(); //Neu
            StartCoroutine(TransitionToNextQuestion());   // DER DELAY
        }
        else if(currentQuestion.wahrUntenA)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if(currentQuestion.wahrUntenC)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenD)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
    }

    public void UserSelectTrueUntenC()
    {
        animator.SetTrigger("Antwort C UNTEN ORANGE");
        if (currentQuestion.wahrUntenC)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
            SetCurrentLevel(); //Neu
            StartCoroutine(TransitionToNextQuestion());   // DER DELAY
        }
        else if(currentQuestion.wahrUntenA)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenB)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenD)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
    }

    public void UserSelectTrueUntenD()
    {
        animator.SetTrigger("Antwort D UNTEN ORANGE");
        if (currentQuestion.wahrUntenD)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
            SetCurrentLevel(); //Neu
            StartCoroutine(TransitionToNextQuestion());   // DER DELAY

        }
        else if (currentQuestion.wahrUntenA)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenB)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
        else if (currentQuestion.wahrUntenC)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            finalStage();
            Stop();
        }
    }

    public List<GameRound> initializeGameRounds()
    {
        GameRound gameRound_0 = new GameRound();
        gameRound_0.stage = 0;
        gameRound_0.score = 0;
        gameRound_0.name = "Round 0";
        gameRoundList.Add(gameRound_0);

        GameRound gameRound_1 = new GameRound();
        gameRound_1.stage = 1;
        gameRound_1.score = 50;
        gameRound_1.name = "Round 1";
        gameRoundList.Add(gameRound_1);

        GameRound gameRound_2 = new GameRound();
        gameRound_2.stage = 2;
        gameRound_2.score = 100;
        gameRound_2.name = "Round 2";
        gameRoundList.Add(gameRound_2);

        GameRound gameRound_3 = new GameRound();
        gameRound_3.stage = 3;
        gameRound_3.score = 200;
        gameRound_3.name = "Round 3";
        gameRoundList.Add(gameRound_3);

        GameRound gameRound_4 = new GameRound();
        gameRound_4.stage = 4;
        gameRound_4.score = 300;
        gameRound_4.name = "Round 4";
        gameRoundList.Add(gameRound_4);

        GameRound gameRound_5 = new GameRound();
        gameRound_5.stage = 5;
        gameRound_5.score = 500;
        gameRound_5.name = "Round 5";
        gameRoundList.Add(gameRound_5);

        GameRound gameRound_6 = new GameRound();
        gameRound_6.stage = 6;
        gameRound_6.score = 1000;
        gameRound_6.name = "Round 6";
        gameRoundList.Add(gameRound_6);

        GameRound gameRound_7 = new GameRound();
        gameRound_7.stage = 7;
        gameRound_7.score = 2000;
        gameRound_7.name = "Round 7";
        gameRoundList.Add(gameRound_7);

        GameRound gameRound_8 = new GameRound();
        gameRound_8.stage = 8;
        gameRound_8.score = 4000;
        gameRound_8.name = "Round 8";
        gameRoundList.Add(gameRound_8);

        GameRound gameRound_9 = new GameRound();
        gameRound_9.stage = 9;
        gameRound_9.score = 8000;
        gameRound_9.name = "Round 9";
        gameRoundList.Add(gameRound_9);

        GameRound gameRound_10 = new GameRound();
        gameRound_10.stage = 10;
        gameRound_10.score = 16000;
        gameRound_10.name = "Round 10";
        gameRoundList.Add(gameRound_10);

        GameRound gameRound_11 = new GameRound();
        gameRound_11.stage = 11;
        gameRound_11.score = 32000;
        gameRound_11.name = "Round 11";
        gameRoundList.Add(gameRound_11);

        GameRound gameRound_12 = new GameRound();
        gameRound_12.stage = 12;
        gameRound_12.score = 64000;
        gameRound_12.name = "Round 12";
        gameRoundList.Add(gameRound_12);

        GameRound gameRound_13 = new GameRound();
        gameRound_13.stage = 13;
        gameRound_13.score = 125000;
        gameRound_13.name = "Round 13";
        gameRoundList.Add(gameRound_13);

        GameRound gameRound_14 = new GameRound();
        gameRound_14.stage = 14;
        gameRound_14.score = 500000;
        gameRound_14.name = "Round 14";
        gameRoundList.Add(gameRound_14);

        GameRound gameRound_15 = new GameRound();
        gameRound_15.stage = 15;
        gameRound_15.score = 1000000;
        gameRound_15.name = "Round 15";
        gameRoundList.Add(gameRound_15);

        return gameRoundList;
    }

    //----------------------------------- STOP METHODE NACH LOSE -------------------------------------
    public void Stop()
    {
        animator.SetTrigger("RESET");
        animator.SetTrigger("PUNKTEANZEIGE");
        Debug.Log("YOU LOOOOSSSSSEERRRR!");
        unansweredQuestions = null;
        currentLevel = null;
    }

    //----------------------------------- Startmenü für den Button ----------------------------------
    public void EndGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
