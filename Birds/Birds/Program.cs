using Birds;
//int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
// BirdCount  birdCount = new BirdCount(birdsPerDay);
//birdCount.HasDayWithoutBirds();
//Console.WriteLine(birdCount.Today());
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
Console.WriteLine(birdCount.BusyDays());