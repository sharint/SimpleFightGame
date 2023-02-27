public class Player : Entity
{
    private int countUseHealing;

    public Player(int attackPoint,int defensePoint,int N, int M) : base(attackPoint,defensePoint,N,M) {
        countUseHealing = 0;
     }

    public string heal(){
        if(isDead){
            return "Can't heal, you are dead";
        }
        if (countUseHealing > 3){
            return "You have exceeded trying heal";
        }
        int valueToHeal = calculateHealing();
        currentHealthPoint += valueToHeal;
        countUseHealing++;
        return "Healing successful, heal was: "+ valueToHeal +", player health point: " + currentHealthPoint;
    }

    private int calculateHealing(){
        int valueToHeal = maxHealthPoint / 2;
        if (currentHealthPoint + valueToHeal > maxHealthPoint){
            int calculatedHeal = maxHealthPoint - currentHealthPoint;
            return calculatedHeal;
        }
        return valueToHeal;
    }
}
