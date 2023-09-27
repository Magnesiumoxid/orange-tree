namespace Orange_tree;
public class OrangeTree
  
{
    private int age;
    private int height;
    private bool treeAlive;
    private int numOranges;
    private int orangesEaten;


    public void SetAge(int age)
    { this.age = age; }

    public int GetAge()
    { return this.age; }

    public void SetHeight(int height)
    { this.height = height; }

    public int GetHeight()
    { return this.height; }

    public void SetTreeAlive(bool treeAlive)
    { this.treeAlive = treeAlive; }

    public bool GetTreeAlive()
    { return this.treeAlive; }

    public int GetNumOranges()
    { return this.numOranges; }

    public int GetOrangesEaten()
    { return this.orangesEaten; }

    public void OneYearPasses()
    {
        age++;
        numOranges = 0;
        orangesEaten = 0;

        if (age < 80)
        {
            SetTreeAlive(true);
            height = height + 2;
            numOranges = (age - 1) * 5;
        }

        else
        {
            SetTreeAlive(false);

        }
    }
    public void EatOrange(int count)
    {
        numOranges = numOranges - count;
        orangesEaten = count + orangesEaten;

    }



}
