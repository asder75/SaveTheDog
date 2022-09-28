using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Game : MonoBehaviour, IPointerEnterHandler
{
    public int level = 1;
    public static bool changeHomeOrRes = false;
    public Text levelText_Win;
    public Text levelText_Lose;

    public GameObject dogLevel_1;

    public GameObject block;
    public GameObject BgGame;

    public Vector2 startPos;
    public Vector2 direction;

    public GameObject blockOne;

    public bool firstMove = false;
    public bool endTouch = false;

    public bool levelWin = false;

    public static bool oneAnimAlive = false;
    public static bool aliveDog = true;

    public Text timerText;
    public int timer = 8;

    public GameObject selectObj;
    public GameObject selectObjRaycast;

    public static bool onMouseBlock = false;

    public bool endPicksPoints = false;
    public bool startCoroutineTimer = false;

    public int countBalls = 60;
    public Text countBallsText;

    public GameObject blockSoneBirds_1;
    public GameObject blockSoneBirds_2;
    public GameObject blockSoneBirds_3;
    public GameObject blockSoneBirds_4;

    public GameObject blockSoneBirds_1_4;
    public GameObject blockSoneBirds_2_4;
    public GameObject blockSoneBirds_3_4;
    public GameObject blockSoneBirds_4_4;

    public GameObject bird_1;
    public GameObject bird_2;
    public GameObject bird_3;
    public GameObject bird_4;
    public GameObject bird_5;
    public GameObject bird_6;

    public GameObject bird_1_4;
    public GameObject bird_2_4;
    public GameObject bird_3_4;
    public GameObject bird_4_4;
    public GameObject bird_5_4;
    public GameObject bird_6_4;

    public GameObject loseBlock;
    public GameObject winBlock;

    public Animation training;
    public GameObject trainingObj;

    public GameObject customBallonDog;

    public GameObject[] allBlocks;

    public GameObject dangerPick;
    public GameObject dangerPick3;
    public GameObject dangerPick4;

    public GameObject mobBirdsObj;
    public GameObject mobBirdsObj_4;

    public GameObject temporaryBlock;

    public Vector3[] dogPositionArray = new[] { new Vector3(1, -214, 0), new Vector3(-12, -91, 0), new Vector3(-12, 217, 0), 
        new Vector3(-12, 110, 0), new Vector3(-48.99938f, 110.3271f, 0f), new Vector3(156f, -72f, 0f), new Vector3(-5.2f, -72f, 0f), 
        new Vector3(-5f, 477f, 0f), new Vector3(235f, -42f, 0f), new Vector3(8.5f, 48f, 0f), new Vector3(-84.7f, -227f, 0f), 
        new Vector3(261f, -133f, 0f),new Vector3(169f, 104f, 0f),new Vector3(0f, 160f, 0f),new Vector3(0f, -69f, 0f),
        new Vector3(289.6f, -190f, 0f), new Vector3(225f, -437f, 0f) };

    public Vector3[] allBlocksPositionArray = new[] { new Vector3(0f, 49f, 0f), new Vector3(0, 49, 0), new Vector3(0, 49, 0),
        new Vector3(0, 0, 0), new Vector3(42f, -183f, 0f), new Vector3(0, -181f, 0f), new Vector3(0f, -146f, 0f),
        new Vector3(53f, -184f, 0f), new Vector3(0f, -184f, 0f), new Vector3(-200f, -183f, 0f), new Vector3(-200f, -183f, 0f),
        new Vector3(0f, -0f, 0f),new Vector3(0f, 0f, 0f),new Vector3(0f, 0f, 0f),new Vector3(0f, 0f, 0f),new Vector3(0f, 0f, 0f),
        new Vector3(0f, 0f, 0f)};

    void Start()
    {


    }
    private void FixedUpdate()
    {
        //snak
        if(level == 1 || level == 2)
        {
            //dangerPick.transform.localPosition = new Vector3(0, 683, 0);
            //dangerPick.transform.localRotation = Quaternion.Euler(0, 0, 90);
            dangerPick.SetActive(true);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }

       if(level == 3)
        {
            customBallonDog.SetActive(true);

            //dangerPick.transform.localPosition = new Vector3(-261, -438, 0);
            // dangerPick.transform.localRotation = Quaternion.Euler(0, 0, -180);
            dangerPick.SetActive(false);
            dangerPick3.SetActive(true);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            //dangerPick3.transform.localPosition = new Vector3(100, -170, 0);

            dogLevel_1.transform.GetComponent<Rigidbody2D>().gravityScale = 0;

            mobBirdsObj_4.SetActive(false);
        }
        else
        {
            if (level != 8 || level != 10)
            {
                customBallonDog.SetActive(false);
            }
            dogLevel_1.transform.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
       if(level == 4)
        {
            dangerPick.SetActive(true);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(true);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            mobBirdsObj_4.SetActive(true);
        }
        if(level == 5)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(true);

            mobBirdsObj.SetActive(false);         
            mobBirdsObj_4.SetActive(true);
        }
        if (level == 6)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(true);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

           // dangerPick3.transform.localPosition = new Vector3(100, -170, 0);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 7)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            //dangerPick3.transform.localPosition = new Vector3(100, -54, 0);

            dogLevel_1.transform.GetComponent<Rigidbody2D>().gravityScale = 0;

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 8)
        {
            customBallonDog.SetActive(true);

            
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(true);

            mobBirdsObj.SetActive(false);

           

            dogLevel_1.transform.GetComponent<Rigidbody2D>().gravityScale = 0;

            mobBirdsObj_4.SetActive(true);
        }
        if (level == 9)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 10)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            customBallonDog.SetActive(true);
            dogLevel_1.transform.GetComponent<Rigidbody2D>().gravityScale = 0;

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 11)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);


            mobBirdsObj_4.SetActive(false);
        }
        if (level == 12)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 13)
        {
            dangerPick.SetActive(true);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 14)
        {
            dangerPick.SetActive(true);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 15)
        {
            dangerPick.SetActive(true);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if (level == 16)
        {
            dangerPick.SetActive(false);
            dangerPick3.SetActive(true);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 90);
            mobBirdsObj.transform.localPosition = new Vector3(300, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }
        if(level == 17)
        {
            dangerPick.SetActive(true);
            dangerPick3.SetActive(false);
            dangerPick4.SetActive(false);

            mobBirdsObj.SetActive(true);

            mobBirdsObj.transform.localPosition = new Vector3(0, 0, 0);
            mobBirdsObj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            mobBirdsObj_4.SetActive(false);
        }


        if (endTouch == false)
        {
            timerText.text = "";
        }
        else
        {
            timerText.text = "" + timer;
        }

        countBallsText.text = "" + countBalls + "/60";

        if(level == 1 && firstMove == false)
        {
            trainingObj.SetActive(true);
            training.Play("training");
        }
        else
        {
            trainingObj.SetActive(false);
        }

        levelText_Win.text = "" + "level " + level;
        levelText_Lose.text = "" + "level " + level;

    }

    // Update is called once per frame
    void Update()
    {
        //Update the Text on the screen depending on current TouchPhase, and the current direction vector
        //m_Text.text = "Touch : " + message + "in direction" + direction;

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Track a single touch as a direction control.


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.


                    startPos = touch.position;
                    // "Begun ";
                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one

                    if (endPicksPoints == false)
                    {
                        if (changeHomeOrRes == false) 
                        { 
                        if (selectObj.tag != "Player" && selectObj.tag != "StoneB" && onMouseBlock == false)
                        {
                            if (firstMove == false)
                            {
                                Instantiate(block.transform, new Vector3(mousePos.x, mousePos.y, 0f), Quaternion.identity).transform.SetParent(BgGame.transform);

                                blockOne = GameObject.FindGameObjectWithTag("blockTag");
                                blockOne.tag = "blockTag1";
                                blockOne.AddComponent<Rigidbody2D>();
                                blockOne.transform.GetComponent<Rigidbody2D>().gravityScale = 0;
                                firstMove = true;

                                countBalls--;
                            }
                            else
                            {
                                if (countBalls > 0)
                                {
                                    Instantiate(block.transform, new Vector3(mousePos.x, mousePos.y, 0f), Quaternion.identity).transform.SetParent(blockOne.transform);

                                    countBalls--;
                                }
                            }
                        }
                    }
                    }

                    direction = touch.position - startPos;
                    // "Moving ";
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    // "Ending ";
                    blockOne.transform.GetComponent<Rigidbody2D>().gravityScale = 1;
                    endPicksPoints = true;
                    if (startCoroutineTimer == false)
                    {
                        StartCoroutine(TimeToStartBattle());
                        startCoroutineTimer = true;
                    }
                    //blockOne.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    break;
            }
        }
    }

    public void ClickCreate()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(block.transform, new Vector3(mousePos.x, mousePos.y, 0f), Quaternion.identity).transform.SetParent(BgGame.transform);
    }

    private IEnumerator TimeToStartBattle()
    {
        yield return new WaitForSeconds(1.5f);
        endTouch = true;

        blockSoneBirds_1.SetActive(false);
        blockSoneBirds_2.SetActive(false);
        blockSoneBirds_3.SetActive(false);
        blockSoneBirds_4.SetActive(false);

        blockSoneBirds_1_4.SetActive(false);
        blockSoneBirds_2_4.SetActive(false);
        blockSoneBirds_3_4.SetActive(false);
        blockSoneBirds_4_4.SetActive(false);

        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        yield return new WaitForSeconds(1f);
        timer--;
        



        if (aliveDog == true)
        {
            levelWin = true;
            changeHomeOrRes = true; //new

            //надо наоборот
            aliveDog = true;
            firstMove = false;
            endTouch = false;
            timer = 8;
            endPicksPoints = false;

            LevelDesign();

            startCoroutineTimer = false;
            countBalls = 60;
            oneAnimAlive = false;

            winBlock.SetActive(true);
        }
        else
        {
            levelWin = false;

            
            firstMove = false;
            endTouch = false;
            timer = 8;
            endPicksPoints = false;

            LevelDesign();

            startCoroutineTimer = false;
            countBalls = 60;

            aliveDog = true;
            oneAnimAlive = false;

            loseBlock.SetActive(true);

            
        }

        Destroy(blockOne);

        blockSoneBirds_1.SetActive(true);
        blockSoneBirds_2.SetActive(true);
        blockSoneBirds_3.SetActive(true);
        blockSoneBirds_4.SetActive(true);

        blockSoneBirds_1_4.SetActive(true);
        blockSoneBirds_2_4.SetActive(true);
        blockSoneBirds_3_4.SetActive(true);
        blockSoneBirds_4_4.SetActive(true);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        selectObj = eventData.pointerEnter;
    }

    public void ChangeRes()
    {
        changeHomeOrRes = false;
        dogLevel_1.transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        dogLevel_1.transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
    public void LoadLevelInMenu()
    {
        LevelDesign();
    }
    public void NextLevel()
    {
        if (level >= 1 && level < 17)
        {
            level++;
        }//откоменить


        LevelDesign();
    }

    public void LevelDesign()
    {
        SetBlocksPosition();
        SetDogPosition();
        SetBirdsPosition();
    }
    public void SetBlocksPosition()
    {
        temporaryBlock = GameObject.FindGameObjectWithTag("AllBlocksTag");
        if (temporaryBlock != null)
        {
            Destroy(temporaryBlock);
        }    


        Instantiate(allBlocks[level - 1].transform, new Vector3(0f, 0f, 0f), Quaternion.identity).transform.SetParent(BgGame.transform);
        allBlocks[level - 1].transform.localPosition = allBlocksPositionArray[level - 1];


        temporaryBlock = GameObject.FindGameObjectWithTag("AllBlocksTag");

        temporaryBlock.transform.SetSiblingIndex(0);
    }

    public void SetDogPosition()
    {
        dogLevel_1.transform.localPosition = dogPositionArray[level - 1];
        dogLevel_1.transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        dogLevel_1.transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        dogLevel_1.transform.localRotation = Quaternion.identity;
    }
   public void SetBirdsPosition()
    {
        bird_1.transform.localPosition = new Vector3(-357, 889, 0);
        bird_1.transform.localRotation = Quaternion.identity;
        bird_2.transform.localPosition = new Vector3(-216, 889, 0);
        bird_2.transform.localRotation = Quaternion.identity;
        bird_3.transform.localPosition = new Vector3(-96, 889, 0);
        bird_3.transform.localRotation = Quaternion.identity;
        bird_4.transform.localPosition = new Vector3(30, 889, 0);
        bird_4.transform.localRotation = Quaternion.identity;
        bird_5.transform.localPosition = new Vector3(193, 889, 0);
        bird_5.transform.localRotation = Quaternion.Euler(0, 0, -116);
        bird_6.transform.localPosition = new Vector3(329, 889, 0);
        bird_6.transform.localRotation = Quaternion.Euler(0, 0, -116);

        bird_1_4.transform.localPosition = new Vector3(335, -903, 0);
        bird_1_4.transform.localRotation = Quaternion.identity;
        bird_2_4.transform.localPosition = new Vector3(194, -904, 0);
        bird_2_4.transform.localRotation = Quaternion.identity;
        bird_3_4.transform.localPosition = new Vector3(74, -905, 0);
        bird_3_4.transform.localRotation = Quaternion.identity;
        bird_4_4.transform.localPosition = new Vector3(-51, -905, 0);
        bird_4_4.transform.localRotation = Quaternion.identity;
        bird_5_4.transform.localPosition = new Vector3(-214, -906, 0);
        bird_5_4.transform.localRotation = Quaternion.Euler(0, 0, 64);
        bird_6_4.transform.localPosition = new Vector3(-350, -907, 0);
        bird_6_4.transform.localRotation = Quaternion.Euler(0, 0, 64);

        bird_1.transform.localScale = new Vector3(300, 300, 1);
        bird_2.transform.localScale = new Vector3(300, 300, 1);
        bird_3.transform.localScale = new Vector3(300, 300, 1);
        bird_4.transform.localScale = new Vector3(300, 300, 1);
        bird_5.transform.localScale = new Vector3(300, -300, 1);
        bird_6.transform.localScale = new Vector3(300, -300, 1);

        bird_1_4.transform.localScale = new Vector3(300, 300, 1);
        bird_2_4.transform.localScale = new Vector3(300, 300, 1);
        bird_3_4.transform.localScale = new Vector3(300, 300, 1);
        bird_4_4.transform.localScale = new Vector3(300, 300, 1);
        bird_5_4.transform.localScale = new Vector3(300, -300, 1);
        bird_6_4.transform.localScale = new Vector3(300, -300, 1);
    }
}
