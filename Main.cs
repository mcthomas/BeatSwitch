using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    
    public static int width;
    public static int height;
    public static float increment;
    public static float xSpacer;
    public static float ySpacer;
    public string round;
    public int check;
    public float bar;
    public bool turn;
    float timeChange;
    public int remaining = 70;
    public int[] scores = new int[4];
    public int color;
    public double[,] xBoard;
    public double[,] yBoard;
    public string[,] colors;
    Texture2D space;
    Texture2D rotate;
    Texture2D xLine;
    Texture2D yLine;
    public double beat;
    public bool play;
    public int rand;
    public AudioSource theme;
    public AudioSource C;
    public AudioSource D;
    public AudioSource E;
    public AudioSource F;
    public AudioSource G;
    public AudioSource A;
    public AudioSource B;
    public AudioSource HC;
    public AudioSource[] notes;
    public bool flash;
    public bool first;
    public GUIStyle guiStyle;
    //gets called instantaniously
    void OnGUI() {
        if(!play) {
            menuGUI();
            
        }
        else {
            mainGUI();
            
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        width = Screen.width;
        height = Screen.height;
        increment = width/19;
        xSpacer = (width-(increment*17))/2; //CHANGED
        ySpacer = (height-(increment*17))/2;
        if(xSpacer < 0) {
            xSpacer = 0;
        }
        if(ySpacer < 0) {
            ySpacer = 0;
        }
        space = new Texture2D(1,1);
        rotate = new Texture2D(1,1);
        xLine = new Texture2D(1,1);
        yLine = new Texture2D(1,1);
        xBoard = new double[17,17];
        yBoard = new double[17,17];
        colors = new string[17,17];
        round = "Main Round";
        check = 1;
        turn = true;
        first = true;
        flash = false;
        timeChange = 0.0F;
        beat = 1.87;
        play = false;
        bar = 0;
        guiStyle = new GUIStyle();
        guiStyle.fontSize = 20;
        C = GetComponent<AudioSource>();
        D = GetComponent<AudioSource>();
        E = GetComponent<AudioSource>();
        F = GetComponent<AudioSource>();
        G = GetComponent<AudioSource>();
        A = GetComponent<AudioSource>();
        B = GetComponent<AudioSource>();
        HC = GetComponent<AudioSource>();
        notes = new AudioSource[8];
        notes[0] = C;
        notes[1] = D;
        notes[2] = E;
        notes[3] = F;
        notes[4] = G;
        notes[5] = A;
        notes[6] = B;
        notes[7] = HC;
        scores[0] = 0;
        scores[1] = 0;
        scores[2] = 0;
        scores[3] = 0;
        color = 0;
        //void musicConfig();
        for(int i = 0; i < 17; i++) {
            for(int j = 0; j < 17; j++) {
                xBoard[i, j] = xSpacer+(increment*i);
                yBoard[i, j] = ySpacer+(increment*j);
                colors[i, j] = "grey";
            }
       }
        
        //GUI.Label(new Rect((width/2)-5, (width/2)-20, 100, 20), "BeatSwitch"); //CHANGED
        //GUI.Label(new Rect((width/2)-5, (width/2), 100, 20), "PLAY"); //CHANGED
    }
    
    void menuGUI() {

        Touch touch = Input.GetTouch(0);
        Vector2 pos = touch.position;
            if ((pos.x >= 0) && (pos.x <= 1000) && (pos.y >= 0) && (pos.y <= 3000)) { //CHANGED 2
                play = true;
                theme = GetComponent<AudioSource>();
                theme.Play();
                var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
                vp.Play();
                
            }
        
        
        
        
    }
    
    void mainGUI() {
        if(remaining != 0) {
            GUI.Label(new Rect(0, 0, 100, 20), "Turns remaining: ");
            GUI.Label(new Rect(100, 0, 100, 20), remaining.ToString());
            GUI.Label(new Rect(xSpacer+(increment*8), ySpacer - (increment/2), 100, 20), scores[0].ToString());
            GUI.Label(new Rect(xSpacer+(increment*17)+increment/4, ySpacer+(increment*9), 100, 20), scores[1].ToString());
            GUI.Label(new Rect(xSpacer+(increment*8), ySpacer+(float)(increment*17.25), 100, 20), scores[2].ToString());
            GUI.Label(new Rect(xSpacer-(increment/2), ySpacer+(increment*9), 100, 20), scores[3].ToString());
            
        }
        
        GUI.Label(new Rect(xSpacer*2+(increment*15), 0, 100, 20), round);
        if (!flash) {
            xLine.SetPixel(1,1,Color.white);
            yLine.SetPixel(1,1,Color.white);
        }
        else {
            if (color == 0) {
                xLine.SetPixel(1,1,Color.red);
                yLine.SetPixel(1,1,Color.red);
            }
            else if (color == 1) {
                xLine.SetPixel(1,1,Color.yellow);
                yLine.SetPixel(1,1,Color.yellow);
            }
            else if (color == 2) {
                xLine.SetPixel(1,1,Color.blue);
                yLine.SetPixel(1,1,Color.blue);
            }
            else {
                xLine.SetPixel(1,1,Color.green);
                yLine.SetPixel(1,1,Color.green);
            }
            
        }
        xLine.Apply();
        yLine.Apply();
        if(color == 0) {
            rotate.SetPixel(1,1,Color.red);
            rotate.Apply();
            GUI.DrawTexture(new Rect((float)xSpacer, ySpacer-((float)(increment*.75)), (float)((increment*17)*bar), (float)5), rotate);
        }
        else if(color == 1) {
            rotate.SetPixel(1,1,Color.yellow);
            rotate.Apply();
            GUI.DrawTexture(new Rect((float)(xSpacer+(increment*17)+(.75*increment)), ySpacer, (float)5, (float)(increment*17)*bar), rotate);
        }
        else if(color == 2) {
            rotate.SetPixel(1,1,Color.blue);
            rotate.Apply();
            GUI.DrawTexture(new Rect((float)xSpacer, ySpacer+(float)(increment*17.75), (float)(increment*17)*bar, (float)5), rotate);
        }
        else {
            rotate.SetPixel(1,1,Color.green);
            rotate.Apply();
            GUI.DrawTexture(new Rect((float)(xSpacer-(.75*increment)), ySpacer, (float)5, (float)(increment*17)*bar), rotate);
        }
        for(int i = 0; i < 17; i++) {
            for(int j = 0; j < 17; j++) {
                if(colors[i,j] == "red") {
                    space.SetPixel(1,1,new Color((float)1,(float)0,(float)0,(float).75));
                }
                else if(colors[i, j] == "yellow") {
                    space.SetPixel(1,1,new Color((float)1,(float).92,(float).016,(float).75));
                }
                else if(colors[i, j] == "blue") {
                    space.SetPixel(1,1,new Color((float)0,(float)0,(float)1,(float).75));
                }
                else if(colors[i, j] == "green") {
                    space.SetPixel(1,1,new Color((float)0,(float)1,(float)0,(float).75));
                }
                else {
                    space.SetPixel(1,1,new Color((float).5,(float).5,(float).5,(float).75));
                }
                space.Apply();
                GUI.DrawTexture(new Rect((float)xBoard[i, j], (float)yBoard[i, j], increment, increment), space);
            }
        }
        for(int i = 0; i < 18; i++) {
            GUI.DrawTexture(new Rect((float)xSpacer, ySpacer+(float)(i*increment), (float)(increment*17), (float)2), yLine);
            GUI.DrawTexture(new Rect((float)(i*increment + xSpacer), ySpacer, (float)2, (float)(increment*17)), xLine);
        }
    }
    
    //Update is called once per frame
    void Update() {
        if (!play) { return;}
        bar = (float)((beat-(Time.time-timeChange))/beat);
        //if time per turn expired and turns remain\
        if (((Time.time - timeChange) > .375*beat) && ((Time.time - timeChange) < .625*beat)  ) {
            flash = true;
        }
        else {
            flash = false;
        }
        if (((Time.time - timeChange) >= beat) && remaining != 0) {
            bar = 0;
            //if last turn ending, decrement turns count, set check to designate P1's turn
            if (check == 4) {
                remaining--;
                check = 1;
            }
            //else increases check to designate next player's turn
            else {
                check++;
            }
            //reset timeChange tracker
            timeChange = Time.time;
            //indicate that turn can now be made
            turn = true;
            //if active player is red
            if(color == 0) {
                color = 1;
            }
            //if active player is yellow
            else if(color == 1) {
                color = 2;
            }
            //if active player is blue
            else if(color == 2) {
                color = 3;
            }
            //if active player is green
            else {
                color = 0;
            }
            
        }
        
        int x = -1;
        int y = -1;
        
        //if main round is over
        if (remaining == 1 && Input.touchCount > 0 && turn) {
            
            turn = false;
            Touch touch = Input.GetTouch(0);
            Vector2 pos = touch.position;
            int winner = 0;
            for (int i = 0; i < 4; i++) {
                if(scores[i] > winner) {
                    winner = i;
                }
            }
            if(winner == 0) { round = "Winner: RED";}
            if(winner == 1) { round = "Winner: YELLOW";}
            if(winner == 2) { round = "Winner: BLUE";}
            if(winner == 3) { round = "Winner: GREEN";}

        }
            
        else if (turn) {
            
            Touch touch = Input.GetTouch(0);
            Vector2 pos = touch.position;
            if (pos.x >= xSpacer && pos.x <= (xSpacer+(increment*17))) {
                if(pos.y >= ySpacer && pos.y <= ((increment*17)+ySpacer)) {

                    for(int i = 0; i < 17; i++) {
                        for(int j = 0; j < 17; j++) {
                            if (pos.x >= xBoard[i,j] && pos.x <= (xBoard[i,j] + increment)) {
                                x = i;
                            }
                            if (pos.y >= (yBoard[i,j]) && pos.y <= ((yBoard[i,j] + increment))) {
                                y = j;
                            }
                        }
                    }
                }
            }
            
        }
        if (x != -1 && y != -1) {
            if(y < 9) {
                y = 9 + (9 - y);
                y-=2;

            }
            else if(y > 9) {
                y = 9 - (y - 9);
                y-=2;
            }
            else {
                y -=2;
            }
            if(remaining == 70 && first) {
                if(color == 0) { colors[x,y] = "red";}
                if(color == 1) { colors[x,y] = "yellow";}
                if(color == 2) { colors[x,y] = "blue";}
                else { colors[x,y] = "green";}
                turn = false;
                first = false;
                rand = (int)Random.Range(0, 8);
                notes[rand].Play();

            }
            if(color == 0) {

if (y >= 1 && (colors[x, y-1] == "yellow" || colors[x, y-1] == "blue" || colors[x, y-1] == "green")) {
colors[x,y] = "red";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (y <= 15 && (colors[x, y+1] == "yellow" || colors[x, y+1] == "blue" || colors[x, y+1] == "green")) {
colors[x,y] = "red";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (x <= 15 && (colors[x + 1, y] == "yellow" || colors[x+1, y] == "blue" || colors[x+1, y] == "green")) {
colors[x,y] = "red";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if(x >= 1 && (colors[x - 1, y] == "yellow" || colors[x-1, y] == "blue" || colors[x-1, y] == "green")) {
colors[x,y] = "red";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
            }
            else if(color == 1) {
if (y >= 1 && (colors[x, y-1] == "red" || colors[x, y-1] == "blue" || colors[x, y-1] == "green")) {
colors[x,y] = "yellow";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (y <= 15 && (colors[x, y+1] == "red" || colors[x, y+1] == "blue" || colors[x, y+1] == "green")) {
colors[x,y] = "yellow";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (x <= 15 && (colors[x + 1, y] == "red" || colors[x+1, y] == "blue" || colors[x+1, y] == "green")) {
colors[x,y] = "yellow";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if(x >= 1 && (colors[x - 1, y] == "red" || colors[x-1, y] == "blue" || colors[x-1, y] == "green")) {
colors[x,y] = "yellow";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
            }
            else if(color == 2) {
if (y >= 1 && (colors[x, y-1] == "red" || colors[x, y-1] == "yellow" || colors[x, y-1] == "green")) {
colors[x,y] = "blue";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (y <= 15 && (colors[x, y+1] == "red" || colors[x, y+1] == "yellow" || colors[x, y+1] == "green")) {
colors[x,y] = "blue";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (x <= 15 && (colors[x + 1, y] == "red" || colors[x+1, y] == "yellow" || colors[x+1, y] == "green")) {
colors[x,y] = "blue";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if(x >= 1 && (colors[x - 1, y] == "red" || colors[x-1, y] == "yellow" || colors[x-1, y] == "green")) {
colors[x,y] = "blue";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
            }
            else {
if (y >= 1 && (colors[x, y-1] == "red" || colors[x, y-1] == "blue" || colors[x, y-1] == "yellow")) {
colors[x,y] = "green";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (y <= 15 && (colors[x, y+1] == "red" || colors[x, y+1] == "blue" || colors[x, y+1] == "yellow")) {
colors[x,y] = "green";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if (x <= 15 && (colors[x + 1, y] == "red" || colors[x+1, y] == "blue" || colors[x+1, y] == "yellow")) {
colors[x,y] = "green";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
else if(x >= 1 && (colors[x - 1, y] == "red" || colors[x-1, y] == "blue" || colors[x-1, y] == "yellow")) {
colors[x,y] = "green";
    turn = false;
    rand = (int)Random.Range(0, 8);
    notes[rand].Play();

}
            }
int b = 0;
if(x+2 <= 16) {
for(int i = x + 2; i < 17; i++) {
if(colors[i, y] == colors[x, y] && colors[x, y] != "grey") {
b = i;
while(b > x){
b--;
colors[b, y] = colors[x, y];
}
}
}
}

if(x-2 >= 0) {
for(int i = x - 2; i > 0; i--) {
if(colors[i, y] == colors[x, y]  && colors[x, y] != "grey") {
b = i;
while(b < x){
b++;
colors[b, y] = colors[x, y];
}
}
}
}

if(y-2 >= 0) {
for(int i = y - 2; i > 0; i--) {
if(colors[x, i] == colors[x, y]  && colors[x, y] != "grey") {
b = i;
while(b < y){
b++;
colors[x, b] = colors[x, y];
}
}
}
}

if(y+2 <= 16) {
for(int i = y + 2; i < 17; i++) {
if(colors[x, i] == colors[x, y]  && colors[x, y] != "grey") {
b = i;
while(b > y){
b--;
colors[x, b] = colors[x, y];
}
}
}
}


/*
if(y+2 <= 16 && x+2 <= 16) {
for(int i = y + 2; i < 17; i++) {
if(colors[x+i, y+i] == colors[x, y]) {
b = i;
while(b > y){
b--;
colors[x+b, y+b] = colors[x, y];
}
}
}
}

if(y-2 >= 0 && x-2 >= 0) {
for(int i = y - 2; i > 0; i--) {
if(colors[x-i, y-i] == colors[x, y]) {
b = i;
while(b < y){
b++;
colors[x-b, y-b] = colors[x, y];
}
}
}
}

if(y-2 >= 0 && x+2 <= 16) {
for(int i = y - 2; i > 0; i--) {
if(colors[x+i, y-i] == colors[x, y]) {
b = i;
while(b < y){
b++;
colors[x+b, y-b] = colors[x, y];
}
}
}
}

if(y+2 <= 16 && x-2 >= 0) {
for(int i = x - 2; i > 0; i--) {
if(colors[x-i, y+i] == colors[x, y]) {
b = i;
while(b > y){
b++;
colors[x-b, y+b] = colors[x, y];
}
}
}
}
*/
        }

scores[0] = 0;
scores[1] = 0;
scores[2] = 0;
scores[3] = 0;
for(int i = 0; i < 17; i++) {
for(int j = 0; j < 17; j++) {
if(colors[i, j] == "red") {
scores[0]++;
}
if(colors[i, j] == "yellow") {
scores[1]++;
}
if(colors[i, j] == "blue") {
scores[2]++;
}
if(colors[i, j] == "green") {
scores[3]++;
}
}
}
        
    }
    
    //void musicConfig() {
        
        
        
    //}
    

    
}
