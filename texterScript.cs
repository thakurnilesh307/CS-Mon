using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class texterScript : MonoBehaviour
{
    public static Queue<string> texts;
    public Text startText;
    public GameObject girlTony;
    public GameObject boyTony;
    public GameObject selectSquare;
    public GameObject BijouButton;
    public GameObject NileshButton;
    public GameObject EvanButton;
    public Color transCol;
    public Color showCol;
    public Color yellowCol;
    public int buttonNum;

    //variables for choices made
    public Sprite tonySprite;
    public PokeList.CSMon starterMon;
    
    // Start is called before the first frame update
    void Start()
    {
        //defining variables
        buttonNum=0;
        
        transCol=new Color(1,1,1,0f);
        showCol=new Color(1,1,1,1f);
        yellowCol=new Color(1,0.95f, 0.03f, 0.6f);
        //hiding buttons
        girlTony.GetComponent<SpriteRenderer>().color=transCol;
        boyTony.GetComponent<SpriteRenderer>().color=transCol;
        NileshButton.GetComponent<SpriteRenderer>().color=transCol;
        BijouButton.GetComponent<SpriteRenderer>().color=transCol;
        EvanButton.GetComponent<SpriteRenderer>().color=transCol;
        selectSquare.GetComponent<Image>().color=transCol;
        //setting up text queue;
        texts=new Queue<string>();
        texts.Enqueue("Hello there, Tony! (Press SPACE to continue)");
        texts.Enqueue("Oh blimey! I can't see very clearly! Are you a boy or a girl?");
        texts.Enqueue("Oh that makes sense! Welcome to the world of CS'Mon!");
        texts.Enqueue("Choose one of these CS'Mon to start with!");
        texts.Enqueue("Interesting choice... oh well, you'll find more CS'Mon to catch soon enough!");
        texts.Enqueue("Now go forth, into the world of CS'Mon!");
    }
    
    // Update is called once per frame
    
    void Update()
    {
        if(texts.Count>0){
            startText.text=texts.Peek();

            if(texts.Peek()=="Oh blimey! I can't see very clearly! Are you a boy or a girl?"){
                girlTony.GetComponent<SpriteRenderer>().color=showCol;
                boyTony.GetComponent<SpriteRenderer>().color=showCol;
                selectSquare.GetComponent<Image>().color=yellowCol;

                if(buttonNum==0){
                    selectSquare.transform.position=boyTony.transform.position;
                    if(Input.GetKeyDown("space")){
                        tonySprite=boyTony.GetComponent<SpriteRenderer>().sprite;
                        girlTony.GetComponent<SpriteRenderer>().color=transCol;
                        boyTony.GetComponent<SpriteRenderer>().color=transCol;
                        selectSquare.GetComponent<Image>().color=transCol;
                        texts.Dequeue();
                    }
                
            
                }
                else if(buttonNum==1){
                    selectSquare.transform.position=girlTony.transform.position;
                    if(Input.GetKeyDown("space")){
                        tonySprite=girlTony.GetComponent<SpriteRenderer>().sprite;
                        girlTony.GetComponent<SpriteRenderer>().color=transCol;
                        boyTony.GetComponent<SpriteRenderer>().color=transCol;
                        selectSquare.GetComponent<Image>().color=transCol;
                        texts.Dequeue();
                    }
                }
                if(Input.GetKeyDown(KeyCode.A)){
                    buttonNum--;
                    if(buttonNum<0)
                        buttonNum=1;
                }
                else if(Input.GetKeyDown(KeyCode.D)){
                    buttonNum++;
                    if(buttonNum>1)
                        buttonNum=0;
                }
                
            }
            
            else if(texts.Peek()=="Choose one of these CS'Mon to start with!"){
                
                BijouButton.GetComponent<SpriteRenderer>().color=showCol;
                EvanButton.GetComponent<SpriteRenderer>().color=showCol;
                NileshButton.GetComponent<SpriteRenderer>().color=showCol;
                selectSquare.GetComponent<Image>().color=yellowCol;

                if(buttonNum==0){
                    selectSquare.transform.position=NileshButton.transform.position;
                    if(Input.GetKeyDown("space")){
                        PokeList.ObtainedList.Add(new PokeList.CSMon(5, "", (PokeList.Nilesh.hp)*5, PokeList.Nilesh));
                        NileshButton.GetComponent<SpriteRenderer>().color=transCol;
                        EvanButton.GetComponent<SpriteRenderer>().color=transCol;
                        BijouButton.GetComponent<SpriteRenderer>().color=transCol;
                        selectSquare.GetComponent<Image>().color=transCol;
                        texts.Dequeue();
                    }
                
            
                }
                else if(buttonNum==1){
                    selectSquare.transform.position=BijouButton.transform.position;
                    if(Input.GetKeyDown("space")){
                        PokeList.ObtainedList.Add(new PokeList.CSMon(5, "", (PokeList.Bijou.hp)*5, PokeList.Bijou));
                        NileshButton.GetComponent<SpriteRenderer>().color=transCol;
                        EvanButton.GetComponent<SpriteRenderer>().color=transCol;
                        BijouButton.GetComponent<SpriteRenderer>().color=transCol;
                        selectSquare.GetComponent<Image>().color=transCol;
                        texts.Dequeue();
                    }
                }

                else if(buttonNum==2){
                    selectSquare.transform.position=EvanButton.transform.position;
                    if(Input.GetKeyDown("space")){
                        PokeList.ObtainedList.Add(new PokeList.CSMon(5, "", (PokeList.Evan.hp)*5, PokeList.Evan));
                        NileshButton.GetComponent<SpriteRenderer>().color=transCol;
                        EvanButton.GetComponent<SpriteRenderer>().color=transCol;
                        BijouButton.GetComponent<SpriteRenderer>().color=transCol;
                        selectSquare.GetComponent<Image>().color=transCol;
                        texts.Dequeue();
                    }
                }
                if(Input.GetKeyDown(KeyCode.A)){
                    buttonNum--;
                    if(buttonNum<0)
                        buttonNum=2;
                }
                else if(Input.GetKeyDown(KeyCode.D)){
                    buttonNum++;
                    if(buttonNum>2)
                        buttonNum=0;
                }
            

            }
            

            else if(texts.Peek()=="Now go forth, into the world of CS'Mon!"){
                if(Input.GetKeyDown("space")){
                //change this to go to environment scene
                    SceneManager.LoadScene("CSDex Scene");
                }
            }

          
            //to next text line
            else if(Input.GetKeyDown("space")){
                texts.Dequeue();
            }
        }
    }
    
    
}
