using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace CTIExerciseOne
{
    class ArrayLists
    {
        #region InsultSelection 

        public ArrayLists(ArrayList Targets, ArrayList Insults, ArrayList PunchLines, ComboBox cbTarget , ComboBox cbPunchLine , ComboBox cbInsult)
        {
            //Stores defualt items to thier respective arraylists

            //Add values to the arraylists
            Targets.Add("Your head ");
            Targets.Add("Your body ");
            Targets.Add("Your legs ");

            Insults.Add("ugly");
            Insults.Add("fat");
            Insults.Add("dumb");

            PunchLines.Add("But it's okay");
            PunchLines.Add("In another world");
            PunchLines.Add("Just kidding");
        }

        public ArrayLists(ArrayList arraylist , ComboBox cb)
        {
            //The following code adds the Arraylists to the combobox
            int arraycount; 
            arraycount = arraylist.Count;
            for (int x = 0; x < arraycount; x = x + 1)
            {
                cb.Items.Add(arraylist[x]);
            }
        }
        #endregion 

    }
}
