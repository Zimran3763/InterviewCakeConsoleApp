﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class InPlaceShuffle
    {
        //The following code returns a random number.
        //    int num = random.Next();
        //The following code returns a random number less than 1000. 
        //    int num = random.Next(1000);
        #region The following code returns a random number between the min and the max range.
        // Instantiate random number generator.  
        private static Random _rand = new Random();

        private static int GetRandom(int floor, int ceiling)
        {
             return _rand.Next(floor, ceiling+1 );
        }
        #endregion
        public static void Shuffle(int[] array)
        {
            // If it's 1 or 0 items, just return
            if (array.Length <= 1)
            {
                return;
            }

            // Walk through from beginning to end
            for (int indexWeAreChoosingFor = 0;
                    indexWeAreChoosingFor < array.Length - 1; indexWeAreChoosingFor++)
            {
                // Choose a random not-yet-placed item to place there
                // (could also be the item currently in that spot).
                // Must be an item AFTER the current item, because the stuff
                // before has all already been placed
                int randomChoiceIndex = GetRandom(indexWeAreChoosingFor, array.Length-1);

                // Place our random choice in the spot by swapping
                if (randomChoiceIndex != indexWeAreChoosingFor)
                {
                    int valueAtIndexWeChoseFor = array[indexWeAreChoosingFor];
                    array[indexWeAreChoosingFor] = array[randomChoiceIndex];
                    array[randomChoiceIndex] = valueAtIndexWeChoseFor;
                }
            }
        }
    }
}
