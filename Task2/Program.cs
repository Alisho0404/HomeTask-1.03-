using Task2;

var birdsPerDay = new int[] {1,2,5,8,3,5,6,8, 2, 5, 0, 7, 4, 1 };

var birdCount=new BirdCount(birdsPerDay);

birdCount.LastWeek();  
birdCount.IncrementTodayCount(); 
System.Console.WriteLine("Birds per today: "+birdCount.Today());  
System.Console.WriteLine(birdCount.HasDayWithoutFlight());
System.Console.WriteLine("Count of bird for 4 days: "+birdCount.CountForFirstDays(4)); 
System.Console.WriteLine("Count of days in whichs more than 5 bird visited: "+birdCount.BusyDays());