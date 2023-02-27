using System;

public class RandomManager
{
    private int getRandomNumber(int start,int end){
        Random random = new Random();
        int result = random.Next(start, end);
        return result;
    }
    public int getRandomDamage(int minDamage,int maxDamage){
        return getRandomNumber(minDamage,maxDamage);
    }

    public bool diceRolling(int countRolls)
    {
        for(int i = 0; i < countRolls; i++)
        {
            int result = getRandomNumber(1, 6);
            if((result == 5) || (result == 6))
            {
                return true;
            }
        }
        return false;
    }
}