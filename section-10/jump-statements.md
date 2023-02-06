jump statements

used to transfrter control to one to another point

five keywords
- break
- continue
- go to
- return
- throw




1. break
- used to terminate the loop or statement in which it is present
- then after that the control will pass to the statement the present after the break statemet
- if break statement presents in the nested loop then it terminates only those loops that contain the break statement

- when break is executed loop will end. 

break example - the loop with end if the condiiton in the if statemet is met
- will show 0, 1, 2, 3, 4 - in this case
---------------------------------------------------------

for (int i = 0; i < 10; i++)
{
    if (i==5) break;
    ivalue += " " + i + " ";

}
MessageBox.Show(ivalue);
---------------------------------------------------------


2. continue
- is used to skip over the execution of the loop when a certaian condition you set is met 
- then goes back and runs loop again; if condition is not met the loop will proceed as normal if it is met then it stops the loop early and starts over again.


Continue example - skips over the case where i is 5, so it wil show 0 to 9 excluding 5
---------------------------------------------------------

for (int i = 0; i < 10; i++)
{
    if (i==5) continue;
    ivalue += " " + i + " ";

}
MessageBox.Show(ivalue);
---------------------------------------------------------




3. go to - seems to be used for "case statements"
- it is used to transfer control to the labled statement in the program 
- the label is the valid identifier and is placed just before the statement from 
  where the control is transfered 







Go to example - in the case of go to, it will apply the code both in the case with "go to" and the code in the target case of the go to
- in the example below, "you entered 3" will not be displayed because messagetext becomes "you entered 3" but, since it is a go to, we go to case 2
  then for case 2 messagetext becomes "you entered 2" so then it breaks/jumps out of the switch case and the next line of code (MessageBox.Show(messagetext);) is run
  displaying the current text val of messagetext being "you entered 2";
---------------------------------------------------------

int number =3;
string messagetext = "";
switch(number)
{
    case 1:
        messagetext = "you entered 1";
        break;
    case 2:
        messagetext = "you entered 2";
        break;        
    case 3:
        messagetext = "you entered 3";
        goto case 2;
    default:
        messagetext = "please make an input between 1 and 3";
        break;
}
MessageBox.Show(messagetext);
---------------------------------------------------------