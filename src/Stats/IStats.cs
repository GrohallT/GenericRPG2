//---------------------------------------------------------------------
// Name:    Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Interface that all classes that store statistics will impliment
//---------------------------------------------------------------------
namespace GenericRPG2.Stats
{
    //-------------------------------------------------------------------    
    // Interface that all classes that store statistics will impliment    
    //-------------------------------------------------------------------
    public interface IStats
    {
        public int getCurrentHp();
        public int getCurrentSp();
        public int getAttack();
        public int getDefense();
        public int getSpeed();
        public int getMaxHp();
        public int getMaxSp();

        public string displayStats();

        public void addHp(int amountAdded);
        public void subtractHp(int amountSubtracted);
        public void setHpToMax();
        public void addSp(int amountAdded);
        public void subtractSp(int amountSubtracted);
        public void addAttack(int amountAdded);
        public void subtractAttack(int amountSubtracted);
        public void addDefense(int amountAdded);
        public void subtractDefense(int amountSubtracted);
        public void addSpeed(int amountAdded);
        public void subtractSpeed(int amountSubtracted);
        
    }
}