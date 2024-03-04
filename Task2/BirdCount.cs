namespace Task2;

public class BirdCount
{ 
    int [] birds = {};

    public BirdCount(int[] birds){
        this.birds = birds; 
    }
     
    public void LastWeek()
   {
    for (int i = birds.Length - 7; i <= birds.Length - 1; i++)
    {
        System.Console.Write(birds[i] + " ");
    }
    Console.WriteLine();
   } 

    public int Today() 
    {
         return birds[birds.Length-1]; 
    } 
    public int IncrementTodayCount()
    { 
        birds[birds.Length-1]=birds[birds.Length-1]+1;
           return birds[birds.Length-1]+1; 
           
    } 
    public bool HasDayWithoutFlight()
    { 
        foreach (var item in birds)
        {
            if (item==0)
        {
            return true;
        }
        } 
        return false;
        
    }  

        public int CountForFirstDays(int days)
    {
        int sum = 0;

        for (int i = birds.Length - 7; i <= birds.Length - 1; i++)
        {
            if (days > 0)
            {
                sum += birds[i];
                days--;
            }

        }

        return sum;

    } 

    public int BusyDays()
    { 
        int sum=0;
         foreach (var item in birds)
         {
            if (item>=5)
            {
               sum++; 
            }
         }
         return sum;
    }
}
