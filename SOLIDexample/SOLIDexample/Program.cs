using SOLIDexample.DIP;
using SOLIDexample.Liskov;
using SOLIDexample.OCP;

namespace SOLIDexample
{
    internal class Program
    {
        static void Main(string[] args)
        {



         
            //Pizza pizza = new Pizza(new Knife());
            Pizza pizza = new Pizza(new Scissor());


            pizza.Sell();







            //FlyShow<Eagle> flyShow = new();
            //FlyShow<Penguin> flyShow2 = new();

            //flyShow.StartShow();
            //flyShow2.StartShow();


            //Chef chef = new Chef();

            //IMeal meal = new MushedPotato();
            //IMeal meal2 = new FrencFries();

            //chef.CookMeal(meal);
            //chef.CookMeal(meal2);

        }
    }
}
