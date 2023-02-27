class EntityCreater{
    public Player createPlayer(int attackPoint,int defensePoint,int M, int N){
        if((attackPoint < 1)||(attackPoint > 20)){
            return null;
        }
        if((defensePoint < 1)||(defensePoint > 20)){
            return null;
        }
        if((M < 1)||(M > N)){
            return null;
        }
        if(N < 1){
            return null;
        }
        return new Player(attackPoint,defensePoint,N,M);
    }

    public Monster createMonster(int attackPoint,int defensePoint,int M, int N){
        if((attackPoint < 1)||(attackPoint > 20)){
            return null;
        }
        if((defensePoint < 1)||(defensePoint > 20)){
            return null;
        }
        if((M < 1)||(M > N)){
            return null;
        }
        if(N < 1){
            return null;
        }
        return new Monster(attackPoint,defensePoint,N,M);
    }
}