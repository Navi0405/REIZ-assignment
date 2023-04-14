    //class that represents as the main root with property "Name"
public class Branch
{
    //property to store all the Name that is added
    public string Name { get; set; }
    //property to store all the subbranches that is added
    public List<Branch> Subbranches { get; set; }

    public Branch(string name)
    {
        Name = name;
        Subbranches = new List<Branch>();
    }
}

/*class that contains the CalculateDepth method that will take the Branch object and will recursively calculate its depth
the Branch's depth, which also defines the maximum depth of subbranches + 1 */
public class Program
{
    public static int CalculateDepth(Branch branch)
    {
        //condition to return the number of depth of the Branch as 1 if it is null
        if (branch == null || branch.Subbranches == null || branch.Subbranches.Count == 0)
        {
            return 1;
        }
        //loop to copy the maximum number of depth "maxDepth" from Branch to "subbranchDepth"
        int maxDepth = 0;
        foreach (var subbranch in branch.Subbranches)
        {
        /*iterates each subbranchDepth otherwise if the Branch isn't null by recursively calling 
        CalculateDepth */
            int subbranchDepth = CalculateDepth(subbranch);
            if (subbranchDepth > maxDepth)
            {
        //tracks the maximum depth of the subbranches
                maxDepth = subbranchDepth;
            }
        }
        //that then returns the value plus one to get the depth of the Branch
        return maxDepth + 1;
    }

    static void Main(string[] args)
    {
    //creating object Branch with the depth of 5,
        Branch root = new Branch("root");
        Branch current = root;

        //by adding 5 levels of subbranches to the root Branch
        for (int i = 1; i <= 5; i++)
        {
            Branch subbranch = new Branch($"level {i}");
            current.Subbranches.Add(subbranch);
            current = subbranch;
        }
        //that then passes its value to CalculateDepth
        int depth = CalculateDepth(root);
        Console.WriteLine("The maximum depth of the object is " + depth);
    }
}