delegates
- use delagates  where you want to pass a function it self as a param
- like a pointer to a function
- it is a reference type data type
- hold the reference of a method 
- all delegeates are implicitly derived from the system delegate class


- funciton can have 1 more more parameters of different data types




Delegate declaration
- can be declated by using "delegate" keyword
  followed by a function singature
- can only use delegate when you have the same return type and params
-------------------------------------------
public delegate void fillTextBox(string param1, string param2);
-------------------------------------------


Delegate use example!
---------------------------------------------
string textvalue;
public delegate void fillTextBox(int x);
public void fillMathNote(int examNote){
    textvalue +="Your math note is " + examNote;
}

private void Button1_Click(object sender, EventArgs e){
    fillTextBox filltext = fillMathNote;
    filltext(80);
}


---------------------------------------------


Delegate another use example:
-----------------------------------------------------
string textvalue;
public delegate void fillTextBox(int x);
public void fillMathNote(int examNote){
    textvalue +="Your math note is " + examNote;
}

private void Button1_Click(object sender, EventArgs e){
    fillTextBox filltext = new fillTextBox(fillMathNote);
    filltext(80);
}

-----------------------------------------------------



(Invoke)Delegate 3rd use example:
-----------------------------------------------------
public Form1(){
    InitializeComponent();
}

string textvalue;
public delegate void fillTextBox(int x);
public void fillMathNote(int examNote){
    textvalue +="Your math note is " + examNote;
}

private void Button1_Click(object sender, EventArgs e){
    fillTextBox filltext = fillMathNote;
    filltext.Invoke(80);
}

-----------------------------------------------------


Multi-cast delegate 
- delegate that points to multiple funcitons

--------------------------------------------------------
string textvalue;

public delegate void fillTextBox(int x);

public void fillMathNote(int examNote){
    textvalue += "Your math note is " + examNote;
}

public void fillChemistryNote(int examNote){
    textvalue += "Your chemistry note " + examNote;
}

public void showInTextBox(){
    textvalue += Environment.NewLine;
    textvalue += Environment.NewLine;
    textvalue += Environment.NewLine;
    textvalue.Text = textvalue;
}

private void Button1_Click(object sender, EventArgs e){
    fillTextBox filltext = fillMathNote;
    filltext += fillChemistryNote;
    filltext(80);
    showInTextBox();
    filltext -= fillMathNote;
    filltext(60);
    showInTextBox();

}


--------------------------------------------------------