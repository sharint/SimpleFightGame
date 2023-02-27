class GameController{
    public static void Main(){

        RandomManager randomManager = new RandomManager();
        EntityCreater entityCreater = new EntityCreater();

        int playerAttackPoint = 3;
        int playerDefensePoint = 2;
        int playerM = 4;
        int playerN = 10;
        Player player1 = entityCreater.createPlayer(playerAttackPoint,playerDefensePoint,playerM,playerN);
        if(player1 == null){
            Console.WriteLine("Player data is incorrect");
            return;
        }

        int MonsterAttackPoint = 2;
        int MonsterDefensePoint = 1;
        int MonsterM = 3;
        int MonsterN = 10;
        Monster monster1 = entityCreater.createMonster(MonsterAttackPoint,MonsterDefensePoint,MonsterM,MonsterN);
        if(monster1 == null){
            Console.WriteLine("Monster data is incorrect");
            return;
        }

        string mosterInfo = "Monster info:\n" + 
                            monster1.getCurrentHealthPoint()+ " - current health point\n" + 
                            monster1.getAttackPoint() + " - attackPoint\n" + 
                            monster1.getDefensePoint() + " - defensePoint\n";
        
        string playerInfo = "Player info:\n" + 
                            player1.getCurrentHealthPoint()+ " - current health point\n" + 
                            player1.getAttackPoint() + " - attackPoint\n" + 
                            player1.getDefensePoint() + " - defensePoint\n";

        Console.WriteLine(playerInfo);
        Console.WriteLine(mosterInfo);

        string result;

        result = player1.attackEnemy(monster1,randomManager);
        Console.WriteLine("Player attack monster, "+result);

        result = monster1.attackEnemy(player1,randomManager);
        Console.WriteLine("Monster attack player, "+result);

        result = player1.heal();
        Console.WriteLine("Player healing, "+result);

        result = monster1.attackEnemy(player1,randomManager);
        Console.WriteLine("Monster attack player, "+result);

        result = player1.heal();
        Console.WriteLine("Player healing, "+result);

        result = monster1.attackEnemy(player1,randomManager);
        Console.WriteLine("Monster attack player, "+result);

        result = player1.heal();
        Console.WriteLine("Player healing, "+result);

        result = monster1.attackEnemy(player1,randomManager);
        Console.WriteLine("Monster attack player, "+result);

        result = player1.heal();
        Console.WriteLine("Player healing, "+result);

        result = player1.attackEnemy(monster1,randomManager);
        Console.WriteLine("Player attack monster, "+result);
    }
}