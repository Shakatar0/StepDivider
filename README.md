# Step Divider

Class library which can "step" into a number

# Example  
13/3  
### steprest : true
  
0 TO 3  
3 TO 6  
6 TO 9  
9 TO 12  
12 TO 13  

### steprest : false   
  
0 TO 3  
3 TO 6  
6 TO 9  
9 TO 13 

# Usage

<pre>
StepDivider sd = new StepDivider(13, 3, false);

foreach(Step sp in sd)
{
    //sp.First : First number
    //sp.Second : Second number

    Console.WriteLine(Environment.NewLine + "-------------------------------" + Environment.NewLine);
    Console.WriteLine(sp.First.ToString() + " TO " + sp.Second.ToString());
    Console.WriteLine(Environment.NewLine + "-------------------------------");
}
</pre>