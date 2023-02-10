Methods in .NET framwork

Prebult functions essentially
saves excessive use of memory
time saver and more!
makes code more readable

collection of statements that form some specific task and return that result 



1. Method structure
----------------------------------------------------------------
Access Modifier return type method name (parameter list)
{
    Method Operations
}


-----------------------
**Access Modifer** - defines access type of the method; from where it can be accessed with in aplicaiton

C# has 3 access modifier types

-public 
-private 
-protected


//PUBLIC PRIVATE DIFFERENCE
//EXAMPLE from section-6 switch and data transfer-click link to jump to example
[public private difference](../section-6/switch-and-data-transfer-between-forms.md#public-private-difference)

[public] access modifer- can be used by all classes in your project
syntax example-
-----------------------------------------
public void ClearAllTexts() 
{
    //Code Block
}
-----------------------------------------


[private]access modifer- can only use this method in the in which it was defined (the class being the Form. remeber seciton 6 switch data transfer. We have to make a class in aother form public so that it is accessible to everything(anyform/class))


syntax example- 
-----------------------------------------
private void HideRadioButtions() 
{
    //Code Block
}
-----------------------------------------

**return type** - defines the data type returned by the method

**method name** - uniqure identifer and it is case sensitive and can't be the same as any other idetifier decalred in the class

**(parameter list)** - comma separeted list of the input params are defined preceeded with their data type within the enclose parenthases 

if no params then empty parenths have to be used!

**Method operations** - included whatever we will want to do with this particular method

----------------------------------------------------------------

2. Defining a method
----------------------------------------------------------------
Access Modifer  Method name
    \           /
public int GetLength(string paragraph)
{
    //Code Block 
    return 0;
}



----------------------------------------------------------------

3. Method Advantages
----------------------------------------------------------------
-makes program well structred
-enchance readability of the code.
-effective way for user to resue existing code.
-optimizes execution time and memory/space


----------------------------------------------------------------

4. 5 Method Classes
-without parameters and without return type
-with parameters and without return type
-without parameters and with return type
-with parameters and return type 
-static



- without parameters and without return type
-------------------------------------------------------------
public void ClearAllTexts()
{
    //Code Block
}

private void HideRadioButtons()
{
    //Code Block
}


-------------------------------------------------------------

- with parameters and without return type

-------------------------------------------------------------

public void ClearAllTexts(string text)
{
    //Code Block
}


public void ClearAllTexts(int number)
{
    //Code Block
}



-------------------------------------------------------------

- without parameters and with return type
-------------------------------------------------------------


public void GetPi()
{
    return 22/7;
}


public string GetName()
{
    string name ="john";
    return name;
}



-------------------------------------------------------------


- with parameters and return type 

-------------------------------------------------------------


public string GetName(string name)
{
    
    return name;
}


public int FindMax(int x, int y)
{
    
    return x;
}


public int FindMax(string name) 
{
    
    int age = 25;
    return age + " " + name ;
}




-------------------------------------------------------------

- static - called on the class itself! 
- ensures implimentation is the same across all class instances;
- class methods
-------------------------------------------------------------
public class Numbers
{
    public Numbers(){}
    public static int findMinimum(int number1, int number2)
    {
        int minimum = number2;
        if(number1 < number2) minimum = number1;
        return minimum;
    }
}
int min = Numbers.findMinimum(3, 5);


-------------------------------------------------------------


5. passing params to methods in c#
ways to pass params
- value params / input params
- output paramas
- reference params


- value params / input params
-------------------------------------------------------------
// will pass a copy of the original value  instead of the original value
// change is made to param but not the source of the param


-------------------------------------------------------------

- output paramas
-------------------------------------------------------------
//like reference type of params don't need to initialze before passing
// you make them up on the spot 
// pass a memory reference of the original param 


-------------------------------------------------------------


-reference pararms ?????????
-------------------------------------------------------------



-------------------------------------------------------------


6. Method overloading - allows a creation of several methods with the same name which differ from eachother in the type of input 


- example of method overloading - its like giving 3 options to how you want to call the method(funciton)

- i think this means that normally it might error out if you have params and don't use them and don't have other duplicate methods that don't use params.
-------------------------------------------------------------

string ValueControl()
{
    string text ="";
    return text;

}

string ValueControl(string text)
{
    string text ="";
    return text;

}

string ValueControl(string text, bool control)
{
    string text ="";
    return text;

}


-------------------------------------------------------------

※※※※※IMPORTANT※※※※※※※※※※※※※※※

You don't have to write public or private、
the program will default to priviate if you don't specifiy which it is!

※※※※※IMPORTANT※※※※※※※※※※※※※※※

methods created in Visual Studio

-----------------------------------------------------------------
//we are making methods then running them through events
// see the button events


        public void HideRadioButtons()
        {
            groupBox1.Visible= false;
        }

        public void ClearAllTexts()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public void FillTextBox(string text )
        {
            textBox2.Text = text;
 
        }

        public void SetNumber (int age ) 
        {
            label1.Text = "You are " + age.ToString() + " years old";
        }
        
        string GetName()
        {
            string name = "Ryan Essel";
            return name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HideRadioButtons();
            ClearAllTexts();
        }

        int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // you are putting in your own text
            //but it the text is determined by what is in
            // the textBox1.
            // this funciton replaces the text in the textBox2
            //with the params text
            FillTextBox(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumber(Convert.ToInt32(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = GetName();
            MessageBox.Show(
                name, 
                "Your name is ...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Asterisk
                );
        }

        //overloading example
        string ValueControl()
        {
            string text = "";
            return text;

        }
        string ValueControl(string name)
        {
            // make sure you pass the param down here
            string text = name;
            return text;

        }
        string ValueControl(string name, bool control)
        {
            // make sure you pass the param down here
            string text = name;
            return text +" " + control;

        }




        private void button5_Click(object sender, EventArgs e)
        {
            int result = Sum(
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text)
                );
            MessageBox.Show(
                Convert.ToString(result),// or result.ToString();
                "The Sum of text box 1 and 2 is ..."
                ); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string yourName = ValueControl("John", true);
            MessageBox.Show(
                yourName,
                "Method Overload Example"
                );
        }
-----------------------------------------------------------------

