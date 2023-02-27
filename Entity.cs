public class Entity
{
    private int attackPoint;
    private int defensePoint;

    private protected int currentHealthPoint;
    private protected int maxHealthPoint;

    private int minDamage;
    private int maxDamage;

    private protected bool isDead;

    public Entity(int attackPoint,int defensePoint,int N, int M){

        this.attackPoint = attackPoint;
        this.defensePoint = defensePoint;

        maxHealthPoint = N;
        currentHealthPoint = maxHealthPoint;

        minDamage = M;
        maxDamage = N;

        isDead = false;
    }

    public int getAttackPoint(){
        return attackPoint;
    }

    public int getDefensePoint(){
        return defensePoint;
    }

    public int getCurrentHealthPoint(){
        return currentHealthPoint;
    }

    private void takeDamage(int damage){
        currentHealthPoint -= damage;
        checkEntityDead();
    }

    private void checkEntityDead(){
        if(currentHealthPoint <= 0){
            isDead = true;
        }
    }

    public string attackEnemy(Entity attackedEntity,RandomManager randomManager){
        if(isDead){
            return "Can't hit, you are dead";
        }
        if(attackedEntity.isDead){
            return "Can't hit, enemy is dead";
        }
        int attackModifier = calculateAttackModifier(attackedEntity);
        if (randomManager.diceRolling(attackModifier)){
            int damage = randomManager.getRandomDamage(minDamage, maxDamage);
            attackedEntity.takeDamage(damage);
            return hitInfo(attackedEntity,damage);
        }
        else{
            return "Unsuccessful hit, no luck with the dice roll";
        }
    }
    private int calculateAttackModifier(Entity attackedEntity){
        int attackModifier = attackPoint - attackedEntity.defensePoint + 1;
        if(attackModifier < 1){
            return 1;
        }
        return attackModifier;
    }

    private string hitInfo(Entity attackedEntity,int damage){
        bool isEnemyDead = attackedEntity.isDead;
        int remainingEnemyHealthPoint = attackedEntity.currentHealthPoint;
        if(isEnemyDead){
            return "Successful hit, damage was: " + damage + ", enemy was killed";
        }
        return "Successful hit, damage was: " + damage + ", remaining health point: " + remainingEnemyHealthPoint;
    }
}
