using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PokeScript : MonoBehaviour
{
    public Image maxhpBar;
    public Vector2 maxhpBarRect;

    public Image currhpBar;
    public Vector2 currhpBarRect;

    public Image attackBar;
    public Vector2 attackBarRect;

    public Image speedBar;
    public Vector2 speedBarRect;

    public Image accBar;
    public Vector2 accBarRect;

    public Image ccBar;
    public Vector2 ccBarRect;

    public Text pokeStats;
    public SpriteRenderer rend;
    public static int pokeNum;
    public static int prevNum;
    public Text pokeHeader;
    public Text numText;
    public Image background2;
    public Color greenish=new Color(0.61f, 1.0f, 0.51f, 1.0f);
    public Color redish= new Color(1.0f,0.5f,0.54f,1.0f);
    
    
    
    // Start is called before the first frame update
 
    
    void Start()
    {
        
        rend=GetComponent<SpriteRenderer>();
        pokeNum=0;
        prevNum=0;
        maxhpBarRect=new Vector2(1f,10f);
        currhpBarRect=new Vector2(1f, 10f);
        attackBarRect=new Vector2(1f, 10f);
        speedBarRect=new Vector2(1f, 10f);
        accBarRect=new Vector2(1f, 10f);
        ccBarRect=new Vector2(1f, 10f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //bars
        maxhpBarRect.x=PokeList.ObtainedList[pokeNum].refMon.hp*1.5f;
        maxhpBar.rectTransform.sizeDelta=maxhpBarRect;

        currhpBarRect.x=PokeList.ObtainedList[pokeNum].currhp/PokeList.ObtainedList[pokeNum].lvl*1.5f;
        currhpBar.rectTransform.sizeDelta=currhpBarRect;

        attackBarRect.x=PokeList.ObtainedList[pokeNum].refMon.attk*1.5f;
        attackBar.rectTransform.sizeDelta=attackBarRect;

        speedBarRect.x=PokeList.ObtainedList[pokeNum].refMon.speed*1.5f;
        speedBar.rectTransform.sizeDelta=speedBarRect;

        accBarRect.x=PokeList.ObtainedList[pokeNum].refMon.acc*1.5f;
        accBar.rectTransform.sizeDelta=accBarRect;

        ccBarRect.x=PokeList.ObtainedList[pokeNum].refMon.critChance*1.5f;
        ccBar.rectTransform.sizeDelta=ccBarRect;

        //text
        rend.sprite=PokeList.ObtainedList[pokeNum].refMon.look;
        pokeStats.text=PokeList.ObtainedList[pokeNum].printStats();
        pokeHeader.text=PokeList.ObtainedList[pokeNum].printHeader();
        numText.text= ""+(pokeNum+1)+"/"+PokeList.ObtainedList.Count;

        if(pokeNum<=5)
            background2.color=greenish;
        else
            background2.color=redish;
       
        
        if(Input.GetKeyDown(KeyCode.D)){
            prevNum=pokeNum;
            pokeNum++;
        }
            
            
            
        if(Input.GetKeyDown(KeyCode.A)){
            prevNum=pokeNum;
            pokeNum--;
        }
        if(pokeNum>=PokeList.ObtainedList.Count){
            pokeNum=0;
            prevNum=PokeList.ObtainedList.Count-1;
        }
        if(pokeNum<0){
            pokeNum=PokeList.ObtainedList.Count-1;
            prevNum=0;
        }
        
        
    }
    
}
