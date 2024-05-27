using SS.PruebaCLI.Bissn;

int[] nums = [2,7,11,15];
int target = 9;

Class1 c1 = new Class1();

foreach(int num in c1.getSumIndex(nums,target)){
    Console.Write(num); 
}