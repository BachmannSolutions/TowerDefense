using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachmannSolutions.TowerDefense
{
    class Game
    {
        public static void Main()
        {
            //name classes with a capital letter, then name the object/instance the same in lower case
            //Classes are templates from which objects are created
            Map map = new Map(8,5);

            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                MapLocation location = new MapLocation(0, 2, map);

                //test invaders
                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)

                };

                //test towers
                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 3, map)),
                    new SniperTower(new MapLocation(3, 3, map)),
                    new PowerTower(new MapLocation(5, 3, map)),
                    new LongRangeTower(new MapLocation(5, 3, map))
                };

                //test level!
                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                //player outcome
                bool playerWon = level.Play();

                //results printed
                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BachmannSolutionsDefenseException)
            {
                Console.WriteLine("Unhandled BachmannSolutionsDefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
            Console.ReadLine();
        }
    }
}