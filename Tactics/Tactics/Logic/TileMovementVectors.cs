using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Logic
{
    class TileMovementVectors
    {
        private Dictionary<string, List<Vector2>> upVectors;
        private Dictionary<string, List<Vector2>> downVectors;
        private Dictionary<string, List<Vector2>> rightVectors;
        private Dictionary<string, List<Vector2>> leftVectors;


        public TileMovementVectors()
        {
            upVectors = new Dictionary<string, List<Vector2>>();
            downVectors = new Dictionary<string, List<Vector2>>();
            rightVectors = new Dictionary<string, List<Vector2>>();
            leftVectors = new Dictionary<string, List<Vector2>>();
            fillUp();
            fillDown();
            fillRight();
            fillLeft();
            
        }

        private void fillLeft()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(-3, -2));
            tempList.Add(new Vector2(-6, -3));
            tempList.Add(new Vector2(-9, -5));
            tempList.Add(new Vector2(-12, -6));
            tempList.Add(new Vector2(3, 1));
            tempList.Add(new Vector2(0, 0));

            leftVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(-2, -2));
            tempList0.Add(new Vector2(-4, -4));
            tempList0.Add(new Vector2(-6, -6));
            tempList0.Add(new Vector2(-8, -8));
            tempList0.Add(new Vector2(-10, -9));
            tempList0.Add(new Vector2(6, 6));
            tempList0.Add(new Vector2(4, 4));
            tempList0.Add(new Vector2(2, 2));
            tempList0.Add(new Vector2(0, 0));

            leftVectors.Add("FFH", tempList0);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(-2, -2));
            tempList1.Add(new Vector2(-4, -4));
            tempList1.Add(new Vector2(-6, -6));
            tempList1.Add(new Vector2(-8, -4));
            tempList1.Add(new Vector2(-10, -4));
            tempList1.Add(new Vector2(6, -3));
            tempList1.Add(new Vector2(4, -2));
            tempList1.Add(new Vector2(2, -1));
            tempList1.Add(new Vector2(0, 0));

            leftVectors.Add("FFL", tempList1);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(-2, -1));
            tempList2.Add(new Vector2(-4, -2));
            tempList2.Add(new Vector2(-6, -3));
            tempList2.Add(new Vector2(-8, -4));
            tempList2.Add(new Vector2(-10, -5));
            tempList2.Add(new Vector2(6, 10));
            tempList2.Add(new Vector2(4, 8));
            tempList2.Add(new Vector2(2, 6));
            tempList2.Add(new Vector2(0, 4));

            leftVectors.Add("FSU", tempList2);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(-2, -1));
            tempList3.Add(new Vector2(-4, -2));
            tempList3.Add(new Vector2(-6, -3));
            tempList3.Add(new Vector2(-8, -4));
            tempList3.Add(new Vector2(-10, -5));
            tempList3.Add(new Vector2(6, 4));
            tempList3.Add(new Vector2(4, 4));
            tempList3.Add(new Vector2(2, 4));
            tempList3.Add(new Vector2(0, 4));

            leftVectors.Add("FSD", tempList3);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(-2, 3));
            tempList4.Add(new Vector2(-4, 2));
            tempList4.Add(new Vector2(-6, 1));
            tempList4.Add(new Vector2(-8, 0));
            tempList4.Add(new Vector2(-10, -1));
            tempList4.Add(new Vector2(6, 6));
            tempList4.Add(new Vector2(4, 4));
            tempList4.Add(new Vector2(2, 2));
            tempList4.Add(new Vector2(0, 0));

            leftVectors.Add("SUF", tempList4);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(-2, 4));
            tempList5.Add(new Vector2(-4, 4));
            tempList5.Add(new Vector2(-6, 4));
            tempList5.Add(new Vector2(-8, 4));
            tempList5.Add(new Vector2(-10, 4));
            tempList5.Add(new Vector2(6, 3));
            tempList5.Add(new Vector2(4, 2));
            tempList5.Add(new Vector2(2, 1));
            tempList5.Add(new Vector2(0, 0));

            leftVectors.Add("SDF", tempList5);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(-2, 2));
            tempList6.Add(new Vector2(-4, 0));
            tempList6.Add(new Vector2(-6, -2));
            tempList6.Add(new Vector2(-8, -4));
            tempList6.Add(new Vector2(-10, -5));
            tempList6.Add(new Vector2(6, 10));
            tempList6.Add(new Vector2(4, 8));
            tempList6.Add(new Vector2(2, 6));
            tempList6.Add(new Vector2(0, 4));

            leftVectors.Add("SUSU", tempList6);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(-2, 4));
            tempList7.Add(new Vector2(-4, 4));
            tempList7.Add(new Vector2(-6, 4));
            tempList7.Add(new Vector2(-8, 4));
            tempList7.Add(new Vector2(-10, 3));
            tempList7.Add(new Vector2(6, 4));
            tempList7.Add(new Vector2(4, 4));
            tempList7.Add(new Vector2(2, 4));
            tempList7.Add(new Vector2(0, 4));

            leftVectors.Add("SDSD", tempList7);

            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(-3, 2));
            tempList8.Add(new Vector2(-6, 1));
            tempList8.Add(new Vector2(-9, -1));
            tempList8.Add(new Vector2(-12, -2));
            tempList8.Add(new Vector2(3, 5));
            tempList8.Add(new Vector2(0, 4));

            leftVectors.Add("SASA", tempList8);
        }

        private void fillDown()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(-3, 2));
            tempList.Add(new Vector2(12, -6));
            tempList.Add(new Vector2(9, -4));
            tempList.Add(new Vector2(6, -3));
            tempList.Add(new Vector2(3, -1));
            tempList.Add(new Vector2(0, 0));

            downVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(-2, -3));
            tempList0.Add(new Vector2(14, -4));
            tempList0.Add(new Vector2(12, -5));
            tempList0.Add(new Vector2(10, -7));
            tempList0.Add(new Vector2(8, -5));
            tempList0.Add(new Vector2(6, -3));
            tempList0.Add(new Vector2(4, -2));
            tempList0.Add(new Vector2(2, -1));
            tempList0.Add(new Vector2(0, 0));

            downVectors.Add("FFH", tempList0);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(-2, 2));
            tempList1.Add(new Vector2(14, -13));
            tempList1.Add(new Vector2(12, -11));
            tempList1.Add(new Vector2(10, -9));
            tempList1.Add(new Vector2(8, -8));
            tempList1.Add(new Vector2(6, -6));
            tempList1.Add(new Vector2(4, -4));
            tempList1.Add(new Vector2(2, -2));
            tempList1.Add(new Vector2(0, 0));

            downVectors.Add("FFL", tempList1);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(-2, 1));
            tempList2.Add(new Vector2(14, 1));
            tempList2.Add(new Vector2(12, 2));
            tempList2.Add(new Vector2(10, 3));
            tempList2.Add(new Vector2(8, 4));
            tempList2.Add(new Vector2(6, 4));
            tempList2.Add(new Vector2(4, 4));
            tempList2.Add(new Vector2(2, 4));
            tempList2.Add(new Vector2(0, 4));

            downVectors.Add("FSU", tempList2);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(-2, 1));
            tempList3.Add(new Vector2(14, -7));
            tempList3.Add(new Vector2(12, -6));
            tempList3.Add(new Vector2(10, -5));
            tempList3.Add(new Vector2(8, -4));
            tempList3.Add(new Vector2(6, -2));
            tempList3.Add(new Vector2(4, 0));
            tempList3.Add(new Vector2(2, 2));
            tempList3.Add(new Vector2(0, 4));

            downVectors.Add("FSD", tempList3);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(-2, 4));
            tempList4.Add(new Vector2(14, -5));
            tempList4.Add(new Vector2(12, -5));
            tempList4.Add(new Vector2(10, -5));
            tempList4.Add(new Vector2(8, -4));
            tempList4.Add(new Vector2(6, -3));
            tempList4.Add(new Vector2(4, -2));
            tempList4.Add(new Vector2(2, -1));
            tempList4.Add(new Vector2(0, 0));

            downVectors.Add("SUF", tempList4);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(-2, 6));
            tempList5.Add(new Vector2(14, -9));
            tempList5.Add(new Vector2(12, -7));
            tempList5.Add(new Vector2(10, -5));
            tempList5.Add(new Vector2(8, -4));
            tempList5.Add(new Vector2(6, -3));
            tempList5.Add(new Vector2(4, -2));
            tempList5.Add(new Vector2(2, -1));
            tempList5.Add(new Vector2(0, 0));

            downVectors.Add("SDF", tempList5);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(-2, 4));
            tempList6.Add(new Vector2(14, 3));
            tempList6.Add(new Vector2(12, 3));
            tempList6.Add(new Vector2(10, 3));
            tempList6.Add(new Vector2(8, 4));
            tempList6.Add(new Vector2(6, 4));
            tempList6.Add(new Vector2(4, 4));
            tempList6.Add(new Vector2(2, 4));
            tempList6.Add(new Vector2(0, 4));

            downVectors.Add("SUSU", tempList6);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(-2, 6));
            tempList7.Add(new Vector2(14, -9));
            tempList7.Add(new Vector2(12, -7));
            tempList7.Add(new Vector2(10, -5));
            tempList7.Add(new Vector2(8, -4));
            tempList7.Add(new Vector2(6, -2));
            tempList7.Add(new Vector2(4, 0));
            tempList7.Add(new Vector2(2, 2));
            tempList7.Add(new Vector2(0, 4));

            downVectors.Add("SDSD", tempList7);

            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(-3, 6));
            tempList8.Add(new Vector2(12, -2));
            tempList8.Add(new Vector2(9, 0));
            tempList8.Add(new Vector2(6, 1));
            tempList8.Add(new Vector2(3, 3));
            tempList8.Add(new Vector2(0, 4));

            downVectors.Add("SASA", tempList8);

        }

        private void fillRight()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(3, 2));
            tempList.Add(new Vector2(-12, -6));
            tempList.Add(new Vector2(-9, -4));
            tempList.Add(new Vector2(-6, -3));
            tempList.Add(new Vector2(-3, -1));
            tempList.Add(new Vector2(0, 0));

            rightVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(2, -3));
            tempList0.Add(new Vector2(-14, -4));
            tempList0.Add(new Vector2(-12, -5));
            tempList0.Add(new Vector2(-10, -7));
            tempList0.Add(new Vector2(-8, -5));
            tempList0.Add(new Vector2(-6, -3));
            tempList0.Add(new Vector2(-4, -2));
            tempList0.Add(new Vector2(-2, -1));
            tempList0.Add(new Vector2(0, 0));

            rightVectors.Add("FFH", tempList0);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(2, 2));
            tempList1.Add(new Vector2(-14, -13));
            tempList1.Add(new Vector2(-12, -11));
            tempList1.Add(new Vector2(-10, -9));
            tempList1.Add(new Vector2(-8, -8));
            tempList1.Add(new Vector2(-6, -6));
            tempList1.Add(new Vector2(-4, -4));
            tempList1.Add(new Vector2(-2, -2));
            tempList1.Add(new Vector2(0, 0));

            rightVectors.Add("FFL", tempList1);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(2, 1));
            tempList2.Add(new Vector2(-14, 1));
            tempList2.Add(new Vector2(-12, 2));
            tempList2.Add(new Vector2(-10, 3));
            tempList2.Add(new Vector2(-8, 4));
            tempList2.Add(new Vector2(-6, 4));
            tempList2.Add(new Vector2(-4, 4));
            tempList2.Add(new Vector2(-2, 4));
            tempList2.Add(new Vector2(0, 4));

            rightVectors.Add("FSU", tempList2);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(2, 1));
            tempList3.Add(new Vector2(-14, -7));
            tempList3.Add(new Vector2(-12, -6));
            tempList3.Add(new Vector2(-10, -5));
            tempList3.Add(new Vector2(-8, -4));
            tempList3.Add(new Vector2(-6, -2));
            tempList3.Add(new Vector2(-4, 0));
            tempList3.Add(new Vector2(-2, 2));
            tempList3.Add(new Vector2(0, 4));

            rightVectors.Add("FSD", tempList3);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(2, 4));
            tempList4.Add(new Vector2(-14, -5));
            tempList4.Add(new Vector2(-12, -5));
            tempList4.Add(new Vector2(-10, -5));
            tempList4.Add(new Vector2(-8, -4));
            tempList4.Add(new Vector2(-6, -3));
            tempList4.Add(new Vector2(-4, -2));
            tempList4.Add(new Vector2(-2, -1));
            tempList4.Add(new Vector2(0, 0));

            rightVectors.Add("SUF", tempList4);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(2, 6));
            tempList5.Add(new Vector2(-14, -9));
            tempList5.Add(new Vector2(-12, -7));
            tempList5.Add(new Vector2(-10, -5));
            tempList5.Add(new Vector2(-8, -4));
            tempList5.Add(new Vector2(-6, -3));
            tempList5.Add(new Vector2(-4, -2));
            tempList5.Add(new Vector2(-2, -1));
            tempList5.Add(new Vector2(0, 0));

            rightVectors.Add("SDF", tempList5);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(2, 4));
            tempList6.Add(new Vector2(-14, 3));
            tempList6.Add(new Vector2(-12, 3));
            tempList6.Add(new Vector2(-10, 3));
            tempList6.Add(new Vector2(-8, 4));
            tempList6.Add(new Vector2(-6, 4));
            tempList6.Add(new Vector2(-4, 4));
            tempList6.Add(new Vector2(-2, 4));
            tempList6.Add(new Vector2(0, 4));

            rightVectors.Add("SUSU", tempList6);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(2, 6));
            tempList7.Add(new Vector2(-14, -9));
            tempList7.Add(new Vector2(-12, -7));
            tempList7.Add(new Vector2(-10, -5));
            tempList7.Add(new Vector2(-8, -4));
            tempList7.Add(new Vector2(-6, -2));
            tempList7.Add(new Vector2(-4, 0));
            tempList7.Add(new Vector2(-2, 2));
            tempList7.Add(new Vector2(0, 4));

            rightVectors.Add("SDSD", tempList7);

            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(3, 6));
            tempList8.Add(new Vector2(-12, -2));
            tempList8.Add(new Vector2(-9, 0));
            tempList8.Add(new Vector2(-6, 1));
            tempList8.Add(new Vector2(-3, 3));
            tempList8.Add(new Vector2(0, 4));

            rightVectors.Add("SASA", tempList8);

        }

        private void fillUp()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(3, -2));
            tempList.Add(new Vector2(6, -3));
            tempList.Add(new Vector2(9, -5));
            tempList.Add(new Vector2(12, -6));
            tempList.Add(new Vector2(-3, 1));
            tempList.Add(new Vector2(0, 0));

            upVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(2, -2));
            tempList0.Add(new Vector2(4, -4));
            tempList0.Add(new Vector2(6, -6));
            tempList0.Add(new Vector2(8, -8));
            tempList0.Add(new Vector2(10, -9));
            tempList0.Add(new Vector2(-6, 6));
            tempList0.Add(new Vector2(-4, 4));
            tempList0.Add(new Vector2(-2, 2));
            tempList0.Add(new Vector2(0, 0));

            upVectors.Add("FFH", tempList0);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(2, -2));
            tempList1.Add(new Vector2(4, -4));
            tempList1.Add(new Vector2(6, -6));
            tempList1.Add(new Vector2(8, -4));
            tempList1.Add(new Vector2(10, -4));
            tempList1.Add(new Vector2(-6, -3));
            tempList1.Add(new Vector2(-4, -2));
            tempList1.Add(new Vector2(-2, -1));
            tempList1.Add(new Vector2(0, 0));

            upVectors.Add("FFL", tempList1);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(2, -1));
            tempList2.Add(new Vector2(4, -2));
            tempList2.Add(new Vector2(6, -3));
            tempList2.Add(new Vector2(8, -4));
            tempList2.Add(new Vector2(10, -5));
            tempList2.Add(new Vector2(-6, 10));
            tempList2.Add(new Vector2(-4, 8));
            tempList2.Add(new Vector2(-2, 6));
            tempList2.Add(new Vector2(0, 4));

            upVectors.Add("FSU", tempList2);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(2, -1));
            tempList3.Add(new Vector2(4, -2));
            tempList3.Add(new Vector2(6, -3));
            tempList3.Add(new Vector2(8, -4));
            tempList3.Add(new Vector2(10, -5));
            tempList3.Add(new Vector2(-6, 4));
            tempList3.Add(new Vector2(-4, 4));
            tempList3.Add(new Vector2(-2, 4));
            tempList3.Add(new Vector2(0, 4));

            upVectors.Add("FSD", tempList3);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(2, 3));
            tempList4.Add(new Vector2(4, 2));
            tempList4.Add(new Vector2(6, 1));
            tempList4.Add(new Vector2(8, 0));
            tempList4.Add(new Vector2(10, -1));
            tempList4.Add(new Vector2(-6, 6));
            tempList4.Add(new Vector2(-4, 4));
            tempList4.Add(new Vector2(-2, 2));
            tempList4.Add(new Vector2(0, 0));

            upVectors.Add("SUF", tempList4);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(2, 4));
            tempList5.Add(new Vector2(4, 4));
            tempList5.Add(new Vector2(6, 4));
            tempList5.Add(new Vector2(8, 4));
            tempList5.Add(new Vector2(10, 4));
            tempList5.Add(new Vector2(-6, 3));
            tempList5.Add(new Vector2(-4, 2));
            tempList5.Add(new Vector2(-2, 1));
            tempList5.Add(new Vector2(0, 0));

            upVectors.Add("SDF", tempList5);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(2, 2));
            tempList6.Add(new Vector2(4, 0));
            tempList6.Add(new Vector2(6, -2));
            tempList6.Add(new Vector2(8, -4));
            tempList6.Add(new Vector2(10, -5));
            tempList6.Add(new Vector2(-6, 10));
            tempList6.Add(new Vector2(-4, 8));
            tempList6.Add(new Vector2(-2, 6));
            tempList6.Add(new Vector2(0, 4));

            upVectors.Add("SUSU", tempList6);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(2, 4));
            tempList7.Add(new Vector2(4, 4));
            tempList7.Add(new Vector2(6, 4));
            tempList7.Add(new Vector2(8, 4));
            tempList7.Add(new Vector2(10, 3));
            tempList7.Add(new Vector2(-6, 4));
            tempList7.Add(new Vector2(-4, 4));
            tempList7.Add(new Vector2(-2, 4));
            tempList7.Add(new Vector2(0, 4));

            upVectors.Add("SDSD", tempList7);

            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(3, 2));
            tempList8.Add(new Vector2(6, 1));
            tempList8.Add(new Vector2(9, -1));
            tempList8.Add(new Vector2(12, -2));
            tempList8.Add(new Vector2(-3, 5));
            tempList8.Add(new Vector2(0, 4));

            upVectors.Add("SASA", tempList8);
        }


        public List<Vector2> getVectors(int direction, string type)
        {
            if (direction == 0)
            {
                return upVectors[type];
            }
            else if (direction == 1)
            {
                return downVectors[type];
            }
            else if (direction == 2)
            {
                return rightVectors[type];
            }
            else if (direction == 3)
            {
                return leftVectors[type];
            }
            else
            {
                return upVectors[type];
            }
        }

        public Dictionary<string, List<Vector2>> getUpVectors()
        {
            return upVectors;
        }

        public Dictionary<string, List<Vector2>> getDownVectors()
        {
            return downVectors;
        }

        public Dictionary<string, List<Vector2>> getRightVectors()
        {
            return rightVectors;
        }

        public Dictionary<string, List<Vector2>> getLeftVectors()
        {
            return leftVectors;
        }
    }
}
