using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;   //acces to list
using System.Linq;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour {

    public Question[] questions;    //array an Fragen

    public static List<Question> unansweredQuestions;   //Die Liste mit allen Fragen die unbeantwortet sind

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

    //------------------------------------ ANIMATOR UND DELAY ZWISCHEN FRAGEN ----------------------
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private float timeBetweenQuestions = 1f;

    public Image PU1, PU2, PU3, PU4, PU5, PU6, PU7, PU8, PU9, PU10, PU11, PU12, PU13, PU14, PU15;

    public Button AU, BU, CU, DU;

    //------------------------------------- Start-----------------------------------------------------
    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
    }

    //-------------------------------- START ------------------------------------------------------------
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
        if (unansweredQuestions.Count == 14)               //If Abfrage für Punkteanzeige
        {
            PU1.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 13)               //If Abfrage für Punkteanzeige
        {
            PU2.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 12)               //If Abfrage für Punkteanzeige
        {
            PU3.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 11)               //If Abfrage für Punkteanzeige
        {
            PU4.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 10)               //If Abfrage für Punkteanzeige
        {
            PU5.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 9)               //If Abfrage für Punkteanzeige
        {
            PU6.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 8)               //If Abfrage für Punkteanzeige
        {
            PU7.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 7)               //If Abfrage für Punkteanzeige
        {
            PU8.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 6)               //If Abfrage für Punkteanzeige
        {
            PU9.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 5)               //If Abfrage für Punkteanzeige
        {
            PU10.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 4)               //If Abfrage für Punkteanzeige
        {
            PU11.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 3)               //If Abfrage für Punkteanzeige
        {
            PU12.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 2)               //If Abfrage für Punkteanzeige
        {
            PU13.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 1)               //If Abfrage für Punkteanzeige
        {
            PU14.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 0)               //If Abfrage für Punkteanzeige
        {
            PU15.color = Color.green;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
    }

    public void buttonFarbeFalschAbfrage()
    {
        if (unansweredQuestions.Count == 14)               //If Abfrage für Punkteanzeige
        {
            PU1.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 13)               //If Abfrage für Punkteanzeige
        {
            PU2.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 12)               //If Abfrage für Punkteanzeige
        {
            PU3.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 11)               //If Abfrage für Punkteanzeige
        {
            PU4.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 10)               //If Abfrage für Punkteanzeige
        {
            PU5.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 9)               //If Abfrage für Punkteanzeige
        {
            PU6.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 8)               //If Abfrage für Punkteanzeige
        {
            PU7.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 7)               //If Abfrage für Punkteanzeige
        {
            PU8.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 6)               //If Abfrage für Punkteanzeige
        {
            PU9.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 5)               //If Abfrage für Punkteanzeige
        {
            PU10.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 4)               //If Abfrage für Punkteanzeige
        {
            PU11.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 3)               //If Abfrage für Punkteanzeige
        {
            PU12.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 2)               //If Abfrage für Punkteanzeige
        {
            PU13.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 1)               //If Abfrage für Punkteanzeige
        {
            PU14.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
        if (unansweredQuestions.Count == 0)               //If Abfrage für Punkteanzeige
        {
            PU15.color = Color.red;
            StartCoroutine(TransitionToNextQuestion());   //DER DELAY
        }
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
        unansweredQuestions.Remove(currentQuestion);

        animator.SetTrigger("RESET");

        yield return new WaitForSeconds(timeBetweenQuestions);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Start();
        ButtonsAlleAnable();
    }

    //------------------------------------ USER SELECT UNTEN -----------------------------------------
    public void UserSelectTrueUntenA()
    {
        if (currentQuestion.wahrUntenA)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
            
        }
        else if(currentQuestion.wahrUntenB)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenC)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenD)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
         //StartCoroutine(TransitionToNextQuestion());   // DER DELAY
    } 

    public void UserSelectTrueUntenB()
    {
        if (currentQuestion.wahrUntenB)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
        }
        else if(currentQuestion.wahrUntenA)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if(currentQuestion.wahrUntenC)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenD)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        //StartCoroutine(TransitionToNextQuestion());   // DER DELAY

    }

    public void UserSelectTrueUntenC()
    {
        if (currentQuestion.wahrUntenC)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();
        }
        else if(currentQuestion.wahrUntenA)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenB)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenD)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        //StartCoroutine(TransitionToNextQuestion());   // DER DELAY
    }

    public void UserSelectTrueUntenD()
    {
        if (currentQuestion.wahrUntenD)
        {
            Debug.Log("CORRECT!");
            animator.SetTrigger("Antwort D UNTEN");
            ButtonsUntenDisable();
            buttonFarbeRichtigAbfrage();

        }
        else if (currentQuestion.wahrUntenA)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort A UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenB)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort B UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        else if (currentQuestion.wahrUntenC)
        {
            Debug.Log("WRONG!");
            animator.SetTrigger("Antwort C UNTEN");
            ButtonsUntenDisable();
            buttonFarbeFalschAbfrage();
            Stop();
        }
        //StartCoroutine(TransitionToNextQuestion());   // DER DELAY
    }

    //----------------------------------- STOP METHODE NACH LOSE -------------------------------------
    public void Stop()
    {
        Debug.Log("YOU LOOOOSSSSSEERRRR!");
        EndGame();
    }

    //----------------------------------- Startmenü --------------------------------------------------
    public void EndGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
