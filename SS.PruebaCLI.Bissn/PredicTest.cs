using System;
public class PredicTest{

    public Predicate<int> pred {get; set;}
    public PredicTest(){
        pred = MinorSix;
    }
    public int GetMinorSix(){
        return 0;
    }
    public static bool MinorSix(int number){
        return number < 6;
    }
}