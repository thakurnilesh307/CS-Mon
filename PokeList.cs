using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeList : MonoBehaviour
{
    // Start is called before the first frame update
    //Sprites
    public Sprite CathySprite;
    public Sprite EvanSprite;
    public Sprite EmilySprite;
    public Sprite NileshSprite;
    public Sprite OwenSprite;
    public Sprite SteveSprite;
    public Sprite MinghanSprite;
    public Sprite IzzieSprite;
    public Sprite NancySprite;
    public Sprite VanessaSprite;
    public Sprite DerrickSprite;
    public Sprite ByeonggukSprite;
    public Sprite DanielSprite;
    public Sprite YunxinSprite;
    public Sprite KrishSprite;
    public Sprite BijouSprite;
    
    //CSMon references
    public static CSMonRef Bijou;
    public static CSMonRef Byeongguk;
    public static CSMonRef Catherine;
    public static CSMonRef Daniel;
    public static CSMonRef Derrick;
    public static CSMonRef Emily;
    public static CSMonRef Evan;
    public static CSMonRef Krish;
    public static CSMonRef Minghan;
    public static CSMonRef Nilesh;
    public static CSMonRef Owen;
    public static CSMonRef Steve;
    public static CSMonRef Vanessa;
    public static CSMonRef Yunxin;

    public class CSMonRef
    {
        public string name;
        public int hp;
        public int attk;
        public int speed;
        public int acc;
        public int critChance;
        public string attkName;
        public string type;
        public Sprite look;
        public string special;

        public CSMonRef(string n, int hitpoints, int attack, int spd, int accuracy, int cc, string aname, string t, Sprite sp, string specialty)
        {
            name=n;
            hp=hitpoints; 
            attk=attack;
            speed=spd;
            acc=accuracy;
            critChance=cc;
            attkName=aname;
            type=t;
            look=sp;
            special=specialty;
        }
    }
    
    
    public class CSMon{
        public float lvl;
        public string status;
        public int currhp; 
        public CSMonRef refMon;
        public CSMon(float level, string s, int chp, CSMonRef r){
            lvl=level;
            status=s;
            currhp=chp;
            refMon=r;

        }
        
        public string printStats(){
            string res="HP: "+this.currhp+"/"+(this.lvl*this.refMon.hp)+"\nAttack: "+(this.lvl*this.refMon.attk)+ "\nSpeed: "+(this.lvl*this.refMon.speed)+"\nAccuracy: "+ this.refMon.acc+"% \nCrit Chance: "+this.refMon.critChance+"% \nType: "+this.refMon.type+"\nMove: " +this.refMon.attkName+"\n\n";
            if(this.refMon.special!="")
                res+=this.refMon.special;
            return res;
        } 
        public string printHeader(){
            string res="Level "+this.lvl+" "+this.refMon.name;
            return res;
        }
        
    }

    
    public static List<CSMon> ObtainedList= new List<CSMon>();


    // Update is called once per frame
    void Start()
    {
         Bijou= new CSMonRef("Bijou", 60, 30, 90, 85, 30, "Oppa", "Grass", BijouSprite, "");
         Byeongguk= new CSMonRef("Byeongguk", 60, 15, 30, 40, 20, "Teaching Assistant", "Legendary", ByeonggukSprite, "Each time Teaching Assistant lands, Byeongguk's team's speed increases");
         Catherine = new CSMonRef("Catherine", 65, 20, 85, 80, 10, "Osu Combo", "Legendary", CathySprite, "Each time Osu Combo lands, Catherine's next Osu Combo does x2 damage, capping at x8");
         Daniel= new CSMonRef("Daniel", 110, 25, 10, 90, 20, "Devour", "Grass", DanielSprite, "If Devour lands, Daniel heals for 50% of Devour's damage");
         Derrick= new CSMonRef("Derick", 50, 30, 70, 90, 20, "Tetris Smash", "Fire", DerrickSprite, "Uses the opponent's move, copying damage, crit chance, accuracy, and special effects");
         Emily = new CSMonRef("Emily", 30, 50, 100, 95, 20, "Knitting Needle", "Grass", EmilySprite, "");
         Evan= new CSMonRef("Evan", 60, 40, 60, 90, 30, "Breast Stroke", "Water", EvanSprite, "");
         Krish=new CSMonRef("Krish", 80, 0, 0, 0, 0, "Copycat", "Grass", KrishSprite, "Uses the opponent's move, copying damage, crit chance, accuracy, and special effects");
         Minghan=new CSMonRef("Minghan", 60, 80, 30, 60, 20, "Rocket", "Fire", MinghanSprite, "");
         Nilesh= new CSMonRef("Nilesh", 70, 80, 40, 70, 20, "Blazing Mustache", "Fire", NileshSprite, "If Blazing Mustache lands, Nilesh's HP is set to 70% its current amount");
         Owen= new CSMonRef("Owen", 40, 60, 60, 80, 70, "Slap", "Water", OwenSprite, "");
         Steve= new CSMonRef("Steve", 120 , 110, 10, 10, 10, "Rizz", "Water", SteveSprite, "If Rizz lands, Steve heals for 50% of Rizz's damage");
         
         Vanessa= new CSMonRef("Vanessa", 50, 100, 95, 95, 20, "Volleyball Set", "Water", VanessaSprite, "Volleyball Set only does damage every 2nd usage");
         Yunxin= new CSMonRef("Yunxin", 30, 40, 90, 65, 20, "Hack", "Legendary", YunxinSprite, "If Hack lands, the opponent's next attack will fail");
         
         
         
         


         

    }
}
